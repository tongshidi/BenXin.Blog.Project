using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenXin.Blog.Project.Model.ViewModel
{
  public class PageList<T> : List<T>,IPageList<T>
  {
    /// <summary>
    /// 分页索引
    /// </summary>
    public int PageIndex { get;set; }

    /// <summary>
    /// 分页大小
    /// </summary>
    public int PageSize { get;set; }

    /// <summary>
    /// 总记录树
    /// </summary>
    public int TotalCount { get;set; }

    /// <summary>
    /// 总页数
    /// </summary>
    public int TotalPages { get;set; }

    /// <summary>
    /// 是否有下一页
    /// </summary>
    public bool HasPreviousPage => PageIndex > 0;

    /// <summary>
    /// 是否有上一页
    /// </summary>
    public bool HasNextPage => PageIndex + 1 < TotalPages;

    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="source">数据源</param>
    /// <param name="pageIndex">分页索引</param>
    /// <param name="pageSize">分页大小</param>
    public PageList(IQueryable<T> source,int pageIndex,int pageSize)
    {
      var total = source.Count();
      TotalCount = total;
      TotalPages = total / pageSize;

      if (total % pageSize > 0)
        TotalPages++;

      PageSize = pageSize;
      PageIndex = pageIndex;

      AddRange(source.Skip(pageIndex * pageSize).Take(pageSize).ToList());
    }

    public PageList(IList<T> source, int pageIndex, int pageSize)
    {
      TotalCount = source.Count();
      TotalPages = TotalCount / pageSize;

      if (TotalCount % pageSize > 0)
        TotalPages++;

      PageSize = pageSize;
      PageIndex = pageIndex;

      AddRange(source.Skip(pageIndex * pageSize).Take(pageSize));
    }

    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="source">数据源</param>
    /// <param name="pageIndex">分页索引</param>
    /// <param name="pageSize">分页大小</param>
    /// <param name="totalCount">总记录数</param>
    public PageList(IEnumerable<T> source,int pageIndex,int pageSize,int totalCount)
    {
      TotalCount = totalCount;
      TotalPages = TotalCount / pageSize;

      if (TotalCount % pageSize > 0)
        TotalPages++;

      AddRange(source.Skip(pageIndex * pageSize).Take(pageSize));
    }
  }
}
