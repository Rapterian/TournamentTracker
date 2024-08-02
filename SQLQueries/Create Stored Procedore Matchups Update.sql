USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spMatchups_Update]    Script Date: 2024/07/29 14:43:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JJ De Kock
-- Create date: 2024/07/29
-- Description:	Updates matchups with winner
-- =============================================
CREATE PROCEDURE [dbo].spMatchups_Update 
	@ID int,
	@WinnerID int
AS
BEGIN
	SET NOCOUNT ON;

    UPDATE dbo.Matchups
	SET WinnerID = @WinnerID
	WHERE ID = @ID;

END
