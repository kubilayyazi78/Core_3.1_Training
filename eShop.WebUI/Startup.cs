using eShop.Business.Services;
using eShop.DataAccess.Data;
using eShop.DataAccess.Repositories;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.WebUI
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
            services.AddControllersWithViews();


            services.AddDbContext<AcibademShopContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("db")));

            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductRepository, EFProductRepository>();

            services.AddScoped<ICategoryService, CategoryService>();
            //  services.AddScoped<ICategoryRepository, FakeCategoryRepository>();
            services.AddScoped<ICategoryRepository, EFCategoryRepository>();


            services.AddScoped<IUserService, UserService>();
            //.netcoreda istenmeyen bir yap� ekli olmaz Session kullanacaksak startupta belirtmeliyiz.
            services.AddSession(so => { so.IdleTimeout = TimeSpan.FromMinutes(10); });

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(opt =>
            {
                opt.LoginPath = "/User/Login";//Login de�ilse y�nlendirelecek yer.
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();


            app.UseAuthentication();//kimlik 
            app.UseAuthorization();//yetki


            app.UseSession();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                 name: null,
                 pattern: "Sayfa{page:int}",
                 defaults: new { controller = "Home", action = "Index", page = 1 });

                endpoints.MapControllerRoute(
                           name: "default",
                           pattern: "{controller=Home}/{action=Index}/{id?}");



            });
        }
    }
}
