CREATE DATABASE OwnersAssociation;
GO

USE OwnersAssociation
GO

CREATE TABLE Staircases (
	Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Code VARCHAR(50) NOT NULL,
	Description VARCHAR(50) NOT NULL,
	InsDt DATETIME NOT NULL,
	InsUsrId INT NOT NULL
);
GO

CREATE TABLE Tenants (
	Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	LastName VARCHAR(50) NOT NULL,
	FirstName VARCHAR(50) NOT NULL,
	StairCaseId INT NOT NULL,
	InsDt DATETIME NOT NULL,
	InsUsrId INT NOT NULL,
	CONSTRAINT FK_Tenants_Staircases FOREIGN KEY (StairCaseId) REFERENCES Staircases(Id)
);
GO

INSERT INTO Staircases (Code, Description, InsDt, InsUsrId)
VALUES
('A1', 'Staircase A1', GETDATE(), 1),
('B1', 'Staircase B1', GETDATE(), 1);

INSERT INTO Tenants (LastName, FirstName, StairCaseId, InsDt, InsUsrId)
VALUES
('Popescu', 'Ion', 1, GETDATE(), 1),
('Ionescu', 'Maria', 2, GETDATE(), 1);

SELECT 
	t.Id AS TenantId, 
	t.FirstName, 
	t.LastName, 
	s.Code AS StairCaseCode, 
	s.Description AS StairCaseDescription
FROM Tenants t
JOIN Staircases s on t.StairCaseId = s.Id;
