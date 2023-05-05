<<<<<<< HEAD
# Additional from Elvin:
* SQL server hosting in Azure
* SQL server hosting in SmarterASP hosting


# Темы сегодняшнего урока: 
* Left join
* Right join
* Outer join
* Inner join 
* Full outer join
* All constraints 


# All constraints

![Constraints]("Constraints.jpg")


=======
# Функции агрегирования в SQL 

Что такое агрегирование? Это процесс суммирования, подсчета среднего, максимума, минимума и т.д. по какому-либо признаку. В SQL для этого есть специальные функции.

<br>

Базовые
* `COUNT` - подсчет количества строк в столбце
* `SUM` - суммирование значений в столбце
* `AVG` - вычисление среднего значения в столбце
* `MIN` - вычисление минимального значения в столбце
* `MAX` - вычисление максимального значения в столбце
<br>

Пример кода с базовыми функциями агрегирования:

```sql

select count(*) from users;
```
Здесь выведется количество строк в таблице users.
    
```sql
    select sum(age) from users;
```
Здесь выведется сумма всех значений в столбце age таблицы users.
    
>>>>>>> 12d5d060b0f6b18358902f6b5a89445f67bc6216

