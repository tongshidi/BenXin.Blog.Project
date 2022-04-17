using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenXin.Blog.Project.Common.Config
{
    /// <summary>
    /// 获取配置信息
    /// </summary>
    public class AppSettingsHelper
    {
        static IConfiguration _configuration { get; set; }

        public AppSettingsHelper(string contentPath)
        {
            string path = "appsettings.json";
            //_configuration = new ConfigurationBuilder().SetBasePath(contentPath).Add(new JsonConfigurationSource { Path = path, Optional = false, ReloadOnChange = true }).Build();\
            _configuration = new ConfigurationBuilder().SetBasePath(contentPath).Add(new JsonConfigurationSource { Path=path,Optional=false,ReloadOnChange=true}).Build();
        }

        /// <summary>
        /// 获取配置文件字符
        /// </summary>
        /// <param name="sections"></param>
        /// <returns></returns>
        public static string GetContent(params string[] sections)
        {
            try
            {
                if (sections.Count()>0)
                {
                    return _configuration[string.Join(":",sections)];
                }
            }
            catch (Exception)
            {
                return "";
            }

            return "";
        }
    }
}
