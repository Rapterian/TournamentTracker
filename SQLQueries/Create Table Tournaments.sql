USE Tournaments;
GO
CREATE TABLE Tournaments
(
	ID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Name nvarchar(100) NOT NULL,
	EntryFee money
);