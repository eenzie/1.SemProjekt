using _1.SemesterProjekt.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SemesterProjekt.Repositories {
    public class Database {

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
        public bool Create(string name, string address, string phoneNumber, string email, out Customer customer) {
            // Gives customer the default value (NULL) in case validation fails
            customer = default;

            // Check if name is Null or whitespace
            if (string.IsNullOrWhiteSpace(name)) {
                return false;
            }

            // Creates a SQL Connection in a using statement,
            // because a "using" will automatically Dispose the resource (the SqlConnection instance)
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString)) {

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

    }
}
