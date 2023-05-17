-- begin transaction First;
-- select * from Product;
--
-- insert into Product(Title, ProductionDate, ExpirationTime) values ('Badam murebbesi', '2019-01-01', '2020-01-01');
-- commit
--
-- rollback transaction First;
--
-- select * from Product
-- where Title = 'Badam murebbesi';


begin transaction;
insert into Product(Title, ProductionDate, ExpirationTime) values ('Snickers', '2019-01-01', '2020-01-01');
save transaction First;
begin transaction;
insert into Product(Title, ProductionDate, ExpirationTime) values ('Twix', '2019-01-01', '2020-01-01');
save transaction Second;
begin transaction;
insert into Product(Title, ProductionDate, ExpirationTime) values ('Bounty', '2019-01-01', '2020-01-01');
save transaction Third;

select top 3 * from Product
order by Id desc;

rollback transaction First;