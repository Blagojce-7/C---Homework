USE [master]
GO
CREATE DATABASE [SEDCACADEMYDB]
GO
USE [SEDCACADEMYDB]
GO


CREATE TABLE [Student] (
	ID INT IDENTITY(1,1),
	FirstName NVARCHAR(20) NOT NULL,
	LastName NVARCHAR(20) NOT NULL,
	DateOfBirth NVARCHAR (25) NOT NULL,
	EnrolledDate NVARCHAR (30) NOT NULL,
	Gender NVARCHAR (15) NOT NULL,
	NationallDNumber NVARCHAR (30) NOT NULL,
	StudentCardNumber INT NOT NULL,
	CONSTRAINT PK_Student PRIMARY KEY CLUSTERED (ID)
)
GO
SELECT * FROM dbo.Student
INSERT INTO dbo.Student (FirstName, LastName, DateOfBirth, EnrolledDate, Gender, NationallDNumber, StudentCardNumber)
VALUES ('Irina', 'Cikarska', '13.12.2002', '01.10.2021', 'Female', 'MP2039', 62928),
       ('Blagojce', 'Ivanov', '21.01.2000', '05.12.2022', 'Male', 'M40D3', 24925),
	   ('Harun', 'Piksi', '01.02.1999', '05.12.2025', 'Male', 'M49f3', 2235)

DROP TABLE dbo.Student -- Za brisenje

CREATE TABLE [Teacher](
    ID INT IDENTITY(1,1),
	FirstName NVARCHAR (30) NOT NULL,
	LastName NVARCHAR (30) NOT NULL,
	DateOfBirth NVARCHAR (20) NOT NULL,
	AcademicRank NVARCHAR (15) NOT NULL,
	HireDate NVARCHAR (20) NOT NULL
)
GO
SELECT * FROM dbo.Teacher
INSERT INTO dbo.Teacher (FirstName, LastName, DateOfBirth, AcademicRank, HireDate)
VALUES ('Roki', 'Rokevski', '15.15.1985', 'Profesor', '25.01.2010')
DROP TABLE dbo.Teacher

CREATE TABLE [Grade](
    ID INT NOT NULL,
	StudentID INT NOT NULL,
	CourseID INT NOT NULL,
	TeacherID INT NOT NULL,
	Grade NVARCHAR (15) NOT NULL,
	Comment NVARCHAR (20) NOT NULL,
	CreatedDate NVARCHAR (30) NOT NULL
)
GO
SELECT * FROM dbo.Grade
DROP TABLE dbo.Grade

CREATE TABLE [Course](
    ID INT NOT NULL,
	Name NVARCHAR (50) NOT NULL,
	Credit INT NOT NULL,
	AcademicYear INT NOT NULL,
	Semester NVARCHAR (80) NOT NULL
)
GO
SELECT * FROM dbo.Course
DROP TABLE dbo.Course

CREATE TABLE [GradeDetails](
    ID INT NOT NULL,
	GradeID INT NOT NULL,
	AchievementTypeID INT NOT NULL,
	AchievementPoints INT NOT NULL,
	AchievementMaxPoints INT NOT NULL,
	AchievementDate NVARCHAR (50) NOT NULL
)
GO
SELECT * FROM dbo.GradeDetails
DROP TABLE dbo.GradeDetails

-- Bez PRIMARY KEY
CREATE TABLE [AchievementType](
    ID INT NOT NULL,
	Name VARCHAR (40) NOT NULL,
	Description VARCHAR (200) NOT NULL,
	ParticipationRate INT NOT NULL
)
GO
SELECT * FROM dbo.AchievementType
INSERT INTO dbo.AchievementType(ID, Name, Description, ParticipationRate)
VALUES (5, 'Rokevski', '15.15.1985', 50),
       (5, 'Trajce', '15.15.1985', 50)
DROP TABLE dbo.AchievementType