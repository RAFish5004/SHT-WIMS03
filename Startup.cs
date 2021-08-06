// ========================================================
// SHTWIMS03.sln, 210309
// Author: Russell Fisher
// 
// ========================================================

// path: C:\OneDriveLocal\OneDrive\ASPMVC\ARCWeb\SHT-WIMS02

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
using SHTWIMS03.Models;
using SHTWIMS03.Areas.Pull.Models;
using SHTWIMS03.Areas.Receive.Models;
using SHTWIMS03.Areas.Count.Models;
using SHTWIMS03.Areas.Locate.Models;


namespace SHTWIMS03
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
            services.AddDbContext<ApplicationDbContext>(options =>         
                options.UseSqlServer(Configuration["Data:WIMS02Connect:ConnectionString"])
           );
            
            // provides collections of more or less static lists
            services.AddTransient<ICatalogItemRepository, EFCatalogItemRepository>();            
            services.AddTransient<ILocationRepository, EFLocationRepository>();
            services.AddTransient<ICountyRepository, EFCountyRepository>();
            services.AddTransient<IPullHdrRepository, EFPullHdrRepository>();
            services.AddScoped<Cart>(sp => SessionCart.GetCart(sp)); // p 273
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>(); // p 273
            services.AddTransient<IPullItemRepository, EFPullItemRepository>(); 
            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();

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
            app.UseStatusCodePages();
            app.UseHttpsRedirection();
            
            app.UseSession(); //p 264
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                name: "AreaRoute",
                pattern: "{area}/{controller}/{action}/{id?}");                

                endpoints.MapControllerRoute(   
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            // Create database tables that already have data
            // CatalogItemSeedData.EnsurePopulated(app);
            // CountySeedData.EnsurePopulated(app);
            // PullHdrSeedData.PopulatedPullHdr(app);
            // PullItemSeedData.EnsurePopulated(app);
        } // eo Configure method ------------------------------------------------------------------

    } // eo Startup class -------------------------------------------------------------------------
} // eo namespace
