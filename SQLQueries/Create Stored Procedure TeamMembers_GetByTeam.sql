USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spTeamMembers_GetByTeam]    Script Date: 2023/12/16 18:53:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE dbo.spTeamMembers_GetByTeam 
	@teamID int 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
    SELECT
        tm.ID,
        tm.TeamID,
        tm.PersonID,
        p.FirstName,
        p.LastName,
        p.EmailAddress,
        p.CellphoneNumber
    FROM
        TeamMembers tm
    INNER JOIN
        People p ON tm.PersonID = p.ID
    WHERE
        tm.TeamID = @teamID;
END
GO
