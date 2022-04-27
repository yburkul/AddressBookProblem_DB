USE [AddressBook_Service]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

alter PROCEDURE Add_AddressBookContact
	-- Add the parameters for the stored procedure here
	@First_Name varchar(50),
	@Last_Name varchar(50),
	@Address varchar(200),
    @City varchar(50),
    @State varchar(50),
    @Zip bigint,
    @PhoneNumber bigint,
    @Email varchar(50),
	@AddressBookName varchar(50),
	@Type varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	insert into AddressBook values (@First_Name,@Last_Name,@Address,@City,@State,@Zip,@PhoneNumber,@Email,@AddressBookName,@Type)
END
GO
select * from AddressBook;