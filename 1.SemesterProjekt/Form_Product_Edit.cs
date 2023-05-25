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
    public partial class Form_Product_Edit : Form
    {

        // This will store the existing Product
        public Product Model { get; set; }
        private readonly ProductService _productService = new ProductService();


        /// <summary>
        /// This constructor is when we want to Create a new product
        /// </summary>
        public Form_Product_Edit()
        {
            InitializeComponent();
        }


        /// <summary>
        /// This constructor is when we want to update an existing product
        /// </summary>
        /// <param name="product"></param>
        public Form_Product_Edit(Product product)
        {
            InitializeComponent();
            Model = product;
        }

        /// <summary>
        /// Glasses
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_SaveGlasses_Click(object sender, EventArgs e)
        {
            // We create a new product
            if (Model == default)
            {
                Product product = SaveProductFromForm(3);

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

                Model = new Glasses(product.ID, product.Name, product.Brand, product.Price,
                    strength, type, coating, sunglasses);

                _productService.CreatedProduct(Model);


            }
            // We update existing product
            else
            {

            }
        }

<<<<<<< HEAD
        private void btn_bino_save_Click(object sender, EventArgs e)
        {
=======
        /// <summary>
        /// Written by Anh
        /// Creating new frames
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_frames_save_Click(object sender, EventArgs e)
        {
            // We create a new product
            if (Model == default)
            {
                Product product = SaveProductFromForm(1);

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

                Model = new Frames(product.ID, product.Name, product.Brand, product.Price,
                    length, width, colour, shape, material);

                _productService.CreatedProduct(Model);


            }
            // We update existing product
            else
            {

            }
        }

        /// <summary>
        /// Written by Anh
        /// Creating new contactlinses
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_lenses_save_Click(object sender, EventArgs e)
        {
            // We create a new product
            if (Model == default)
            {
                Product product = SaveProductFromForm(2);

                string duration = tb_contactlenses_duration.Text;
                string strengthstr = tb_contactlenses_strength.Text;
                double strength;
                bool hasUVFilter = cb_Contactlenses_hasUVFilter.Checked;

                if (!double.TryParse(strengthstr, out strength))
                {
                    Console.WriteLine("");
                    return;
                }


                Model = new ContactLenses(product.ID, product.Name, product.Brand, product.Price,
                    duration, strength, hasUVFilter);

                _productService.CreatedProduct(Model);


            }
            // We update existing product
            else
            {

            }
        }

        /// <summary>
        /// Written by Anh
        /// Creating new binoculars
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_bino_save_Click(object sender, EventArgs e) 
        {
            // We create a new product
            if (Model == default)
            {
                Product product = SaveProductFromForm(4);

                string zoom = tb_binoculars_zoom.Text;
                string type = tb_binoculars_type.Text;
                bool isWaterproof = cb_binoculars_isWaterproof.Checked;

                Model = new Binoculars(product.ID, product.Name, product.Brand, product.Price,
                    zoom, type, isWaterproof);

                _productService.CreatedProduct(Model);


            }
            // We update existing product
            else
            {

            }
>>>>>>> 035640e (SUI-37: Method creating new frames, contactlenses and binoculars for dabase and services)

        }

        /// <summary>
        /// Written by Ina
        /// Save New Accessory event method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_acces_save_Click(object sender, EventArgs e)
        {
            // We create a new product
            if (Model == default)
            {
                Product product = SaveProductFromForm(5);

                string colour = tb_Acces_Colour.Text;
                string type = tb_Acces_Type.Text;

                Model = new Accessories(product.ID, product.Name, product.Brand, product.Price,
                    type, colour);

                _productService.CreatedProduct(Model);
            }
            // We update existing product
            else
            {

            }
        }


        private Product SaveProductFromForm(int productGroupID)
        {
            string name = tb_ProductName.Text;
            Brand brand = (Brand)cbBox_Brand.SelectedValue;
            string pricestr = tb_ProductPrice.Text;
            int price;

            // If we fail to parse
            if (!int.TryParse(pricestr, out price))
            {
                return default;
            }


            Product product = new Product(name, brand, price, productGroupID);
            return product;
        }

        private void Form_Product_Edit_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> categories = _productService.Categories;
            List<Brand> brands = _productService.Brands;

            cbBox_Brand.DataSource = brands;
            cbBox_Brand.DisplayMember = "Name";

            cbBox_ProductType.DataSource = categories.ToList();
            cbBox_ProductType.DisplayMember = "Value";
        }

        private void cbBox_ProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var data = (KeyValuePair<int, string>)cbBox_ProductType.SelectedItem;

            HideAllBoxes();

            switch (data.Key)
            {
                case 1: // frames
                    gb_frames.Visible = true;
                    Console.WriteLine("");
                    break;

                case 2: // lenses
                    gb_lenses.Visible = true;
                    Console.WriteLine("");
                    break;

                case 3: // Glasses
                    gb_glasses.Visible = true;
                    Console.WriteLine("");
                    break;

                case 4: // Bino
                    gb_binoculars.Visible = true;
                    Console.WriteLine("");
                    break;

                case 5: // Accessories
                    gb_Accessories.Visible = true;
                    Console.WriteLine("");
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
<<<<<<< HEAD

=======
     
>>>>>>> 035640e (SUI-37: Method creating new frames, contactlenses and binoculars for dabase and services)
    }
}
