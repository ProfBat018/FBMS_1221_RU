create database PetStore collate SQL_Latin1_General_CP1_CI_AS
go

use PetStore
go

grant connect on database :: PetStore to dbo
go

grant view any column encryption key definition, view any column master key definition on database :: PetStore to [public]
go

create table dbo.AnimalTypes
(
    Id   int identity
        constraint PK_AnimalTypes
            primary key,
    Name nvarchar(max) not null
)
go

create table dbo.PetCategories
(
    Id           int identity
        constraint PK_PetCategories
            primary key,
    Name         nvarchar(max) not null,
    AnimalTypeID int           not null
        constraint FK_PetCategories_AnimalTypes_AnimalTypeID
            references dbo.AnimalTypes
            on delete cascade
)
go

create index IX_PetCategories_AnimalTypeID
    on dbo.PetCategories (AnimalTypeID)
go

create table dbo.ProductCategoryTypes
(
    Id   int identity
        constraint PK_ProductCategoryTypes
            primary key,
    Name nvarchar(max) not null
)
go

create table dbo.ProductCategories
(
    Id                    int identity
        constraint PK_ProductCategories
            primary key,
    Name                  nvarchar(max) not null,
    ProductCategoryTypeId int           not null
        constraint FK_ProductCategories_ProductCategoryTypes_ProductCategoryTypeId
            references dbo.ProductCategoryTypes
            on delete cascade,
    PetCategoryId         int default 0 not null
        constraint FK_ProductCategories_PetCategories_PetCategoryId
            references dbo.PetCategories
)
go

create index IX_ProductCategories_ProductCategoryTypeId
    on dbo.ProductCategories (ProductCategoryTypeId)
go

create index IX_ProductCategories_PetCategoryId
    on dbo.ProductCategories (PetCategoryId)
go

create table dbo.Products
(
    Id                int identity
        constraint PK_Products
            primary key,
    Name              nvarchar(max) not null,
    Description       nvarchar(max) not null,
    ImagePath         nvarchar(max) not null,
    Price             real          not null,
    ProductCategoryId int           not null
        constraint FK_Products_ProductCategories_ProductCategoryId
            references dbo.ProductCategories
            on delete cascade
)
go

create table dbo.Pets
(
    Id            int identity
        constraint PK_Pets
            primary key,
    Name          nvarchar(max) not null,
    Age           int           not null,
    Color         nvarchar(max) not null,
    PetCategoryId int           not null
        constraint FK_Pets_PetCategories_PetCategoryId
            references dbo.PetCategories
            on delete cascade,
    ProductId     int           not null
        constraint FK_Pets_Products_ProductId
            references dbo.Products
            on delete cascade
)
go

create index IX_Pets_PetCategoryId
    on dbo.Pets (PetCategoryId)
go

create index IX_Pets_ProductId
    on dbo.Pets (ProductId)
go

create index IX_Products_ProductCategoryId
    on dbo.Products (ProductCategoryId)
go

create table dbo.Specifications
(
    Id   int identity
        constraint PK_Specifications
            primary key,
    Name nvarchar(max) not null
)
go

create table dbo.ProductSpecifications
(
    Id                int identity
        constraint PK_ProductSpecifications
            primary key,
    ProductCategoryId int           not null
        constraint FK_ProductSpecifications_ProductCategories_ProductCategoryId
            references dbo.ProductCategories
            on delete cascade,
    SpecificationId   int           not null
        constraint FK_ProductSpecifications_Specifications_SpecificationId
            references dbo.Specifications
            on delete cascade,
    Value             nvarchar(max) not null
)
go

create index IX_ProductSpecifications_ProductCategoryId
    on dbo.ProductSpecifications (ProductCategoryId)
go

create index IX_ProductSpecifications_SpecificationId
    on dbo.ProductSpecifications (SpecificationId)
go
