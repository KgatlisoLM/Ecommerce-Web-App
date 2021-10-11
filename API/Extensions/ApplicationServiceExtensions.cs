using CORE.Interfaces;
using INFRASTRUCTURE.Data;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IProductRepo, ProductRepo>();
            services.AddScoped<IBasketRepo, BasketRepo>();
            services.AddScoped(typeof(IGenericRepo<>), (typeof(GenericRepo<>)));

            return services;
        }
    }
}
