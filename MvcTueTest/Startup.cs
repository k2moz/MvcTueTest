using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
// Сюда добавляем импорт (предварительно ставим пакет через Nuget)
using Microsoft.AspNetCore.SpaServices.Webpack;
using MvcTueTest.Models;
using Microsoft.EntityFrameworkCore;
// добавляем ORACLE
//using Oracle.ManagedDataAccess.Client;

namespace MvcTueTest
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
            //services.AddControllersWithViews(); это строчка из темплейта MVC CORE
            // Решение 134 ошибки!
            services.AddMvc(options => options.EnableEndpointRouting = false);
//            services.AddMvc();


//            services.AddDbContext<PersonAppContext>(
//                options => options.UseNpgsql(
//                    Configuration.GetConnectionString("DefaultConnection")
//                )
//            );

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        [Obsolete]
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
            
            if (env.IsDevelopment())
            {
               
                app.UseDeveloperExceptionPage();

                // сюда добавляем webpack
                app.UseWebpackDevMiddleware(new WebpackDevMiddlewareOptions
                {
                    HotModuleReplacement = true
                });
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            
            
//            
//            app.Run(async (context) =>
//            {
//                string conString = "User Id=P_MDD_DEV;Password=P_MDD_DEV134:Data Source=10.0.3.64:1521/test";
//            });
            
            
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();


            // Здесь добавляем роутинг. Надо разобраться как с ним работать
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapSpaFallbackRoute(
                    name: "spa-fallback",
                    defaults: new { controller = "Home", action = "Index" });
            });




            

            // Это из тмеплейта MVC CORE
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(
            //        name: "default",
            //        pattern: "{controller=Home}/{action=Index}/{id?}");
            //});



        }
    }
}
