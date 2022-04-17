using BenXin.Blog.Project.Common.Ulitity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenXin.Blog.Project.Model.Enum.Common
{
    /// <summary>
    /// 返回枚举
    /// </summary>
    public enum ResponeStatus
    {
        /// <summary>
        /// 成功请求
        /// </summary>
        [Desc]
        Success = 0,

        /// <summary>
        /// 请求失败
        /// </summary>
        [Desc]
        Fail = -1,

        /// <summary>
        /// token失效
        /// </summary>
        [Desc]
        TokenUnValite = 90001,
    }
}
