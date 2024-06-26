USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spMatchup_GetByTournament]    Script Date: 2024/05/11 14:39:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JJ De Kock
-- Create date: 2023/04/28
-- Description:	Gets all the info on persons in the people table
-- =============================================
CREATE PROCEDURE [dbo].[spMatchup_GetByTournament]  
	@tournamentID INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
    SELECT Matchups.*
    FROM dbo.Matchups
    WHERE dbo.Matchups.TournamentID = @tournamentID
	ORDER BY MatchupRound;
END

