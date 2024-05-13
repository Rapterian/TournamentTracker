USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spTournament_GetAll]    Script Date: 2024/05/10 16:19:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JJ De Kock
-- Create date: 2024/05/10
-- Description:	Gets all the info on tournaments in the tournaments table
-- =============================================
CREATE PROCEDURE [dbo].spTournament_GetAll 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * 
	FROM	DBO.Tournaments
	WHERE Active=1;
END
