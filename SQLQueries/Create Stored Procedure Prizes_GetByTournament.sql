USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spTeamMembers_GetByTeam]    Script Date: 2024/05/10 17:23:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JJ De Kock
-- Create date: 2023/04/28
-- Description:	Gets all the info on persons in the people table
-- =============================================
CREATE PROCEDURE [dbo].spPrizes_GetByTournament  
	@tournamentID INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
    SELECT *
    FROM dbo.Prizes
    INNER JOIN dbo.TournamentPrizes ON dbo.Prizes.ID = dbo.TournamentPrizes.PrizeID
    WHERE dbo.TournamentPrizes.TournamentID = @tournamentID;
END
