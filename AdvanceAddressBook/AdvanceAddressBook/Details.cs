using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAddressBook
{
    public class Details
    {
        static string connectionString = @"Data Source=DESKTOP-DNLCRQ5\SQLEXPRESS;Initial Catalog=AddressBook_Service;Integrated Security=True;";
        static SqlConnection sqlConnection = new SqlConnection(connectionString);

        public void EstablishConnection()
        {
            if (sqlConnection != null && sqlConnection.State.Equals(ConnectionState.Closed))
            {
                try
                {
                    sqlConnection.Open();
                }
                catch (Exception)
                {
                    throw new AddressException(AddressException.ExceptionType.Connection_Failed, "connection failed");

                }
            }
        }
        public void CloseConnection()
        {
            if (sqlConnection != null && sqlConnection.State.Equals(ConnectionState.Open))
            {
                try
                {
                    sqlConnection.Close();
                }
                catch (Exception)
                {
                    throw new AddressException(AddressException.ExceptionType.Connection_Failed, "connection failed");
                }
            }
        }
        public static List<AddressBook> GetAddressBookDetails()
        {
            List<AddressBook> list = new List<AddressBook>();
            AddressBook address = new AddressBook();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            using (sqlConnection)
            {
                SqlCommand cmd = new SqlCommand("dbo.spGetAllAddressBookData", sqlConnection);
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        address.ID = reader.GetInt32(0);
                        address.First_Name = reader.GetString(1);
                        address.Last_Name = reader.GetString(2);
                        address.Address = reader.GetString(3);
                        address.City = reader.GetString(4);
                        address.State = reader.GetString(5);
                        address.Zip = reader.GetInt64(6);
                        address.PhoneNumber = reader.GetInt64(7);
                        address.Email = reader.GetString(8);
                        address.Type = reader.GetString(9);
                        address.AddressBookName = reader.GetString(10);
                        list.Add(address);
                        Console.WriteLine(address.ID + "," + address.First_Name + "," + address.Last_Name + "," + address.Address + "," + address.City + ","
                            + address.State + "," + address.Zip + "," + address.PhoneNumber + "," + address.Email + "," + address.Type + "," + address.AddressBookName);
                    }
                }
                else
                {
                    Console.WriteLine("No Data Found");
                }
                sqlConnection.Close();

            }
            return list;
        }
        public bool UpdateContact(AddressBook address)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("dbo.EditContact", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@First_Name", address.First_Name);
                    command.Parameters.AddWithValue("@Last_Name", address.Last_Name);
                    command.Parameters.AddWithValue("@Address", address.Address);
                    command.Parameters.AddWithValue("@City", address.City);
                    command.Parameters.AddWithValue("@State", address.State);
                    command.Parameters.AddWithValue("@Zip", address.Zip);
                    command.Parameters.AddWithValue("@PhoneNumber", address.PhoneNumber);
                    command.Parameters.AddWithValue("@Email", address.Email);
                    command.Parameters.AddWithValue("@AddressBookName", address.AddressBookName);
                    command.Parameters.AddWithValue("@Type", address.Type);
                    connection.Open();
                    var result = command.ExecuteNonQuery();
                    connection.Close();
                    if (result != 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception)
            {
                throw new AddressException(AddressException.ExceptionType.Contact_Not_Updated, "Contact not updated");
                return false;
            }
        }
        public bool GetDataFromCityAndState(AddressBook address)
        {
            try
            {
                List<AddressBook> list = new List<AddressBook>();
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                using (sqlConnection)
                {
                    SqlCommand cmd = new SqlCommand("spRetreiveTheData", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(@"City", address.City);
                    cmd.Parameters.AddWithValue(@"State", address.State);
                    sqlConnection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            address.ID = reader.GetInt32(0);
                            address.First_Name = reader.GetString(1);
                            address.Last_Name = reader.GetString(2);
                            address.Address = reader.GetString(3);
                            address.City = reader.GetString(4);
                            address.State = reader.GetString(5);
                            address.Zip = reader.GetInt64(6);
                            address.PhoneNumber = reader.GetInt64(7);
                            address.Email = reader.GetString(8);
                            address.Type = reader.GetString(9);
                            address.AddressBookName = reader.GetString(10);
                            list.Add(address);
                            Console.WriteLine(address.ID + "," + address.First_Name + "," + address.Last_Name + "," + address.Address + "," + address.City + ","
                                + address.State + "," + address.Zip + "," + address.PhoneNumber + "," + address.Email + "," + address.Type + "," + address.AddressBookName);                           
                        }
                        Console.WriteLine("The Number Of Address is: " + list.Count());
                    }
                    else
                    {
                        Console.WriteLine("No Data Found");
                    }
                    sqlConnection.Close();
                    return true;
                }               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;

            }
        }
    }
}
