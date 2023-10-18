using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServer.Controllers;
using WebServer.Middlewares.Classes;
using WebServer.Services.Interfaces;

namespace WebServer.Services.Classes
{
    public class Startup : IStartup
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<LoggerMiddleware>();
            serviceCollection.AddTransient<HomeController>();
            serviceCollection.AddTransient<InfoController>();

            serviceCollection.AddTransient<LoggerService>();
            serviceCollection.AddTransient<MVCMiddleware>();
            serviceCollection.AddTransient<StaticFilesMiddleware>();
        }
        
        public void ConfigureMiddleware(MiddlewareBuilder builder)
        {
            builder.Use<MVCMiddleware>();
            builder.Use<LoggerMiddleware>();
            builder.Use<StaticFilesMiddleware>();
        }
    }
}

