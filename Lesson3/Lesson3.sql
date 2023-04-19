use MyDb;

create table Car(
    Id int identity(1, 1) primary key,
    Make nvarchar(50) not null,
    Model nvarchar(50) not null,
    Year int not null,
);



