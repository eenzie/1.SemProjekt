using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SemesterProjekt.Models
{
    public class ContactLenses : Product
    {
        /// <summary>
        /// Written by Anh
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="brand"></param>
        /// <param name="price"></param>
        /// <param name="stock"></param>
        /// <param name="strength"></param>
        /// <param name="hasUVFilter"></param>
        /// <param name="type"></param>

        public ContactLenses(Product product, string duration, decimal strength, bool hasUVFilter) : base(product)
        {
            this.Duration = duration;
            this.Strength = strength;
            this.HasUVFilter = hasUVFilter;
        }

        public string Duration { get; set; }
        public decimal Strength { get; set; }
        public bool HasUVFilter { get; set; }
       
        public override int ProductGroupID => PGID;
        private const int PGID = 2;
    }
}
