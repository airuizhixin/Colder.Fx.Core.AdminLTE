using Coldairarrow.Business;
using Coldairarrow.Business.BusManage;
using Coldairarrow.DataRepository;
using Coldairarrow.Entity.BusManage;
using Coldairarrow.Util;
using Quartz;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace TaskSchedule
{
    class ProjectNoticeJob : IJob
    {
        IRepository _db { get; } = DbFactory.GetRepository();
        MsgHelper _msgHelper { get; } = new MsgHelper();
        Bus_ProjectBusiness _proBus { get; } = new Bus_ProjectBusiness();
        public async Task Execute(IJobExecutionContext context)
        {
            await Task.Run(() =>
            {
                //待分配或审核通知
                if (_db.GetIQueryable<Bus_Project>()
                    .Any(x => x.IsDeleted == false && (x.NiCheState == 0 || x.NiCheState == 1)))
                {
                    _msgHelper.SendAuditNotice("18705808736");
                }

                //超时未跟踪通知
                //超时1星期
                DateTime endTime = DateTime.Now.AddDays(-7);
                var projectList = _proBus
                    .GetDataList(true, null, null, null, null, 2, null, null, endTime, null, null,null, new Pagination())
                    .ToList();

                projectList.ForEach(aProject =>
                {
                    try
                    {
                        _msgHelper.SendTrackNotice(aProject.MarketerPhoneNum, aProject.ProjectName, 1);
                    }
                    catch
                    {

                    }
                });

                //超时2星期
                endTime = DateTime.Now.AddDays(-14);
                projectList = _proBus
                    .GetDataList(true, null, null, null, null, 2, null, null, endTime,null,null,null, new Pagination())
                    .ToList();

                projectList.ForEach(aProject =>
                {
                    try
                    {
                        _msgHelper.SendTrackNotice(aProject.MarketingManagerPhoneNum, aProject.ProjectName, 2);
                    }
                    catch
                    {

                    }
                });
            });
        }
    }
}
