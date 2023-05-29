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
        Database_Product Database_Product = new Database_Product();

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

        /// <summary>
        /// Written by Ina
        /// Method for reading all order lines that include a specific product
        /// </summary>
        /// <param name="product"></param>
        /// <returns>List of order lines containing product</returns>
        public List<OrderLine> SelectProductOrderLines(Product selectedProduct = null)
        {
            var orderLines = new List<OrderLine>();
           
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                string selectSQLString = $"select * from OrderLine";

                if (selectedProduct != null)
                {
                    selectSQLString += $" where ProductID = {selectedProduct.ID};";
                }

                SqlCommand cmd = new SqlCommand(selectSQLString, sqlConnection);

                sqlConnection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                List<Product> productList = Database_Product.SelectProductsFromDatabase();
                List<Eyetest> eyetestList = Database_Product.SelectEyeTests();
                List<Order> orderList = SelectOrders();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    int quantity = reader.GetInt32(1);
                    decimal salesPrice = reader.GetDecimal(2);
                    int product = reader.GetInt32(3);
                    int eyetest = reader.GetInt32(4);
                    int order = reader.GetInt32(5);

                    Product products = productList.Find(x => x.ID == product);
                    Eyetest eyetests = eyetestList.Find(x => x.ID == eyetest);
                    Order orders = orderList.Find(x => x.ID == order);

                    if (products == null || eyetests == null)
                    {
                        // Some error handling here
                        continue;
                    }

                    OrderLine orderLine = new OrderLine(id, quantity, salesPrice, products, eyetests, orders);

                    orderLines.Add(orderLine);
                }
            }
            return orderLines;
        }
    }
}
