﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SemesterProjekt.Models
{
    public class Product
    {
        /// <summary>
        /// Written by Anh
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="brand"></param>
        /// <param name="price"></param>
        public Product(int id, string name, Brand brand, decimal price, int productGroupID) 
        { 
            this.ID = id;
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.ProductGroupID = productGroupID;
        }

        public Product(string name, Brand brand, decimal price, int productGroupID) {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.ProductGroupID = productGroupID;
        }

        public Product(Product product)
        {
            this.ID = product.ID;
            this.Name = product.Name;
            this.Brand = product.Brand;
            this.Price = product.Price;
            this.ProductGroupID = product.ProductGroupID;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public Brand Brand { get; set; }
        public decimal Price { get; set; }
        public virtual int ProductGroupID { get; set; }

        public override string ToString() {
            return Name;
        }



    }
}
