using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intro
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Uygulamam�zda kullanaca��m�z her t�rl� bile�eni ve ba��ml�l���(Dependency) buradan eklenmektedir.
            services.AddControllersWithViews();//empty proje oldu�u i�in kendimiz ekledik.
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //Middleware: httpRequest'den sonra, applicationdan �nce �al��mas�n� istedi�imiz mini alanlar.
            //Pipeline: Middleware in belirli bir s�raya g�re �al��mas�.

            app.UseRouting().UseStaticFiles();

            //app.UseStaticFiles();

  


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
            });

          //  burada olmaz app.UseAuthentication();
           // app.UseAuthorization();
        }
    }
}
