SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JJ De Kock
-- Create date: 2023/04/38
-- Description:	Inserts a new peron in the people table
-- =============================================
CREATE PROCEDURE dbo.spPeople_Insert 
	-- Add the parameters for the stored procedure here
	@FirstName nvarchar(100),
	@LastName nvarchar(100),
	@EmailAddress nvarchar(200),
	@CellphoneNumber nvarchar(10),
	@ID int = 0 out
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO dbo.People
	VALUES(@FirstName,@LastName,@EmailAddress,@CellphoneNumber)

	SELECT @ID = SCOPE_IDENTITY();
END
GO
