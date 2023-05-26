using _1.SemesterProjekt.Models;
using _1.SemesterProjekt.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _1.SemesterProjekt.Service {
    public class ShopService 
    {
        private readonly Database_Shop _shop = new Database_Shop();
        public List<Shop> ReadAllShops()
        {
            return _shop.GetAllShops();
        }

        public List<Employee> GetEmployees(Shop shop) {
            return _shop.GetAllEmployees(shop);
        }

    }
}
