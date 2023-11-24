USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spTeamMembers_Insert]    Script Date: 2023/11/24 14:20:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JJ De Kock
-- Create date: 2023/04/38
-- Description:	Inserts a new team member in the TeamMembers table
-- =============================================
CREATE PROCEDURE [dbo].[spTeamMembers_Insert] 
	-- Add the parameters for the stored procedure here
	@teamID int,
	@personID int,
	@ID int = 0 out
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO dbo.TeamMembers
	VALUES(@teamID,@personID)

	SELECT @ID = SCOPE_IDENTITY();
END
