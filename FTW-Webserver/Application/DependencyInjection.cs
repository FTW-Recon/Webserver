using System;
using System.Collections.Generic;
using System.Text;
using FTWWebserver.Application.StoreFile;
using FTWWebserver.Application.StoreFile.Boundaries;
using Microsoft.Extensions.DependencyInjection;

namespace FTWWebserver.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IUseCase<StoreFileInput>, StoreFileUseCase>();
            return services;
        }
    }
}
