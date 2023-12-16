USE Tournaments
SET ANSI_NULLS ON
GO
/****** Object:  StoredProcedure [dbo].[spTeams_GetAll]    Script Date: 2023/12/16 18:53:34 ******/
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<JJ De ock>
-- Create date: <2023/12/16>
-- Description:	<Get all info of Teams>
-- =============================================
CREATE PROCEDURE dbo.spTeams_GetAll
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM dbo.Teams;
END
GO
