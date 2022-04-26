using Autofac;
using BenXin.Blog.Project.AutoFac;
using BenXin.Blog.Project.Common.Config;
using BenXin.Blog.Project.IRepository;
using BenXin.Blog.Project.IRepository.UnitOfWork;
using BenXin.Blog.Project.IService;
using BenXin.Blog.Project.Model.ViewModel;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace BenXin.Blog.Project
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            Env = env;
        }

        public IConfiguration Configuration { get; }

        /// <summary>
        /// 运行环境
        /// </summary>
        public IWebHostEnvironment Env { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();

            //提前注入单例，不然里面AppSettingsHelper 中IConfiguration 就不能注入赋值默认为null
            services.AddSingleton(new AppSettingsHelper(Env.ContentRootPath));

            /*
             * 1.添加service AddSwaggerGen 配置信息
             * 2.app.UseSwagger() 注册，配置app.UseSwaggerUI 信息
             */
            //添加swagger配置
            services.AddSwaggerGen((option) =>
            {
                option.SwaggerDoc("v1", new OpenApiInfo() { Title = "BenXin.Project", Version = "v1", Description = "基于.NET5开发的api" });
                //获取根路径
                var baseDir = System.AppDomain.CurrentDomain.BaseDirectory;
                //加载xml的注释信息，需要在对应的类中属性》生成事件》勾选xml》保存》重新编译
                var xmlFile = "BenXin.Blog.Project.Model.xml";//可以多个xml,后续执行 option.IncludeXmlComments 其他xml路径即可
                var xmlPath = System.IO.Path.Combine(baseDir, xmlFile);
                option.IncludeXmlComments(xmlPath, true);
            });

            //SqlSugar本地注入
            services.AddSqlSugarSetup();

            ////Swagger接口文档注入
            //services.AddAdminSwaggerSetup();

            //添加跨域
            services.AddCors(c =>
            {
                c.AddPolicy(AppSettingsConstVars.CorsPolicyName, cors =>
                {
                    var isAllIP = AppSettingsConstVars.CorsEnableAllIPs;
                    cors
                    .AllowAnyMethod()//允许任何方法
                    .AllowAnyHeader();//允许任何表头
                    if (!isAllIP)
                        cors.WithOrigins(AppSettingsConstVars.CorsIPs);//如果不是全部配置那就默认允许全部跨域
                });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BenXin.Blog.Project v1"));
            }

            //添加跨域
            app.UseCors(AppSettingsConstVars.CorsPolicyName);

            //返回错误码
            app.UseStatusCodePages();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //设置默认路由
                endpoints.MapControllers();
                //endpoints.MapControllerRoute("default","{controller=Home}/{action=Index}/{id?}");
            });
        }

        /// <summary>
        /// autofac使用然后注入
        /// </summary>
        /// <param name="builder"></param>
        public void ConfigureContainer(ContainerBuilder builder)
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
            builder.RegisterAssemblyTypes(assemblysService).Where(t => t.Name.EndsWith("Service")).AsImplementedInterfaces();

            //获取 Repository.dll 程序集服务，并注册
            var assemblysRepository = Assembly.LoadFrom(repositoryFile);
            //支持属性注入
            builder.RegisterAssemblyTypes(assemblysRepository).Where(t => t.Name.EndsWith("Repository")).AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(assemblysRepository).Where(t => t.Name.EndsWith("UnitOfWork")).AsImplementedInterfaces();

            //builder.RegisterType<UserService>().As<IUserService>();
            //builder.RegisterType<UserRepository>().As<IUserRepository>();
            //builder.RegisterType<IUnitOfWork>();
            #endregion

            //builder.RegisterModule<AutoFacRegister>();//注册
            //var controllersTypeInAssembly = typeof(Startup).Assembly.GetExportedTypes().Where(x=>typeof(ControllerBase).IsAssignableFrom(x)).ToArray();//
            //builder.RegisterTypes(controllersTypeInAssembly).AsImplementedInterfaces();
            //获取所有控制器类型并使用属性注入
            //var controllerBaseType = typeof(ControllerBase);
            //builder.RegisterAssemblyTypes(typeof(Program).Assembly).Where(x => controllerBaseType.IsAssignableFrom(x) && x != controllerBaseType)
            //    .AsImplementedInterfaces().PropertiesAutowired();

        }
    }
}
