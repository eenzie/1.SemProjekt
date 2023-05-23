using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SemesterProjekt.Models
{

    
    public class Accessories : Product
    {
        /// <summary>
        /// Written by Anh
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="brand"></param>
        /// <param name="price"></param>
        /// <param name="stock"></param>
        /// <param name="type"></param>
        public Accessories(int id, string name, string brand, decimal price, int stock, string type) : base(id, name, brand, price, stock)
        {
            this.Type = type;
        }
        public string Type { get; set; }
    }
}
