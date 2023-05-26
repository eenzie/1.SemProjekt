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
            lb_Shop.Text = _currentShop.ToString();
        }

        private void Form_Product_Load(object sender, EventArgs e)
        {

        }

        private void bt_SearchProuct_Click(object sender, EventArgs e)
        {
            string input = tb_ProductNumSearch.Text;
            // string productType = cmBox_ProductType;
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



        private void bt_UpdateProduct_Click(object sender, EventArgs e)
        {
            if (dgv_Products.SelectedRows.Count == 0) {
                return;
            }

            var selectedItem = (Product)dgv_Products.SelectedRows[0].DataBoundItem;
            if (selectedItem == default) {
                return;
            }

            Form_Product_Edit form_Product_Edit = new Form_Product_Edit(selectedItem);
            form_Product_Edit.ShowDialog();

        }

        private void bt_DeleteProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
