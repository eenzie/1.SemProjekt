using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SemesterProjekt.Models {
    public class ProductStock {
        public Product Product { get; set; }
        public Shop Store { get; set; }
        public int Stock { get; set; }
    }
}
