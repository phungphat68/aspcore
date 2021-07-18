using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing.Constraints;
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
            app.UseMvc(x =>
            {
                x.MapRoute("default", "post/{id:int}", new { controllers = "Post", Action = "good" });
            });
            //app.UseRouting();
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute("default", "post/{id:int}", new { Controllers = "Post", Action = "good" });
            //});
            //app.UseMvc();
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute("post", "{controller=Post}/{action=PostByID}/{id:int}");
            //    //endpoints.MapRazorPages();
            //});
            //app.UseMvcWithDefaultRoute();



            //app.UseEndpoints(Endpoint =>
            //{
            //    Endpoint.MapControllerRoute("DEFAULT", "{CONTROLLER=Home}/{ACTION=Index}/{id?}");
            //});



            ////app.UseEndpoints(Endpoint =>
            ////{
            ////    Endpoint.MapControllerRoute("secure", "secure", new
            ////    {
            ////        controller = "Admin",
            ////        action = "Index"
            ////    });
            ////});




            //    app.UseEndpoints(Endpoint =>
            //    {
            //        Endpoint.MapControllerRoute("abcd", "huhuh", new
            //        {
            //            controller = "Home",
            //            action = "Index"
            //        });
            //    });

            //    //Mặc định khi start app sẽ chạy vào chỗ này
            //app.UseEndpoints(Endpoint =>
            //{
            //    Endpoint.MapControllerRoute("default", "{controller=Home}/{action=Index}/{Id?}");
            //});
            //app.UseEndpoints(
            //endpoints =>
            //    {
            //        endpoints.MapControllerRoute(
            //       name: "default",
            //       pattern: "{controller=Home}/{action=Index}/{id:int?}");
            //    }
            //    );
            //app.UseEndpoints(Endpoint =>
            //     {
            //         Endpoint.MapControllerRoute("abcd", "huhuh", new
            //         {
            //             controller = "Post",
            //             action = "PostByID",
            //             id: int

            //         });
            //     });

            //app.UseEndpoints(
            // endpoints =>
            // {
            //     endpoints.MapControllerRoute(
            //   "PostByID",
            //   "Post",
            //   new
            //   {
            //       controller = "Post",
            //       action = "PostByID",
            //       id:int
            //   });
            // });

            


            app.Run(handler: async (CONTEXT) =>
                {
                    await CONTEXT.Response.WriteAsync(text: " KHONG TIM THAY ROUTE");
                });





        }
    }
}
