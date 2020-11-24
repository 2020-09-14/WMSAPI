using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WMS.Database;
using WMS.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using AutoMapper;

namespace WMS
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public IConfiguration _configuration { get; }
        public Startup (IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddCors(options =>
        options.AddPolicy("cor",
        p => p.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin())
        );

            services.AddControllersWithViews();

            services.AddScoped<IWMSRepository,StudentsRepository>();
            services.AddScoped<IWMSAllot, AllotRepository>();
            services.AddScoped<IWMSPurchaseRepository, PurchaseRepository>();
            services.AddScoped<IWMSInventoryRepository, InventoryRepssitory>();
            services.AddScoped<EX_Wangchao, EX_Wangchaolist>();
            ;            services.AddDbContext<AppDbContext>(option=> {
                option.UseSqlServer(_configuration["DbContext:ConnectionString"]);
            });

         
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseStaticFiles();
            app.UseCors("cor");
            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                    endpoints.MapControllers();
            });
        }
    }
}
