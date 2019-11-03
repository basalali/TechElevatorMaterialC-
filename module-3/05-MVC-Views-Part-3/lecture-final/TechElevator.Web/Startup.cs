﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TechElevator.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration) // john changed lines 15-20
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {            
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            // john inserted these lines, 50-52 
            SqlConnectionString = Configuration["ConnectionStrings:SqlConnectionString"];
            FilePath = Configuration["ConnectionStrings:FilePath"];
            Source = Configuration["ConnectionStrings:Source"];
        }
    

        public static string SqlConnectionString
        {
            get;
            private set;
        }

        public static string FilePath
        {
            get;
            private set;
        }

        public static string Source
        {
            get;
            private set;
        }


}
}
