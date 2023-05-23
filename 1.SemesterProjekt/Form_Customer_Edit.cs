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
    public partial class Form_Customer_Edit : Form
    {
        private readonly CustomerService _customerService;
        private Customer _customer;
        public Form_Customer_Edit()
        {
            InitializeComponent();
            _customerService = new CustomerService();
            groupBox1.Visible = false;
        }

        private void Form_Customer_Edit_Load(object sender, EventArgs e)
        {

        }

        private void bt_SaveCustomer_Click(object sender, EventArgs e)
        {
            // Check if we are registering a new customer or updating an existing one
            if (_customer is null) {
                // We create a new customer
                string name = tb_CustomerName.Text;
                string address = tb_CustomerAddress.Text;
                string phoneNo = tb_CustomerPhone.Text;
                string mail = tb_CustomerMail.Text;
                int postcode = (int)num_postcode.Value;

                Console.WriteLine("");

                Customer customer = new Customer(name, address, postcode, phoneNo, mail);
                if (_customerService.CreateCustomer(customer)) {
                    MessageBox.Show("The customer has been registered in the system!", "Customer created!", MessageBoxButtons.OK);
                    this.Close();
                }
                else {
                    MessageBox.Show("There was a problem registering the customer, make sure the input is correct!", "There was a problem!", MessageBoxButtons.OK);
                }
            }
            else {
                // Update existing customer
            }
        }
    }
}
