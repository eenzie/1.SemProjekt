using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SemesterProjekt.Models
{
    public abstract class Product
    {
        /// <summary>
        /// Written by Anh
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="brand"></param>
        /// <param name="price"></param>
        /// <param name="stock"></param>
        public Product(int id, string name, string brand, double price, int stock) 
        { 
            this.ID = id;
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Stock = stock;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

    }
}
