using _1.SemesterProjekt.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SemesterProjekt.Repositories
{
    public class Database_Order : Database_Abstract
    {
        Database_Shop Database_Shop = new Database_Shop();


        /// <summary>
        /// Written By Anton
        /// This method can return all orders, or filter them by customer if parameter is used
        /// </summary>
        /// <param name="customer">The Customer instance to filter for</param>
        /// <returns>List of orders</returns>
        public List<Order> SelectOrders(Customer customer = null)
        {
            // Instantiate list to return
            var orders = new List<Order>();

            // Creates a SQL connection
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {

                // base sql string
                string selectSQLString = $"select * from Orders";
                // If customer is not null, we will filter by CustomerId
                if (customer != null) {
                    selectSQLString += $" where CustomerID = {customer.ID};";
                }

                // Creates a SQL Command
                SqlCommand cmd = new SqlCommand(selectSQLString, sqlConnection);


                // Opens the SQL Connection
                sqlConnection.Open();

                // Create a SqlDataReader with the executed SQL statement
                SqlDataReader reader = cmd.ExecuteReader();

                // This is so we can bind the ID of shops and employees to instances.
                List<Shop> shops = Database_Shop.GetAllShops();
                List<Employee> employees = Database_Shop.GetAllEmployees();

                // Iterate over the result set
                while (reader.Read())
                {
                    // Extract values from individual columns
                    int id = reader.GetInt32(0);
                    DateTime dateTime = reader.GetDateTime(1);
                    decimal subTotal = reader.GetDecimal(2);
                    int employeeID = reader.GetInt32(4);
                    int shopID = reader.GetInt32(5);

                    // Construct order instance
                    Employee employee = employees.Find(x => x.ID == employeeID);
                    Shop shop = shops.Find(x => x.ID == shopID);

                    // Verify that instance of employee and shop exist, if not, we can't construct order instance
                    if (employee  == null|| shop == null) {
                        // Some error handling here
                        continue;
                    }

                    Order order = new Order(id, dateTime, subTotal, customer, employee,shop);

                    // Add instance to the list returned
                    orders.Add(order);
                }

            }

            return orders;
        }
    }
}
