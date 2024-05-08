USE Tournaments

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JJ De Kock
-- Create date: 2023/04/28
-- Description:	Gets all the info on persons in the people table
-- =============================================
CREATE PROCEDURE dbo.spPeople_GetAll 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM	DBO.People;
END
GO
