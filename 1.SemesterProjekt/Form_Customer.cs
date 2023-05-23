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
    public partial class Form_Customer : Form
    {
        private CustomerService _customerService = new CustomerService();
        public BindingList<Customer> Customers { get; set; } = new BindingList<Customer>();

        private void Form_Customer_Load(object sender, EventArgs e)
        {

        }

        public Form_Customer()
        {
            InitializeComponent();
        }

        private void bt_ShowAllCustomers_Click(object sender, EventArgs e)
        {
            Customers = new BindingList<Customer>(_customerService.ReadAllCustomers());

            dgv_Customers.DataSource = Customers;
            dgv_Customers.Columns["IsDeleted"].Visible = false;
        }

        private void bt_SearchCustomer_Click(object sender, EventArgs e)
        {
            string input = tb_CustomerSearch.Text;
            string postcodeString = cmBox_PostCode.Text;
            int? postcode = null;

            if (!string.IsNullOrWhiteSpace(postcodeString)) {
                if (int.TryParse(postcodeString, out int _postcode)){
                    postcode = _postcode;
                }
            }

            if (int.TryParse(input, out int parsedInt))
            {
                Customers = new BindingList<Customer>() { _customerService.ReadCustomerById(parsedInt) };
            }
            else
            {
                Customers = new BindingList<Customer>(_customerService.ReadCustomersByName(input, postcode));
            }

            dgv_Customers.DataSource = Customers;
            dgv_Customers.Columns["IsDeleted"].Visible = false;
        }

        private void bt_NewCustomer_Click(object sender, EventArgs e) {
            var form_Customer_Edit = new Form_Customer_Edit();
            form_Customer_Edit.ShowDialog();
        }
    }
}
