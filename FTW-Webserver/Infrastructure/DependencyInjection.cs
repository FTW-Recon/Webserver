using System;
using System.Collections.Generic;
using System.Text;
using FTWWebserver.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IDataStorageService, DataStorageService>();
            return services;
        }
        
    }
}
