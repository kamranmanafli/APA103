CREATE DATABASE Company1

use Company1

create table Countries(
Id int primary key identity,
[Name] nvarchar(max)
)

create table Cities(
Id int primary key identity,
[Name] nvarchar(max),
CountryId int,
Foreign key (CountryId) references Countries(Id)
)

create table Employees3(
Id int Primary key identity,
[Name] nvarchar(max),
Surname nvarchar(max),
Age int,
Salary decimal(10,2),
Position nvarchar(max),
IsDeleted Bit,
CityId int,
foreign key (CityId) references Cities(Id)
)

select
    e.Name,
    e.Surname,
    c.Name AS City,
    co.Name AS Country
from Employees3 e
join Cities c on e.CityId = c.Id
join Countries co on c.CountryId = co.Id

select 
    e.Name,
    co.Name AS Country
from Employees3 e
join Cities c on e.CityId = c.Id
join Countries co on c.CountryId = co.Id
where e.Salary > 2000

select c.Name as City, co.Name as Country
from Cities c
join Countries co on c.CountryId = co.Id

select 
Name,
Surname,
Age,
Salary,
Position,
IsDeleted,
CityId
from Employees3 where Position = 'Reseption'

select e.Name, e.Surname, c.Name as City, co.Name as Country
from Employees3 e
join Cities c on e.CityId = c.Id
join Countries co on c.CountryId = co.Id
where e.IsDeleted = 1