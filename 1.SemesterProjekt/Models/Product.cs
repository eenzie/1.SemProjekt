using System;
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
        /// <param name="stock"></param>
        public Product(int id, string name, Brand brand, decimal price) 
        { 
            this.ID = id;
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public Brand Brand { get; set; }
        public decimal Price { get; set; }
        public virtual int ProductGroupID { get; }

    }
}
