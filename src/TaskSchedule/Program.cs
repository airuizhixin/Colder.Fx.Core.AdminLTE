using Coldairarrow.Util;
using Coldairarrow.Util.WindowsService;
using Quartz;
using Quartz.Impl;
using Quartz.Logging;
using System;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace TaskSchedule
{
    public class Program
    {
        private static void Main(string[] args)
        {
            WindowsServiceContainer container = new WindowsServiceContainer("ccs_opportunity_mgr_TaskSchedule", args)
            {
                Description = "商机管理系统定时任务服务",
                HandleOnStart = argss =>
                {
                    LogProvider.SetCurrentLogProvider(new ConsoleLogProvider());

                    RunScheduler().GetAwaiter().GetResult();
                }
            };

            container.Start();

            //LogProvider.SetCurrentLogProvider(new ConsoleLogProvider());

            //RunScheduler().GetAwaiter().GetResult();

            //Console.ReadLine();
        }

        private static async Task RunScheduler()
        {
            try
            {
                // Grab the Scheduler instance from the Factory
                NameValueCollection props = new NameValueCollection
                {
                    { "quartz.serializer.type", "binary" }
                };
                StdSchedulerFactory factory = new StdSchedulerFactory(props);
                IScheduler scheduler = await factory.GetScheduler();

                await scheduler.Start();

                IJobDetail job = JobBuilder.Create<ProjectNoticeJob>()
                    .WithIdentity("job1", "group1")
                    .Build();

                ITrigger trigger = TriggerBuilder.Create()
                    .WithIdentity("trigger1", "group1")
                    .StartNow()
                    .WithCronSchedule("0 30 8 * * ?")//每天8.30
                    .Build();

                await scheduler.ScheduleJob(job, trigger);
            }
            catch (SchedulerException se)
            {
                Console.WriteLine(se);
            }
        }

        private class ConsoleLogProvider : ILogProvider
        {
            public Logger GetLogger(string name)
            {
                return (level, func, exception, parameters) =>
                {
                    if (level >= LogLevel.Info && func != null)
                    {
                        //string msg = "[" + DateTime.Now.ToLongTimeString() + "] [" + level + "] " + func(), parameters;
                        //FileHelper.WriteLog(msg)
                        Console.WriteLine("[" + DateTime.Now.ToLongTimeString() + "] [" + level + "] " + func(), parameters);
                    }
                    return true;
                };
            }

            public IDisposable OpenNestedContext(string message)
            {
                throw new NotImplementedException();
            }

            public IDisposable OpenMappedContext(string key, string value)
            {
                throw new NotImplementedException();
            }
        }
    }

    public class HelloJob : IJob
    {
        public HelloJob()
        {
            Console.WriteLine("新建对象");
        }
        public async Task Execute(IJobExecutionContext context)
        {
            await Console.Out.WriteLineAsync($"{DateTime.Now}:Greetings from HelloJob!");
        }
    }
}