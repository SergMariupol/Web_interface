using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_interface.Data;
using Web_interface.Data.Interfaces;
using Web_interface.Data.Models;
using Web_interface.Data.Repository;

namespace Web_interface
{
    public class Startup
    {

        private IConfigurationRoot confstring;
        public Startup(Microsoft.AspNetCore.Hosting.IHostingEnvironment hostEnv)
        {
            confstring = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsetings.json").Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContent>(options => options.UseSqlServer(confstring.GetConnectionString("DefaultConnection")));
            services.AddTransient<IAllCars, CarRepository>();//реализация интерфейсов
            services.AddTransient<ICarsCategory, CategoryRepository>();//реализация интерфейсов
            services.AddTransient<IAllOrders, OrderRepository>();//реализация интерфейсов
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
         
            services.AddScoped(sp =>ShopCar.GetCar(sp));
            services.AddMvc(options => options.EnableEndpointRouting = false);// add mvc
            services.AddMemoryCache();
            services.AddSession();
            //services.AddRazorPages();
            //services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();//error list
            app.UseStatusCodePages();//code page
            app.UseStaticFiles();//static files
                                 //app.UseMvcWithDefaultRoute();//url adress index.html
           // app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseMvcWithDefaultRoute();
            //app.UseRouting();

            //app.UseAuthorization();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(
            //        name: "default",
            //        pattern: "{controller=Home}/{action=Index}/{id?}");
            //});

            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default", template: "{controller = Home}/{ation=index}/{id?}");
                routes.MapRoute(name: "categoryFilter", template: "{controller = Car}/{ation=index}/{category?}", defaults: new { Controller = "Car", acrion = "List" });
            });


            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDbContent content = scope.ServiceProvider.GetRequiredService<AppDbContent>();
                DBObjects.Initial(content);
            }
        }
    }
}
