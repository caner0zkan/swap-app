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
using Microsoft.AspNetCore.Session;

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
            //Session
            services.AddMvc();
            services.AddDistributedMemoryCache();
            services.AddSession();

            services.AddControllers();

            //AddSingleton
            services.AddSingleton<IUserService, UserManager>();
            services.AddSingleton<IProductStatusService, ProductStatusManager>();
            services.AddSingleton<IProductService, ProductManager>();
            services.AddSingleton<IImageService, ImageManager>();
            services.AddSingleton<ICategoryService, CategoryManager>();
            services.AddSingleton<IBidService, BidManager>();
            services.AddSingleton<ICommentService, CommentManager>();

            services.AddSingleton<IUserRepository, UserRepository>();
            services.AddSingleton<IProductStatusRepository, ProductStatusRepository>();
            services.AddSingleton<IProductRepository, ProductRepository>();
            services.AddSingleton<IImageRepository, ImageRepository>();
            services.AddSingleton<ICategoryRepository, CategoryRepository>();
            services.AddSingleton<IBidRepository, BidRepository>();
            services.AddSingleton<ICommentRepository, CommentRepository>();

            //CORS
            services.AddCors();

            //Newtonsoft
            services.AddControllers().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );

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

            //Session
            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
