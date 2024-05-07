USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spTournamentEntries_Insert]    Script Date: 2024/05/07 21:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JJ De Kock
-- Create date: 2024/05/07
-- Description:	Creates and inserts a new prize
-- =============================================
CREATE PROCEDURE dbo.spTournamentEntries_Insert 
	@TournamentID int,
	@TeamID int,
	@ID int =0 output
AS
BEGIN
	SET NOCOUNT ON;

    INSERT INTO dbo.TournamentEntries(TournamentID,TeamID)
	VALUES(@TournamentID,@TeamID)

	SELECT @ID = SCOPE_IDENTITY();

END
GO
