using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FirstASP
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Added the MVC (Model View Controller) service 
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Added for use with services.addMVC
            app.UseMvc();  // This replaces the functions below

            // Removed since services.addmvc 
            // // app.UseRouting();

            // // app.UseEndpoints(endpoints =>
            // // {
            // //     endpoints.MapGet("/", async context =>
            // //     {
            // //         await context.Response.WriteAsync("Hello World!");
            // //     });
            // // });
        }

        public Startup(IWebHostEnvironment env) {
            System.Console.WriteLine(env.ContentRootPath);
            System.Console.WriteLine(env.IsDevelopment());
        }
    }
}
