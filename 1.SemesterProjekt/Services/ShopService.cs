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
        /// <summary>
        /// Written by Anton
        /// returns a list of all shops
        /// </summary>
        /// <returns>List of Shops</returns>
        public List<Shop> ReadAllShops()
        {
            return _shop.GetAllShops();
        }


        /// <summary>
        /// Written by Anton
        /// Will return list of all employees in the shop parameter
        /// </summary>
        /// <param name="shop">Shop instance to filter employees by</param>
        /// <returns>List of employees, filtered by shop</returns>
        public List<Employee> GetEmployees(Shop shop) {
            return _shop.GetAllEmployees(shop);
        }

    }
}
