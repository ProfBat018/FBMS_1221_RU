using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServer.Middlewares.Classes;

namespace WebServer.Services.Interfaces
{
    public interface IStartup
    {
        // Configure services - Dependency Injection
        // С помощью этого метода мы можем добавлять сервисы в контейнер
        public void Configure(IServiceCollection? serviceCollection);
        
        // Configure middleware
        // С помощью этого метода мы можем добавлять middleware в конвейер
        public void Configure(MiddlewareBuilder? builder);
    }
}
