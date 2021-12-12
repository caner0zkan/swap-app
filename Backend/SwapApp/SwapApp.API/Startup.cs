using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SwapApp.Business.Abstract;
using SwapApp.Business.Concrete;
using SwapApp.DataAccess.Abstract;
using SwapApp.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwapApp.API
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
            services.AddControllers();

            //AddSingleton
            services.AddSingleton<IUserService, UserManager>();
            services.AddSingleton<IProductStatusService, ProductStatusManager>();
            services.AddSingleton<IProductService, ProductManager>();
            services.AddSingleton<IImageService, ImageManager>();
            services.AddSingleton<ICategoryService, CategoryManager>();
            services.AddSingleton<IBidService, BidManager>();

            services.AddSingleton<IUserRepository, UserRepository>();
            services.AddSingleton<IProductStatusRepository, ProductStatusRepository>();
            services.AddSingleton<IProductRepository, ProductRepository>();
            services.AddSingleton<IImageRepository, ImageRepository>();
            services.AddSingleton<ICategoryRepository, CategoryRepository>();
            services.AddSingleton<IBidRepository, BidRepository>();

            //CORS
            services.AddCors();

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
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            //CORS
            app.UseCors(options =>
            options.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
            );

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
