using _1.SemesterProjekt.Models;
using _1.SemesterProjekt.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _1.SemesterProjekt.Services
{
    public class OrderService
    {
        Database_Order database_Order = new Database_Order();
      
        /// <summary>
        /// This will return all orders or filter them by Customer
        /// </summary>
        /// <param name="customer">Customer instance to filter by, default if no filter applied</param>
        /// <returns>List of orders</returns>
        public List<Order> GetCustomerOrders(Customer customer = null)
        {
            var orders = database_Order.SelectOrders(customer);
            return orders;
        }

        /// <summary>
        /// This will return all orders within a given period between start and end filter by customer optional
        /// </summary>
        /// <param name="start">The start of the period to search for</param>
        /// <param name="end">The end of the period to search for</param>
        /// <param name="customer">A customer to filter by</param>
        /// <returns>A list of orders in a time period optionally filtered by a customer</returns>
        public List<Order> GetOrdersByDate(DateTime start, DateTime end, Customer customer = null) {
            return GetCustomerOrders(customer).Where(c => c.Date >= start && end >= c.Date).ToList();
        }

        /// <summary>
        /// Written by Ina
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public List<OrderLine> GetProductOrderLines(Product product = null)
        {
            var orderLines = database_Order.SelectProductOrderLines(product);
            return orderLines;
        }

        public bool CreateOrder(Order order) {
            // Opret først Order i order tabellen

            return database_Order.InsertOrder(order);
        }

    }
}
