using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenXin.Blog.Project.Model.ViewModel
{
  public interface IPageList<T> : IList<T>
  {
    /// <summary>
    /// 页索引
    /// </summary>
    int PageIndex { get; }

    /// <summary>
    /// 页码
    /// </summary>
    int PageSize { get; }

    /// <summary>
    /// 总计
    /// </summary>
    int TotalCount { get; }

    /// <summary>
    /// 总页数
    /// </summary>
    int TotalPages { get; }

    bool HasPreviousPage { get; }

    bool HasNextPage { get; }
  }
}
