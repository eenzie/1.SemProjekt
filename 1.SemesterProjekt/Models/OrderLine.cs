﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SemesterProjekt.Models
{
    public class OrderLine
    {
        /// <summary>
        /// Witten by Ina
        /// </summary>
        /// <param name="id"></param>
        /// <param name="quantity"></param>
        /// <param name="salesPrice"></param>
        /// <param name="productID"></param>
        /// <param name="eyetestID"></param>
        /// <param name="orderID"></param>
        public OrderLine(int id, int quantity, decimal salesPrice, Product product, Eyetest eyetest, Order order)
        {
            this.ID = id;
            this.Quantity = quantity;
            this.SalesPrice = salesPrice;
            this.Product = product;
            this.Eyetest = eyetest;
            this.Order = order;
        }

        public int ID { get; set; }
        public int Quantity { get; set; }
        public decimal SalesPrice { get; set; }
        public Product Product { get; set; }
        public Eyetest Eyetest { get; set; }
        public Order Order { get; set; }
    }
}
