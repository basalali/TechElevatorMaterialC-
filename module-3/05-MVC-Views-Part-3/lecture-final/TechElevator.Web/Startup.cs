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
<<<<<<< HEAD
        public Startup(IConfiguration configuration) // john changed lines 15-20
=======
        //beginning of insert
        public Startup(IConfiguration configuration)
>>>>>>> 2200c6b41be6ed5a872978634c7ecbc0d19fab3b
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        //end of insert


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
<<<<<<< HEAD
            // john inserted these lines, 50-52 
=======

            //insert starts here
>>>>>>> 2200c6b41be6ed5a872978634c7ecbc0d19fab3b
            SqlConnectionString = Configuration["ConnectionStrings:SqlConnectionString"];
            FilePath = Configuration["ConnectionStrings:FilePath"];
            Source = Configuration["ConnectionStrings:Source"];
            //insert ends here
        }
    
        //insert starts here

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

        //insert end here


}
}