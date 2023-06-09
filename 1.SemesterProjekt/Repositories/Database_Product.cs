﻿using _1.SemesterProjekt.Models;
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
using System.Drawing;
using _1.SemesterProjekt.Services;
using System.Linq.Expressions;

namespace _1.SemesterProjekt.Repositories {
    public class Database_Product : Database_Abstract {

        #region Create
        private bool InsertProductIntoDatabase(Product product) {
            if (product.Price <= 0) {
                return false;
            }

            if (string.IsNullOrWhiteSpace(product.Name)) {
                return false;
            }

            try {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString)) {
                    string insertSqlString = $"insert into Products (Name, Brand, Price, ProductGroupID) output inserted.ID values (@name, {product.Brand.ID}, {product.Price}, {product.ProductGroupID});";
                    SqlCommand sqlCommand = new SqlCommand(insertSqlString, sqlConnection);
                    sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = product.Name;

                    sqlConnection.Open();
                    product.ID = (int)sqlCommand.ExecuteScalar();
                    return true;
                }
            }
            catch (Exception e) {
                LogService.LogError(e.Message, nameof(Database_Product), nameof(InsertProductIntoDatabase));
                return false;
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

            try {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString)) {
                    int booltoint = (glasses.IsSunglasses) ? 1 : 0;
                    string insertqlString = $"insert into Glass (ID, Strength, GlassType, Coating, IsSunglasses) output inserted.ID values ({glasses.ID}, {glasses.Strength.ToString(CultureInfo.InvariantCulture)}, '{glasses.GlassType}', '{glasses.Coating}', {booltoint});";
                    SqlCommand sqlCommand = new SqlCommand(insertqlString, sqlConnection);

                    sqlConnection.Open();
                    glasses.ID = (int)sqlCommand.ExecuteScalar();
                    return true;
                }
            }
            catch (Exception e) {
                LogService.LogError(e.Message, nameof(Database_Product), nameof(InsertGlassesIntoDatabase));
                DeleteProduct(glasses);
                return false;
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
            try {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString)) {
                    string insertqlString = $"insert into Accessories (ID, Colour, Type) output inserted.ID values ({accessories.ID}, '{accessories.Colour}', '{accessories.Type}');";
                    SqlCommand sqlCommand = new SqlCommand(insertqlString, sqlConnection);

                    sqlConnection.Open();
                    accessories.ID = (int)sqlCommand.ExecuteScalar();
                    return true;
                }
            }
            catch (Exception e) {
                LogService.LogError(e.Message, nameof(Database_Product), nameof(InsertAccessoriesIntoDatabase));
                DeleteProduct(accessories);
                return false;
            }
        }

        public bool InsertFramesIntoDatabase(Frames frames) {
            if (!InsertProductIntoDatabase(frames)) {
                return false;
            }
            try {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString)) {
                    string insertqlString = $"insert into Frames (ID, Length, Width, Colour, Material, Shape) output inserted.ID values ({frames.ID}, {frames.Length.ToString(CultureInfo.InvariantCulture)}, {frames.Width.ToString(CultureInfo.InvariantCulture)}, '{frames.Colour}', '{frames.Material}', '{frames.Shape}');";
                    SqlCommand sqlCommand = new SqlCommand(insertqlString, sqlConnection);

                    sqlConnection.Open();
                    frames.ID = (int)sqlCommand.ExecuteScalar();
                    return true;
                }
            }
            catch (Exception e) {
                LogService.LogError(e.Message, nameof(Database_Product), nameof(InsertFramesIntoDatabase));
                DeleteProduct(frames);
                return false;
            }
        }

        /// <summary>
        /// Written by Anh
        /// Creating new contactlenses into database
        /// </summary>
        /// <param name="contactlenses"></param>
        /// <returns></returns>
        public bool InsertContactlensesIntoDatabase(ContactLenses contactlenses) {
    
            if (!InsertProductIntoDatabase(contactlenses)) {
                return false;
            }

            try {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString)) {
                    int booltoint = (contactlenses.HasUVFilter) ? 1 : 0;
                    string insertqlString = $"insert into ContactLenses (ID, Duration, Strength, HasUVFilter) output inserted.ID values ({contactlenses.ID}, '{contactlenses.Duration}', {contactlenses.Strength.ToString(CultureInfo.InvariantCulture)}, {booltoint});";

                    SqlCommand sqlCommand = new SqlCommand(insertqlString, sqlConnection);

                    sqlConnection.Open();
                    contactlenses.ID = (int)sqlCommand.ExecuteScalar();
                    return true;
                }
            }
            catch (Exception e) {
                LogService.LogError(e.Message, nameof(Database_Product), nameof(InsertContactlensesIntoDatabase));
                DeleteProduct(contactlenses);
                return false;
            }
        }

        /// <summary>
        /// Written by Anh
        /// Creating new binoculars into database
        /// </summary>
        /// <param name="binoculars"></param>
        /// <returns></returns>
        public bool InsertBinocularsIntoDatabase(Binoculars binoculars) {
            if (!InsertProductIntoDatabase(binoculars)) {
                return false;
            }

            try {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString)) {
                    int booltoint = (binoculars.IsWaterproof) ? 1 : 0;
                    string insertqlString = $"insert into Binoculars (ID, Type, Zoom, IsWaterproof) output inserted.ID values ({binoculars.ID}, '{binoculars.Type}', '{binoculars.Zoom}', {booltoint});";
                    SqlCommand sqlCommand = new SqlCommand(insertqlString, sqlConnection);

                    sqlConnection.Open();
                    binoculars.ID = (int)sqlCommand.ExecuteScalar();
                    return true;
                }
            }
            catch (Exception e) {
                LogService.LogError(e.Message, nameof(Database_Product), nameof(InsertBinocularsIntoDatabase));
                // If the above failed, we delete from product table, so we don't have a "ghost product"
                DeleteProduct(binoculars);
                return false;
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

        public List<ProductCategory> SelectProductType() {
            List<ProductCategory> categories = new List<ProductCategory>();
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString)) {

                string selectSqlString = $"select * from ProductGroups";

                SqlCommand sqlCommand = new SqlCommand(selectSqlString, sqlConnection);

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read()) {
                    int id = sqlDataReader.GetInt32(0);
                    string name = sqlDataReader.GetString(1);

                    categories.Add(new ProductCategory(id, name));
                }
            }

            return categories;
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


        public List<ContactLenses> SelectLenses() {
            List<ContactLenses> lenses = new List<ContactLenses>();
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString)) {
                string sqlSelectString = $"select * from ContactLenses;";

                SqlCommand sqlCommand = new SqlCommand(sqlSelectString, sqlConnection);
                sqlConnection.Open();
                List<Product> products = SelectProductsFromDatabase();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read()) {
                    int id = sqlDataReader.GetInt32(0);
                    string duration = sqlDataReader.GetString(1);
                    decimal strength = sqlDataReader.GetDecimal(2);
                    bool hasUV = sqlDataReader.GetBoolean(3);

                    Product product = products.FirstOrDefault(c => c.ID == id);



                    ContactLenses lense = new ContactLenses(product, duration, strength, hasUV);
                    lenses.Add(lense);
                }
            }

            return lenses;
        }

        public List<Glasses> SelectGlasses() {
            List<Glasses> glasses = new List<Glasses>();
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString)) {
                string sqlSelectString = $"select * from Glass;";

                SqlCommand sqlCommand = new SqlCommand(sqlSelectString, sqlConnection);
                sqlConnection.Open();
                List<Product> products = SelectProductsFromDatabase();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read()) {
                    int id = sqlDataReader.GetInt32(0);
                    decimal strength = sqlDataReader.GetDecimal(1);
                    string glassType = sqlDataReader.GetString(2);
                    string coating = sqlDataReader.GetString(3);
                    bool isSunGlasses = sqlDataReader.GetBoolean(4);

                    Product product = products.FirstOrDefault(c => c.ID == id);



                    Glasses glass = new Glasses(product, strength, glassType, coating, isSunGlasses);
                    glasses.Add(glass);
                }
            }

            return glasses;
        }


        public List<Binoculars> SelectBinoculars() {
            List<Binoculars> binos = new List<Binoculars>();
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString)) {
                string sqlSelectString = $"select * from Binoculars;";

                SqlCommand sqlCommand = new SqlCommand(sqlSelectString, sqlConnection);
                sqlConnection.Open();
                List<Product> products = SelectProductsFromDatabase();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read()) {
                    int id = sqlDataReader.GetInt32(0);
                    string binoType = sqlDataReader.GetString(2);
                    string zoom = sqlDataReader.GetString(2);
                    bool waterproof = sqlDataReader.GetBoolean(3);

                    Product product = products.FirstOrDefault(c => c.ID == id);

                    Binoculars glass = new Binoculars(product, binoType, zoom, waterproof);
                    binos.Add(glass);
                }
            }

            return binos;
        }


        public List<Accessories> SelectAccessories() {
            List<Accessories> accessories = new List<Accessories>();
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString)) {
                string sqlSelectString = $"select * from Accessories;";

                SqlCommand sqlCommand = new SqlCommand(sqlSelectString, sqlConnection);
                sqlConnection.Open();
                List<Product> products = SelectProductsFromDatabase();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read()) {
                    int id = sqlDataReader.GetInt32(0);
                    string color = sqlDataReader.GetString(1);
                    string type = sqlDataReader.GetString(2);

                    Product product = products.FirstOrDefault(c => c.ID == id);

                    Accessories accessory = new Accessories(product, type, color);
                    accessories.Add(accessory);
                }
            }

            return accessories;
        }


        /// <summary>
        /// Written by Ina
        /// Method to read list of Eyetests
        /// </summary>
        /// <returns>List of eyetests</returns>
        public List<Eyetest> SelectEyeTests() {
            List<Eyetest> eyetests = new List<Eyetest>();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString)) {
                string selectSqlString = $"select * from Eyetests;";

                SqlCommand sqlCommand = new SqlCommand(selectSqlString, sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read()) {
                    int id = sqlDataReader.GetInt32(0);
                    decimal price = sqlDataReader.GetDecimal(1);
                    int customerID = sqlDataReader.GetInt32(2);

                    Eyetest eyetest = new Eyetest(id, price, customerID);

                    eyetests.Add(eyetest);
                }
            }

            return eyetests;
        }

        #endregion


        #region Update
        /// <summary>
        /// Written by Anton
        /// Emthod to update existing products
        /// </summary>
        /// <param name="updatedProduct"></param>
        /// <returns></returns>
        public bool UpdateProduct(Product updatedProduct) {
            try {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString)) {
                    string updateSqlString = "UPDATE Products SET " +
                                             "Name = @updatedName, " +
                                             "Brand = @updatedBrand, " +
                                             "Price = @updatedPrice " +
                                             $"WHERE ID = {updatedProduct.ID};";

                    SqlCommand sqlCommand = new SqlCommand(updateSqlString, sqlConnection);

                    sqlCommand.Parameters.Add("@updatedName", SqlDbType.NVarChar).Value = updatedProduct.Name;
                    sqlCommand.Parameters.Add("@updatedBrand", SqlDbType.Int).Value = updatedProduct.Brand.ID;
                    sqlCommand.Parameters.Add("@updatedPrice", SqlDbType.Decimal).Value = updatedProduct.Price;

                    sqlConnection.Open();
                    int rowsAffected = sqlCommand.ExecuteNonQuery();

                    //if rowsAffected is greater than zero, then the program found the product and has
                    //updated the customer, otherwise it is false and can't update the product
                    return rowsAffected > 0;

                }
            } catch (Exception e) {
                LogService.LogError(e.Message, nameof(Database_Product), nameof(UpdateProduct));
                return false;
            }
        }

        /// <summary>
        /// Written by Anh
        /// </summary>
        /// <param name="updatedFrame"></param>
        /// <returns></returns>
        public bool UpdateFrame(Frames updatedFrame) {
            try {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString)) {
                    string updateSqlString = "UPDATE Frames SET " +
                                             "Length = @updatedLength, " +
                                             "Width = @updatedWidth, " +
                                             "Colour = @updatedColour, " +
                                             "Material = @updatedMaterial, " +
                                             "Shape = @updatedShape " +
                                             $"WHERE ID = {updatedFrame.ID};";

                    SqlCommand sqlCommand = new SqlCommand(updateSqlString, sqlConnection);

                    sqlCommand.Parameters.Add("@updatedLength", SqlDbType.Decimal).Value = updatedFrame.Length;
                    sqlCommand.Parameters.Add("@updatedWidth", SqlDbType.Decimal).Value = updatedFrame.Width;
                    sqlCommand.Parameters.Add("@updatedColour", SqlDbType.NVarChar).Value = updatedFrame.Colour;
                    sqlCommand.Parameters.Add("@updatedMaterial", SqlDbType.NVarChar).Value = updatedFrame.Material;
                    sqlCommand.Parameters.Add("@updatedShape", SqlDbType.NVarChar).Value = updatedFrame.Shape;

                    sqlConnection.Open();
                    int rowsAffected = sqlCommand.ExecuteNonQuery();

                    //if rowsAffected is greater than zero, then the program found the product and has
                    //updated the customer, otherwise it is false and can't update the product
                    return rowsAffected > 0;

                }
            } catch (Exception e) {
                LogService.LogError(e.Message, nameof(Database_Product), nameof(UpdateFrame));
                return false;
            }
        }

        /// <summary>
        /// Written by Anton
        /// </summary>
        /// <param name="updatedGlass"></param>
        /// <returns></returns>
        public bool UpdateGlass(Glasses updatedGlass) {
            try {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString)) {
                    string updateSqlString = "UPDATE Glass SET " +
                                             "Strength = @updatedStrength, " +
                                             "GlassType = @updatedGlassType, " +
                                             "Coating = @updatedCoating, " +
                                             "IsSunglasses = @updatedIsSunglasses " +
                                             $"WHERE ID = {updatedGlass.ID};";

                    SqlCommand sqlCommand = new SqlCommand(updateSqlString, sqlConnection);

                    sqlCommand.Parameters.Add("@updatedStrength", SqlDbType.Decimal).Value = updatedGlass.Strength;
                    sqlCommand.Parameters.Add("@updatedGlassType", SqlDbType.NVarChar).Value = updatedGlass.GlassType;
                    sqlCommand.Parameters.Add("@updatedCoating", SqlDbType.NVarChar).Value = updatedGlass.Coating;
                    sqlCommand.Parameters.Add("@updatedIsSunglasses", SqlDbType.Bit).Value = updatedGlass.IsSunglasses;

                    sqlConnection.Open();
                    int rowsAffected = sqlCommand.ExecuteNonQuery();

                    //if rowsAffected is greater than zero, then the program found the product and has
                    //updated the customer, otherwise it is false and can't update the product
                    return rowsAffected > 0;
                }
            } catch (Exception e) {
                LogService.LogError(e.Message, nameof(Database_Product), nameof(UpdateGlass));
                return false;
            }
        }

        /// <summary>
        /// Written by Anh
        /// </summary>
        /// <param name="updatedContactLense"></param>
        /// <returns></returns>
        public bool UpdateContactLense(ContactLenses updatedContactLense) {
            try {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString)) {
                    string updateSqlString = "UPDATE ContactLenses SET " +
                                             "Duration = @updatedDuration, " +
                                             "Strength = @updatedStrength, " +
                                             "HasUVFilter = @updatedHasUVFilter " +
                                             $"WHERE ID = {updatedContactLense.ID};";

                    SqlCommand sqlCommand = new SqlCommand(updateSqlString, sqlConnection);

                    sqlCommand.Parameters.Add("@updatedDuration", SqlDbType.NVarChar).Value = updatedContactLense.Duration;
                    sqlCommand.Parameters.Add("@updatedStrength", SqlDbType.Decimal).Value = updatedContactLense.Strength;
                    sqlCommand.Parameters.Add("@updatedHasUVFilter", SqlDbType.Bit).Value = updatedContactLense.HasUVFilter;

                    sqlConnection.Open();
                    int rowsAffected = sqlCommand.ExecuteNonQuery();

                    //if rowsAffected is greater than zero, then the program found the product and has
                    //updated the customer, otherwise it is false and can't update the product
                    return rowsAffected > 0;


                }
            } catch (Exception e) {
                LogService.LogError(e.Message, nameof(Database_Product), nameof(UpdateContactLense));
                return false;
            }
        }

        /// <summary>
        /// Written by Anh
        /// </summary>
        /// <param name="updatedBinocular"></param>
        /// <returns></returns>
        public bool UpdateBinocular(Binoculars updatedBinocular) {
            try {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString)) {
                    string updateSqlString = "UPDATE Binoculars SET " +
                                             "Type = @updatedType, " +
                                             "Zoom = @updatedZoom, " +
                                             "IsWaterproof = @updatedIsWaterproof " +
                                             $"WHERE ID = {updatedBinocular.ID};";

                    SqlCommand sqlCommand = new SqlCommand(updateSqlString, sqlConnection);

                    sqlCommand.Parameters.Add("@updatedType", SqlDbType.NVarChar).Value = updatedBinocular.Type;
                    sqlCommand.Parameters.Add("@updatedZoom", SqlDbType.NVarChar).Value = updatedBinocular.Zoom;
                    sqlCommand.Parameters.Add("@updatedIsWaterproof", SqlDbType.TinyInt).Value = updatedBinocular.IsWaterproof;

                    sqlConnection.Open();
                    int rowsAffected = sqlCommand.ExecuteNonQuery();

                    //if rowsAffected is greater than zero, then the program found the product and has
                    //updated the customer, otherwise it is false and can't update the product
                    return rowsAffected > 0;

                }
            } catch (Exception e) {
                LogService.LogError(e.Message, nameof(Database_Product), nameof(UpdateBinocular));
                return false;
            }
        }

        /// <summary>
        /// Written by Ina
        /// </summary>
        /// <param name="updatedAccessorie"></param>
        /// <returns></returns>
        public bool UpdateAccessories(Accessories updatedAccessorie) {
            try {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString)) {
                    string updateSqlString = "UPDATE Accessories SET " +
                                             "Colour = @updatedColour, " +
                                             "Type = @updatedType " +
                                             $"WHERE ID = {updatedAccessorie.ID};";

                    SqlCommand sqlCommand = new SqlCommand(updateSqlString, sqlConnection);

                    sqlCommand.Parameters.Add("@updatedColour", SqlDbType.NVarChar).Value = updatedAccessorie.Colour;
                    sqlCommand.Parameters.Add("@updatedType", SqlDbType.NVarChar).Value = updatedAccessorie.Type;

                    sqlConnection.Open();
                    int rowsAffected = sqlCommand.ExecuteNonQuery();

                    //if rowsAffected is greater than zero, then the program found the product and has
                    //updated the customer, otherwise it is false and can't update the product
                    return rowsAffected > 0;
                }
            } catch (Exception e) {
                LogService.LogError(e.Message, nameof(Database_Product), nameof(UpdateAccessories));
                return false;
            }
        }
        #endregion

        /// <summary>
        /// Written by Anh
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public bool DeleteProduct(Product product) {
            try {
                // //This using statement ensures that the SqlConnection object
                //is disposed of properly after its usage. It establishes a connection to the database
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString)) {
                    string deleteSqlString = $"DELETE FROM Products WHERE Id = {product.ID}";

                    using (SqlCommand sqlCommand = new SqlCommand(deleteSqlString, sqlConnection)) {


                        sqlConnection.Open();
                        int rowsAffected = sqlCommand.ExecuteNonQuery();

                        //if rowsAffected is greater than zero, then the program found the customer and has
                        //deleted the customer, otherwise it is false and can't delete the customer
                        return rowsAffected > 0;
                    }
                }
            } catch (Exception e) {
                LogService.LogError(e.Message, nameof(Database_Product), nameof(DeleteProduct));
                return false;
            }
        }
    }
}