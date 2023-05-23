using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SemesterProjekt.Models
{
    public class Frames : Product {
        public Frames(int id, string name, Brand brand, decimal price, int productGroupID) : base(id, name, brand, price, productGroupID) {
        }
    }
}
