using AutoMapper;
using EasyNail.Services.Interfaces;
using EasyNail.Services.Services;
using EasyNails.Core.Interfaces;
using EasyNails.Infraestructure.Data;
using EasyNails.Infraestructure.Filters;
using EasyNails.Infraestructure.Repositories;
using EasyNails.Infraestructure.Seeders;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace EasyNaills.Api
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
            services.AddControllers(opt =>
            {
                opt.Filters.Add<GlobalExceptionFilter>();
            });

            services.AddDbContext<DataContext>(cfg =>
            {
                cfg.UseSqlServer(Configuration.GetConnectionString("ConnectionStringCredentials"));
            });

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            //SeedDb
            services.AddTransient<SeedDbContextData>();

            //Dependency Injection Services
            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddTransient<IUserService, UserService>();
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddMvc(opt =>
            {
                opt.Filters.Add<ValidationFilter>();
            }).AddFluentValidation(opt =>
            {
                opt.RegisterValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());
            });
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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
