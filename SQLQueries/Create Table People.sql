USE Tournaments;
GO
CREATE TABLE People
(
	ID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
	FirstName nvarchar(100) NOT NULL,
	LastName nvarchar(100) NOT NULL,
	EmailAddress nvarchar(200) NOT NULL,
	CellphoneNumber varchar(10) NOT NULL
);