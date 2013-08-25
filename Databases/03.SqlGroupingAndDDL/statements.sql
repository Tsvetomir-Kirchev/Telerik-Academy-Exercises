-- This exercises are for TelerikAcademy Database which can be downloaded from here:
-- http://telerikacademy.com/Courses/Courses/Details/98
-----------------------------------------------------------------------------------------------------
--Write a SQL query to find the names and salaries of the employees that take the minimal 
--salary in the company. Use a nested SELECT statement.
SELECT 
	FirstName, 
	LastName, 
	Salary
FROM Employees
WHERE Salary = 
	(SELECT MIN(Salary) FROM Employees)
-----------------------------------------------------------------------------------------------------
--Write a SQL query to find the names and salaries of the employees that have a salary that 
--is up to 10% higher than the minimal salary for the company.
SELECT 
	FirstName,
	LastName,
	Salary
FROM Employees
WHERE Salary > 
	(SELECT MIN(Salary) + (MIN(Salary) * 0.1) FROM Employees)
-----------------------------------------------------------------------------------------------------
--Write a SQL query to find the full name, salary and department of the employees that take the
--minimal salary in their department. Use a nested SELECT statement.
SELECT 
	FirstName, 
	LastName, 
	Salary, 
	d.Name
FROM Employees e
	INNER JOIN Departments d
		ON e.DepartmentId = d.DepartmentId
WHERE Salary = (
    SELECT MIN(Salary)
    FROM Employees
    WHERE DepartmentId = d.DepartmentId
);
-----------------------------------------------------------------------------------------------------
--Write a SQL query to find the average salary in the department #1.
SELECT AVG(Salary) AS [Average Salary]
FROM Employees
WHERE DepartmentID = 1
-----------------------------------------------------------------------------------------------------
--Write a SQL query to find the average salary  in the "Sales" department.
SELECT AVG(Salary) AS [Average Salary]
FROM Employees e
	INNER JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'
-----------------------------------------------------------------------------------------------------
--Write a SQL query to find the number of employees in the "Sales" department.
SELECT COUNT(*) AS [Number of Employees]
FROM Employees e
	INNER JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'
-----------------------------------------------------------------------------------------------------
--Write a SQL query to find the number of all employees that have manager.
SELECT COUNT(*) AS [Number of employees with manager]
FROM Employees
WHERE ManagerID IS NOT NULL
-----------------------------------------------------------------------------------------------------
--Write a SQL query to find the number of all employees that have no manager.
SELECT COUNT(*) AS [Number of employees with manager]
FROM Employees
WHERE ManagerID IS NULL
-----------------------------------------------------------------------------------------------------
--Write a SQL query to find all departments and the average salary for each of them.
SELECT 
	AVG(e.Salary) AS [Average salary],
	d.Name
FROM Employees e
	INNER JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name
-----------------------------------------------------------------------------------------------------
--Write a SQL query to find the count of all employees in each department and for each town.
SELECT 
	COUNT(*) AS [Employees count],
	d.Name,
	t.Name
FROM Employees e
	INNER JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
	INNER JOIN Addresses a
		ON e.AddressID = a.AddressID
	INNER JOIN Towns t
		ON a.TownID = t.TownID
GROUP BY d.Name, t.Name
-----------------------------------------------------------------------------------------------------
--Write a SQL query to find all managers that have exactly 5 employees. 
--Display their first name and last name.
SELECT 
	m.FirstName,
	m.LastName
FROM Employees e
	INNER JOIN Employees m
		ON e.ManagerID = m.EmployeeID
GROUP BY m.EmployeeID, m.FirstName, m.LastName
HAVING COUNT(*) = 5
-----------------------------------------------------------------------------------------------------
--Write a SQL query to find all employees along with their managers. 
--For employees that do not have manager display the value "(no manager)".
SELECT
	e.FirstName,
	e.LastName,
	COALESCE(m.FirstName + ' ' + m.LastName, 'No manager') AS [Manager]
FROM Employees e
	LEFT OUTER JOIN Employees m
		ON e.ManagerID = m.EmployeeID
-----------------------------------------------------------------------------------------------------
--Write a SQL query to find the names of all employees whose last name is exactly 5 characters long. 
--Use the built-in LEN(str) function.
SELECT
	FirstName,
	LastName
FROM Employees
WHERE LEN(LastName) = 5
-----------------------------------------------------------------------------------------------------
--Write a SQL query to display the current date and time in the following format 
--"day.month.year hour:minutes:seconds:milliseconds". 
--Search in  Google to find how to format dates in SQL Server.
SELECT CONVERT(VARCHAR(10), GETDATE(), 104) + ' ' + CONVERT(VARCHAR(13), GETDATE(), 114)
-----------------------------------------------------------------------------------------------------
--Write a SQL statement to create a table Users. Users should have username, password, 
--full name and last login time. Choose appropriate data types for the table fields. 
--Define a primary key column with a primary key constraint. 
--Define the primary key column as identity to facilitate inserting records.
--Define unique constraint to avoid repeating usernames. 
--Define a check constraint to ensure the password is at least 5 characters long.
CREATE TABLE Users
(
	[UserId] INT NOT NULL PRIMARY KEY IDENTITY,
	[UserName] VARCHAR(20) NOT NULL UNIQUE,
	[Password] VARCHAR(20) NOT NULL CHECK(LEN(Password) >= 5),
	[FullName] VARCHAR(40) NOT NULL,
	[LastLoginTime] DATETIME DEFAULT GETDATE() NOT NULL
)
GO
-----------------------------------------------------------------------------------------------------
--Write a SQL statement to create a view that displays the users from the Users table 
--that have been in the system today. Test if the view works correctly.
CREATE VIEW UsersForToday 
AS
	SELECT * FROM Users WHERE 
	DATEDIFF(DAY, DATEADD(DAY, 0, CURRENT_TIMESTAMP), LastLoginTime) = 0
-----------------------------------------------------------------------------------------------------
--Write a SQL statement to create a table Groups. Groups should have unique name
-- (use unique constraint). Define primary key and identity column.
CREATE TABLE Groups
(
	GroupId INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(100),
	CONSTRAINT UC_Name UNIQUE(Name)
);
-----------------------------------------------------------------------------------------------------
--Write a SQL statement to add a column GroupID to the table Users. 
--Fill some data in this new column and as well in the Groups table. 
--Write a SQL statement to add a foreign key constraint between tables Users and Groups tables.
ALTER TABLE [dbo].[Users]
	ADD GroupId INT
GO

INSERT INTO [dbo].[Users]
	VALUES('Tsvetomir', '12345', 'Tsvetomir Kirchev', GETDATE(), 1)
GO
INSERT INTO [dbo].[Users]
	VALUES('John', 'qwerty', 'Johny Walker', GETDATE(), 1)
GO
INSERT INTO [dbo].[Users]
	VALUES('Kubrat', '12345', 'Han Kubrat', GETDATE(), 1)
GO

ALTER TABLE [dbo].[Users] NOCHECK CONSTRAINT ALL
ALTER TABLE [dbo].Groups NOCHECK CONSTRAINT ALL
GO

ALTER TABLE [dbo].[Users]
	ADD CONSTRAINT FK_Users_Groups FOREIGN KEY(GroupId)
	REFERENCES Groups(GroupId)
GO

ALTER TABLE [dbo].[Users] WITH CHECK CHECK CONSTRAINT ALL
ALTER TABLE [dbo].Groups WITH CHECK CHECK CONSTRAINT ALL
GO
-----------------------------------------------------------------------------------------------------
--Write SQL statements to insert several records in the Users and Groups tables.
INSERT INTO [dbo].[Groups]
	VALUES('sample group')
GO
INSERT INTO [dbo].[Groups]
	VALUES('other group')
GO
INSERT INTO [dbo].[Groups]
	VALUES('the cool group')
GO

INSERT INTO [dbo].[Users]
	VALUES('Kai', 'kai123', 'Kai Green', GETDATE(), 3)
GO
INSERT INTO [dbo].[Users]
	VALUES('Jack', 'onclejack', 'Jack Daniels', GETDATE(), 1)
GO
-----------------------------------------------------------------------------------------------------
--Write SQL statements to update some of the records in the Users and Groups tables.
UPDATE Groups
SET Name = 'hacker group'
WHERE Name = 'sample group'

UPDATE Users
SET UserName = 'Hacker', GroupId = (SELECT GroupId FROM Groups WHERE Name = 'hacker group')
WHERE UserName = 'Tsvetomir'
-----------------------------------------------------------------------------------------------------
--Write SQL statements to delete some of the records from the Users and Groups tables.
DELETE FROM Groups
WHERE Name = 'other group'

DELETE FROM Users
WHERE UserName = 'John'
-----------------------------------------------------------------------------------------------------
--Write SQL statements to insert in the Users table the names of all employees 
--from the Employees table. Combine the first and last names as a full name. 
--For username use the first letter of the first name + the last name (in lowercase). 
--Use the same for the password, and NULL for last login time.

-----------------------------------------------------------------------------------------------------
23
-----------------------------------------------------------------------------------------------------
