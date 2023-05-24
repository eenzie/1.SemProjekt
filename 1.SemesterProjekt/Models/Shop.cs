using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SemesterProjekt.Models {
    public class Shop {
        public int ID { get; set; }
        public string Address { get; set; }
        public int PostCode { get; set; }
        public override string ToString()
        {
            return $"{PostCode} {Address}";
        }

        public Shop(int id, string address, int postCode)
        {
            ID = id;
            Address = address;
            PostCode = postCode;
        }
    }
}
