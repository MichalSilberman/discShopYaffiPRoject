using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using BLL;
using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApi
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
            services.AddCors(opti => opti.AddPolicy("AllowAll", p => {
                p.AllowAnyOrigin();
                p.AllowAnyMethod();
                p.AllowAnyHeader();
            }
            ));
            //קשרנו בין הממשק של שכבת ה-DAL לבין המחלקה
            //כנ"ל כלפי שכבת ה-BLL
            services.AddScoped(typeof(ICustomerDAL), typeof(CustomerDAL));
            services.AddScoped(typeof(ICustomerBLL), typeof(CustomerBLL));

            services.AddScoped(typeof(ISingerDAL), typeof(SingerDAL));
            services.AddScoped(typeof(ISingerBLL), typeof(SingerBLL));

            services.AddScoped(typeof(IShoppingDAL), typeof(ShoppingDAL));
            services.AddScoped(typeof(IDetailsShoppingDAL), typeof(DetailsShoppingDAL));

            services.AddScoped(typeof(IDiscDAL), typeof(DiscDAL));
            services.AddScoped(typeof(IDiscBLL), typeof(DiscBLL));
            services.AddScoped(typeof(ICartBLL), typeof(CartBLL));
            //הזרקה של מסד הנתונים
            services.AddDbContext<DiscShopDBContext>(option => option.UseSqlServer("Server=LAPTOP-L37SNTD8;Database=DiscShopDB;Trusted_Connection=True;"));
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
            app.UseCors("AllowAll");
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
