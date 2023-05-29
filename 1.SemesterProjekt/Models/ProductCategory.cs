using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SemesterProjekt.Models {
    public class ProductCategory {
        public int ID { get; set; }
        public string Name { get; set; }

        public ProductCategory(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
    }
}
