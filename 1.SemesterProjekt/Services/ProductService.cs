using _1.SemesterProjekt.Models;
using _1.SemesterProjekt.Repositories;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _1.SemesterProjekt.Service {
    public class ProductService 
    {
        private Database_Product _database = new Database_Product();

        public bool CreatedProduct(Product product)
        {
            switch (product.ProductGroupID) {
                case 3:
                    return _database.InsertGlassesIntoDatabase((Glasses)product);
            }

            return false;
        }

        /// <summary>
        /// Written by Ina
        /// Service layer method to get all products in stock
        /// </summary>
        /// <returns>true if customer is found and method call is successful</returns>
        public List<ProductStock> ReadAllProductsInStock()
        {
            return _database.SelectProductsInStockFromDatabase();
        }

    }
}
