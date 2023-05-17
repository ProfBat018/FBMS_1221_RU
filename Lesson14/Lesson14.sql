-- -- some and any. Это одно и тоже
--
-- select top 4 *
-- from Product
-- where Id > some (select top 3 Id from Product)
--
-- create view Top4Products as
-- select top 4 * from Product
--
-- select * from Top4Products


-- grant, deny , revoke


create table #temp (Id int, Name nvarchar(50))

insert into #temp values (1, 'Ivan')
insert into #temp values (2, 'Petr')


select * from #temp


