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

namespace _1.SemesterProjekt
{
    public partial class Form_Order : Form
    {
        private Shop _shop;
        private readonly ShopService _shopService = new ShopService();
        public Form_Order(Shop shop)
        {
            InitializeComponent();
            _shop = shop;
            List<Employee> employees = _shopService.GetEmployees(_shop);

            cmBox.DataSource = employees;
            cmBox.DisplayMember = "Name";
        }

        private void Form_Order_Load(object sender, EventArgs e)
        {

        }

        private void bt_SearchCustomer_Click(object sender, EventArgs e)
        {

        }

        private void bt_SelectCustomer_Click(object sender, EventArgs e)
        {

        }

        private void cmBox_ProductType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_SearchProduct_Click(object sender, EventArgs e)
        {

        }

        private void bt_SelectProduct_Click(object sender, EventArgs e)
        {

        }

        private void bt_Payment_Click(object sender, EventArgs e)
        {

        }
    }
}
