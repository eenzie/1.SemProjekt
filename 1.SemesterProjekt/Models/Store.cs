using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SemesterProjekt.Models {
    public class Store {
        public int ID { get; set; }
        public string Address { get; set; }
        public Employee BossMan { get; set; }
    }
}
