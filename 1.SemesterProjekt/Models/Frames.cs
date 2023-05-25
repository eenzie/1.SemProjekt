using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SemesterProjekt.Models
{
    public class Frames : Product
    {
        /// <summary>
        /// Written by Anh
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="brand"></param>
        /// <param name="price"></param>
        /// <param name="length"></param>
        /// <param name="width"></param>
        /// <param name="colour"></param>
        /// <param name="material"></param>
        /// <param name="shape"></param>
        public Frames(int id, string name, Brand brand, decimal price, decimal length, decimal width, string colour, string material, string shape) : base(id, name, brand, price, 1)
        {
            this.ID = id;
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Length = length;
            this.Width = width;
            this.Colour = colour;
            this.Material = material;
            this.Shape = shape;
         }
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public string Colour { get; set; }

        public string Material { get; set; }
        public string Shape { get; set; }

        public int productGroupID => 1;
    }
}


