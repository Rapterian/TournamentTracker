USE Tournaments;
GO
CREATE TABLE MatchupEntries
(
	ID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
	MatchupID int FOREIGN KEY REFERENCES Matchups(ID),
	ParentMatchupID int FOREIGN KEY REFERENCES Matchups(ID),
	TeamCompetingID int FOREIGN KEY REFERENCES Teams(ID),
	Score int
);