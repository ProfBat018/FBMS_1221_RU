use Store;



SELECT DATEADD(day, ROUND(RAND() * DATEDIFF(day,DATEADD(day, -500, GETDATE()), GETDATE()), 0), DATEADD(day, -500, GETDATE())) AS RandomDate

--select DATEDIFF(day, ROUND(RAND(), 0), GETDATE())

--select DATEADD(day, DATEDIFF(day, ROUND(RAND() * (10000 - 1), 0) + 1, GETDATE()), GetDate())


create table Product(
Id int identity(1, 1) UNIQUE,
[Title] nvarchar(MAX) NOT NULL,
[QRCode] varbinary(max) DEFAULT CAST(CRYPT_GEN_RANDOM(16) AS VARBINARY(16)),
[ProductionDate] date default DATEADD(day, ROUND(RAND() * DATEDIFF(day,DATEADD(day, -500, GETDATE()), GETDATE()), 0), DATEADD(day, -500, GETDATE())),
[ExpirationTime] date,
constraint CHK_Time check([ExpirationTime] > [ProductionDate]) 
);


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
PositionId int foreign key references Position(Id),
Salary smallmoney CHECK(Salary >= 345)
);


create table BonusCard(
Id int primary key identity(1, 1),
PersonId int foreign key references Person(Id),
Balance smallmoney default 3);


create table BoughtProducts(
Id int primary key identity(1, 1),
ProductId  int foreign key references Product(Id)
);

create table Receipt(
Id int primary key identity(1, 1),
[Date] date default GETDATE(),
Total money check(Total > 0),
BoughtProductsId int foreign key references 
);

create table Customer(
Id int primary key identity(1, 1),
BonusId int foreign key references BonusCard(Id),

);

select * from Person;




