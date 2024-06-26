USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spTournaments_Insert]    Script Date: 2024/05/11 15:33:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JJ De Kock
-- Create date: 2024/05/07
-- Description:	Creates and inserts a new tournament
-- =============================================
CREATE PROCEDURE [dbo].[spTournaments_Insert]
	@TournamentName nvarchar(200),
	@EntryFee money,
	@ID int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

    INSERT INTO dbo.Tournaments(TournamentName,EntryFee,Active)
	VALUES ( @TournamentName,@EntryFee,1);

	SELECT @ID = SCOPE_IDENTITY();

END
