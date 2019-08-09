using Coldairarrow.DataRepository;
using Coldairarrow.Entity.Base_SysManage;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Coldairarrow.Util;
using System.Data;
using Autofac;
using Autofac.Extras.DynamicProxy;
using Coldairarrow.Entity.ScmManage;

namespace Coldairarrow.Console1
{
    class Program
    {
        static Program()
        {
            var builder = new ContainerBuilder();

            var baseType = typeof(IDependency);
            var baseTypeCircle = typeof(ICircleDependency);

            //Coldairarrow相关程序集
            var assemblys = Assembly.GetEntryAssembly().GetReferencedAssemblies()
                .Select(Assembly.Load)
                .Cast<Assembly>()
                .Where(x => x.FullName.Contains("Coldairarrow")).ToList();

            //自动注入IDependency接口,支持AOP
            builder.RegisterAssemblyTypes(assemblys.ToArray())
                .Where(x => baseType.IsAssignableFrom(x) && x != baseType)
                .AsImplementedInterfaces()
                .PropertiesAutowired()
                .InstancePerDependency()
                .EnableInterfaceInterceptors()
                .InterceptedBy(typeof(Interceptor));

            //自动注入ICircleDependency接口,循环依赖注入,不支持AOP
            builder.RegisterAssemblyTypes(assemblys.ToArray())
                .Where(x => baseTypeCircle.IsAssignableFrom(x) && x != baseTypeCircle)
                .AsImplementedInterfaces()
                .PropertiesAutowired(PropertyWiringOptions.AllowCircularDependencies)
                .InstancePerLifetimeScope();

            //AOP
            builder.RegisterType<Interceptor>();

            AutofacHelper.Container = builder.Build();
        }

        public static void DeleteData()
        {
            var db = DbFactory.GetRepository();
            List<string> orderNums = "1159345588689571841,1159021292796645376,1158936070935678977,1158673392837201920,1158635216118616064,1157208576238948352,1157162217406337024,1156111883456090112".Split(',').ToList();
            List<string> orderIds = db.GetIQueryable<Ent_Order>()
                .Where(x => orderNums.Contains(x.OrderNo))
                .Select(x => x.Id).ToList();
            //供应链订单发票
            //db.Delete_Sql<Scm_OrderInvoice>(x => !orderIds.Contains(x.OrderId));
            //供应链订单对账
            //db.Delete_Sql<Scm_OrderSOA>(x => !orderIds.Contains(x.OrderId));
            //企业授信恢复
            db.UpdateWhere_Sql<Scm_EnterpriseCompany>(x => true, ("DepositVal", 100000), ("DepositValUsed", 0));

            string tmp = string.Empty;
        }

        static void Main(string[] args)
        {
            //DeleteData();

            Console.WriteLine("完成");
            Console.ReadLine();
        }
    }
}