using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SemesterProjekt.Models
{
    public class Eyetest
    {
        /// <summary>
        /// Written by Anh
        /// </summary>
        /// <param name="id"></param>
        /// <param name="price"></param>
        /// <param name="customerID"></param>
        public Eyetest(int id, decimal price, int customerID) 
        {
            this.ID = id;
            this.Price = price;
            this.CustomerID = customerID;
        }
        public int ID { get; set; }
        public decimal Price { get; set; }
        public int CustomerID { get; set; }
    }
}
