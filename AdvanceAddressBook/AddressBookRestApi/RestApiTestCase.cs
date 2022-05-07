using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using AdvanceAddressBook;

namespace AddressBookRestApi
{
    class Contact
    {
        public int id { get; set; }
        public string name { get; set; }
        public string Address { get; set; }
    }
    [TestClass]
    public class UnitTest1
    {
        RestClient client = new RestClient("http://localhost:3000");
        private RestResponse GetAddressBookList()
        {
            RestRequest request = new RestRequest("/Address", Method.Get);
            //act
            RestResponse response = client.GetAsync(request).Result;
            return response;
        }
        /// <summary>
        /// Test method to check the contact list retrieved from json server
        /// </summary>
        [TestMethod]
        public void OnCallingGetApi_ReturnAddressList()
        {
            RestResponse response = GetAddressBookList();
            //assert
            Assert.AreEqual(response.StatusCode, System.Net.HttpStatusCode.OK);
            List<Contact> dataResponse = JsonConvert.DeserializeObject<List<Contact>>(response.Content);
            Assert.AreEqual(5, dataResponse.Count);
            foreach (var item in dataResponse)
            {
                System.Console.WriteLine("id: " + item.id + " Name: " + item.name + " Address: " + item.Address);
            }
        }
    }
}