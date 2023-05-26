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


        /// <summary>
        /// Written by Anton
        /// </summary>
        /// <param name="glasses"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Written by Ina
        /// Method to Create new Accessory product
        /// </summary>
        /// <param name="accessories"></param>
        /// <returns>Returns true if success, false otherwise</returns>
        public bool InsertAccessoriesIntoDatabase(Accessories accessories) {
            if (!InsertProductIntoDatabase(accessories)) {
                return false;
            }

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString)) {
                string insertqlString = $"insert into Accessories (ID, Colour, Type) output inserted.ID values ({accessories.ID}, '{accessories.Colour}', '{accessories.Type}');";
                SqlCommand sqlCommand = new SqlCommand(insertqlString, sqlConnection);

                sqlConnection.Open();
                accessories.ID = (int)sqlCommand.ExecuteScalar();
                return true;
            }
        }

        public bool InsertFramesIntoDatabase(Frames frames)
        {
            if (!InsertProductIntoDatabase(frames))
            {
                return false;
            }
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                string insertqlString = $"insert into Frames (ID, Length, Width, Colour, Material, Shape) output inserted.ID values ({frames.ID}, {frames.Length.ToString(CultureInfo.InvariantCulture)}, {frames.Width.ToString(CultureInfo.InvariantCulture)}, '{frames.Colour}', '{frames.Material}', '{frames.Shape}');";
                SqlCommand sqlCommand = new SqlCommand(insertqlString, sqlConnection);

                sqlConnection.Open();
                frames.ID = (int)sqlCommand.ExecuteScalar();
                return true;
            }
        }

        /// <summary>
        /// Written by Anh
        /// Creating new contactlenses into database
        /// </summary>
        /// <param name="contactlenses"></param>
        /// <returns></returns>
        public bool InsertContactlensesIntoDatabase(ContactLenses contactlenses)
        {
            if (!InsertProductIntoDatabase(contactlenses))
            {
                return false;
            }
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                int booltoint = (contactlenses.HasUVFilter) ? 1 : 0;
                string insertqlString = $"insert into ContactLenses (ID, Duration, Strength, HasUVFilter) output inserted.ID values ({contactlenses.ID}, '{contactlenses.Duration}', {contactlenses.Strength.ToString(CultureInfo.InvariantCulture)}, {booltoint});";

                SqlCommand sqlCommand = new SqlCommand(insertqlString, sqlConnection);

                sqlConnection.Open();
                contactlenses.ID = (int)sqlCommand.ExecuteScalar();
                return true;
            }
        }

        /// <summary>
        /// Written by Anh
        /// Creating new binoculars into database
        /// </summary>
        /// <param name="binoculars"></param>
        /// <returns></returns>
        public bool InsertBinocularsIntoDatabase(Binoculars binoculars)
        {
            if (!InsertProductIntoDatabase(binoculars))
            {
                return false;
            }
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                int booltoint = (binoculars.IsWaterproof) ? 1 : 0;
                string insertqlString = $"insert into Binoculars (ID, Type, Zoom, IsWaterproof) output inserted.ID values ({binoculars.ID}, '{binoculars.Type}', '{binoculars.Zoom}', {booltoint});";
                SqlCommand sqlCommand = new SqlCommand(insertqlString, sqlConnection);

                sqlConnection.Open();
                binoculars.ID = (int)sqlCommand.ExecuteScalar();
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
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read()) {
                    int id = sqlDataReader.GetInt32(0);
                    string name = sqlDataReader.GetString(1);
                    int brandID = sqlDataReader.GetInt32(2);
                    decimal price = sqlDataReader.GetDecimal(3);
                    int productGroupID = sqlDataReader.GetInt32(4);

                    Brand brand = brands.Find(c => c.ID == brandID);
                    Product product = new Product(id, name, brand, price, productGroupID);
                    products.Add(product);
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

        public List<Frames> SelectFrames() {
            List<Frames> frames = new List<Frames>();
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString)) {
                string sqlSelectString = $"select * from Frames;";

                SqlCommand sqlCommand = new SqlCommand(sqlSelectString, sqlConnection);
                sqlConnection.Open();
                List<Product> products = SelectProductsFromDatabase();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read()) {
                    int id = sqlDataReader.GetInt32(0);
                    Product product = products.FirstOrDefault(c => c.ID == id);
                    decimal length = sqlDataReader.GetDecimal(1);
                    decimal width = sqlDataReader.GetDecimal(2);
                    string colour = sqlDataReader.GetString(3);
                    string material = sqlDataReader.GetString(4);
                    string shape = sqlDataReader.GetString(5);
                    Frames frame = new Frames(product, length, width, colour, material, shape);
                    frames.Add(frame);
                }
            }

            return frames;
        }

        #endregion


#region Update
        public bool UpdateProduct(Product updatedProduct)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                string updateSqlString = "UPDATE Product SET " +
                                         "Name = @updatedName, " +
                                         "Brand = @updatedBrand, " +
                                         "Price = @updatedPrice" +
                                         $"WHERE ID = {updatedProduct.ID};";

                SqlCommand sqlCommand = new SqlCommand(updateSqlString, sqlConnection);

                sqlCommand.Parameters.Add("@updatedName", SqlDbType.NVarChar).Value = updatedProduct.Name;
                sqlCommand.Parameters.Add("@updatedBrand", SqlDbType.Int).Value = updatedProduct.Brand;
                sqlCommand.Parameters.Add("@updatedPrice", SqlDbType.Decimal).Value = updatedProduct.Price;

                try
                {
                    sqlConnection.Open();
                    int rowsAffected = sqlCommand.ExecuteNonQuery();

                    //if rowsAffected is greater than zero, then the program found the product and has
                    //updated the customer, otherwise it is false and can't update the product
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    //false indicates that the program fails to update the product
                    return false;
                }
            }
        }


        public bool UpdateFrame(Frames updatedFrame)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                string updateSqlString = "UPDATE Frames SET " +
                                         "Length = @updatedLength, " +
                                         "Width = @updatedWidth, " +
                                         "Colour = @updatedColour" +
                                         "Material = @updatedMaterial" +
                                         "Shape = @updatedShape" +
                                         $"WHERE ID = {updatedFrame.ID};";

                SqlCommand sqlCommand = new SqlCommand(updateSqlString, sqlConnection);

                sqlCommand.Parameters.Add("@updatedLength", SqlDbType.Decimal).Value = updatedFrame.Length;
                sqlCommand.Parameters.Add("@updatedWidth", SqlDbType.Decimal).Value = updatedFrame.Width;
                sqlCommand.Parameters.Add("@updatedColour", SqlDbType.NVarChar).Value = updatedFrame.Colour;
                sqlCommand.Parameters.Add("@updatedMaterial", SqlDbType.NVarChar).Value = updatedFrame.Material;
                sqlCommand.Parameters.Add("@updatedShape", SqlDbType.NVarChar).Value = updatedFrame.Shape;

                try
                {
                    sqlConnection.Open();
                    int rowsAffected = sqlCommand.ExecuteNonQuery();

                    //if rowsAffected is greater than zero, then the program found the product and has
                    //updated the customer, otherwise it is false and can't update the product
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    //false indicates that the program fails to update the product
                    return false;
                }
            }
        }

        public bool UpdateGlas(Glasses updatedGlass)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                string updateSqlString = "UPDATE Glass SET " +
                                         "Strength = @updatedStrength, " +
                                         "GlassType = @updatedGlassType, " +
                                         "Coating = @updatedCoating" +
                                         "IsSunglasses = @updatedIsSunglasses" +
                                         $"WHERE ID = {updatedGlass.ID};";

                SqlCommand sqlCommand = new SqlCommand(updateSqlString, sqlConnection);

                sqlCommand.Parameters.Add("@updatedStrength", SqlDbType.Decimal).Value = updatedGlass.Strength;
                sqlCommand.Parameters.Add("@updatedGlassType", SqlDbType.NVarChar).Value = updatedGlass.GlassType;
                sqlCommand.Parameters.Add("@updatedCoating", SqlDbType.NVarChar).Value = updatedGlass.Coating;
                sqlCommand.Parameters.Add("@updatedIsSunglasses", SqlDbType.Bit).Value = updatedGlass.IsSunglasses;

                try
                {
                    sqlConnection.Open();
                    int rowsAffected = sqlCommand.ExecuteNonQuery();

                    //if rowsAffected is greater than zero, then the program found the product and has
                    //updated the customer, otherwise it is false and can't update the product
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    //false indicates that the program fails to update the product
                    return false;
                }

            }
        }

        public bool UpdateContactLense(ContactLenses updatedContactLense)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                string updateSqlString = "UPDATE ContactLenses SET " +
                                         "Duration = @updatedDuration, " +
                                         "Strength = @updatedStrength, " +
                                         "HasUVFilter = @updatedHasUVFilter" +
                                         $"WHERE ID = {updatedContactLense.ID};";

                SqlCommand sqlCommand = new SqlCommand(updateSqlString, sqlConnection);

                sqlCommand.Parameters.Add("@updatedDuration", SqlDbType.NVarChar).Value = updatedContactLense.Duration;
                sqlCommand.Parameters.Add("@updatedStrength", SqlDbType.Decimal).Value = updatedContactLense.Strength;
                sqlCommand.Parameters.Add("@updatedHasUVFilter", SqlDbType.Bit).Value = updatedContactLense.HasUVFilter;

                try
                {
                    sqlConnection.Open();
                    int rowsAffected = sqlCommand.ExecuteNonQuery();

                    //if rowsAffected is greater than zero, then the program found the product and has
                    //updated the customer, otherwise it is false and can't update the product
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    //false indicates that the program fails to update the product
                    return false;
                }

            }
        }

        public bool UpdateBinocular(Binoculars updatedBinocular)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                string updateSqlString = "UPDATE Binoculars SET " +
                                         "Type = @updatedType, " +
                                         "Zoom = @updatedZoom, " +
                                         "IsWaterproof = @updatedIsWaterproof" +
                                         $"WHERE ID = {updatedBinocular.ID};";

                SqlCommand sqlCommand = new SqlCommand(updateSqlString, sqlConnection);

                sqlCommand.Parameters.Add("@updatedType", SqlDbType.NVarChar).Value = updatedBinocular.Type;
                sqlCommand.Parameters.Add("@updatedZoom", SqlDbType.NVarChar).Value = updatedBinocular.Zoom;
                sqlCommand.Parameters.Add("@updatedIsWaterproof", SqlDbType.TinyInt).Value = updatedBinocular.IsWaterproof;

                try
                {
                    sqlConnection.Open();
                    int rowsAffected = sqlCommand.ExecuteNonQuery();

                    //if rowsAffected is greater than zero, then the program found the product and has
                    //updated the customer, otherwise it is false and can't update the product
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    //false indicates that the program fails to update the product
                    return false;
                }
            }
        }

        public bool UpdateAccessories(Accessories updatedAccessorie)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                string updateSqlString = "UPDATE Accessories SET " +
                                         "Colour = @updatedColour, " +
                                         "Type = @updatedType, " +
                                         $"WHERE ID = {updatedAccessorie.ID};";

                SqlCommand sqlCommand = new SqlCommand(updateSqlString, sqlConnection);

                sqlCommand.Parameters.Add("@updatedColour", SqlDbType.NVarChar).Value = updatedAccessorie.Colour;
                sqlCommand.Parameters.Add("@updatedType", SqlDbType.NVarChar).Value = updatedAccessorie.Type;

                try
                {
                    sqlConnection.Open();
                    int rowsAffected = sqlCommand.ExecuteNonQuery();

                    //if rowsAffected is greater than zero, then the program found the product and has
                    //updated the customer, otherwise it is false and can't update the product
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    //false indicates that the program fails to update the product
                    return false;
                }
            }
        }
        #endregion
    }
}