using _1.SemesterProjekt.Models;
using _1.SemesterProjekt.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _1.SemesterProjekt
{
    // Written by Anton
    public partial class Form_Product_Edit : Form
    {
        // This will store the existing Product
        public Product Product { get; set; }

        private readonly ProductService _productService = new ProductService();
        public event EventHandler<Product> ProductUpdated;

        // This constructor is when we want to Create a new product
        public Form_Product_Edit()
        {
            InitializeComponent();
            InitComboBoxes();
        }

        // This constructor is when we want to update an existing product
        public Form_Product_Edit(Product product)
        {
            InitializeComponent();
            InitComboBoxes();

            Product = product;
            tb_ProductName.Text = Product.Name;
            cbBox_Brand.Text = Product.Brand.ToString();
            tb_ProductPrice.Text = Product.Price.ToString();

            switch (product.ProductGroupID)
            {
                // Frames
                case 1:
                    Frames frames = _productService.GetFrames().FirstOrDefault(x => x.ID == product.ID);
                    Product = frames;
                    tb_frames_length.Text = frames.Length.ToString();
                    tb_frames_width.Text = frames.Width.ToString();
                    tb_frames_colour.Text = frames.Colour;
                    tb_frames_shape.Text = frames.Shape;
                    tb_frames_material.Text = frames.Material;
                    cbBox_ProductType.SelectedIndex = 0;
                    break;

                // Contact Lenses
                case 2:
                    ContactLenses contactLenses = _productService.GetLenses().FirstOrDefault(x => x.ID == product.ID);
                    Product = contactLenses;

                    tb_contactlenses_duration.Text = contactLenses.Duration.ToString();
                    tb_contactlenses_strength.Text = contactLenses.Strength.ToString();
                    cb_Contactlenses_hasUVFilter.Checked = contactLenses.HasUVFilter;
                    cbBox_ProductType.SelectedIndex = 1;
                    break;

                // Glasses
                case 3:
                    Glasses glasses = _productService.GetGlasses().FirstOrDefault(x => x.ID == product.ID);
                    Product = glasses;

                    tb_glasses_coating.Text = glasses.Coating;
                    tb_glasses_type.Text = glasses.GlassType;
                    tb_glasses_strength.Text = glasses.Strength.ToString();
                    cb_glasses_sunglasses.Checked = glasses.IsSunglasses;
                    cbBox_ProductType.SelectedIndex = 2;
                    break;

                // Binoculars
                case 4:
                    Binoculars binoculars = _productService.GetBinoculars().FirstOrDefault(x => x.ID == product.ID);
                    Product = binoculars;
                    tb_binoculars_zoom.Text = binoculars.Zoom;
                    tb_binoculars_type.Text = binoculars.Type;
                    cb_binoculars_isWaterproof.Checked = binoculars.IsWaterproof;
                    cbBox_ProductType.SelectedIndex = 3;
                    break;

                // Accessories
                case 5:
                    Accessories accessories = _productService.GetAccessories().FirstOrDefault(x => x.ID == product.ID);
                    Product = accessories;

                    tb_Acces_Colour.Text = accessories.Colour;
                    tb_Acces_Type.Text = accessories.Type;
                    cbBox_ProductType.SelectedIndex = 4;
                    break;
            }
        }

        private void InitComboBoxes()
        {
            List<ProductCategory> categories = _productService.Categories;
            List<Brand> brands = _productService.Brands;

            cbBox_Brand.DataSource = brands;
            cbBox_Brand.DisplayMember = "Name";

            cbBox_ProductType.DataSource = categories.ToList();
            cbBox_ProductType.DisplayMember = "Name";
        }

        /// <summary>
        /// Written by Anh and Ina
        /// Glasses
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_SaveGlasses_Click(object sender, EventArgs e)
        {
            // We create a new product
            if (Product == default)
            {
                Product product = ExtractProductInfoFromForm(3);

                string coating = tb_glasses_coating.Text;
                string type = tb_glasses_type.Text;
                string strengthstr = tb_glasses_strength.Text;
                decimal strength;
                bool sunglasses = cb_glasses_sunglasses.Checked;

                if (!decimal.TryParse(strengthstr, out strength))
                {
                    Console.WriteLine("");
                    return;
                }

                Product = new Glasses(product,strength, type, coating, sunglasses);

                bool success = _productService.CreatedProduct(Product);

                if (success)
                {
                    MessageBox.Show("Glas er nu oprettet i systemet.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Close the current form
                }
                else
                {
                    MessageBox.Show("Kunne desværre ikke oprette glas. Prøv venligst igen.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // We update existing product
            else
            {
                Product product = ExtractProductInfoFromForm(3);
                product.ID = Product.ID;
                Product.Name = product.Name;
                Product.Brand = product.Brand;
                Product.Price = product.Price;

                decimal strength = decimal.Parse(tb_glasses_strength.Text);
                string glassType = tb_glasses_type.Text;
                string coating = tb_glasses_coating.Text;
                bool isSunglasses = cb_glasses_sunglasses.Checked;
                Glasses glasses = new Glasses(product, strength, glassType, coating, isSunglasses);

                // Call the ProductService to update the product in the database
                bool success = _productService.EditProduct(Product);

                if (success)
                {
                    MessageBox.Show("Glas er nu opdateret i systemet.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kunne desværre ikke opdatere glas. Prøv venligst igen.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Written by Anh and Ina
        /// Creating new frames
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_frames_save_Click(object sender, EventArgs e)
        {
            // We create a new product
            if (Product == default)
            {
                Product product = ExtractProductInfoFromForm(1);

                string lengthstr = tb_frames_length.Text;
                decimal length;
                string widthstr = tb_frames_width.Text;
                decimal width;
                string colour = tb_frames_colour.Text;
                string shape = tb_frames_shape.Text;
                string material = tb_frames_material.Text;

                if (!decimal.TryParse(lengthstr, out length))
                {
                    Console.WriteLine("");
                    return;
                }

                if (!decimal.TryParse(widthstr, out width))
                {
                    Console.WriteLine("");
                    return;
                }

                Product = new Frames(product,length, width, colour, material, shape);

               bool success = _productService.CreatedProduct(Product);

                if (success)
                {
                    MessageBox.Show("Brillestellet er nu oprettet i systemet.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Close the current form
                }
                else
                {
                    MessageBox.Show("Kunne desværre ikke oprette brillestellet. Prøv venligst igen.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // We update existing product
            else
            {
                Product product = ExtractProductInfoFromForm(1);
                product.ID = Product.ID;
                Product.Name = product.Name;
                Product.Brand = product.Brand;
                Product.Price = product.Price;

                decimal length = decimal.Parse(tb_frames_length.Text);
                decimal width = decimal.Parse(tb_frames_width.Text);
                string colour = tb_frames_colour.Text;
                string shape = tb_frames_shape.Text;
                string material = tb_frames_material.Text;
                Frames frames = new Frames(product, length, width, colour, shape, material);

                // Call the ProductService to update the product in the database
                bool success = _productService.EditProduct(Product);

                if (success)
                {
                    MessageBox.Show("Brillestellet er nu opdateret i systemet.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kunne desværre ikke opdatere brillestellet. Prøv venligst igen.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Written by Anh and Ina
        /// Creating new contactlinses
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_lenses_save_Click(object sender, EventArgs e)
        {
            // We create a new product
            if (Product == default)
            {
                Product product = ExtractProductInfoFromForm(2);

                string duration = tb_contactlenses_duration.Text;
                string strengthstr = tb_contactlenses_strength.Text;
                decimal strength;
                bool hasUVFilter = cb_Contactlenses_hasUVFilter.Checked;

                if (!decimal.TryParse(strengthstr, out strength))
                {
                    Console.WriteLine("");
                    return;
                }

                Product = new ContactLenses(product, duration, strength, hasUVFilter);

                bool success = _productService.CreatedProduct(Product);

                if (success)
                {
                    MessageBox.Show("Kontaktlensen er nu oprettet i systemet.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Close the current form
                }
                else
                {
                    MessageBox.Show("Kunne desværre ikke oprette kontaktlensen. Prøv venligst igen.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            // We update existing product
            else
            {
                Product product = ExtractProductInfoFromForm(2);
                product.ID = Product.ID;
                Product.Name = product.Name;
                Product.Brand = product.Brand;
                Product.Price = product.Price;

                string duration = tb_contactlenses_duration.Text;
                decimal strength = decimal.Parse(tb_contactlenses_strength.Text);
                bool hasUVFilter = cb_Contactlenses_hasUVFilter.Checked;
                ContactLenses contactLenses = new ContactLenses(product, duration, strength, hasUVFilter);
                
                // Call the ProductService to update the product in the database
                bool success = _productService.EditProduct(Product);

                if (success)
                {
                    MessageBox.Show("Kontaktlinserne er nu opdateret i systemet.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kunne desværre ikke opdatere kontaktlinserne. Prøv venligst igen.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Written by Anh and Ina
        /// Creating new binoculars
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_bino_save_Click(object sender, EventArgs e) 
        {
            // We create a new product
            if (Product == default)
            {
                Product product = ExtractProductInfoFromForm(4);

                string zoom = tb_binoculars_zoom.Text;
                string type = tb_binoculars_type.Text;
                bool isWaterproof = cb_binoculars_isWaterproof.Checked;

                Product = new Binoculars(product,type, zoom, isWaterproof);

                bool success = _productService.CreatedProduct(Product);

                if (success)
                {
                    MessageBox.Show("Kikkerten er nu oprettet i systemet.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Close the current form
                }
                else
                {
                    MessageBox.Show("Kunne desværre ikke oprette kikkerten. Prøv venligst igen.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // We update existing product
            else
            {
                Product product = ExtractProductInfoFromForm(4);

                product.ID = Product.ID;
                Product.Name = product.Name;
                Product.Brand = product.Brand;
                Product.Price = product.Price;

                string zoom = tb_binoculars_zoom.Text;
                string type = tb_binoculars_type.Text;
                bool isWaterproof = cb_binoculars_isWaterproof.Checked;
                Binoculars binoculars = new Binoculars(product, zoom, type, isWaterproof);

                // Call the ProductService to update the product in the database
                bool success = _productService.EditProduct(binoculars);

                if (success)
                {
                    MessageBox.Show("Kikkerten er nu opdateret i systemet.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kunne desværre ikke opdatere kikkerten. Prøv venligst igen.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Written by Ina and Anh
        /// Save New Accessory event method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_acces_save_Click(object sender, EventArgs e)
        {
            // We create a new product
            if (Product == default)
            {
                Product = ExtractProductInfoFromForm(5);

                string colour = tb_Acces_Colour.Text;
                string type = tb_Acces_Type.Text;
                Accessories accessory = new Accessories(Product, type, colour);
                accessory.Colour = colour;
                accessory.Type = type;

                bool success = _productService.CreatedProduct(accessory);

                if (success)
                {
                    MessageBox.Show("Tilbehøret er nu oprettet i systemet.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Close the current form
                }
                else
                {
                    MessageBox.Show("Kunne desværre ikke oprette tilbehøret. Prøv venligst igen.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // We update existing product
            else
            {
                Product product = ExtractProductInfoFromForm(5);

                product.ID = Product.ID;

                Product.Name = product.Name;
                Product.Brand = product.Brand;
                Product.Price = product.Price;

                string type = tb_Acces_Type.Text;
                string color = tb_Acces_Colour.Text;
                Accessories accessory = new Accessories(product, type , color);

                // Call the ProductService to update the product in the database
                bool success = _productService.EditProduct(accessory);

                if (success)
                {
                    MessageBox.Show("Tilbehøret er nu opdateret i systemet.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kunne desværre ikke opdatere tilbehøret. Prøv venligst igen.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private Product ExtractProductInfoFromForm(int productGroupID)
        {
            string name = tb_ProductName.Text;
            Brand brand = (Brand)cbBox_Brand.SelectedValue;
            string pricestr = tb_ProductPrice.Text;
            decimal price;

            // If we fail to parse
            if (!decimal.TryParse(pricestr, out price))
            {
                return default;
            }

            Product product = new Product(name, brand, price, productGroupID);
            return product;
        }

        private void cbBox_ProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductCategory data = (ProductCategory)cbBox_ProductType.SelectedItem;

            HideAllBoxes();

            switch (data.ID)
            {
                case 1: // frames
                    gb_frames.Visible = true;
                    break;

                case 2: // lenses
                    gb_lenses.Visible = true;
                    break;

                case 3: // Glasses
                    gb_glasses.Visible = true;
                    break;

                case 4: // Bino
                    gb_binoculars.Visible = true;
                    break;

                case 5: // Accessories
                    gb_Accessories.Visible = true;
                    break;
            }
        }

        private void HideAllBoxes()
        {
            gb_frames.Visible = false;
            gb_lenses.Visible = false;
            gb_glasses.Visible = false;
            gb_binoculars.Visible = false;
            gb_Accessories.Visible = false;
        }
    }
}
