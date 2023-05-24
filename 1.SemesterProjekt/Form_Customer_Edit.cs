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
        public event EventHandler<Customer> CustomerCreated;
        public event EventHandler<Customer> CustomerUpdated;

        private readonly CustomerService _customerService;
        private Customer _customer;
        public Form_Customer_Edit()
        {
            InitializeComponent();
            _customerService = new CustomerService();
            groupBox1.Visible = false;
        }

        public Form_Customer_Edit(Customer customer)
        {
            InitializeComponent();
            _customerService = new CustomerService();
            _customer = customer;

            tb_CustomerName.Text = _customer.Name;
            tb_CustomerAddress.Text = _customer.Address;
            tb_CustomerPhone.Text = _customer.PhoneNo;
            tb_CustomerMail.Text = _customer.Email;
            num_postcode.Value = _customer.PostCode;
        }

        private void SaveCustomer() {
            string name = tb_CustomerName.Text;
            string address = tb_CustomerAddress.Text;
            string phoneNo = tb_CustomerPhone.Text;
            string mail = tb_CustomerMail.Text;
            int postcode = (int)num_postcode.Value;

            Customer customer = new Customer(name, address, postcode, phoneNo, mail);
            if (_customerService.CreateCustomer(customer)) {
                CustomerCreated.Invoke(this, customer);
                MessageBox.Show("The customer has been registered in the system!", "Customer created!", MessageBoxButtons.OK);
                this.Close();
            }
            else {
                MessageBox.Show("There was a problem registering the customer, make sure the input is correct!", "There was a problem!", MessageBoxButtons.OK);
            }
        }

        private void UpdateCustomer() {
            string name = tb_CustomerName.Text;
            string address = tb_CustomerAddress.Text;
            string phoneNo = tb_CustomerPhone.Text;
            string mail = tb_CustomerMail.Text;
            int postcode = (int)num_postcode.Value;

            Customer customer = new Customer(_customer.ID,name, address, postcode, phoneNo, mail, false);
            if (_customerService.EditCustomer(customer)) {
                CustomerUpdated.Invoke(this, customer);
                MessageBox.Show("The customer has been updated in the system!", "Customer updated!", MessageBoxButtons.OK);
                this.Close();
            }
            else {
                MessageBox.Show("There was a problem updating the customer, make sure the input is correct!", "There was a problem!", MessageBoxButtons.OK);
            }
        }

        private void bt_SaveCustomer_Click(object sender, EventArgs e)
        {
            // Check if we are registering a new customer or updating an existing one
            if (_customer is null) {
                SaveCustomer();
            }
            else {
                if (ckBox_IsDeleted.Checked)
                {
                    if (_customerService.SetCustomerAsIsDeleted(_customer))
                    {
                        MessageBox.Show("Marking customer as deleted", "Success", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to mark customer as deleted", "Failed", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    UpdateCustomer();
                }
            }
        }
    }
}
