using System;
using System.ComponentModel.Design;
using System.IO;
using System.Reflection;
using HotelApp.DataAccess;
using HotelApp.Services;
using HotelApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace HotelApp.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureServicesHotelApp(this IServiceCollection serviceCollection)
        { 
            serviceCollection
                .AddScoped<IRoomService,RoomService>()
                .AddScoped<IRoomTypeService,RoomTypeService>()
                .AddScoped<IUserService,UserService>()
                .AddScoped<IRoomStateService,RoomStateService>()
                .AddScoped<IVisitorService,VisitorService>();
            
            return serviceCollection;
        }
        
        public static IServiceCollection ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Hotel API",
                });
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
            return services;
        }
    
        public static IServiceCollection ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<HotelContext>(a=>a.UseNpgsql(configuration["DbConnection"]));
            return services;
        }
    }
}