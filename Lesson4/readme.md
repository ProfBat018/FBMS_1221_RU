# Lesson4 : Многотабличные базы данных. Ограничения. 

## Constraints. Ограничения
* Ограничения - это правила, которые накладываются на данные в таблице
* Ограничения позволяют нам контролировать данные в таблице

Типы ограничений:
* NOT NULL
* UNIQUE
* PRIMARY KEY
* FOREIGN KEY
* CHECK
* DEFAULT
* INDEX
* AUTO INCREMENT
* COLLATE
* ON DELETE
* ON UPDATE


## Базы данных делятся на два типа:
* Однотабличные
* Многотабличные

## Однотабличные базы данных
* Содержат в себе одну таблицу
* Все данные хранятся в одной таблице
* Легко записывать и считывать данные
* Но при этом, если в таблице много данных, то это может привести к снижению производительности
* Трудно поддерживать целостность данных
* Нарушается принцип DRY (Don't repeat yourself)
* Нарушается принцип KISS (Keep it simple, stupid)
* Нарушается принцип YAGNI (You aren't gonna need it)
* Сложно бывает фильтровать данные

## Многотабличные базы данных
* Содержат в себе несколько таблиц
* Все данные хранятся в разных таблицах
* Легко поддерживать целостность данных
* Не нарушается принцип DRY (Don't repeat yourself)
* Не нарушается принцип KISS (Keep it simple, stupid)
* Не нарушается принцип YAGNI (You aren't gonna need it)
* Легко фильтровать данные

### Однотабличные базы данных - это редкость
* Все базы данных, которые мы будем создавать, являются многотабличными

# Есть общие принципы нормализации и денормализации баз данных
* Нормализация - это процесс разбиения таблицы на несколько таблиц
* Денормализация - это процесс объединения таблиц в одну таблицу

## Можно задать абсолютно логичный вопрос: "Зачем нужно соединять таблицы, если это усложняет работу с данными?"
* Ответ: "Да, это усложняет работу с данными, но при этом, это упрощает работу с данными"
🐺🐺🐺(Безумно можно быть дата аналитиком)
![wolf.jpg](wolf.jpg)
<br>

Если без рофлов, то это действительно так. При правильной чрезмерной нормализации, работа с данными усложняется.
<br>
Именно из-за этого иногда делаем ctrl + z и возвращаем 5 таблиц в 3 таблицы. 

# Пример:
```tsql

create table Person (
    [Id] int identity(1,1) primary key,
    [Name] nvarchar(50) not null check (len([Name]) >= 2),
    [Surname] nvarchar(50) not null check (len([Surname]) >= 3),
    [Age] int not null check ([Age] >= 15 and [Age] <= 65),
    [Email] nvarchar(50) not null unique check ([Email] like '%_@__%.__%')
);


create table Teachers(
  [Id] int identity(1,1) primary key,
  [PersonId] int not null foreign key references Person([Id]),
  [Salary] smallmoney not null check ([Salary] >= 300)
);
```
Если взять и создать аналогию с C#
```csharp
public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
}

public class Teacher
{
    public int Id { get; set; }
    public Person Person { get; set; }
    public decimal Salary { get; set; }
}
```


