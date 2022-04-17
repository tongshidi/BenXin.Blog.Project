using Autofac;
using BenXin.Blog.Project.AutoFac;
using BenXin.Blog.Project.Common.Config;
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
using System.Linq;
using System.Threading.Tasks;

namespace BenXin.Blog.Project
{
    public class Startup
    {
        public Startup(IConfiguration configuration,IWebHostEnvironment env)
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
            services.AddSwaggerGen((option)=> 
            {
                option.SwaggerDoc("v1",new OpenApiInfo() { Title="BenXin.Project",Version= "v1", Description="����.NET5������api"});
                //��ȡ��·��
                var baseDir = System.AppDomain.CurrentDomain.BaseDirectory;
                //����xml��ע����Ϣ����Ҫ�ڶ�Ӧ���������ԡ������¼�����ѡxml�����桷���±���
                var xmlFile = "BenXin.Blog.Project.Model.xml";//���Զ��xml,����ִ�� option.IncludeXmlComments ����xml·������
                var xmlPath = System.IO.Path.Combine(baseDir,xmlFile);
                option.IncludeXmlComments(xmlPath,true);
            });

            ////Swagger�ӿ��ĵ�ע��
            //services.AddAdminSwaggerSetup();

            //��ӿ���
            services.AddCors(c=> 
            {
                c.AddPolicy(AppSettingsConstVars.CorsPolicyName,cors=> 
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
            builder.RegisterModule(new AutoFacRegister());//ע��

            //��ȡ���п��������Ͳ�ʹ������ע��
            var controllerBaseType = typeof(ControllerBase);
            builder.RegisterAssemblyTypes(typeof(Program).Assembly).Where(x => controllerBaseType.IsAssignableFrom(x) && x != controllerBaseType)
                .PropertiesAutowired();
        }
    }
}
