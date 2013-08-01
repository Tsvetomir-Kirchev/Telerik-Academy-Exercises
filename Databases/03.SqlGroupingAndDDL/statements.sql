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
3
-----------------------------------------------------------------------------------------------------