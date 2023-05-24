using _1.SemesterProjekt.Models;
using _1.SemesterProjekt.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SemesterProjekt.Service {
    public class ShopService 
    {
        public List<Shop> ReadAllShops()
        {
            Database_Shop shop = new Database_Shop();
            return shop.GetAllShops();
        }

    }
}
