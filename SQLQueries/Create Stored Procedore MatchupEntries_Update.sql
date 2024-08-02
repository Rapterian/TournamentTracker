USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spMatchupEntries_Update]    Script Date: 2024/07/29 14:43:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JJ De Kock
-- Create date: 2024/07/29
-- Description:	Updates matchup entries
-- =============================================
CREATE PROCEDURE [dbo].spMatchupEntries_Update 
	@ID int,
	@TeamCompeteingID int = null,
	@Score float = null
AS
BEGIN
	SET NOCOUNT ON;

    UPDATE dbo.MatchupEntries
	SET TeamCompetingID=@TeamCompeteingID, Score = @Score
	WHERE ID = @ID;

END
