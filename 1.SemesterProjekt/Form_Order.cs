using _1.SemesterProjekt.Models;
using _1.SemesterProjekt.Service;
using _1.SemesterProjekt.Services;
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
        private readonly ProductService _productService = new ProductService();
        private readonly OrderService _orderService = new OrderService();
        public BindingList<Customer> Customers = new BindingList<Customer>();
        private ProductCategory _currentCategory = null;
        public BindingList<OrderLine> OrderLines = new BindingList<OrderLine>();
        private Customer _selectedCustomer;
        private Employee _selectedEmployee;

        private Order _order;

        public Form_Order(Shop shop)
        {
            InitializeComponent();
            _shop = shop;
            List<Employee> employees = _shopService.GetEmployees(_shop);

            cmBox_Employee.DataSource = employees;
            cmBox_Employee.DisplayMember = "Name";

            List<ProductCategory> categories = _productService.Categories;
            categories = new List<ProductCategory>(categories.Prepend(new ProductCategory(0, "Alle kategorier")));
            cmBox_ProductType.DataSource = categories;
            cmBox_ProductType.DisplayMember = "Name";

            _order = new Order(shop);
            dgv_OrderLines.DataSource = OrderLines;
            dgv_OrderLines.Columns["ID"].Visible = false;
            dgv_OrderLines.Columns["Order"].Visible = false;
            dgv_OrderLines.Columns["Eyetest"].Visible = false;

            OrderLines.ListChanged += OrderLines_ListChanged;
        }


        /// <summary>
        /// This bind to BindingList's event ListChanged
        /// This will be triggered when our OrderLine List has changed, will update taxes and totals
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderLines_ListChanged(object sender, ListChangedEventArgs e) {
            decimal subtotal = CalculateSubtotal();

            decimal vatRate = 0.25M;

            decimal moms = subtotal * vatRate;
            decimal total = subtotal + moms;

            tb_Subtotal.Text = subtotal.ToString("C");
            tb_VAT.Text = moms.ToString("C");
            tb_TotalSale.Text = total.ToString("C");

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
            _order.Customer = customer;
        }

        private void FillCustomerForm(Customer customer) {
            _selectedCustomer = customer;
            tb_CustAdressOut.Text = customer.Address;
            tb_CustMailOut.Text = customer.Email;
            tb_CustNameOut.Text = customer.Name;
            tb_CustPhoneOut.Text = customer.PhoneNo;
        }

        private void cmBox_ProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductCategory selectCategory = (ProductCategory)cmBox_ProductType.SelectedItem;
            bt_SearchProduct_Click(this, new EventArgs());
        }

        private void bt_SearchProduct_Click(object sender, EventArgs e)
        {
            string input = tb_ProductSearch.Text;
            int? number = null;
            if (int.TryParse(input, out int n))
                number = n;


            ProductCategory selectCategory = (ProductCategory)cmBox_ProductType.SelectedItem;
            if (selectCategory == null) {
                List<Product> productss = _productService.GetProducts();
                dgv_Products.DataSource = productss;
                _currentCategory = null;
                return;
            }

            _currentCategory = selectCategory;

            switch (selectCategory.ID) {
                case 1:

                    List<Frames> productFrames = _productService.GetFrames();
                    if (number is null) {
                        productFrames = new List<Frames>(productFrames.Where(c => c.Name.ToLower().Contains(input.ToLower())));
                    }
                    else {
                        productFrames = new List<Frames>() { productFrames.FirstOrDefault(c => c.ID == number.Value) };
                    }

                    dgv_Products.DataSource = productFrames;

                    break;
                case 2:
                    List<ContactLenses> productLenses = _productService.GetLenses();
                    if (number is null) {
                        productLenses = new List<ContactLenses>(productLenses.Where(c => c.Name.ToLower().Contains(input.ToLower())));
                    }
                    else {
                        productLenses = new List<ContactLenses>() { productLenses.FirstOrDefault(c => c.ID == number.Value) };
                    }

                    dgv_Products.DataSource = productLenses;

                    break;
                case 3:
                    List<Glasses> productGlasses = _productService.GetGlasses();
                    if (number is null) {
                        productGlasses = new List<Glasses>(productGlasses.Where(c => c.Name.ToLower().Contains(input.ToLower())));
                    }
                    else {
                        productGlasses = new List<Glasses>() { productGlasses.FirstOrDefault(c => c.ID == number.Value) };
                    }

                    dgv_Products.DataSource = productGlasses;

                    break;
                case 4:
                    List<Binoculars> productBinos = _productService.GetBinoculars();
                    if (number is null) {
                        productBinos = new List<Binoculars>(productBinos.Where(c => c.Name.ToLower().Contains(input.ToLower())));
                    }
                    else {
                        productBinos = new List<Binoculars>() { productBinos.FirstOrDefault(c => c.ID == number.Value) };
                    }

                    dgv_Products.DataSource = productBinos;

                    break;
                case 5:
                    List<Accessories> productAcc = _productService.GetAccessories();
                    if (number is null) {
                        productAcc = new List<Accessories>(productAcc.Where(c => c.Name.ToLower().Contains(input.ToLower())));
                    }
                    else {
                        productAcc = new List<Accessories>() { productAcc.FirstOrDefault(c => c.ID == number.Value) };
                    }

                    dgv_Products.DataSource = productAcc;

                    break;
                default:
                    List<Product> products = _productService.GetProducts();
                    if (number is null) {
                        products = new List<Product>(products.Where(c => c.Name.ToLower().Contains(input.ToLower())));
                    }
                    else {
                        products = new List<Product>() { products.FirstOrDefault(c => c.ID == number.Value) };
                    }

                    

                    dgv_Products.DataSource = products;
                    break;
            }
        }

        private void bt_SelectProduct_Click(object sender, EventArgs e)
        {

            if (dgv_Products.SelectedRows.Count == 0) {
                return;
            }

            Product product = (Product)dgv_Products.SelectedRows[0].DataBoundItem;
            if (int.TryParse(tb_Amount.Text, out int quantity)){
                // int quantity, decimal salesPrice, Product product, Order order
                OrderLine orderLine = new OrderLine(quantity, product.Price, product);
                OrderLines.Add(orderLine);
            }
        }

        /// <summary>
        /// Written By Anh
        /// This method calculates the subtotal of the order
        /// </summary>
        /// <returns></returns>
        private decimal CalculateSubtotal()
        {
            decimal subtotal = 0;

            // Gennemløb OrderLine instancer som er bindet til vores DataGridView
            foreach (OrderLine orderLine in OrderLines) {
                // Tilføj værdien til subtotalen
                subtotal += orderLine.TotalPrice;
            }

            return subtotal;
        }

        /// <summary>
        /// Written by Anh
        /// This method displays the total price
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_Payment_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;

            Order order = new Order(today, CalculateSubtotal(), _selectedCustomer, _selectedEmployee, _shop);
            order.OrderLines = this.OrderLines.ToList();

            if (_orderService.CreateOrder(order)) {
                MessageBox.Show("Order has been submitted to the database!", "Success", MessageBoxButtons.OK);
                OrderLines.Clear();
                _order = new Order(_shop);
            }
            else {
                MessageBox.Show("Failed to commit the order!", "Failed", MessageBoxButtons.OK);
            }

            
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

            try
            {
                Process.Start(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmBox_Employee_SelectedIndexChanged(object sender, EventArgs e) {
            _selectedEmployee = (Employee)cmBox_Employee.SelectedValue;
        }
    }
}
