using _1.SemesterProjekt.Models;
using _1.SemesterProjekt.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        /// Written by Anh
        /// This deletes the selected row of a product
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

                // Fjerner det valgte produktlinje 
                dgv_Products.Rows.Remove(selectedRow);
            }
        }
    }
