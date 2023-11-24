USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spTeams_Insert]    Script Date: 2023/11/24 14:18:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JJ De Kock
-- Create date: 2023/11/24
-- Description:	Inserts a new team in the Teams table
-- =============================================
CREATE PROCEDURE [dbo].[spTeams_Insert]
	@teamName nvarchar(100),
	@ID int = 0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO dbo.Teams
	VALUES(@teamName);

	SELECT @ID = SCOPE_IDENTITY();
END
GO
