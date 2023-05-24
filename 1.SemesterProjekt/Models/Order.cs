using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SemesterProjekt.Models
{
    public class Order
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public decimal SubTotal { get; set; }
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
        public Shop Shop { get; set; }
    }
}
