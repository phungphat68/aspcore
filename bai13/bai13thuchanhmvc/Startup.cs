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
            //services.AddMvc( =option> option.EnableEndpointRouting = false);
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddOptions();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();
            app.UseEndpoints(Endpoint =>
            {
                Endpoint.MapControllerRoute("secure", "{controller=Admin}/{action=Index}/{id?}");
                Endpoint.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
                

               
            });

            //APP.USEMVC(ROUTES =>
            //{

            //    ROUTES.MAPROUTE(NAME: "DEFAULT", TEMPLATE: "{CONTROLLER}/{ACTION}/{ID?}");
            //}
            //        );

            // Tai da sua
            //app.UseMvc(ROUTES =>
            //{
            //    ROUTES.MapRoute(name: "DEFAULT", template: "{CONTROLLER=HOME}/{ACTION=INDEX}/{ID?}");
            //});

            app.Run(handler: async (CONTEXT) =>
            {
                await CONTEXT.Response.WriteAsync(text: " KHONG TIM THAY ROUTE");
            });



        }
    }
}
