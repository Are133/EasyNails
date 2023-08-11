
using EasyNails.Core.Interfaces;
using EasyNails.Infraestructure.Data;
using EasyNails.Infraestructure.Interfaces;
using EasyNails.Infraestructure.Options;
using EasyNails.Infraestructure.Repositories;
using EasyNails.Infraestructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.IO;
using System.Reflection;

namespace EasyNails.Infraestructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDbContexts(this IServiceCollection services, IConfiguration configuration)
        {
            return services.AddDbContext<DataContext>(cfg =>
            {
                cfg.UseSqlServer(configuration.GetConnectionString("ConnectionStringCredentials"));
            });
        }

        public static IServiceCollection AddOptions(this IServiceCollection services, IConfiguration configuration)
        {
            return services.Configure<PaginationOptions>(opt => configuration.GetSection("Pagination").Bind(opt));
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddSingleton<IUriService>(prov =>
            {
                var accesor = prov.GetRequiredService<IHttpContextAccessor>();
                var request = accesor.HttpContext.Request;
                var absoluteUri = string.Concat(request.Scheme, "://", request.Host.ToUriComponent());
                return new UriService(absoluteUri);
            });

            return services;
        }

        public static IServiceCollection AddSwaggerConfigure(this IServiceCollection services, string xmlFileName)
        {
            return services.AddSwaggerGen(docSwgr =>
            {
                docSwgr.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Easy Nails API",
                    Version = "v1",
                });
                var xmlRoutPath = Path.Combine(AppContext.BaseDirectory, xmlFileName);

                docSwgr.IncludeXmlComments(xmlRoutPath);
            });
        }
    }
}
