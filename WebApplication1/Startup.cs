using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Projeto.Data.Contracts;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using AutoMapper;
using Projeto.Data.Repository;
using Swashbuckle.AspNetCore.Swagger;
using Projeto.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            #region Mapeamento de injeção de dependência

            services.AddAutoMapper(typeof(Startup));

            services.AddDbContext<DataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Projeto")));

            services.AddTransient<IUnityOfWork, UnityOfWork>();

            #endregion

           
            #region Configuração do Swagger

            services.AddSwaggerGen(
               swagger =>
               {
                   swagger.SwaggerDoc("v1",
                       new Info
                       {
                           Title = "TCC COTI Informática",
                           Version = "v1",
                           Description = "Projeto desenvolvido em Asp.Net CORE com EntityFramework"
                       });
               }
               );

            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            #region Configuração do Swagger

            app.UseSwagger();
            app.UseSwaggerUI(
                swagger =>
                {
                    swagger.SwaggerEndpoint("/swagger/v1/swagger.json", "Projeto");
                }
                );

            #endregion

            app.UseMvc();
        }
    }
}
