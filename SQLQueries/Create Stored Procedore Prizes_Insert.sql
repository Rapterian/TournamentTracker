SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JJ De Kock
-- Create date: 2023/04/26
-- Description:	Inserts a new Prize in the prizes table
-- =============================================
CREATE PROCEDURE spPrizes_Insert 
	-- Add the parameters for the stored procedure here
	@PlaceNumber int,
	@PlaceName nvarchar(100),
	@PrizeAmount money,
	@PrizePercentage float,
	@ID int = 0 out
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO dbo.Prizes
	VALUES(@PlaceNumber,@PlaceName,@PrizeAmount,@PrizePercentage);

	SELECT @ID = SCOPE_IDENTITY();
END
GO
