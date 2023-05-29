using _1.SemesterProjekt.Models;
using _1.SemesterProjekt.Service;
using _1.SemesterProjekt.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _1.SemesterProjekt
{
    public partial class Form_Product : Form
    {
        private Shop _currentShop;
        private OrderService _orderService = new OrderService();
        private ProductService _productService = new ProductService();
        public BindingList<Product> Products { get; set; } = new BindingList<Product>();
        public Form_Product(Shop currentShop)
        {
            InitializeComponent();
            _currentShop = currentShop;
        }

        private void Form_Product_Load(object sender, EventArgs e)
        {

        }

        private void bt_SearchProduct_Click(object sender, EventArgs e)
        {
            string input = tb_ProductNumSearch.Text;

            if (int.TryParse(input, out int parsedInt))
            {
                Products = new BindingList<Product>() { _productService.GetProducts().FirstOrDefault(x => x.ID == parsedInt) };
            }
            else
            {
                Products = new BindingList<Product>(_productService.GetProducts().Where(x => x.Name.ToLower().Contains(input.ToLower())).ToList());
            }

            dgv_Products.DataSource = Products;

        }

        private void bt_ShowAllProducts_Click(object sender, EventArgs e)
        {
            Products = new BindingList<Product>(_productService.GetProducts());

            dgv_Products.DataSource = Products;
        }

        private void bt_NewProduct_Click(object sender, EventArgs e)
        {
            Form_Product_Edit form_Product_Edit = new Form_Product_Edit();
            form_Product_Edit.ShowDialog();
        }


        /// <summary>
        /// Written by Anh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_UpdateProduct_Click(object sender, EventArgs e)
        {
            if (dgv_Products.SelectedRows.Count == 0)
            {
                return;
            }

            // Find en måde at få den selected customer i datagridrow
            var row = dgv_Products.SelectedRows[0];
            Product product = (Product)row.DataBoundItem;


            var form_Product_Edit = new Form_Product_Edit(product);
            form_Product_Edit.ProductUpdated += Form_Product_Edit_ProductUpdated;
            form_Product_Edit.ShowDialog();
            form_Product_Edit.ProductUpdated -= Form_Product_Edit_ProductUpdated;

        }

        /// <summary>
        /// Written by Anh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Product_Edit_ProductUpdated(object sender, Product e)
        {
            Product old = Products.FirstOrDefault(p => p.ID == e.ID);
            if (old != default)
            {
                int index = Products.IndexOf(old);
                Products.Remove(old);
                Products.Insert(index, e);
                dgv_Products.Rows[index].Selected = true;
            }
        }

        /// <summary>
        /// Written by Ina
        /// Deletes product, if product is not on an order lines
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_DeleteProduct_Click(object sender, EventArgs e)
        {
            if (dgv_Products.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow selectedRow = dgv_Products.SelectedRows[0];
            Product selectedProduct = (Product)selectedRow.DataBoundItem;

            //get list of orders that include the product.... Method to be written
            List<OrderLine> productOrders = _orderService.GetProductOrderLines(selectedProduct);

            if (productOrders.Count > 0)
            {
                MessageBox.Show("Produktet kan ikke slettes fra systemet, i det der er nogle ordre tilknyttet til produktet", "Kan ikke slette produktet", MessageBoxButtons.OK);
                return;
            }

            var dialogResponse = MessageBox.Show($"Er du sikker på du vil slette produktet {selectedProduct.Name}", "Er du sikker?", MessageBoxButtons.YesNo);

            if (dialogResponse == DialogResult.Yes)
            {
                Products.Remove(selectedProduct);
                _productService.DeleteProduct(selectedProduct);
                MessageBox.Show("Produktet er nu blevet slettet fra systemet", "Produkt slettet", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Written by Ina
        /// Link label method to open local Help File for the Product windows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void link_ProductHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string fileName = "Produkt Hjælp.pdf";
            string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            try
            {
                Process.Start(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
