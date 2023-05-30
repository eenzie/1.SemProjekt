using _1.SemesterProjekt.Models;
using _1.SemesterProjekt.Service;
using _1.SemesterProjekt.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _1.SemesterProjekt {
    public partial class Form_Statistics : Form {
        private readonly OrderService _orderService = new OrderService();
        private readonly CustomerService _customerService = new CustomerService();
        private readonly ShopService _shopService = new ShopService();
        public BindingList<Order> Orders { get; set; } = new BindingList<Order>();
        private Employee _employee;
        private Customer _customer;
        private DateTime _start;
        private DateTime _end;
        private Shop _shop;

        public Form_Statistics(Shop shop) {
            InitializeComponent();
            _shop = shop;
        }

        private void Form_Statistics_Load(object sender, EventArgs e) {
            dgv_Stat_OrderResults.DataSource = Orders;
            Customer catchAllCustomer = new Customer(0, "Alle kunder", "", 0, "", "", true);
            List<Customer> customers = new List<Customer>(_customerService.ReadAllCustomers().Prepend(catchAllCustomer));
            cmBox_Stat_Customer.DataSource = customers;
            cmBox_Stat_Customer.DisplayMember = "Name";


            Employee catchAllEmployee = new Employee(0, "Alle ansatte", "", _shop);
            List<Employee> employees = new List<Employee>(_shopService.GetEmployees(_shop).Prepend(catchAllEmployee));
            cmBox_Stat_Employee.DataSource = employees;
            cmBox_Stat_Employee.DisplayMember = "Name";
        }

        private void btn_GetSales_Click(object sender, EventArgs e) {

        }

        private void btn_PrintToFile_Click(object sender, EventArgs e) {
            //Orders
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.Title = "Save statistics to Text File";
            saveFileDialog.Filter = "Text file|*.txt";
            saveFileDialog.ShowDialog();
            
            if (saveFileDialog.FileName != "") {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.OpenFile())) {

                    sw.WriteLine($"Fra Dato: {_start.ToShortDateString()} til Dato: {_end.ToShortDateString()}");
                    sw.WriteLine($"Kundenummer\t\tNavn\t\tDato\t\tAnsat\t\tKøb");
                    foreach (var order in Orders) {
                        sw.WriteLine($"{order.Customer.ID}\t\t{order.Customer.Name}\t\t{order.Date.ToShortDateString()}\t\t{order.Employee.ID}\t\t{order.SubTotal}");
                    }
                    sw.WriteLine($"\t\t\t\t\t\tI alt\t\t{Orders.Sum(c => c.SubTotal)}");
                }
            }

        }

        /// <summary>
        /// Written by Ina
        /// Link label method to open local Help File for the Statistics window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void link_StatesticsHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            string fileName = "Statistik Hjælp.pdf";

            try {
                Process.Start(fileName);
            } catch (Exception ex) {
                MessageBox.Show($"Error opening the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmBox_Stat_Customer_SelectedValueChanged(object sender, EventArgs e) {
            _customer = (Customer)cmBox_Stat_Customer.SelectedValue;
            UpdateStatistics();
        }

        private void dtp_Stat_From_ValueChanged(object sender, EventArgs e) {
            _start = dtp_Stat_From.Value;
            UpdateStatistics();
        }

        private void dtp_Stat_To_ValueChanged(object sender, EventArgs e) {
            _end = dtp_Stat_To.Value;
            UpdateStatistics();
        }

        private void cmBox_Stat_Employee_SelectedValueChanged(object sender, EventArgs e) {
            _employee = (Employee)cmBox_Stat_Employee.SelectedValue;
            UpdateStatistics();
        }

        private void UpdateStatistics() {
            List<Order> orders = _orderService.GetOrdersByDate(_start, _end);

            if (_customer != null) {
                if (_customer.ID != 0) {
                    orders = orders.Where(c => c.Customer.ID == _customer.ID).ToList();
                }
            }

            if (_employee != null) {
                if (_employee.ID != 0) {
                    orders = orders.Where(c => c.Employee.ID == _employee.ID).ToList();
                }
            }

            Orders = new BindingList<Order>(orders);

            if (Orders.Count != 0) {
                tb_Stat_TotalSales.Text = Orders.Sum(c => c.SubTotal).ToString();
                tb_Stat_SalesCount.Text = Orders.Count.ToString();
                tb_Stat_AverageOrder.Text = (Orders.Sum(c => c.SubTotal) / Orders.Count).ToString();
            }
        }
    }
}
