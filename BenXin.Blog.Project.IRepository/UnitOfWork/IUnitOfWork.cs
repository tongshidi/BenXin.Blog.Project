using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenXin.Blog.Project.IRepository.UnitOfWork
{
  public interface IUnitOfWork
  {
    SqlSugarScope GetDbClient();

    void BeginTran();

    void CommitTran();

    void RollbackTran();
  }
}
