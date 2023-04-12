using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServer.Middlewares.Interfaces;

namespace WebServer.Middlewares.Classes
{
    public class MiddlewareBuilder
    {
        private Stack<Type>? middlewares = new(); // LoggerMiddleware StaticFilesMiddleware

        // Use - Добавляет middleware в конвейер
        public void Use<T>() where T : IMiddleware
        {
            middlewares?.Push(typeof(T));
        }

        // Build - Собирает конвейер
        public HttpHandler Build()
        {
            HttpHandler handler = context => context!.Response.Close();

            while (middlewares?.Count != 0)
            {
                var type = middlewares?.Pop();
                var middleware = Activator.CreateInstance(type!) as IMiddleware;

                middleware!.Next = handler;
                handler = middleware.Handle;
            }
            return handler;
        }
    }
}
