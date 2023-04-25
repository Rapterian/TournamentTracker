USE Tournaments;
GO
CREATE TABLE TournamentPrizes
(
	ID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
	TournamentID int FOREIGN KEY REFERENCES Tournaments(ID),
	PrizeID int FOREIGN KEY REFERENCES Prizes(ID)
);