# Тема урока. Dapper 

Dapper - это библиотека, которая предоставляет простой и быстрый способ доступа к базе данных. Dapper - это микро ORM, который помогает вам взаимодействовать с базой данных. Dapper предоставляет нам методы расширения для IDbConnection. Используя эти методы расширения, мы можем выполнять CRUD операции в базе данных.

Небольшой сравнительный анализ Dapper и Entity Framework:
* Скорость
* * Dapper работает быстрее, чем Entity Framework, потому что Dapper выполняет прямой маппинг данных в объекты, а Entity Framework выполняет маппинг данных в объекты через модель данных.
* Удобство использования
* * Entity Framework более удобен в использовании, чем Dapper, потому что Entity Framework предоставляет нам множество функций, таких как миграции, маппинг, контекст данных и т. д.
* Поддержка
* * Entity Framework поддерживает множество баз данных, таких как SQL Server, MySQL, SQLite, Oracle и т. д., а Dapper поддерживает только SQL Server и Oracle.
* Поддержка LINQ
* * Entity Framework поддерживает LINQ, а Dapper не поддерживает LINQ.
* Поддержка хранимых процедур
* * Entity Framework поддерживает хранимые процедуры, а Dapper не поддерживает хранимые процедуры.


## Подключение Dapper к проекту

Для подключения Dapper нужно скачать библиотеку Dapper через NuGet. Для этого нужно воспользоваться командой:
```bash
dotnet add package dapper
```

## Подключение к базе данных

Для подключения используется класс SqlConnection. Для этого нужно создать экземпляр класса SqlConnection и передать в конструктор строку подключения к базе данных. Пример:
```csharp

using (IDbConnection db = new SqlConnection(connectionString))
{
    // ...
}
```

## Выполнение запросов

Для выполнения запросов используется метод Execute. Пример:
```csharp

using (IDbConnection db = new SqlConnection(connectionString))
{
    db.Execute("INSERT INTO Users (Name, Age) VALUES (@Name, @Age)", new { Name = "Tom", Age = 33 });
}
```

## Выполнение запросов с возвращаемыми данными

Для выполнения запросов с возвращаемыми данными используется метод Query. Пример:
```csharp

using (IDbConnection db = new SqlConnection(connectionString))
{
    var users = db.Query<User>("SELECT * FROM Users");
}
```

## Выполнение запросов с параметрами

Для выполнения запросов с параметрами используется анонимный объект. Пример:
```csharp

using (IDbConnection db = new SqlConnection(connectionString))
{
    var users = db.Query<User>("SELECT * FROM Users WHERE Age = @Age", new { Age = 33 });
}
```

## Выполнение запросов с inner join

Для выполнения запросов с inner join используется метод Query. Пример:
```csharp

using (IDbConnection db = new SqlConnection(connectionString))
{
    var users = db.Query<User, Company, User>("SELECT * FROM Users INNER JOIN Companies ON Users.CompanyId = Companies.Id", (user, company) => { user.Company = company; return user; });
}
```




