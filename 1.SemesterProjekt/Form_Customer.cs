using _1.SemesterProjekt.Models;
using _1.SemesterProjekt.Service;
using _1.SemesterProjekt.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace _1.SemesterProjekt
{
    public partial class Form_Customer : Form
    {
        private CustomerService _customerService = new CustomerService();
        private OrderService _orderService = new OrderService();

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

            if (!string.IsNullOrWhiteSpace(postcodeString))
            {
                if (int.TryParse(postcodeString, out int _postcode))
                {
                    postcode = _postcode;
                }
            }


            if (int.TryParse(input, out int parsedInt))
            {
                Customers = new BindingList<Customer>() { _customerService.ReadCustomerById(parsedInt) };
            }
            else
            {
                if (input.Contains("@"))
                {
                    Customers = new BindingList<Customer>(_customerService.ReadCustomerByEmail(input));
                }
                else
                {
                    Customers = new BindingList<Customer>(_customerService.ReadCustomersByName(input, postcode));
                }
            }

            dgv_Customers.DataSource = Customers;
            dgv_Customers.Columns["IsDeleted"].Visible = false;
        }

        private void bt_NewCustomer_Click(object sender, EventArgs e)
        {
            var form_Customer_Edit = new Form_Customer_Edit();
            form_Customer_Edit.CustomerCreated += Form_Customer_Edit_CustomerCreated;
            form_Customer_Edit.ShowDialog();
            form_Customer_Edit.CustomerCreated -= Form_Customer_Edit_CustomerCreated;
        }

        private void Form_Customer_Edit_CustomerCreated(object sender, Customer e)
        {
            Customers.Add(e);
        }

        private void bt_UpdateCustomer_Click(object sender, EventArgs e)
        {

            if (dgv_Customers.SelectedRows.Count == 0)
            {
                return;
            }

            // Find en måde at få den selected customer i datagridrow
            var row = dgv_Customers.SelectedRows[0];
            Customer customer = (Customer)row.DataBoundItem;


            var form_Customer_Edit = new Form_Customer_Edit(customer);
            form_Customer_Edit.CustomerUpdated += Form_Customer_Edit_CustomerUpdated;
            form_Customer_Edit.ShowDialog();
            form_Customer_Edit.CustomerUpdated -= Form_Customer_Edit_CustomerUpdated;
        }

        private void Form_Customer_Edit_CustomerUpdated(object sender, Customer e)
        {
            Customer old = Customers.FirstOrDefault(c => c.ID == e.ID);
            if (old != default)
            {
                int index = Customers.IndexOf(old);
                Customers.Remove(old);
                Customers.Insert(index, e);
                dgv_Customers.Rows[index].Selected = true;
            }
        }

        private void bt_DeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgv_Customers.SelectedRows.Count == 0)
            {
                return;
            }


            // Find en måde at få den selected customer i datagridrow
            var row = dgv_Customers.SelectedRows[0];
            Customer customer = (Customer)row.DataBoundItem;

            List<Order> customerOrders = _orderService.GetCustomerOrders(customer);

            if (customerOrders.Count > 0)
            {
                MessageBox.Show("Kunden kan ikke slettet fra systemet, i det der er nogle order tilknyttet til kunden. Brug deaktiver funktionen under redigerer kunde", "Kan ikke slette kunde", MessageBoxButtons.OK);
                return;
            }


            var dialogResponse = MessageBox.Show($"Er du sikker på du vil slette kunden {customer.Name}", "Er du sikker?", MessageBoxButtons.YesNo);

            if (dialogResponse == DialogResult.Yes)
            {
                Customers.Remove(customer);
                _customerService.DeleteCustomer(customer);
                MessageBox.Show("Kunden er nu blevet slettet fra systemet", "Kunden slettet", MessageBoxButtons.OK);
            }

        }

        /// <summary>
        /// Written by Ina
        /// Link label method to open local Help File for the Customer windows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void link_CustomerHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string fileName = "Kunde Hjælp.pdf";
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
