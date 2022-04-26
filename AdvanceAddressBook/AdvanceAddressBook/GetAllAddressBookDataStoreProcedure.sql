USE [AddressBook_Service]

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [spGetAllAddressBookData] 
AS
BEGIN
	SET NOCOUNT ON;
    -- Insert statements for procedure here
	 Select * from AddressBook;
END
GO
