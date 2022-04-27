USE[AddressBook_Service]

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

alter PROCEDURE [spRetreiveTheData]
@City varchar(50),
@State varchar(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from AddressBook where City = @City And State = @State;
	select * from AddressBook
END
GO
