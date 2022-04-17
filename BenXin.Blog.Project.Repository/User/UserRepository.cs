using BenXin.Blog.Project.IRepository;
using BenXin.Blog.Project.IRepository.UnitOfWork;
using BenXin.Blog.Project.Model.Entities.User;
using BenXin.Blog.Project.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenXin.Blog.Project.Repository.User
{
    public class UserRepository : BaseRepository<UserModel>, IUserRepository
    {
        protected UserRepository(IUnitOfWork unitOfWork):base(unitOfWork)
        {
            
        }

        /// <summary>
        /// 通过用户获取token
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ResponeResult<string>> GetUserToken(int id)
        {
            var model = await QueryByIdAsync(id);
            var result = new ResponeResult<string>() { data="获取到token",result_code=Model.Enum.Common.ResponeStatus.Success,result_msg=""};
            
            return result;
            
        }
    }
}
