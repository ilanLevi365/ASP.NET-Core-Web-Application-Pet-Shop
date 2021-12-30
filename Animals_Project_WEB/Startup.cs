using Animals_Project_WEB.Data;
using Animals_Project_WEB.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animals_Project_WEB
{
    public class Startup
    {
        private IConfiguration _configuratin;

        public Startup(IConfiguration configuration)
        {
            _configuratin = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IRepository, MyRepository>();

            string connectionString = _configuratin.GetConnectionString("DefaultConnection");
            services.AddDbContext<HrContext>(options => options.UseSqlServer(connectionString));

            services.AddControllersWithViews();
        }


        public void Configure(IApplicationBuilder app, HrContext ctx)
        {
            //To your reason
            ctx.Database.EnsureDeleted();

            ctx.Database.EnsureCreated();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
