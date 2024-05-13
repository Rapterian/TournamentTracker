USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spTeams_GetByTournament]    Script Date: 2024/05/10 17:23:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JJ De Kock
-- Create date: 2023/04/28
-- Description:	Gets all the info on persons in the people table
-- =============================================
CREATE PROCEDURE [dbo].spTeams_GetByTournament  
	@tournamentID INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
    SELECT DISTINCT Teams.*
    FROM dbo.Teams
    INNER JOIN dbo.TournamentEntries ON Teams.ID = TournamentEntries.TeamID
    WHERE TournamentEntries.TournamentID = @tournamentID;
END
