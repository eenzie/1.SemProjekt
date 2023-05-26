using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SemesterProjekt.Models {
    public class Brand {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? ProductGroupId { get; set; }

        public Brand(int id, string name, int? productGroupId = null)
        {
            ID = id;
            Name = name;
            ProductGroupId = productGroupId;
        }

        public override string ToString() {
            return Name;
        }
    }
}
