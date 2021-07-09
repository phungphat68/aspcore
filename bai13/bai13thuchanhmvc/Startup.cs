using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace bai13thuchanhmvc
{
    public class Startup
    {

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(option => option.EnableEndpointRouting = false);
            //services.AddOptions();
            //services.AddMvc();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseMvcWithDefaultRoute();
            app.UseRouting();
            app.UseMvcWithDefaultRoute();
            app.UseEndpoints(TenTuDat =>
            {
                TenTuDat.MapControllerRoute("DEFAULT", "{CONTROLLER=HOME}/{ACTION=INDEX}/{id?}");
            });
            

            //app.UseRouting();
            //app.UseEndpoints(Endpoint =>
            //{
            //    Endpoint.MapControllerRoute("secure", "secure", new
            //    {
            //        controller = "Admin",
            //        action = "Index"
            //    });

            //    app.UseEndpoints(Endpoint =>
            //    {
            //        Endpoint.MapControllerRoute("abcd", "huhuh", new
            //        {
            //            controller = "Home",
            //            action = "Index"
            //        });
            //    });

            //    //Mặc định khi start app sẽ chạy vào chỗ này
            //    app.UseEndpoints(Endpoint =>
            //    {
            //        Endpoint.MapControllerRoute("default", "{controller=Home}/{action=Index}/{Id?}");
            //    });

            //    //APP.USEMVC(ROUTES =>
            //    //{

            //    //    ROUTES.MAPROUTE(NAME: "DEFAULT", TEMPLATE: "{CONTROLLER}/{ACTION}/{ID?}");
            //    //}
            //    //);

            //    //Tai da sua
            //    app.UseMvc(ROUTES =>
            //    {
            //        ROUTES.MapRoute(name: "DEFAULT", template: "{CONTROLLER=HOME}/{ACTION=INDEX}/{ID?}");
            //    });

            app.Run(handler: async (CONTEXT) =>
            {
                await CONTEXT.Response.WriteAsync(text: " KHONG TIM THAY ROUTE");
            });
       
        }
    }
}
