# Additional from Elvin:
* SQL server hosting in Azure
* SQL server hosting in SmarterASP hosting


# Темы сегодняшнего урока: 
* Left join
* Right join
* Inner join 
* Full outer join
* All constraints 

# Left join
Left Join возвращает все строки из левой таблицы и только те строки из правой таблицы, которые удовлетворяют условию соединения.

# Right join
Right Join возвращает все строки из правой таблицы и только те строки из левой таблицы, которые удовлетворяют условию соединения.

# Inner join
Inner Join возвращает not null из левой и правой, которые удовлетворяют условию соединения.


# Full outer join
Full outer join возвращает все строки из левой и правой таблицы, которые удовлетворяют условию соединения.

# Разница между Outer Join & Full outer join 
* `Outer Join` - возвращает все строки из левой и правой таблицы, которые удовлетворяют условию соединения.
* `Full outer join` - возвращает все строки из левой и правой таблицы, которые удовлетворяют условию соединения.
То есть разницы нет. 

![SQL Joins](https://user-images.githubusercontent.com/7157346/64021626-fa6c1200-cb66-11e9-8742-23bc7d107532.png)

### On delete cascade

При использовании On delete cascade, при удалении родительской записи, удаляются все дочерние записи.

Пример использования:

```sql
create table Parent
(
    Id int primary key identity(1,1),
    Name nvarchar(50)
)
    
create table Child
(
    Id int primary key identity(1,1),
    Name nvarchar(50),
    ParentId int foreign key references Parent(Id) on delete cascade
)
```

# All constraints

![Constraints]("Constraints.jpg")


```sql
-- how to get all table schema information from database
select * from sys.tables;
```

# Разница между Convert & Cast 

* `Convert` - преобразует значение в указанный тип данных, который не обязательно должен быть совместим с исходным типом данных.

* `Cast` - преобразует значение в указанный тип данных, который обязательно должен быть совместим с исходным типом данных.


# Разница между union & union all
* `Union` - объединяет результаты двух или более запросов в один набор исключая дубликаты.
* `Union all` - объединяет результаты двух или более запросов в один набор включая дубликаты.

