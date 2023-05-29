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
        public Accessories(int id, string name, Brand brand, decimal price, string type, string colour) : base(id, name, brand, price, PGID)
        {
            this.Type = type;
            this.Colour = colour;
        }
        public string Type { get; set; }
        public string Colour { get; set; }
        public override int ProductGroupID => PGID;
        private const int PGID = 5;
    }
}
