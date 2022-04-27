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
        /// UC -Get all the Address Book Data 
        /// </summary>
        [Test]
        public void Get_AllAddressBookData()
        {
            var expected = 10;
            var result = Details.GetAddressBookDetails();
            Assert.AreEqual(expected, result.Count);
        }
        /// <summary>
        /// UC - Update the Address Book Contact In DataBase
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
        [Test]
        public void Get_Data_ByUsingCityAndState()
        {
            bool expected = true;
            addressBook.City = "surat";
            addressBook.State = "gujrat";
            bool result = details.GetDataFromCityAndState(addressBook);
            Assert.AreEqual(expected, result);
        }
    }
}