using _1.SemesterProjekt.Models;
using _1.SemesterProjekt.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _1.SemesterProjekt.Repositories
{
    public class Database_Customer : Database_Abstract
    {
        
        public List<Customer> GetCustomerByEmail(string email)
        {
            // Wrap the using statement in a try catch block
            try {
                using (SqlConnection connection = new SqlConnection(ConnectionString)) {
                    string selectSQLString = $"select ID, Name, Address, PostCode, Phone, Email from Customers where LOWER(Email) LIKE LOWER('%{email}%') and IsDeleted = 0;";
                    SqlCommand sqlCommand = new SqlCommand(selectSQLString, connection);

                    List<Customer> customers = new List<Customer>();
                    connection.Open();

                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read()) {
                        int id = sqlDataReader.GetInt32(0);
                        string cname = sqlDataReader.GetString(1);
                        string address = sqlDataReader.GetString(2);
                        int postcode = sqlDataReader.GetInt32(3);
                        string phone = sqlDataReader.GetString(4);
                        string mail = sqlDataReader.GetString(5);

                        Customer customer = new Customer(id, cname, address, postcode, phone, mail, false);
                        customers.Add(customer);
                    }

                    return customers;
                }
            }
            catch (Exception e) {
                // If there is an error, we write it to the logfile
                LogService.LogError(e.Message, nameof(Database_Customer), nameof(GetCustomerByEmail));
                // return empty list.
                return new List<Customer>();
            }
        }

        /// <summary>
        /// Written by Anton
        /// Method to register a new customer in the database
        /// </summary>
        /// <param name="name"></param>
        /// <param name="address"></param>
        /// <param name="postcode"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="email"></param>
        /// <param name="customer"></param>
        /// <returns>Returns true if success, false otherwise</returns>
        public bool CreateCustomer(Customer customer)
        {
            // Check if name is Null or whitespace
            if (string.IsNullOrWhiteSpace(customer.Name))
            {
                return false;
            }

            // Wrap using statement in try catch
            try {
                // Creates a SQL Connection in a using statement,
                // because a "using" will automatically Dispose the resource (the SqlConnection instance)
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString)) {

                    // Construct a parameterized insert SQL string
                    string insertSqlString =
                        $"insert into Customers (Name, Address, PostCode, Phone, Email, IsDeleted) output inserted.ID values (@name, @address, @postcode, @phoneNumber, @email, 0);";

                    // Create SQL Command with the insert SQL string and SQL connection
                    SqlCommand sqlCommand = new SqlCommand(insertSqlString, sqlConnection);

                    // Add parameters and values to the command

                    #region Parameters

                    // We add a parameter with a name and a database type and give it a value
                    sqlCommand.Parameters.Add("@name", SqlDbType.NChar).Value = customer.Name;

                    // rinse and repeat
                    sqlCommand.Parameters.Add("@address", SqlDbType.NChar).Value = customer.Address;

                    sqlCommand.Parameters.Add("@postcode", SqlDbType.Int).Value = customer.PostCode;

                    sqlCommand.Parameters.Add("@phoneNumber", SqlDbType.NChar).Value = customer.PhoneNo;

                    sqlCommand.Parameters.Add("@email", SqlDbType.NChar).Value = customer.Email;

                    #endregion

                    // Open the connection
                    sqlConnection.Open();

                    // We execute the command, and store output (Inserted.Id)
                    int newlyInsertedId = (int)sqlCommand.ExecuteScalar();

                    // Instantiate Customer instance
                    customer.ID = newlyInsertedId;

                    // If the command above succeeded in creating a customer, the Id will be greater than zero
                    return newlyInsertedId > 0;
                }
            }
            catch (Exception e) {
                // Write error to log
                LogService.LogError(e.Message, nameof(Database_Customer), nameof(CreateCustomer));
                return false;
            }
        }

        /// <summary>
        /// Written by Anton
        /// Method to get all customers by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public List<Customer> GetCustomerByName(string name)
        {
            try {
                using (SqlConnection connection = new SqlConnection(ConnectionString)) {
                    string selectSQLString = $"select ID, Name, Address, PostCode, Phone, Email from Customers where LOWER(Name) LIKE LOWER('%{name}%') and IsDeleted = 0;";
                    SqlCommand sqlCommand = new SqlCommand(selectSQLString, connection);

                    List<Customer> customers = new List<Customer>();
                    connection.Open();

                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read()) {
                        int id = sqlDataReader.GetInt32(0);
                        string cname = sqlDataReader.GetString(1);
                        string address = sqlDataReader.GetString(2);
                        int postcode = sqlDataReader.GetInt32(3);
                        string phone = sqlDataReader.GetString(4);
                        string email = sqlDataReader.GetString(5);

                        Customer customer = new Customer(id, cname, address, postcode, phone, email, false);
                        customers.Add(customer);
                    }

                    return customers;
                }
            }
            catch (Exception e) {
                LogService.LogError(e.Message, nameof(Database_Customer), nameof(GetCustomerByName));
                return new List<Customer>();
            }
        }

        /// <summary>
        /// Written by Anton
        /// Method to get all Customers by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Customer GetCustomerById(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string selectSQLString = $"select Name, Address, PostCode, Phone, Email from Customers where ID = {id} and IsDeleted = 0;";
                SqlCommand sqlCommand = new SqlCommand(selectSQLString, connection);
                connection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    string name = sqlDataReader.GetString(0);
                    string address = sqlDataReader.GetString(1);
                    int postcode = sqlDataReader.GetInt32(2);
                    string phone = sqlDataReader.GetString(3);
                    string email = sqlDataReader.GetString(4);


                    Customer customer = new Customer(id, name, address, postcode, phone, email, false);
                    return customer;
                }

                return default;
            }
        }

        /// <summary>
        /// Written by Anton
        /// Method to get all customers
        /// </summary>
        /// <returns></returns>
        public List<Customer> GetAllCustomers()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string selectSQLString = $"select Id, Name, Address, PostCode, Phone, Email from Customers where IsDeleted = 0;";
                SqlCommand sqlCommand = new SqlCommand(selectSQLString, connection);

                List<Customer> customers = new List<Customer>();
                connection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    int id = sqlDataReader.GetInt32(0);
                    string name = sqlDataReader.GetString(1);
                    string address = sqlDataReader.GetString(2);
                    int postcode = sqlDataReader.GetInt32(3);
                    string phone = sqlDataReader.GetString(4);
                    string email = sqlDataReader.GetString(5);


                    Customer customer = new Customer(id, name, address, postcode, phone, email, false);
                    customers.Add(customer);
                }

                return customers;
            }
        }

        /// <summary>
        /// Written by Ina
        /// Update customer details using ID parameter
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updatedCustomer"></param>
        /// <returns>true if customer is found and query is executed</returns>
        public bool UpdateCustomerInDatabase(Customer updatedCustomer)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                string updateSqlString = "UPDATE Customers SET " +
                                         "Name = @updatedName, " +
                                         "Address = @updatedAddress, " +
                                         $"PostCode = {updatedCustomer.PostCode}, " +
                                         "Phone = @updatedPhone, " +
                                         "Email = @updatedEmail " +
                                         $"WHERE ID = {updatedCustomer.ID}";

                SqlCommand sqlCommand = new SqlCommand(updateSqlString, sqlConnection);

                sqlCommand.Parameters.Add("@updatedName", SqlDbType.NVarChar).Value = updatedCustomer.Name;
                sqlCommand.Parameters.Add("@updatedAddress", SqlDbType.NVarChar).Value = updatedCustomer.Address;
                sqlCommand.Parameters.Add("@updatedPhone", SqlDbType.NVarChar).Value = updatedCustomer.PhoneNo;
                sqlCommand.Parameters.Add("@updatedEmail", SqlDbType.NVarChar).Value = updatedCustomer.Email;

                try
                {
                    sqlConnection.Open();
                    int rowsAffected = sqlCommand.ExecuteNonQuery();

                    //if rowsAffected is greater than zero, then the program found the customer and has
                    //deleted the customer, otherwise it is false and can't delete the customer
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    //false indicates that the program fails to delete the customer
                    return false;
                }

            }
        }

        /// <summary>
        /// Written by Ina
        /// Update Customer details using ID parameter to set Is Deleted to true (1)
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>true if customer is found and query is executed</returns>
        public bool MarkCustomerAsIsDeleted(Customer customer)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                string isDeletedSqlString = "UPDATE Customers SET " +
                                         "Name = 'Slettet', " +
                                         "Address = NULL, " +
                                         "PostCode = NULL, " +
                                         "Phone = NULL, " +
                                         "Email = NULL, " +
                                         "IsDeleted = 1 " +
                                         $"WHERE id = {customer.ID};";

                using (SqlCommand sqlCommand = new SqlCommand(isDeletedSqlString, sqlConnection))
                {

                    try
                    {
                        sqlConnection.Open();
                        int rowsAffected = sqlCommand.ExecuteNonQuery();

                        //if rowsAffected is greater than zero, then the program found the customer and has
                        //deleted the customer, otherwise it is false and can't delete the customer
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        //false indicates that the program fails to delete the customer
                        return false;
                    }
                }
            }
        }

        /// <summary>
        /// Written by Anh
        /// Method to delelete a customer based on their customer ID
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="deleteCustomer"></param>
        /// <returns></returns>
        public bool DeleteCustomer(Customer customer)
        {
            // //This using statement ensures that the SqlConnection object
            //is disposed of properly after its usage. It establishes a connection to the database
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                string deleteSqlString = $"DELETE FROM Customers WHERE Id = {customer.ID}";

                using (SqlCommand sqlCommand = new SqlCommand(deleteSqlString, sqlConnection))
                {

                    try
                    {
                        sqlConnection.Open();
                        int rowsAffected = sqlCommand.ExecuteNonQuery();

                        //if rowsAffected is greater than zero, then the program found the customer and has
                        //deleted the customer, otherwise it is false and can't delete the customer
                        return rowsAffected > 0;

                    }
                    catch (Exception ex)
                    {
                        //false indicates that the program fails to delete the customer
                        return false;
                    }
                }
            }
        }

        /// <summary>
        /// Written By Anton
        /// This will insert the common product info into the super product table
        /// </summary>
        /// <param name="product"></param>
        /// <returns>The database generated ID, zero if failed</returns>
    }
}
