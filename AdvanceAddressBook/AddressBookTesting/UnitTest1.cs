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
    }
}