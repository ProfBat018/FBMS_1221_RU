use [1221Test]

-- DDL

-- drop table Students;

CREATE TABLE Students(
    Id int IDENTITY(1,1) primary key,
    Name varchar(50) not null,
    Surname varchar(50) not null,
    Age int not null check ((Age > 0) AND (Age <= 100)),
    Email varchar(50) not null unique,
);

-- DML
insert into Students values ('Maga', 'Babayev', 16, 'foo2@gmail.com');
insert into Students (Name, Age, Surname, Email) values ('John', 20, 'Smith', 'foo@gmail.com');

select * from Students;

select Id, Name, Email from Students
where (Name = 'Maga' and Age = 16);

delete from Students
where Name = 'John';

select * from Students;

insert into Students (Name, Age, Surname, Email) values ('Elvin', 21, 'Azimov', 'foo@gmail.com');

use master;
create database MyDb;
