USE Tournaments;
GO
CREATE TABLE TournamentEntries
(
	ID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
	TournamentID int FOREIGN KEY REFERENCES Tournaments(ID),
	TeamID int FOREIGN KEY REFERENCES Teams(ID)
);