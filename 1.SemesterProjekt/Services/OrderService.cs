using _1.SemesterProjekt.Models;
using _1.SemesterProjekt.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
