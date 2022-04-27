using AdvanceAddressBook;
using NUnit.Framework;

namespace AddressBookTesting
{
    public class Test
    {
        Details details;
        AddressBook addressBook;
        [SetUp]
        public void Setup()
        {
            details = new Details();
            addressBook = new AddressBook();
        }
        /// <summary>
        /// TC -Get all the Address Book Data 
        /// </summary>
        [Test]
        public void Get_AllAddressBookData()
        {
            var expected = 10;
            var result = Details.GetAddressBookDetails();
            Assert.AreEqual(expected, result.Count);
        }
        /// <summary>
        /// TC- Update the Address Book Contact In DataBase
        /// </summary>
        [Test]
        public void Update_AddressBook_ContactInDB()
        {
            bool expected = true;
            addressBook.First_Name = "Satish";
            addressBook.Last_Name = "Shelke";
            addressBook.Address = "Street 07";
            addressBook.City = "Pune";
            addressBook.State = "MH";
            addressBook.Zip = 340045;
            addressBook.PhoneNumber = 8805320078;
            addressBook.Email = "satishshelke123@gmail.com";
            addressBook.AddressBookName = "FriendCircle";
            addressBook.Type = "Friend";
            bool result = details.UpdateContact(addressBook);
            Assert.AreEqual(expected, result);
        }
        /// <summary>
        /// TC - Get The Data by using City And State
        /// </summary>
        [Test]
        public void Get_Data_ByUsingCityAndState()
        {
            bool expected = true;
            addressBook.City = "surat";
            addressBook.State = "gujrat";
            bool result = details.GetDataFromCityAndState(addressBook);
            Assert.AreEqual(expected, result);
        }
        /// <summary>
        /// TC - Add The Contact in Address Book
        /// </summary>
        [Test]
        public void Add_AddressBook_ContactInDB()
        {
            bool expected = true;
            addressBook.First_Name = "Raju";
            addressBook.Last_Name = "Wayal";
            addressBook.Address = "Street 45";
            addressBook.City = "Haydrabad";
            addressBook.State = "Telangana";
            addressBook.Zip = 940045;
            addressBook.PhoneNumber = 9805310008;
            addressBook.Email = "raju13@gmail.com";
            addressBook.AddressBookName = "CollageBook";
            addressBook.Type = "Friend";
            bool result = details.AddContact(addressBook);
            Assert.AreEqual(expected, result);
        }
    }
}