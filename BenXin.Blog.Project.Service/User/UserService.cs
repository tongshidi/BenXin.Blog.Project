using BenXin.Blog.Project.IRepository;
using BenXin.Blog.Project.IRepository.UnitOfWork;
using BenXin.Blog.Project.IService;
using BenXin.Blog.Project.Model.Entities.User;
using BenXin.Blog.Project.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenXin.Blog.Project.Service
{
    public class UserService : BaseService<UserModel>, IUserService
    {
        private readonly IUserRepository _userRepository = null;
        private readonly IUnitOfWork _unitOfWork = null;

        public UserService(IUserRepository userRepository,IUnitOfWork unitOfWork)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
            base._baseRepository = userRepository;//父类直接在子类中进行注入
        }

        /// <summary>
        /// 获取用户token
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ResponeResult<string>> GetUserToken(int id)
        {
            var result = await _userRepository.GetUserToken(id);
            result.data = null;
            result.result_code = Model.Enum.Common.ResponeStatus.Success;
            result.result_msg = "请求成功";
            return result;
        }
    }
}
