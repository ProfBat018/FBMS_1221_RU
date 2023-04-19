### Мы работаем на MS SQL Server 2022, используя DataGrip или SSMS на языке T-SQL
## SSMS - Sql Server Managment Studio
SSMS - IDE, среда разработки для работы с базами данных SQL Server. Позволяет создавать базы данных, таблицы, хранимые процедуры, функции, триггеры, представления, индексы, пользователей, роли, права доступа и т.д.
## Sql Server Configuration Manager
SSCM - конфигуратор SQL Server. Позволяет настраивать параметры сервера, управлять службами, просматривать логи, настраивать сетевые подключения и т.д.

## SSMS vs DataGrip
**SSMS** - достаточно старая и устаревшая среда разработки, которая не имеет никаких преимуществ перед DataGrip,
но создавать опции автоматизации и службы обслуживания в SSMS можно, а в DataGrip нет.
<br>
**DataGrip** - это универсальная среда разработки. Тут можно работать с различными СУБД, а не только с SQL Server.
<br>

# Lesson2 - DDL и DML
## DDL - Data Definition Language
DDL - язык определения данных. Позволяет создавать базы данных, таблицы, индексы, представления, хранимые процедуры, функции, триггеры и т.д.
## DML - Data Manipulation Language
DML - язык манипуляции данными. Позволяет вставлять, обновлять, удалять данные из таблиц.

<br>

## DDL syntax
* CREATE - DATABASE, TABLE, INDEX, VIEW, PROCEDURE, FUNCTION, TRIGGER
* DROP или Delete - DATABASE, TABLE, INDEX, VIEW, PROCEDURE, FUNCTION, TRIGGER
* Alter - DATABASE, TABLE, INDEX, VIEW, PROCEDURE, FUNCTION, TRIGGER
<br>

# Создание таблиц в SQL Server
```tsql
CREATE TABLE Students(
    Id int IDENTITY(1,1) primary key,
    Name varchar(50) not null,
    Surname varchar(50) not null,
    Age int not null,
    Email varchar(50) not null unique,
);
```

## SQL constraints(***ограничения***)
unique - уникальное значение
```tsql
    [Age] int not null check ((Age > 0) AND (Age <= 100))
```
check - ограничение на значение
<br>

## Transactions - ACID
* Atomicity - Атомарность
* Consistency - Консистентность
* Isolation - Изоляция
* Durability - Долговечность
<br>

