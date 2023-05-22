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
        public Form_Customer()
        {
            InitializeComponent();

        }

        private void bt_ShowAllCustomers_Click(object sender, EventArgs e) {
            // tb_CustomerNumSearch

            string input = tb_CustomerNumSearch.Text;
            List<Customer> customers = _customerService.ReadCustomersByName(input);

            Console.WriteLine("");

        }
    }
}
