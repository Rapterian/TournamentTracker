USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spMatchupEntries_Insert]    Script Date: 2024/05/08 19:01:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JJ De Kock
-- Create date: 2024/05/08
-- Description:	Creates and inserts a new prize
-- =============================================
CREATE PROCEDURE [dbo].spMatchupEntries_Insert 
	@MatchupID int,
	@ParentMatchupID int,
	@TeamCompetingID int,
	@ID int =0 output
AS
BEGIN
	SET NOCOUNT ON;

    INSERT INTO dbo.MatchupEntries(MatchupID,ParentMatchupID,TeamCompetingID)
	VALUES(@MatchupID,@ParentMatchupID,@TeamCompetingID)

	SELECT @ID = SCOPE_IDENTITY();

END
