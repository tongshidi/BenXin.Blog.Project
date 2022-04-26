using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenXin.Blog.Project.Common.Config
{
    /// <summary>
    /// 配置文件
    /// </summary>
    public class AppSettingsConstVars
    {
        #region 数据库字符串
        /// <summary>
        /// 数据库链接字符串
        /// </summary>
        public static readonly string DbSqlConnection = AppSettingsHelper.GetContent("ConnectionStrings", "SqlConnection");
        /// <summary>
        /// 获取数据库类型
        /// </summary>
        public static readonly string DbDbType = AppSettingsHelper.GetContent("ConnectionStrings", "DbType");

        #endregion

        #region 跨域配置

        public static readonly string CorsPolicyName = AppSettingsHelper.GetContent("Cors", "PolicyName");
        public static readonly bool CorsEnableAllIPs = Convert.ToBoolean(AppSettingsHelper.GetContent("Cors", "EnableAllIPs"));
        public static readonly string CorsIPs = AppSettingsHelper.GetContent("Cors", "IPs");

        #endregion
    }
}
