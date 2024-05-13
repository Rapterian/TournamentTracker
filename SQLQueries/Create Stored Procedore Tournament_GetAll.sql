USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spTournament_GetAll]    Script Date: 2024/05/10 17:18:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JJ De Kock
-- Create date: 2024/05/10
-- Description:	Gets all the info on teams in the Teams table
-- =============================================
CREATE PROCEDURE [dbo].spTournament_GetAll 
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM dbo.Tournaments;
END