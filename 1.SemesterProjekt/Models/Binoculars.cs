using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SemesterProjekt.Models
{
    public class Binoculars : Product
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
        public Binoculars(int id, string name, Brand brand, decimal price, string type, string zoom, bool isWaterproof) : base(id, name, brand, price, 5)
        {
            this.Type = type;
            this.Zoom = zoom;
            this.IsWaterproof = isWaterproof;
        }
        public string Type { get; set; }
        public string Zoom { get; set; }
        public bool IsWaterproof { get; set; }
        public override int ProductGroupID => 5;
    }
}
