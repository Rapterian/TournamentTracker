USE master;
CREATE DATABASE Tournaments
ON PRIMARY
(
NAME='TournamentsDbFile',
FILENAME='D:\Documents\C# Portofolio\Tournament Tracker Des Top App\TournamentTracker\SQLData\TournamentsDbFile.mdf'
)
LOG ON
(
NAME='TournamentsDbLog',
FILENAME='D:\Documents\C# Portofolio\Tournament Tracker Des Top App\TournamentTracker\SQLLog\TournamentsDbLog.ldf'
);

USE Tournaments;
GO
CREATE TABLE Tournaments
(
	ID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Name nvarchar(100) NOT NULL,
	EntryFee money
);

USE Tournaments;
GO
CREATE TABLE Teams
(
	ID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
	TeamName nvarchar(100) NOT NULL
);

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

USE Tournaments;
GO
CREATE TABLE Matchups
(
	ID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
	WinnerID int FOREIGN KEY REFERENCES Teams(ID),
	MatchupRound int
);

USE Tournaments;
GO
CREATE TABLE TeamMembers
(
	ID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
	TeamID int FOREIGN KEY REFERENCES Teams(ID),
	PersonID int FOREIGN KEY REFERENCES People(ID)
);

USE Tournaments;
GO
CREATE TABLE TournamentEntries
(
	ID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
	TournamentID int FOREIGN KEY REFERENCES Tournaments(ID),
	TeamID int FOREIGN KEY REFERENCES Teams(ID)
);

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

USE Tournaments;
GO
CREATE TABLE TournamentPrizes
(
	ID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
	TournamentID int FOREIGN KEY REFERENCES Tournaments(ID),
	PrizeID int FOREIGN KEY REFERENCES Prizes(ID)
);