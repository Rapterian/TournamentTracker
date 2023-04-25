USE Tournaments;
GO
CREATE TABLE Prizes
(
	ID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
	PlaceNumber int NOT NULL,
	PlaceName nvarchar(100) NOT NULL,
	PrizeAmount money,
	PrizePercentage float,
);

