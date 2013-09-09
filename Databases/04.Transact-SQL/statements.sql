-- This exercises are for TelerikAcademy Database which can be downloaded from here:
-- http://telerikacademy.com/Courses/Courses/Details/98
-----------------------------------------------------------------------------------------------------
--Create a database with two tables: Persons(Id(PK), FirstName, LastName, SSN) 
--and Accounts(Id(PK), PersonId(FK), Balance). Insert few records for testing. 
--Write a stored procedure that selects the full names of all persons.
USE master
GO
CREATE DATABASE [People]
GO
USE [People]
GO
CREATE TABLE Persons
(
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	SSN NVARCHAR(20) NOT NULL
);
CREATE TABLE Accounts
(
	Id INT PRIMARY KEY IDENTITY,
	PersonId INT,
	Balance MONEY NOT NULL,
	CONSTRAINT FK_Accounts_Persons FOREIGN KEY(PersonId)
	REFERENCES Persons(Id)
);
-- Insertign test data into Persons
INSERT INTO Persons(FirstName, LastName, SSN)
VALUES('Tsvetomir', 'Kirchev', '99999999')
INSERT INTO Persons(FirstName, LastName, SSN)
VALUES('John', 'Atanasov', '55555555')
INSERT INTO Persons(FirstName, LastName, SSN)
VALUES('Jack', 'Daniels', '111111111')
INSERT INTO Persons(FirstName, LastName, SSN)
VALUES('Jeam', 'Beam', '222222222')
GO
-- Insert test data into Accounts
INSERT INTO Accounts(PersonId, Balance)
VALUES('1', '1000000')
INSERT INTO Accounts(PersonId, Balance)
VALUES('2', '20000')
INSERT INTO Accounts(PersonId, Balance)
VALUES('3', '1000')
INSERT INTO Accounts(PersonId, Balance)
VALUES('4', '500000')
GO
-- Creating stored procedure, that selects the full names of all persons
CREATE PROCEDURE dbo.usp_GetFullNamesOfAllPersons
AS
	SELECT FirstName + ' ' + LastName AS [Full Name]
	FROM Persons
GO
-- Executign the stored procedure usp_GetFullNamesOfAllPersons
EXEC dbo.usp_GetFullNamesOfAllPersons
-----------------------------------------------------------------------------------------------------