# Урок №10. Триггеры. Репликация.


Что такое Триггеры и зачем они нужны ?

Триггеры - это специальные хранимые процедуры, которые выполняются автоматически при выполнении определенных операций с данными. Триггеры могут выполняться до или после выполнения операции, которая вызвала триггер, и могут действовать как на одну строку, так и на группу строк.


Триггеры могут использоваться для следующих целей:
- Ограничение доступа к данным (триггеры проверки)
- Поддержка целостности данных (триггеры действий)
- Аудит изменений данных (триггеры аудита)

## Ключевые слова для создания триггера:
* `CREATE TRIGGER` - создание триггера
* `ON` - на какую таблицу
* `FOR EACH ROW` - для каждой строки
* `BEGIN` - начало тела триггера
* `END` - конец тела триггера


## Какие бывают триггеры ?
* `DML` - триггеры, которые срабатывают при выполнении операций `INSERT`, `UPDATE`, `DELETE`
* `DDL` - триггеры, которые срабатывают при выполнении операций `CREATE`, `ALTER`, `DROP`
* `LOGON` - триггеры, которые срабатывают при подключении пользователя к базе данных
* `DATABASE` - триггеры, которые срабатывают при создании, изменении или удалении базы данных


## DML триггеры бывают следующих типов: 
* `INSERT` - триггер срабатывает при добавлении данных в таблицу
* `UPDATE` - триггер срабатывает при обновлении данных в таблице
* `DELETE` - триггер срабатывает при удалении данных из таблицы


## DDL триггеры бывают следующих типов:
* `CREATE` - триггер срабатывает при создании объекта
* `ALTER` - триггер срабатывает при изменении объекта
* `DROP` - триггер срабатывает при удалении объекта
* `RENAME` - триггер срабатывает при переименовании объекта
* `TRUNCATE` - триггер срабатывает при очистке таблицы

## Сами триггеры могут быть следующих типов:
* `BEFORE` - триггер срабатывает до выполнения операции
* `AFTER` - триггер срабатывает после выполнения операции
* `INSTEAD OF` - триггер срабатывает вместо выполнения операции
* `FOR` - триггер срабатывает для каждой строки


Пример. Синтаксис создания DML триггера на insert:
```sql

CREATE TRIGGER trigger_name
ON table_name
FOR INSERT
AS
BEGIN
    -- тело триггера
END
```

### При `insert` часто нужно бывает брать данные, которые пользователь хочет ввести. Как это сделать ?
Для этого в теле триггера можно использовать следующие функции:
* `INSERTED` - возвращает данные, которые были добавлены в таблицу
* `DELETED` - возвращает данные, которые были удалены из таблицы
* `UPDATE` - возвращает данные, которые были обновлены в таблице

Пример. Синтаксис использования функций `INSERTED` и `DELETED`:
```sql

CREATE TRIGGER trigger_name
ON table_name
FOR INSERT
AS
BEGIN
    -- тело триггера
    SELECT * FROM INSERTED
    SELECT * FROM DELETED
END
```

# ВНИМАНИЕ! Разница между For Insert и After Insert
* `For Insert` - триггер срабатывает до выполнения операции
* `After Insert` - триггер срабатывает после выполнения операции

    



