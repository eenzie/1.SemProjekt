using _1.SemesterProjekt.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Windows.Forms;

namespace _1.SemesterProjekt.Repositories
{
    public class Database
    {

        private readonly string ConnectionString = @"Server=mssql3.unoeuro.com;Database=tripshop_dk_db_project;User Id=tripshop_dk;Password=wDafdGbx6ynAkcRzprmt;TrustServerCertificate=True";

        /// <summary>
        /// Method to register a new customer in the database
        /// </summary>
        /// <param name="name">Customer's full name [required]</param>
        /// <param name="address">Customer's address [optional]</param>
        /// <param name="phoneNumber">Customer's phone number [optional]</param>
        /// <param name="email">Customer's email [optional]</param>
        /// <param name="customer">A new Customer instance</param>
        /// <returns>Returns true if success, false otherwise</returns>
        public bool Create(string name, string address, string phoneNumber, string email, out Customer customer)
        {
            // Gives customer the default value (NULL) in case validation fails
            customer = default;

            // Check if name is Null or whitespace
            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }

            // Creates a SQL Connection in a using statement,
            // because a "using" will automatically Dispose the resource (the SqlConnection instance)
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {

                // Construct a parameterized insert SQL string
                string insertSqlString =
                    $"insert into Customers (Name, Address, Phone, Email, MarkedAsDeleted) output inserted.Id values (@name, @address, @phoneNumber, @email, 0);";

                // Create SQL Command with the insert SQL string and SQL connection
                SqlCommand sqlCommand = new SqlCommand(insertSqlString, sqlConnection);

                // Add parameters and values to the command

                #region Parameters

                // We add a parameter with a name and a database type
                sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar);

                // We add a value to the parameter we added above
                sqlCommand.Parameters["@name"].Value = name;

                // rinse and repeat
                sqlCommand.Parameters.Add("@address", SqlDbType.NVarChar);
                sqlCommand.Parameters["@address"].Value = address;

                sqlCommand.Parameters.Add("@phoneNumber", SqlDbType.NVarChar);
                sqlCommand.Parameters["@phoneNumber"].Value = phoneNumber;

                sqlCommand.Parameters.Add("@email", SqlDbType.NVarChar);
                sqlCommand.Parameters["@email"].Value = email;

                #endregion

                // Open the connection
                sqlConnection.Open();

                // We execute the command, and store output (Inserted.Id)
                int newlyInsertedId = (int)sqlCommand.ExecuteScalar();

                // Instantiate Customer instance
                customer = new Customer(newlyInsertedId, name, address, phoneNumber, email, false);


                // If the command above succeeded in creating a customer, the Id will be greater than zero
                return newlyInsertedId > 0;
            }
        }

        /// <summary>
        /// Written by Ina
        /// Update customer details using ID parameter
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updatedCustomer"></param>
        /// <returns>true if customer is found and query is executed</returns>
        public bool UpdateCustomerByID(string id, Customer updatedCustomer)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                string updateSqlString = "UPDATE Customers SET " +
                                         "Name = @updatedName, " +
                                         "Address = @updatedAddress, " +
                                         "PhoneNo = @updatedPhoneNo, " +
                                         "Email = @updatedEmail " +
                                         "WHERE ID = @id";

                using (SqlCommand sqlCommand = new SqlCommand(updateSqlString, sqlConnection))
                {
                    sqlCommand.Parameters.Add("@updatedName", SqlDbType.NVarChar).Value = updatedCustomer.Name;
                    sqlCommand.Parameters.Add("@updatedAddress", SqlDbType.NVarChar).Value = updatedCustomer.Address;
                    sqlCommand.Parameters.Add("@updatedPhoneNo", SqlDbType.NVarChar).Value = updatedCustomer.PhoneNo;
                    sqlCommand.Parameters.Add("@updatedEmail", SqlDbType.NVarChar).Value = updatedCustomer.Email;
                    sqlCommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;

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
                        //Display an error message of the exception
                        MessageBox.Show(ex.Message);

                        //false indicates that the program fails to delete the customer
                        return false;
                    }
                }
            }
        }


        /// <summary>
        /// Written by Ina
        /// Update Customer details using ID parameter to set Is Deleted to true (1)
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>true if customer is found and query is executed</returns>
        public bool IsDeletedCustomerByID(Customer customer)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                string isDeletedSqlString = "UPDATE Customers SET " +
                                         "Name = @Name, " +
                                         "Address = IS NULL, " +
                                         "PhoneNo = IS NULL, " +
                                         "Email = IS NULL, " +
                                         "IsDeleted = 1 " +
                                         "WHERE id = @id";

                using (SqlCommand sqlCommand = new SqlCommand(isDeletedSqlString, sqlConnection))
                {
                    sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = customer.Name;
                    sqlCommand.Parameters.Add("@Address", SqlDbType.NVarChar).Value = customer.Address;
                    sqlCommand.Parameters.Add("@PhoneNo", SqlDbType.NVarChar).Value = customer.PhoneNo;
                    sqlCommand.Parameters.Add("@Email", SqlDbType.NVarChar).Value = customer.Email;
                    sqlCommand.Parameters.Add("@IsDeleted", SqlDbType.NVarChar).Value = customer.IsDeleted;
                    sqlCommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = customer.ID;

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
                        //Display an error message of the exception
                        MessageBox.Show(ex.Message);

                        //false indicates that the program fails to delete the customer
                        return false;
                    }
                }
            }
        }

        /// <summary>
        /// Method to delelete a customer based on their customer ID
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="deleteCustomer"></param>
        /// <returns></returns>
        public bool DeleteCustomerById(Customer customer)
        {
            // //This using statement ensures that the SqlConnection object
            //is disposed of properly after its usage. It establishes a connection to the database
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                string deleteSqlString = "DELETE FROM Customers WHERE Id = @customerId";

                using (SqlCommand sqlCommand = new SqlCommand(deleteSqlString, sqlConnection))
                {
                    //add parameters with customer ID and a database type
                    sqlCommand.Parameters.Add("@customerId", SqlDbType.Int);
                    //add a value to the above parameter
                    sqlCommand.Parameters["@customerId"].Value = customer.ID;

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
                        //Display an error message of the exception
                        MessageBox.Show(ex.Message);

                        //false indicates that the program fails to delete the customer
                        return false;
                    }
                }
            }
        }
    }
}
