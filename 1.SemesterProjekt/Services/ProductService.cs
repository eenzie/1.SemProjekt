using _1.SemesterProjekt.Models;
using _1.SemesterProjekt.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SemesterProjekt.Service {
    public class ProductService 
    {
        private Database _database = new Database();

        public bool CreatedProduct(string name, string brand, decimal price, int stock, string type, double strength, bool hasUVFilter, string glassType, string coating, bool isSunglass, out Product product)
        {
            return _database.CreateProduct(name, brand, price, stock, type, strength, hasUVFilter, glassType, coating, isSunglass, out product);
        }

        /// <summary>
        /// Written by Ina
        /// Service layer method to get all products in stock
        /// </summary>
        /// <returns>true if customer is found and method call is successful</returns>
        public List<Product> ReadAllProductsInStock()
        {
            return _database.GetAllProductsInStock();
        }

    }
}
