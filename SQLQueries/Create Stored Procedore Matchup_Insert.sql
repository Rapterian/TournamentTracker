USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spMatchups_Insert]    Script Date: 2024/05/08 19:01:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JJ De Kock
-- Create date: 2024/05/08
-- Description:	Creates and inserts a new prize
-- =============================================
CREATE PROCEDURE [dbo].spMatchups_Insert 
	@TournamentID int,
	@MatchupRound int,
	@ID int =0 output
AS
BEGIN
	SET NOCOUNT ON;

    INSERT INTO dbo.Matchups(ID,MatchupRound)
	VALUES(@TournamentID,@MatchupRound)

	SELECT @ID = SCOPE_IDENTITY();

END
