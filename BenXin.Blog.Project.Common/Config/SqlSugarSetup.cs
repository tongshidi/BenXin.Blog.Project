using Microsoft.Extensions.DependencyInjection;
using SqlSugar;
using SqlSugar.IOC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenXin.Blog.Project.Common.Config
{
    public static class SqlSugarSetup
    {

        public static void AddSqlSugarSetup(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            SugarIocServices.AddSqlSugar(new IocConfig
            {
                //数据库链接
                ConnectionString = AppSettingsConstVars.DbSqlConnection,
                //数据库支持的类型
                DbType = AppSettingsConstVars.DbDbType == IocDbType.MySql.ToString() ? IocDbType.MySql : IocDbType.SqlServer,
                //是否开启自动关闭数据库链接
                IsAutoCloseConnection = true
            });

            services.ConfigurationSugar(db=> 
            {
                db.CurrentConnectionConfig.InitKeyType = InitKeyType.Attribute;
                //db.CurrentConnectionConfig.ConfigureExternalServices = new ConfigureExternalServices()
                //{
                //    //判断是否开启redis设置二级缓存方式
                //    DataInfoCacheService = AppSettingsConstVars.RedisUseCache ? (ICacheService)new SqlSugarRedisCache() : new SqlSugarMemoryCache()
                //};

                //执行SQL 错误事件，可监控sql（暂时屏蔽，需要可开启）
                //db.Aop.OnLogExecuting = (sql, p) =>
                //{
                //    NLogUtil.WriteFileLog(NLog.LogLevel.Error, LogType.Other, "SqlSugar执行SQL错误事件打印Sql", sql);
                //};

                //执行SQL 错误事件
                db.Aop.OnError = (exp) =>
                {
                    //NLogUtil.WriteFileLog(NLog.LogLevel.Error, LogType.Other, "SqlSugar", "执行SQL错误事件", exp);
                };

                //设置更多连接参数
                //db.CurrentConnectionConfig.XXXX=XXXX
                //db.CurrentConnectionConfig.MoreSetting=new MoreSetting(){}
                //读写分离等都在这儿设置
            });
        }
    }
}
