USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spTournaments_Complete]    Script Date: 2024/08/07 10:13:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JJ De Kock
-- Create date: 2024/07/29
-- Description:	Updates matchups with winner
-- =============================================
CREATE PROCEDURE [dbo].spTournaments_Complete 
	@ID int
AS
BEGIN
	SET NOCOUNT ON;

    UPDATE dbo.Tournaments
	SET Active = 0
	WHERE ID = @ID;

END
