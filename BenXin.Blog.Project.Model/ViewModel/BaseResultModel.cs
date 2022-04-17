using BenXin.Blog.Project.Model.Enum.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenXin.Blog.Project.Model.ViewModel
{
    public class BaseResultModel<T>
    {
        /// <summary>
        /// 通用返回
        /// </summary>
        public ResponeStatus result_code { get; set; }

        /// <summary>
        /// 返回的错误信息
        /// </summary>
        public string result_msg { get; set; } = "";

        /// <summary>
        /// 返回信息
        /// </summary>
        public T data { get; set; }
    }
}
