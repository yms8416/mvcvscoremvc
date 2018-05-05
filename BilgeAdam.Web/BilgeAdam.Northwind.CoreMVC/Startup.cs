using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using BilgeAdam.Northwind.CoreMVC.Models.DI;
using BilgeAdam.Northwind.CoreData.Context;
using Microsoft.EntityFrameworkCore;

namespace BilgeAdam.Northwind.CoreMVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IPerson, Teacher>();
            //services.AddTransient<IPerson, Teacher>();
            //services.AddSingleton<IPerson, Teacher>();

            services.AddDbContext<NorthwindContext>((options) => {
                options.UseSqlServer(Configuration.GetConnectionString("NorthwindConnStr"));
            });
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
