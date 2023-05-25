using _1.SemesterProjekt.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;

namespace _1.SemesterProjekt.Repositories {
    public class Database_Product {
        private readonly string ConnectionString = @"Server=mssql3.unoeuro.com;Database=tripshop_dk_db_project;User Id=tripshop_dk;Password=wDafdGbx6ynAkcRzprmt;TrustServerCertificate=True";

#region Create
        private bool InsertProductIntoDatabase(Product product) {
            if (product.Price <= 0) {
                return false;
            }

            if (string.IsNullOrWhiteSpace(product.Name)) {
                return false;
            }

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString)) {
                string insertSqlString = $"insert into Products (Name, Brand, Price, ProductGroupID) output inserted.ID values (@name, {product.Brand.ID}, {product.Price}, {product.ProductGroupID});";
                SqlCommand sqlCommand = new SqlCommand(insertSqlString, sqlConnection);
                sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = product.Name;

                sqlConnection.Open();
                product.ID = (int)sqlCommand.ExecuteScalar();
                return true;
            }
        }




        public bool InsertGlassesIntoDatabase(Glasses glasses) {
            if (!InsertProductIntoDatabase(glasses)) {
                return false;
            }

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString)) {
                int booltoint = (glasses.IsSunglasses) ? 1 : 0;
                string insertqlString = $"insert into Glass (ID, Strength, GlassType, Coating, IsSunglasses) output inserted.ID values ({glasses.ID}, {glasses.Strength.ToString(CultureInfo.InvariantCulture)}, '{glasses.GlassType}', '{glasses.Coating}', {booltoint});";
                SqlCommand sqlCommand = new SqlCommand(insertqlString, sqlConnection);

                sqlConnection.Open();
                glasses.ID = (int)sqlCommand.ExecuteScalar();
                return true;
            }
        }

        #endregion


#region Read

        public List<Brand> SelectBrands() {
            List<Brand> brands = new List<Brand>();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString)) {
                string selectSqlString = $"select * from Brands;";

                SqlCommand sqlCommand = new SqlCommand(selectSqlString, sqlConnection);

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read()) {
                    int id = sqlDataReader.GetInt32(0);
                    string name = sqlDataReader.GetString(1);
                    int? productGroupId = sqlDataReader.GetInt32(2);

                    Brand brand = new Brand(id, name, productGroupId);
                    brands.Add(brand);
                }

            }

            return brands;
        }

        public List<Product> SelectProductsFromDatabase() {
            List<Brand> brands = SelectBrands();
            List<Product> products = new List<Product>();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString)) {
                string selectSqlString = $"select * from Products;";

                SqlCommand sqlCommand = new SqlCommand(selectSqlString, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read()) {
                    int id = sqlDataReader.GetInt32(0);
                    string name = sqlDataReader.GetString(1);
                    int brandID = sqlDataReader.GetInt32(2);
                    decimal price = sqlDataReader.GetDecimal(3);
                    int productGroupID = sqlDataReader.GetInt32(4);

                    Brand brand = brands.Find(c => c.ID == brandID);
                    Product product = new Product(id, name, brand, price, productGroupID);
                }
            }

            return products;
        }

        public Dictionary<int, string> SelectProductType() {
            Dictionary<int, string> data = new Dictionary<int, string>();
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString)) {

                string selectSqlString = $"select * from ProductGroups";

                SqlCommand sqlCommand = new SqlCommand(selectSqlString, sqlConnection);

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read()) {
                    int id = sqlDataReader.GetInt32(0);
                    string name = sqlDataReader.GetString(1);

                    data.Add(id, name);
                }
            }

            return data;
        }

        #endregion

    }
}
