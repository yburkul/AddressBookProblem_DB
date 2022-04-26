USE[AddressBook_Service]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

alter PROCEDURE EditContact
	-- Add the parameters for the stored procedure here
	@First_Name varchar(50),
	@Last_Name varchar(50),
	@Address varchar(200),
    @City varchar(50),
    @State varchar(50),
    @Zip bigint,
    @PhoneNumber bigint,
    @Email varchar(50),
	@Type varchar(50),
	@AddressBookName varchar(50)
AS

BEGIN
SET NOCOUNT ON;
update AddressBook set First_Name = @First_Name, Last_Name = @Last_Name, Address = @Address, City = @City, State = @State,
Zip = @Zip, PhoneNumber = @PhoneNumber, Email = @Email, Type = @Type, AddressBookName = @AddressBookName where First_Name = @First_Name;

    -- Insert statements for procedure here
	select * from AddressBook;

END
GO