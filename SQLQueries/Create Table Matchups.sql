USE Tournaments;
GO
CREATE TABLE Matchups
(
	ID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
	WinnerID int FOREIGN KEY REFERENCES Teams(ID),
	MatchupRound int
);