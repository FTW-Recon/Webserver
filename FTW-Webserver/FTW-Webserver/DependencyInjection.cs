using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.StoreFile.Boundaries;
using FTWWebserver.Controllers.StoreFile;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace FTWWebserver
{
    public static class DependencyInjection 
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {
            services.AddScoped<IStoreFilePort, StoreFilePresentation>();
            return services;
        }
    }
}
