using BenXin.Blog.Project.Model.Entities.User;
using BenXin.Blog.Project.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenXin.Blog.Project.IRepository
{
    public interface IUserRepository: IBaseRepository<UserModel>
    {
        Task<ResponeResult<string>> GetUserToken(int id);
    }
}
