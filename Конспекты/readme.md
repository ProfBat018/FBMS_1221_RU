# ASP.NET Web API 

Это фреймворк для создания HTTP-сервисов, которые могут быть использованы различными клиентами, такими как браузеры и мобильные устройства, а так же другие `микросервисы или приложения`. Он позволяет разработчикам создавать `RESTful` веб-службы, которые могут обрабатывать запросы HTTP GET, POST, PUT и DELETE. ASP.NET Web API также обеспечивает встроенную поддержку форматов данных, таких как `JSON и XML`, и может быть интегрирован с другими фреймворками ASP.NET, такими как `MVC` и `SignalR`.

## CORS - Cross-Origin Resource Sharing

По сути нужен для того, чтобы делиться
вашим API с другими хостами. Например, если вы хотите, чтобы ваш API был доступен с другого домена, вам нужно будет включить CORS.

По хорошему, если вы хотите, чтобы ваш API был доступен с другого домена, вы должны включить CORS. Это позволит вашему API принимать запросы с других доменов. 


## Как работает CORS

У `HTTP` есть свои header-ы, которые позволяют браузеру и серверу обмениваться информацией о том, какие запросы разрешены, а какие нет. К примеру 
`Access-Control-Allow-Origin` - указывает, какие домены могут получать доступ к ресурсу.
`Access-Control-Strict-Origin` - указывает, какие домены могут получать доступ к ресурсу, но только если они отправляют `Origin` header в запросе.

### Как написать это в коде

В `ASP.NET Core` есть специальный middleware, который позволяет включить CORS. Для этого нужно добавить его в `ConfigureServices` метод в `Startup.cs` файле.

```csharp
    builder.services.AddCors(options =>
    {
        options.AddPolicy("AllowAllOrigins",
            builder => builder.AllowAnyOrigin());
    });
```

```cs

// Define the DTOs using records
public record UserDto(int Id, string Name, string Email);
public record OrderDto(int Id, string ProductName, decimal Price);
public record AddressDto(int Id, string Street, string City, string Country);

// Define the DbContext with Fluent API
public class MyDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Address> Addresses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure the User entity
        modelBuilder.Entity<User>()
            .HasKey(u => u.Id);
        modelBuilder.Entity<User>()
            .Property(u => u.Name)
            .IsRequired()
            .HasMaxLength(50);
        modelBuilder.Entity<User>()
            .Property(u => u.Email)
            .IsRequired()
            .HasMaxLength(50);

        // Configure the Order entity
        modelBuilder.Entity<Order>()
            .HasKey(o => o.Id);
        modelBuilder.Entity<Order>()
            .Property(o => o.ProductName)
            .IsRequired()
            .HasMaxLength(50);
        modelBuilder.Entity<Order>()
            .Property(o => o.Price)
            .IsRequired();

        // Configure the Address entity
        modelBuilder.Entity<Address>()
            .HasKey(a => a.Id);
        modelBuilder.Entity<Address>()
            .Property(a => a.Street)
            .IsRequired()
            .HasMaxLength(50);
        modelBuilder.Entity<Address>()
            .Property(a => a.City)
            .IsRequired()
            .HasMaxLength(50);
        modelBuilder.Entity<Address>()
            .Property(a => a.Country)
            .IsRequired()
            .HasMaxLength(50);

        base.OnModelCreating(modelBuilder);
    }
}

```
