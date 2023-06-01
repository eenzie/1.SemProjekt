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

            dgv_Stat_OrderResults.DataSource = Orders;

            DateTime now = DateTime.Now;
            DateTime startOfMonth = new DateTime(now.Year, now.Month, 1);
            DateTime lastDayOfMonth = startOfMonth.AddMonths(1).AddDays(-1);


            dtp_Stat_From.Value = startOfMonth;
            dtp_Stat_To.Value = lastDayOfMonth;
        }

        private void btn_PrintToFile_Click(object sender, EventArgs e) {
            UpdateStatistics();
            //Orders
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.Title = "Save statistics to Text File";
            saveFileDialog.Filter = "Text file|*.txt";
            saveFileDialog.ShowDialog();

            DateTime _start = dtp_Stat_From.Value;
            DateTime _end = dtp_Stat_To.Value;

            if (saveFileDialog.FileName != "") {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.OpenFile())) {

                    string head = string.Format("{0,-10} {1,-50} {2,-15} {3,-10} {4,-10}", "KundeNr", "Kunde Navn", "Dato", "Ansat", "Køb");
                    string datehead = string.Format("{0,-10} {1,-50} {2,-15} {3,-10} {4,-10}", "", "Fra Dato", _start.ToShortDateString(), "Til Dato", _end.ToShortDateString());
                    sw.WriteLine(datehead);
                    sw.WriteLine();
                    sw.WriteLine(head);
                    foreach (var order in Orders) {
                        string line = string.Format("{0,-10} {1,-50} {2,-15} {3,-10} {4,-10}", order.Customer.ID, order.Customer, order.Date.ToShortDateString(), order.Employee.ID, order.SubTotal);
                        sw.WriteLine(line);
                    }
                    string tail = string.Format("{0,-10} {1,-50} {2,-15} {3,-10} {4,-10}", "", "", "", "I alt", Orders.Sum(c => c.SubTotal));
                    sw.WriteLine();
                    sw.WriteLine(tail);
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
            string fileName = "/HelperFiles/Statistik Hjælp.pdf";
            string dir = Environment.CurrentDirectory;
            string fullPath = dir + fileName;

            try {
                Process.Start(fullPath);
            } catch (Exception ex) {
                MessageBox.Show($"Error opening the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmBox_Stat_Customer_SelectedValueChanged(object sender, EventArgs e) {
            _customer = (Customer)cmBox_Stat_Customer.SelectedValue;
        }


        private void cmBox_Stat_Employee_SelectedValueChanged(object sender, EventArgs e) {
            _employee = (Employee)cmBox_Stat_Employee.SelectedValue;
        }

        private void UpdateStatistics() {
            DateTime _start = dtp_Stat_From.Value;
            _start = new DateTime(_start.Year, _start.Month, _start.Day, 0, 0, 0);
            DateTime _end = dtp_Stat_To.Value;
            _end = new DateTime(_end.Year, _end.Month, _end.Day, 23, 59, 59);

            List<Order> orders = _orderService.GetOrdersByDate(_start, _end);

            if (_customer != null && _customer.ID != 0) {
                orders = orders.Where(c => c.Customer.ID == _customer.ID).ToList();
            }

            if (_employee != null && _employee.ID != 0) {
                orders = orders.Where(c => c.Employee.ID == _employee.ID).ToList();
            }

            Orders = new BindingList<Order>(orders);
            dgv_Stat_OrderResults.DataSource = Orders;

            if (Orders.Count != 0) {
                tb_Stat_TotalSales.Text = Orders.Sum(c => c.SubTotal).ToString("C");
                tb_Stat_SalesCount.Text = Orders.Count.ToString();
                tb_Stat_AverageOrder.Text = (Orders.Sum(c => c.SubTotal) / Orders.Count).ToString("C");

                var timeSpan = _end - _start;
                
                tb_Stat_AverageDay.Text = ((double)Orders.Sum(c => c.SubTotal) / timeSpan.TotalDays).ToString("C");
            }


        }

        private void bt_PrintScreen_Click(object sender, EventArgs e) {
            UpdateStatistics();
        }
    }
}
