using BenXin.Blog.Project.Model.Entities.User;
using BenXin.Blog.Project.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenXin.Blog.Project.IService
{
    public interface IUserService : IBaseService<UserModel>
    {
        /// <summary>
        /// ªÒ»°token
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ResponeResult<string>> GetUserToken(int id);
    }
}
