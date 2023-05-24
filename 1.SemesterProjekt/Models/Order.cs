using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SemesterProjekt.Models
{
    public class Order
    {
        /// <summary>
        /// Written by Ina
        /// </summary>
        /// <param name="id"></param>
        /// <param name="date"></param>
        /// <param name="subTotal"></param>
        /// <param name="customer"></param>
        /// <param name="employee"></param>
        /// <param name="shop"></param>
        public Order(int id, DateTime date, decimal subTotal, Customer customer, Employee employee, Shop shop)
        {
            this.ID = id;
            this.Date = date;
            this.SubTotal = subTotal;
            this.Customer = customer;
            this.Employee = employee;
            this.Shop = shop;
        }

        /// <summary>
        /// Written by Anton
        /// </summary>
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public decimal SubTotal { get; set; }
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
        public Shop Shop { get; set; }
    }
}
