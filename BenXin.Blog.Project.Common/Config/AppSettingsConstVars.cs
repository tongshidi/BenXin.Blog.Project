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
        #region 跨域配置

        public static readonly string CorsPolicyName = AppSettingsHelper.GetContent("Cors", "PolicyName");
        public static readonly bool CorsEnableAllIPs = Convert.ToBoolean(AppSettingsHelper.GetContent("Cors", "EnableAllIPs"));
        public static readonly string CorsIPs = AppSettingsHelper.GetContent("Cors", "IPs");

        #endregion
    }
}
