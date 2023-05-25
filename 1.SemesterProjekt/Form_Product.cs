using _1.SemesterProjekt.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.SemesterProjekt
{
    public partial class Form_Product : Form
    {
        private Shop _currentShop;
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

        }

        private void bt_ShowAllProducts_Click(object sender, EventArgs e)
        {

        }

        private void bt_NewProduct_Click(object sender, EventArgs e)
        {
            Form_Product_Edit form_Product_Edit = new Form_Product_Edit();
            form_Product_Edit.ShowDialog();
        }



        private void bt_UpdateProduct_Click(object sender, EventArgs e)
        {

        }

        private void bt_DeleteProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
