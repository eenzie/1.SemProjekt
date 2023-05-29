using _1.SemesterProjekt.Models;
using _1.SemesterProjekt.Repositories;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _1.SemesterProjekt.Service
{
    public class ProductService
    {
        private Database_Product _database = new Database_Product();
        public Dictionary<int, string> Categories => _database.SelectProductType();
        public List<Brand> Brands => _database.SelectBrands();


        public bool CreatedProduct(Product product)
        {
            switch (product.ProductGroupID)
            {
                case 1:
                    return _database.InsertFramesIntoDatabase((Frames)product);
                case 2:
                    return _database.InsertContactlensesIntoDatabase((ContactLenses)product);
                case 3:
                    return _database.InsertGlassesIntoDatabase((Glasses)product);
                case 4:
                    return _database.InsertBinocularsIntoDatabase((Binoculars)product);
                case 5:
                    return _database.InsertAccessoriesIntoDatabase((Accessories)product);
            }

            return false;
        }

        public List<Frames> GetFrames() {
            return _database.SelectFrames();
        }

        public List<Product> GetProducts()
        {
            return _database.SelectProductsFromDatabase();
        }

        public bool EditProduct(Product updatedProduct)
        {
            switch (updatedProduct.ProductGroupID)
            {
                case 1:
                    return _database.UpdateFrame((Frames)updatedProduct);
                case 2:
                    return _database.UpdateContactLense((ContactLenses)updatedProduct);
                case 3:
                    return _database.UpdateGlass((Glasses)updatedProduct);
                case 4:
                    return _database.UpdateBinocular((Binoculars)updatedProduct);
                case 5:
                    return _database.UpdateAccessories((Accessories)updatedProduct);
            }

            return false;
        }


        /// <summary>
        /// Written by Anh
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public bool DeleteProduct(Product product)
        {
            bool isDeleted = _database.DeleteProduct(product);
            return isDeleted;
        }
    }
}
