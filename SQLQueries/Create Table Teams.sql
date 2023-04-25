USE Tournaments;
GO
CREATE TABLE Teams
(
	ID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
	TeamName nvarchar(100) NOT NULL
);