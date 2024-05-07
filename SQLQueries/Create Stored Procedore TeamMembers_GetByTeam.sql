USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spTeamMembers_GetByTeam]    Script Date: 2023/12/02 19:04:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JJ De Kock
-- Create date: 2023/04/28
-- Description:	Gets all the info on persons in the people table
-- =============================================
CREATE PROCEDURE [dbo].[spTeamMembers_GetByTeam]  
	@teamID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM dbo.People
	JOIN dbo.TeamMembers ON dbo.People.ID = dbo.TeamMembers.PersonID
	WHERE dbo.TeamMembers.TeamID = @teamID;
END
GO
