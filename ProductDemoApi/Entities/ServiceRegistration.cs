using Microsoft.Extensions.DependencyInjection;
using ProductDemoApi.Interfaces;
using ProductDemoApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductDemoApi.Entities
{
    public static class ServiceRegistration
    {

        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
