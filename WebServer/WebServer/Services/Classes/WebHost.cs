using Microsoft.Extensions.DependencyInjection;
using System.Net;
using WebServer.Middlewares.Classes;

namespace WebServer.Services.Classes
{
    public class WebHost
    {
        public WebHost(ushort port)
        {
            _port = port;
            _listener = new();
            _builder = new();
            _startup = new();
        }

        public void UserStartup()
        {
            var collection = new ServiceCollection();

            _startup?.Configure(collection); // конфигурируем сервисы и добавляем их в коллекцию

            Container = collection.BuildServiceProvider(); // Создаем контейнер сервисов с нужной коллекцией сервисов
        }

        public void Start()
        {
            _listener.Prefixes.Add($"http://localhost:{_port}/"); // 127.0.0.1
            _listener.Start();
            Console.WriteLine($"Server started on port: {_port}");


            while (true)
            {
                this.UserStartup();

                _startup.Configure(_builder);
                

                var context = _listener.GetContext(); 
               
                // Получаем контекст запроса, то есть все данные запроса.
                // Например, если мы отправили запрос на http://localhost:5000/Info/GetInfo
                // То в контексте будет храниться информация о запросе, такая как:
                // 1. Метод запроса (GET, POST, PUT, DELETE)
                // 2. Путь запроса (Info/GetInfo) самое главное, что сейчас нам нужно
                // 3. Заголовки запроса
                // 4. Тело запроса
                // 5. Куки запроса
                // 6. И т.д.

                HandleRequest(context);
            }
        }

        public void HandleRequest(HttpListenerContext context)
        {
            var handler = _builder?.Build();
            handler?.Invoke(context);
        }

        private Startup _startup;

        public static ServiceProvider? Container;
        private HttpListener _listener;
        private ushort _port;
        private MiddlewareBuilder? _builder;
    }
}
