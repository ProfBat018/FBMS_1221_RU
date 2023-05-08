use Store;

SELECT DATEADD(day, ROUND(RAND() * DATEDIFF(day,DATEADD(day, -500, GETDATE()), GETDATE()), 0), DATEADD(day, -500, GETDATE())) AS RandomDate

--select DATEDIFF(day, ROUND(RAND(), 0), GETDATE())
--select DATEADD(day, DATEDIFF(day, ROUND(RAND() * (10000 - 1), 0) + 1, GETDATE()), GetDate())


create table Product(
Id int identity(1, 1) UNIQUE,
[Title] nvarchar(MAX) NOT NULL,
[QRCode] varbinary(max) DEFAULT CONVERT(varbinary(max), NEWID()),
[ProductionDate] date default DATEADD(day, ROUND(RAND() * DATEDIFF(day,DATEADD(day, -500, GETDATE()), GETDATE()), 0), DATEADD(day, -500, GETDATE())),
[ExpirationTime] date,
constraint CHK_Time check([ExpirationTime] > [ProductionDate])
);

create table BoughtProducts(
Id int primary key identity(1, 1),
ProductId int foreign key references Product(Id) On DELETE CASCADE
);

create table Receipt(
Id int primary key identity(1, 1),
[Date] date default GETDATE(),
Total money check(Total > 0),
BoughtProductsId int foreign key references BoughtProducts(Id) on delete cascade
);


drop table Receipt
drop table BoughtProducts;
drop table Product;



create table Person (
Id int primary key identity(1, 1),
Name nvarchar(MAX) NOT NULL CHECK (Len(Name) > 3),
Surname nvarchar(MAX) NOT NULL CHECK (Len(Surname) > 3),
Age int NOT NULL CHECK(Age >= 16)
);


create table Positions(
Id int primary key identity(1, 1),
Name nvarchar(MAX) NOT NULL CHECK (Len(Name) >= 3)
);


create table Employee(
Id int primary key identity(1, 1),
PersonId int foreign key references Person(Id),
PositionId int foreign key references Positions(Id),
Salary smallmoney CHECK(Salary >= 345)
);


create table BonusCard(
Id int primary key identity(1, 1),
PersonId int foreign key references Person(Id),
Balance smallmoney default 3);



create table Customer(
Id int primary key identity(1, 1),
BonusId int foreign key references BonusCard(Id),
);


select * from sys.tables;


select Receipt.Date, Sum(Total) from Receipt
inner join BoughtProducts on Receipt.BoughtProductsId = BoughtProducts.Id
group by Receipt.Date

insert into Receipt(Date, Total, BoughtProductsId) values('2019-05-05', 100, 1)

select * from Receipt
inner join BoughtProducts on Receipt.BoughtProductsId = BoughtProducts.Id
where Date = '2019-05-05'


select * from BoughtProducts
left join Receipt on BoughtProducts.Id = Receipt.BoughtProductsId

select * from BoughtProducts
left join Receipt on BoughtProducts.Id = Receipt.BoughtProductsId
where Receipt.Id is not null

select * from BoughtProducts
inner join Receipt on BoughtProducts.Id = Receipt.BoughtProductsId

select * from BoughtProducts
right join Receipt on BoughtProducts.Id = Receipt.BoughtProductsId


select * from BoughtProducts
full outer join Receipt on BoughtProducts.Id = Receipt.BoughtProductsId


select * from BoughtProducts
cross join Receipt

select BoughtProducts.Id, ProductId, Title, QRCode from BoughtProducts
inner join Product P on P.Id = BoughtProducts.ProductId


select * from Product;

select * from BoughtProducts;

ALTER TABLE Product ADD CONSTRAINT PK_Product PRIMARY KEY (Id);