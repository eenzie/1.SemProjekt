using _1.SemesterProjekt.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace _1.SemesterProjekt.Repositories
{
    public class Database
    {
        private readonly string ConnectionString = @"Server=mssql3.unoeuro.com;Database=tripshop_dk_db_project;User Id=tripshop_dk;Password=wDafdGbx6ynAkcRzprmt;TrustServerCertificate=True";

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
        public bool CreateCustomer(string name, string address, int postcode, string phoneNumber, string email, out Customer customer)
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
                    $"insert into Customers (Name, Address, PostCode, Phone, Email, MarkedAsDeleted) output inserted.Id values (@name, @address, @postcode, @phoneNumber, @email, 0);";

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

                sqlCommand.Parameters.Add("@postcode", SqlDbType.Int);
                sqlCommand.Parameters["@postcode"].Value = postcode;

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
                customer = new Customer(newlyInsertedId, name, address, postcode, phoneNumber, email, false);

                // If the command above succeeded in creating a customer, the Id will be greater than zero
                return newlyInsertedId > 0;
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
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string selectSQLString = $"select ID, Name, Address, PostCode, Phone, Email from Customers where LOWER(Name) LIKE LOWER('%{name}%') and IsDeleted = 0;";
                SqlCommand sqlCommand = new SqlCommand(selectSQLString, connection);

                List<Customer> customers = new List<Customer>();
                connection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
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
        public bool UpdateCustomerByID(string id, Customer updatedCustomer)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                string updateSqlString = "UPDATE Customers SET " +
                                         "Name = @updatedName, " +
                                         "Address = @updatedAddress, " +
                                         "PostCode 0 @updatedPostCode, " +
                                         "Phone = @updatedPhone, " +
                                         "Email = @updatedEmail " +
                                         "WHERE ID = @id";

                using (SqlCommand sqlCommand = new SqlCommand(updateSqlString, sqlConnection))
                {
                    sqlCommand.Parameters.Add("@updatedName", SqlDbType.NVarChar).Value = updatedCustomer.Name;
                    sqlCommand.Parameters.Add("@updatedAddress", SqlDbType.NVarChar).Value = updatedCustomer.Address;
                    sqlCommand.Parameters.Add("@updatedPostCode", SqlDbType.Int).Value = updatedCustomer.PostCode;
                    sqlCommand.Parameters.Add("@updatedPhone", SqlDbType.NVarChar).Value = updatedCustomer.PhoneNo;
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
                                         "PostCode = @PostCode, " +
                                         "Phone = IS NULL, " +
                                         "Email = IS NULL, " +
                                         "IsDeleted = 1 " +
                                         "WHERE id = @id";

                using (SqlCommand sqlCommand = new SqlCommand(isDeletedSqlString, sqlConnection))
                {
                    sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = customer.Name;
                    sqlCommand.Parameters.Add("@Address", SqlDbType.NVarChar).Value = customer.Address;
                    sqlCommand.Parameters.Add("@PostCode", SqlDbType.Int).Value = customer.PostCode;
                    sqlCommand.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = customer.PhoneNo;
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
        /// Written by Anh
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

        /// <summary>
        /// Written by Anh
        /// Method to create a product in the database
        /// </summary>
        /// <param name="name"></param>
        /// <param name="brand"></param>
        /// <param name="price"></param>
        /// <param name="stock"></param>
        /// <param name="type"></param>
        /// <param name="strength"></param>
        /// <param name="hasUVFilter"></param>
        /// <param name="glassType"></param>
        /// <param name="coating"></param>
        /// <param name="isSunglass"></param>
        /// <param name="product"></param>
        /// <returns></returns>
        public bool CreateProduct(string name, string brand, decimal price, int stock, string type, double strength, bool hasUVFilter, string glassType, string coating, bool isSunglass, out Product product)
        {
            product = default;

            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                string insertSqlString =
                   $"insert into Products (Name, Brand, Price, Stock, Type, Strength, HasUVFilter, GlassType, Coating, IsSunglass) output inserted.Id values (@name, @brand, @price, @stock, @type, @strength, @hasUVFilter, @glasstype, @coating, @isSunglass);";

                SqlCommand sqlCommand = new SqlCommand(insertSqlString, sqlConnection);

                #region Parameters

                sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar);
                sqlCommand.Parameters["@name"].Value = name;

                sqlCommand.Parameters.Add("@brand", SqlDbType.NVarChar);
                sqlCommand.Parameters["@brand"].Value = brand;

                sqlCommand.Parameters.Add("@price", SqlDbType.Decimal);
                sqlCommand.Parameters["@price"].Value = price;

                sqlCommand.Parameters.Add("@stock", SqlDbType.Int);
                sqlCommand.Parameters["@stock"].Value = stock;

                sqlCommand.Parameters.Add("@type", SqlDbType.NVarChar);
                sqlCommand.Parameters["@type"].Value = type;

                sqlCommand.Parameters.Add("@strength", SqlDbType.Decimal);
                sqlCommand.Parameters["@strength"].Value = strength;

                sqlCommand.Parameters.Add("@hasUVFilter", SqlDbType.TinyInt);
                sqlCommand.Parameters["@hasUVFilter"].Value = hasUVFilter;

                sqlCommand.Parameters.Add("@glassType", SqlDbType.NVarChar);
                sqlCommand.Parameters["@glassType"].Value = glassType;

                sqlCommand.Parameters.Add("@coating", SqlDbType.NVarChar);
                sqlCommand.Parameters["@coating"].Value = coating;

                sqlCommand.Parameters.Add("@isSunglass", SqlDbType.TinyInt);
                sqlCommand.Parameters["@isSunglass"].Value = isSunglass;


                #endregion

                sqlConnection.Open();

                int newlyInsertedId = (int)sqlCommand.ExecuteScalar();

                product = new Accessories(newlyInsertedId, name, brand, price, stock, type);

                product = new Binoculars(newlyInsertedId, name, brand, price, stock, type);

                product = new ContactLenses(newlyInsertedId, name, brand, price, stock, strength, hasUVFilter, type);

                product = new Glasses(newlyInsertedId, name, brand, price, stock, strength, glassType, coating, isSunglass);


                return newlyInsertedId > 0;
            }
        }

        /// <summary>
        /// Written by Ina
        /// Method to get all products from database where product is in stock
        /// </summary>
        /// <returns>true if product is found and query is executed</returns>
        public List<Product> GetAllProductsInStock()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string selectSQLString = $"SELECT ID, Name, Brand, Price, Stock from Products WHERE Stock > 0;";
                SqlCommand sqlCommand = new SqlCommand(selectSQLString, connection);

                List<Product> products = new List<Product>();
                connection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    int id = sqlDataReader.GetInt32(0);
                    string name = sqlDataReader.GetString(1);
                    string brand = sqlDataReader.GetString(2);
                    decimal price = sqlDataReader.GetDecimal(3);
                    int stock = sqlDataReader.GetInt32(4);

                    Product product = new Product(id, name, brand, price, stock);
                    products.Add(product);
                }

                return products;
            }
        }


        /// <summary>
        /// Written By Anton
        /// This will insert the common product info into the super product table
        /// </summary>
        /// <param name="product"></param>
        /// <returns>The database generated ID, zero if failed</returns>
        private bool InsertProductIntoDatabase(Product product) {
            if (product.Price <= 0) {
                return false;
            }

            if (string.IsNullOrWhiteSpace(product.Name)) {
                return false;
            }

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString)) {
                string insertSqlString = $"insert into Products (Name, Brand, Price, ProductGroupID) output inserted.ID values (@name, {product.Brand.ID}, {product.Price}, {product.ProductGroupId})";
                SqlCommand sqlCommand = new SqlCommand(insertSqlString, sqlConnection);
                sqlCommand.Parameters.Add("@name", SqlDbType.NChar).Value = product.Name;

                product.ID = (int)sqlCommand.ExecuteScalar();
                return true;
            }
        }


        public bool InsertGlassesIntoDatabase(Glasses glasses) {
            if (!InsertProductIntoDatabase(glasses)) {
                return false;
            }

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString)) {
                string insertqlString = $"insert into Glass (ID, Strength, GlassType, Coating, IsSunglasses) output inserted.ID values ({glasses.ID}, {glasses.Strength}, {glasses.GlassType}, {glasses.Coating}, {glasses.IsSunglasses});";
                SqlCommand sqlCommand = new SqlCommand(insertqlString, sqlConnection);

                glasses.ID = (int)sqlCommand.ExecuteScalar();
                return true;
            }
        }
    }
}
