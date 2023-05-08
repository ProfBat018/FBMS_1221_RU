-- -- ---- Как создать переменные в SQL ?
-- --
-- -- DECLARE @count INT = 0;
-- --
-- -- ---- Как его заполнить ?
-- --
-- -- SET @count = (SELECT COUNT(*) FROM Product);
-- -- print @count;
-- -- select @count;
-- --
-- -- ---- Как его использовать. Например с условиями и циклами ?
-- --
-- -- if @count > 0
-- --     begin
-- --         select 'count > 0';
-- --     end
-- -- else
-- --     begin
-- --         select 'count <= 0';
-- --     end
-- --
--
--
-- -- declare @boughtCount int = 0;
-- -- declare @receiptCount int = 0;
-- --
-- --
-- -- SET @boughtCount = (select COUNT(*) as ReceiptProductCount
-- -- from Product
-- -- where Id in (select ProductId
-- --              from BoughtProducts
-- --                       inner join Receipt on BoughtProducts.Id = Receipt.BoughtProductsId))
-- --
-- --
-- -- SET @receiptCount = (select count(*) as ProductCount
-- -- from Product
-- -- where Id in (select ProductId
-- --              from BoughtProducts
-- --                       left join Receipt on BoughtProducts.Id = Receipt.BoughtProductsId
-- --              where Receipt.Id is null))
-- --
-- -- if @boughtCount > @receiptCount
-- --     begin
-- --         select @boughtCount as BoughtCount
-- --     end
-- -- else
-- --     begin
-- --         select @receiptCount as ReceiptCount;
-- --     end
-- --
--
--
-- -- DECLARE @i int = 0;
-- --
-- -- while @i <= 10
-- --     begin
-- --         insert into Product (Title) values ('Product ' + cast(@i as varchar));
-- --         set @i = @i + 1;
-- --     end
-- --
--
-- ---- Что такое функции и процедуры ?
--
-- -- ---- Как создать функцию ?
--
-- create function GetProductCount()
-- returns int
-- as
--     begin
--         declare @count int = 0;
--         set @count = (select count(*) from Product);
--         return @count;
--     end
--
--
-- create function GetProduct(@id int)
-- returns table
-- as
--     return
--         (select * from Product where Id = @id);
--
--
--
-- select GetProductCount();
-- select * from GetProduct(1);
--
--
-- create procedure GetProductCountProcedure(@count int output)
-- as
--     begin
--         set @count = (select count(*) from Product);
--     end
--
--
-- declare @result int = 0;
-- execute GetProductCountProcedure @result output;
-- select @result;
--
--
-- select ProductId, MAX(Total) from BoughtProducts
-- inner join Receipt on BoughtProducts.Id = Receipt.BoughtProductsId
-- where Receipt.Date between '2019-01-01' and '2019-12-31'
-- group by ProductId
-- having MAX(Total) > 1000
--



CREATE TABLE [Teachers]
(
[Name] CHAR NOT NULL CHECK (Len(Name)<1),
[Surname] CHAR NOT NULL CHECK (Len(Surname)<1),
[Salary] MONEY NOT NULL CHECK (Len(Salary)>=150),
[Employment Date] DATETIME
)
CREATE TABLE [Groups]
(
[Id] INT IDENTITY(1,1) PRIMARY KEY NOT NULL ,
[Name] NVARCHAR(10) NOT NULL CHECK (Len(Name) > 1),
[Rating] INT NOT NULL CHECK (Rating > 0 and Rating<5),
[Year] INT NOT NULL CHECK (Year >= 1 and Year <= 5)
)

drop table [Teachers]
CREATE TABLE [Departments]
(
[Id] INT IDENTITY(1,1) PRIMARY KEY NOT NULL ,
[Financing] MONEY DEFAULT 0 NOT NULL CHECK(Financing>0),
[Name] NVARCHAR (100) NOT NULL CHECK (Len(Name>1)) UNIQUE
)
CREATE TABLE [Faculties]
(
[Id] INT IDENTITY(1,1) PRIMARY KEY NOT NULL ,
[Name] NVARCHAR(100) NOT NULL CHECK (Len(Name>1)) UNIQUE ,
)
CREATE TABLE [Teachers]
(
[Id] INT IDENTITY(1,1) PRIMARY KEY NOT NULL ,
[EmploymentDate] DATE NOT NULL CHECK (EmploymentDate>'01.01.1990'),
[Name] NVARCHAR(MAX) NOT NULL CHECK(Len(Name>1)) ,
[Premium] MONEY NOT NULL CHECK (Premium>0) DEFAULT 0,
[Salary] MONEY NOT NULL CHECK (Salary>=0),
[Surname] NVARCHAR(MAX) NOT NULL CHECK (Len(Name>1))
)
