using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SHTWIMS02.Models;

namespace SHTWIMS02
{
    public class Startup // -----------------------------------------------------------------------
    {
        // constructor
        public Startup(IConfiguration configuration) // -------------------------------------------
        {
            Configuration = configuration;

        } // eo Startup constructor ---------------------------------------------------------------
        
        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services) // -----------------------------
        {
            services.AddControllersWithViews(); // enable EndPoints (I think)
       
        } // eo ConfigureServices -----------------------------------------------------------------



        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // Endpoints: https://www.learmoreseekmore.com/2020/01/endpoint-routing-in-aspnet-core.html
        // Areas: https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/areas?view=aspnetcore-5.0
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) // ----------------
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseRouting();
            app.UseStaticFiles();
            app.UseHttpsRedirection();
            
            //app.UseSession(); //this generates an exception 
            /*
             InvalidOperationException: Unable to resolve service for type 'Microsoft.AspNetCore.Session.ISessionStore' 
              while attempting to activate 'Microsoft.AspNetCore.Session.SessionMiddleware'.
             */


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        } // eo Configure method ------------------------------------------------------------------

    } // eo Startup class -------------------------------------------------------------------------
} // eo namespace
