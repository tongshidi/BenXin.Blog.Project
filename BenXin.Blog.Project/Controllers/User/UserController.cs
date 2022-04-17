using BenXin.Blog.Project.IService;
using BenXin.Blog.Project.Model.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BenXin.Blog.Project.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController
    {
        //private IBaseService _userService { get; set; }

        //public UserController(IUserService userService)
        //{
        //    _userService = userService;
        //}

        [HttpGet]
        public async Task<ResponeResult<string>> GetUserToken()
        {
            return new ResponeResult<string>();
        }
    }
}
