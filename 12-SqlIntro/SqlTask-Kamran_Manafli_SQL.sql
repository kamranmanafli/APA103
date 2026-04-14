CREATE DATABASE Company

use Company


create table Employees(
EmployeeID int,
FirstName nvarchar(max),
LastName nvarchar(max),
Email nvarchar(max),
PhoneNumber int,
HireDate Date,
JobTitle nvarchar(max),
Salary money,
Department nvarchar(max)
)

INSERT INTO Employees VALUES
(1, 'Ali', 'Mammadov', 'ali@company.az', '0501234567', '2019-05-10', 'Developer', 2500, 'IT'),
(2, 'Leyla', 'Hasanova', 'leyla@company.az', '0512345678', '2021-03-15', 'HR', 1800, 'HR'),
(3, 'Rashad', 'Aliyev', 'rashad@company.az', '0553456789', '2022-07-20', 'Accountant', 2200, 'Finance'),
(4, 'Nigar', 'Quliyeva', 'nigar@company.az', '0704567890', '2020-01-25', 'Designer', 2000, 'Design'),
(5, 'Kamal', 'Huseynov', 'kamal@company.az', '0775678901', '2018-11-30', 'Manager', 3000, 'IT');


-- SELECT Query-lər

select * from Employees

select * from Employees where Salary > 2000;

select * from Employees where Department = 'IT';

select * from Employees order by Salary desc;

select Firstname, Salary from Employees;

select * from Employees where HireDate > '2020-01-01';

select * from Employees where Email like '%company.az%';

-- Aggregate Functions

select max(Salary) as MaxSalary from Employees;

select min(Salary) as MinSalary from Employees;

select avg(Salary) as AvarageSalary from Employees;

select count(*) as AllEmployees from Employees;

select sum(Salary) from Employees;	

-- GROUP BY Query

select Department, count(*) from Employees
group by department;

select Department, avg(Salary) from Employees
group by department;

select Department, max(Salary) from Employees
group by department;

-- UPDATE Query

update Employees 
set Salary = 2800 where EmployeeID = 1;

update Employees
set Salary = Salary * 1.10 where Department = 'IT';

update Employees 
set JobTitle = 'HR Manager' where FirstName = 'Leyla' and LastName = 'Hasanova'; 


-- DELETE Query

INSERT INTO Employees VALUES
(6, 'Test', 'User', 'test@company.az', '0999999999', '2023-01-01', 'Intern', 1400, 'IT');

delete from Employees where EmployeeID = '5';

delete from Employees where salary < 1500;

-- Elave

select * from Employees where FirstName like '%a%'; 

select * from Employees where Salary between 2000 and 2500;

select * from Employees where Department in ('Finance', 'IT'); 
