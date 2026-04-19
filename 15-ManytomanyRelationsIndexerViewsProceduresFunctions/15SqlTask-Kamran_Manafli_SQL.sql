CREATE DATABASE CompanyMM;
use CompanyMM;

Create table Employees (
EmployeeID int identity primary key,
FirstName varchar(50) not null,
LastName varchar(50) not null,
BirthDate Date,
Email varchar(100) unique,
Check (BirthDate <= GetDate())
);

Create table Projects(
ProjectId int identity primary key,
ProjectName varchar(100) not null,
StartDate Date,
EndDate Date,
Check (EndDate is null or EndDate >= StartDate)
);

create table EmployeeProjects (
EmployeeID int,
ProjectID int,
AssignedDate Date default getdate(),
constraint pk_EmployeeProjects primary key (EmployeeID, ProjectID),
constraint fk_Employee foreign key (EmployeeID)
references Employees(EmployeeID) on delete cascade,
constraint fk_Project foreign key (ProjectID)
references Projects(ProjectID) on delete cascade
);

INSERT INTO Employees (FirstName, LastName, BirthDate, Email) VALUES
('Ali', 'Mammadov', '1990-05-10', 'ali@mail.com'),
('Leyla', 'Aliyeva', '1992-07-21', 'leyla@mail.com'),
('Kamran', 'Huseynov', '1988-03-15', 'kamran@mail.com'),
('Nigar', 'Quliyeva', '1995-11-02', 'nigar@mail.com'),
('Rashad', 'Ismayilov', '1987-09-30', 'rashad@mail.com');

INSERT INTO Projects (ProjectName, StartDate, EndDate) VALUES
('ERP System', '2024-01-01', NULL),
('Mobile App', '2024-03-01', NULL),
('Website Redesign', '2024-02-15', NULL);

INSERT INTO EmployeeProjects (EmployeeID, ProjectID) VALUES
(1,1),(1,2),
(2,1),
(3,1),(3,2),(3,3),
(4,2),
(5,3);

select * from Employees;

select * from Projects;

select e.EmployeeID, e.FirstName, e.LastName, p.ProjectName
from Employees e
join EmployeeProjects ep on e.EmployeeID = ep.EmployeeID
join Projects p on ep.ProjectID = p.ProjectId;

select p.ProjectName, count(ep.EmployeeID) as EmployeeCount
from Projects p
left join EmployeeProjects ep on p.ProjectId = ep.ProjectID
group by p.ProjectName;

select e.EmployeeID, e.FirstName, count(ep.ProjectID) as ProjectCount
from Employees e
join EmployeeProjects ep on e.EmployeeID = ep.EmployeeID
group by e.EmployeeID, e.FirstName
having count(ep.ProjectID) > 2;

create view EmployeeProjectView as
select
	e.EmployeeID,
	e.FirstName + ' ' + e.LastName as FullName,
	p.ProjectID,
	p.ProjectName,
	ep.AssignedDate
from Employees e
join EmployeeProjects ep on e.EmployeeID = ep.EmployeeID
join Projects p on ep.ProjectID = p.ProjectId;

select * from EmployeeProjectView
where EmployeeID = 1;

create procedure sp_AssignEmployeeToProject
	@empId int,
	@projId int
as
begin
	if not exists (
	select 1
	from EmployeeProjects
	where EmployeeID = @empId and ProjectId = @projId
	)
	begin
		insert into EmployeeProjects (EmployeeID, ProjectID)
		values (@empId, @projId);
	End
End
Go

create function fn_GetProjectCount (@empId int)
returns int
as
begin
	declare @count int;

	select @count = Count(*)
	from EmployeeProjects
	where EmployeeID = @empId;

	return @count;
End
Go

select dbo.fn_GetProjectCount(3) as ProjectCount;

exec sp_AssignEmployeeToProject @empId = 2, @projId = 3;

select * from EmployeeProjects where  EmployeeID = 2;

delete from EmployeeProjects
where EmployeeID = 2;

















