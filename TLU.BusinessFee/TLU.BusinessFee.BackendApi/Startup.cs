using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using TLU.BusinessFee.Application.Catalog.ChucVus;
using TLU.BusinessFee.Application.Catalog.NhanViens;
using TLU.BusinessFee.Application.Catalog.PhongBans;
using TLU.BusinessFee.Data.EF;
using TLU.BusinessFee.Utilities.Constants;

namespace TLU.BusinessFee.BackendApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<TLUBusinessFeeDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString(SystemConstant.MainConnectionString)));

            //declare DI

            services.AddTransient<IPublicPhongBanService, PublicPhongBanService>();
            services.AddTransient<IManagerPhongBanService, ManagePhongBanService>();
            services.AddTransient<IManagerChucVuSerVice, ManagerChucVuService>();
            services.AddTransient<IManagerNhanVienService, ManagarNhanVienService>();
            services.AddControllersWithViews();
            //swagger
            services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new OpenApiInfo { Title = "swaggerdemo", Version = "v1" });
            
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseCors(p => p.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:3000"));
            app.UseAuthorization();
            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "swagger TLUBusinessFee demov 1");
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
