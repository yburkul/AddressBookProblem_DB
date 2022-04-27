using System;

namespace AdvanceAddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome in Address Book System Ado.Net");
            Details details = new Details();
            int option = 0;
            do
            {
                Console.WriteLine("1: For Establish Connection");
                Console.WriteLine("2: For Close Connection");
                Console.WriteLine("3: For Get All Address Book Contact Details");
                Console.WriteLine("4: For Update The Contact");
                Console.WriteLine("5: For Get Data By Using City And State");
                Console.WriteLine("0: For Exit");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        details.EstablishConnection();
                        Console.WriteLine("Connection is Open");
                        break;
                    case 2:
                        details.CloseConnection();
                        Console.WriteLine("Connection is closed");
                        break;
                    case 3:
                        Details.GetAddressBookDetails();
                        break;
                    case 4:
                        AddressBook addressbook = new AddressBook();
                        Console.WriteLine("Enter a First Name for Update Contact");
                        string firstname = Console.ReadLine();
                        addressbook.First_Name = firstname;
                        Console.WriteLine("Enter Last Name");
                        string lastname = Console.ReadLine();
                        addressbook.Last_Name = lastname;
                        Console.WriteLine("Enter Address");
                        string address = Console.ReadLine();
                        addressbook.Address = address;
                        Console.WriteLine("Enter City");
                        string city = Console.ReadLine();
                        addressbook.City = city;
                        Console.WriteLine("Enter State");
                        string State = Console.ReadLine();
                        addressbook.State = State;
                        Console.WriteLine("Enter Zip");
                        double zip = Convert.ToInt64(Console.ReadLine());
                        addressbook.Zip = zip;
                        Console.WriteLine("Enter PhoneNumber");
                        double Phone = Convert.ToInt64(Console.ReadLine());
                        addressbook.PhoneNumber = Phone;
                        Console.WriteLine("Enter Email");
                        string Email = Console.ReadLine();
                        addressbook.Email = Email;
                        Console.WriteLine("Enter a Address Book Name");
                        string AddressBookName = Console.ReadLine();
                        addressbook.AddressBookName = AddressBookName;
                        Console.WriteLine("Enter type");
                        string type = Console.ReadLine();
                        addressbook.Type = type;
                        details.UpdateContact(addressbook);
                        Console.WriteLine("Contact is Updated");
                        break;
                    case 5:
                        AddressBook getData = new AddressBook();
                        Console.Write("Enter the City Name:-");
                        string cityname = Console.ReadLine();
                        getData.City = cityname;
                        Console.Write("Enter the State Name:-");
                        string statename = Console.ReadLine();
                        getData.State = statename;
                        details.GetDataFromCityAndState(getData);
                        break;
                    case 6:
                        AddressBook addressBook = new AddressBook();
                        Console.WriteLine("Enter First Name");
                        string FirstName = Console.ReadLine();
                        addressBook.First_Name = FirstName;
                        Console.WriteLine("Enter Last Name");
                        string LastName = Console.ReadLine();
                        addressBook.Last_Name = LastName;
                        Console.WriteLine("Enter Address");
                        string Address = Console.ReadLine();
                        addressBook.Address = Address;
                        Console.WriteLine("Enter City");
                        string City = Console.ReadLine();
                        addressBook.City = City;
                        Console.WriteLine("Enter state");
                        string state = Console.ReadLine();
                        addressBook.State = state;
                        Console.WriteLine("Enter Zip");
                        double Zip = Convert.ToInt64(Console.ReadLine());
                        addressBook.Zip = Zip;
                        Console.WriteLine("Enter PhoneNumber");
                        double PhoneNumber = Convert.ToInt64(Console.ReadLine());
                        addressBook.PhoneNumber = PhoneNumber;
                        Console.WriteLine("Enter Email");
                        string email = Console.ReadLine();
                        addressBook.Email = email;                        
                        Console.WriteLine("Enter a Address Book Name");
                        string AddressbookName = Console.ReadLine();
                        addressBook.AddressBookName = AddressbookName;
                        Console.WriteLine("Enter type");
                        string Type = Console.ReadLine();
                        addressBook.Type = Type;
                        details.AddContact(addressBook);
                        Console.WriteLine("New Contact is Added");
                        break;
                    case 0:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }
            while (option != 0);
        }
    }
}
