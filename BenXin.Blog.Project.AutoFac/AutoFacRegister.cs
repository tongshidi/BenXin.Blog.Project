using Autofac;
using System;
using System.IO;
using System.Reflection;

namespace BenXin.Blog.Project.AutoFac
{
    /// <summary>
    /// Autofac自动注入
    /// </summary>
    public class AutoFacRegister:Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var basePath = AppContext.BaseDirectory;

            #region 带有接口层的服务注入

            var sericesDLLFile = System.IO.Path.Combine(basePath, "BenXin.Blog.Project.Service.dll");
            var repositoryFile = System.IO.Path.Combine(basePath, "BenXin.Blog.Project.Repository.dll");

            if (!(File.Exists(sericesDLLFile) && File.Exists(repositoryFile)))
            {
                var msg = "Repository.dll和Services.dll 丢失，因为项目解耦了，所以需要先F6编译，再F5运行，请检查 bin 文件夹，并拷贝。";
                throw new Exception(msg);
            }

            //获取 Service.dll 程序集服务，并注册
            var assemblysService = Assembly.LoadFrom(sericesDLLFile);
            //支持属性注入
            builder.RegisterAssemblyTypes(assemblysService).AsImplementedInterfaces().InstancePerDependency()
                .PropertiesAutowired(PropertyWiringOptions.AllowCircularDependencies);

            //获取 Repository.dll 程序集服务，并注册
            var assemblysRepository = Assembly.LoadFrom(repositoryFile);
            //支持属性注入
            builder.RegisterAssemblyTypes(assemblysRepository).AsImplementedInterfaces().InstancePerDependency()
                .PropertiesAutowired(PropertyWiringOptions.AllowCircularDependencies);

            #endregion
        }

    }
}
