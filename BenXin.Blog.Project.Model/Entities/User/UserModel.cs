using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenXin.Blog.Project.Model.Entities.User
{
  public class UserModel
  {
    public int Id { get; set; }

    public string NickName { get; set; }

    public string Name { get; set; }

    public int Age { get; set; }

    public string Password { get; set; }
  }
}
