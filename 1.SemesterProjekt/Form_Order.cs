using _1.SemesterProjekt.Models;
using _1.SemesterProjekt.Service;
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
    public partial class Form_Order : Form
    {
        private Shop _shop;
        private readonly ShopService _shopService = new ShopService();
        private readonly CustomerService _customerService = new CustomerService();
        public BindingList<Customer> Customers = new BindingList<Customer>();

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
            string input = tb_CustomerSearch.Text;


            if (int.TryParse(input, out int parsedInt)) {
                Customers = new BindingList<Customer>() { _customerService.ReadCustomerById(parsedInt) };
            }
            else {
                if (input.Contains("@")) {
                    Customers = new BindingList<Customer>(_customerService.ReadCustomerByEmail(input));
                }
                else {
                    Customers = new BindingList<Customer>(_customerService.ReadCustomersByName(input));
                }
            }

            dgv_Customers.DataSource = Customers;
            dgv_Customers.Columns["IsDeleted"].Visible = false;
        }

        private void bt_SelectCustomer_Click(object sender, EventArgs e)
        {
            if (dgv_Customers.SelectedRows.Count == 0) {
                return;
            }

            Customer customer = (Customer)dgv_Customers.SelectedRows[0].DataBoundItem;
            FillCustomerForm(customer);
        }

        private void FillCustomerForm(Customer customer) {
            tb_CustAdressOut.Text = customer.Address;
            tb_CustMailOut.Text = customer.Email;
            tb_CustNameOut.Text = customer.Name;
            tb_CustPhoneOut.Text = customer.PhoneNo;
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

        /// <summary>
        /// Written by Ina
        /// Link label method to open local Help File for the Order window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void link_OrderHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string fileName = "Ordre Hjælp.pdf";
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
