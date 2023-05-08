<<<<<<< HEAD
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
=======
select * from Groups
select * from Students

select AVG(GPA) from Students

select Groups.Name, AVG(Students.GPA) as AverageGPA
from Students
         inner join Groups on Students.GroupID = Groups.ID
group by Groups.Name


select Salary, Name, Age, Email
from Teachers
inner join Person P on P.Id = Teachers.PersonId
where Salary = (select Min(Salary) from Teachers)

select * from Students

select Person.Name, Groups.Name, Students.GPA from Students
inner join Groups on Groups.Id = Students.GroupId
inner join Person on Person.Id = Students.PersonId
where GroupId = 5


select * from Groups
>>>>>>> 12d5d060b0f6b18358902f6b5a89445f67bc6216



use Academy

create table Parent(ID int primary key );

create table Child(Id int, ParentId int foreign key references Parent(Id) on delete cascade );


insert into Parent values(1);
insert into Parent values(2);

insert into Child values(1, 1);
insert into Child values(2, 1);

delete from Parent where Id = 1;

select * from Child
