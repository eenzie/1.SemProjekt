using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SemesterProjekt.Models {
    public class OrderLine {
        /// <summary>
        /// Written by Ina
        /// </summary>
        /// <param name="id"></param>
        /// <param name="quantity"></param>
        /// <param name="salesPrice"></param>
        /// <param name="product"></param>
        /// <param name="eyetest"></param>
        /// <param name="order"></param>
        public OrderLine(int id, int quantity, decimal salesPrice, Product product, Order order) {
            this.ID = id;
            this.Quantity = quantity;
            this.SalesPrice = salesPrice;
            this.Product = product;
            this.Order = order;
        }

        public OrderLine(int quantity, decimal salesPrice, Product product) {
            this.Quantity = quantity;
            this.SalesPrice = salesPrice;
            this.Product = product;
        }

        public int ID { get; set; }
        public int Quantity { get; set; }
        public decimal SalesPrice { get; set; }
        public Product Product { get; set; }
        public Eyetest Eyetest { get; set; }
        public Order Order { get; set; }

        public decimal TotalPrice => Quantity * SalesPrice;
    }
}
