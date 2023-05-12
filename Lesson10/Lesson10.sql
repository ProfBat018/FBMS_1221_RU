use Store;

create trigger AfterInsertTrigger on Product
    after insert
    as
begin
    select 'After Insert',  * from inserted;
end;

create trigger ForInsertTrigger on Product
    for insert
    as
begin
    declare @title nvarchar(50) set @title = (select Title from inserted);

    if @title = 'Kiwi'
    begin
        raiserror('Kiwi is not allowed', 16, 1);
    end
end;


drop trigger ForInsertTrigger;

insert into Product(Title,  ProductionDate, ExpirationTime) values('Nar',  '2018-01-01', '2022-01-01');
insert into Product(Title,  ProductionDate, ExpirationTime) values('Kiwi',  '2018-01-01', '2022-01-01');


create trigger DeleteTable on Product
    for delete
    as
begin
    select * from deleted
end

create trigger DropProduct3 on database
    for DROP_TABLE
    as
begin
    declare @tableName nvarchar(50) set @tableName = EVENTDATA().value('(/EVENT_INSTANCE/ObjectName)[1]', 'nvarchar(50)');
    if @tableName = 'Test'
    begin
        raiserror('You can not drop Test table', 16, 1);
    end
end


create table Test(Id int, Name nvarchar(50));

drop table Test;