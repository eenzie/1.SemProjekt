using _1.SemesterProjekt.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SemesterProjekt.Repositories
{
    public class Database_Order
    {
        private readonly string ConnectionString = @"Server=mssql3.unoeuro.com;Database=tripshop_dk_db_project;User Id=tripshop_dk;Password=wDafdGbx6ynAkcRzprmt;TrustServerCertificate=True";
        Database_Shop Database_Shop = new Database_Shop();

        public List<Order> SelectOrders(Customer customer)
        {
            var orders = new List<Order>();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                string selectSQLString = $"select * from Orders where CustomerID = {customer.ID};";
                SqlCommand cmd = new SqlCommand(selectSQLString, sqlConnection);

                sqlConnection.Open();

                SqlDataReader reader = cmd.ExecuteReader();


                List<Shop> shops = Database_Shop.GetAllShops();
                List<Employee> employees = Database_Shop.GetAllEmployees();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    DateTime dateTime = reader.GetDateTime(1);
                    decimal subTotal = reader.GetDecimal(2);
                    int employeeID = reader.GetInt32(4);
                    int shopID = reader.GetInt32(5);

                    Order order = new Order()
                    {
                        ID = id,
                        Date = dateTime,
                        SubTotal = subTotal,
                        Customer = customer,
                        Shop = shops.Find(x => x.ID == shopID),
                        Employee = employees.Find(x => x.ID == employeeID)
                    };

                    orders.Add(order);
                }

            }

            return orders;
        }
    }
}
