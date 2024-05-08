USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spTeams_GetAll]    Script Date: 2023/12/02 19:04:28 ******/
SET ANSI_NULLS ON
GO
/****** Object:  StoredProcedure [dbo].[spTeams_GetAll]    Script Date: 2023/12/16 18:53:34 ******/
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JJ De Kock
-- Create date: 2023/04/28
-- Description:	Gets all the info on teams in the Teams table
-- =============================================
CREATE PROCEDURE [dbo].[spTeams_GetAll] 
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM dbo.Teams;
END
GO
