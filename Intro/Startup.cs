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
            //Uygulamamýzda kullanacaðýmýz her türlü bileþeni ve baðýmlýlýðý(Dependency) buradan eklenmektedir.
            services.AddControllersWithViews();//empty proje olduðu için kendimiz ekledik.
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //Middleware: httpRequest'den sonra, applicationdan önce çalýþmasýný istediðimiz mini alanlar.
            //Pipeline: Middleware in belirli bir sýraya göre çalýþmasý.

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
