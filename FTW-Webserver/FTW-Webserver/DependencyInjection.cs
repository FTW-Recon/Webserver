using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FTWWebserver
{
    public static class DependencyInjection 
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {
            //services.AddScoped<IServ1, Impl1>();
            return services;
        }
    }
}
