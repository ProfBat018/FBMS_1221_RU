# Логирование данных и интерфейс ILogger<T>

## Логирование данных в Ef Core

Ef core под капотом предоставляет нам возможность логировать все запросы к БД. Для этого нам нужно воспользоваться методом `LogTo` в `DbContext`:

```csharp

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.LogTo(Console.WriteLine);
    }
}
```

Теперь при каждом запросе к БД мы будем видеть в консоли логи:

```csharp
var author = new Author { Name = "Author 1" };
var book = new Book { Name = "Book 1", Author = author };

using (var db = new AppDbContext(options))
{
    db.Books.Add(book);
    db.SaveChanges();
}
```

```bash

info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (0ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT COUNT(*)
      FROM [Books] AS [b]

info: Microsoft.EntityFrameworkCore.Database.Command[20101]

        Executed DbCommand (0ms) [Parameters=[@p0='Book 1' (Size = 450)], CommandType='Text', CommandTimeout='30']
        SELECT [b].[Id], [b].[AuthorId], [b].[Name]
        FROM [Books] AS [b]
        WHERE [b].[Name] = @p0
        ORDER BY [b].[Id]
```

## Логирование данных в NLog

Для логирования данных в NLog нам нужно установить пакет `NLog.Extensions.Logging` и добавить в `appsettings.json` настройки для NLog:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information"
    },
    "NLog": {
      "LogLevel": {
        "Default": "Information"
      }
    }
  }
}
```

Теперь нам нужно добавить в `Program.cs` настройки для NLog:

```csharp
public static IHostBuilder CreateHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
        .ConfigureLogging(logging =>
        {
            logging.ClearProviders();
            logging.SetMinimumLevel(LogLevel.Trace);
        })
        .UseNLog()
        .ConfigureWebHostDefaults(webBuilder =>
        {
            webBuilder.UseStartup<Startup>();
        });
```

Теперь мы можем воспользоваться интерфейсом `ILogger<T>` для логирования данных:

```csharp
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        _logger.LogInformation("Index action called");
        return View();
    }
}
```

Все это будет записано в файл логов:

```bash
2021-03-28 16:39:05.0000|INFO|WebApplication1.Controllers.HomeController|Index action called
```
