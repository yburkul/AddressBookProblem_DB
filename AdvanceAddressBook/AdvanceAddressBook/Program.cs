﻿using System;

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
