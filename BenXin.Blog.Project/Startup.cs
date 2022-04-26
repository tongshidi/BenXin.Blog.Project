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
        /// ���л���
        /// </summary>
        public IWebHostEnvironment Env { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();

            //��ǰע�뵥������Ȼ����AppSettingsHelper ��IConfiguration �Ͳ���ע�븳ֵĬ��Ϊnull
            services.AddSingleton(new AppSettingsHelper(Env.ContentRootPath));

            /*
             * 1.���service AddSwaggerGen ������Ϣ
             * 2.app.UseSwagger() ע�ᣬ����app.UseSwaggerUI ��Ϣ
             */
            //���swagger����
            services.AddSwaggerGen((option) =>
            {
                option.SwaggerDoc("v1", new OpenApiInfo() { Title = "BenXin.Project", Version = "v1", Description = "����.NET5������api" });
                //��ȡ��·��
                var baseDir = System.AppDomain.CurrentDomain.BaseDirectory;
                //����xml��ע����Ϣ����Ҫ�ڶ�Ӧ���������ԡ������¼�����ѡxml�����桷���±���
                var xmlFile = "BenXin.Blog.Project.Model.xml";//���Զ��xml,����ִ�� option.IncludeXmlComments ����xml·������
                var xmlPath = System.IO.Path.Combine(baseDir, xmlFile);
                option.IncludeXmlComments(xmlPath, true);
            });

            //SqlSugar����ע��
            services.AddSqlSugarSetup();

            ////Swagger�ӿ��ĵ�ע��
            //services.AddAdminSwaggerSetup();

            //��ӿ���
            services.AddCors(c =>
            {
                c.AddPolicy(AppSettingsConstVars.CorsPolicyName, cors =>
                {
                    var isAllIP = AppSettingsConstVars.CorsEnableAllIPs;
                    cors
                    .AllowAnyMethod()//�����κη���
                    .AllowAnyHeader();//�����κα�ͷ
                    if (!isAllIP)
                        cors.WithOrigins(AppSettingsConstVars.CorsIPs);//�������ȫ�������Ǿ�Ĭ������ȫ������
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

            //��ӿ���
            app.UseCors(AppSettingsConstVars.CorsPolicyName);

            //���ش�����
            app.UseStatusCodePages();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //����Ĭ��·��
                endpoints.MapControllers();
                //endpoints.MapControllerRoute("default","{controller=Home}/{action=Index}/{id?}");
            });
        }

        /// <summary>
        /// autofacʹ��Ȼ��ע��
        /// </summary>
        /// <param name="builder"></param>
        public void ConfigureContainer(ContainerBuilder builder)
        {
            var basePath = AppContext.BaseDirectory;

            #region ���нӿڲ�ķ���ע��

            var sericesDLLFile = System.IO.Path.Combine(basePath, "BenXin.Blog.Project.Service.dll");
            var repositoryFile = System.IO.Path.Combine(basePath, "BenXin.Blog.Project.Repository.dll");

            if (!(File.Exists(sericesDLLFile) && File.Exists(repositoryFile)))
            {
                var msg = "Repository.dll��Services.dll ��ʧ����Ϊ��Ŀ�����ˣ�������Ҫ��F6���룬��F5���У����� bin �ļ��У���������";
                throw new Exception(msg);
            }

            //��ȡ Service.dll ���򼯷��񣬲�ע��
            var assemblysService = Assembly.LoadFrom(sericesDLLFile);
            //֧������ע��
            builder.RegisterAssemblyTypes(assemblysService).Where(t => t.Name.EndsWith("Service")).AsImplementedInterfaces();

            //��ȡ Repository.dll ���򼯷��񣬲�ע��
            var assemblysRepository = Assembly.LoadFrom(repositoryFile);
            //֧������ע��
            builder.RegisterAssemblyTypes(assemblysRepository).Where(t => t.Name.EndsWith("Repository")).AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(assemblysRepository).Where(t => t.Name.EndsWith("UnitOfWork")).AsImplementedInterfaces();

            //builder.RegisterType<UserService>().As<IUserService>();
            //builder.RegisterType<UserRepository>().As<IUserRepository>();
            //builder.RegisterType<IUnitOfWork>();
            #endregion

            //builder.RegisterModule<AutoFacRegister>();//ע��
            //var controllersTypeInAssembly = typeof(Startup).Assembly.GetExportedTypes().Where(x=>typeof(ControllerBase).IsAssignableFrom(x)).ToArray();//
            //builder.RegisterTypes(controllersTypeInAssembly).AsImplementedInterfaces();
            //��ȡ���п��������Ͳ�ʹ������ע��
            //var controllerBaseType = typeof(ControllerBase);
            //builder.RegisterAssemblyTypes(typeof(Program).Assembly).Where(x => controllerBaseType.IsAssignableFrom(x) && x != controllerBaseType)
            //    .AsImplementedInterfaces().PropertiesAutowired();

        }
    }
}
