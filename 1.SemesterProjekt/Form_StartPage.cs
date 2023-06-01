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

namespace _1.SemesterProjekt
{
    public partial class Form_StartPage : Form
    {

        public Shop SelectedShop { get; set; }

        public Form_StartPage()
        {
            InitializeComponent();
            // Here we listen to the logservice for errors
            // We listen from this window, because it is always open in the background
            LogService.ExceptionCaught += LogService_ExceptionCaught;
        }

        /// <summary>
        /// This will properly notify the user about the error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogService_ExceptionCaught(object sender, string e) {
            MessageBox.Show(e, "There was an exception!", MessageBoxButtons.OK);
        }

        private void Form_StartPage_Load(object sender, EventArgs e)
        {
            ShopService shopService = new ShopService();
            List<Shop> shops = shopService.ReadAllShops();
            lbx_Shops.DataSource = shops.OrderBy(x => x.PostCode).ToList();
        }

        private void bt_Form_Customer_Click(object sender, EventArgs e)
        {
            Form_Customer form_Customer = new Form_Customer();
            form_Customer.ShowDialog();
        }

        private void lbx_Shops_SelectedValueChanged(object sender, EventArgs e)
        {
            SelectedShop = (Shop)lbx_Shops.SelectedValue;
        }

        private void bt_Form_Products_Click(object sender, EventArgs e)
        {
            Form_Product form_Product = new Form_Product(SelectedShop);
            form_Product.ShowDialog();
        }

        private void bt_Orders_Click(object sender, EventArgs e)
        {
            Form_Order form_Order = new Form_Order(SelectedShop);
            form_Order.ShowDialog();
        }

        private void bt_Form_Statistics_Click(object sender, EventArgs e)
        {
            Form_Statistics form_Statistics = new Form_Statistics(SelectedShop);
            form_Statistics.ShowDialog();
        }

        private void bt_Form_IR_Click(object sender, EventArgs e)
        {
            Form_Intelligent_Advisor form_IntelligentAdvisor = new Form_Intelligent_Advisor();
            form_IntelligentAdvisor.ShowDialog();
        }

        /// <summary>
        /// Written by Ina
        /// Link label method to open local Help File for the Start window
        /// </summary>
        /// <param name = "sender" ></ param >
        /// < param name="e"></param>
        private void link_StartHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string fileName = "/HelperFiles/Start Hjælp.pdf";
            string dir = Environment.CurrentDirectory;
            string fullPath = dir + fileName;

            try
            {
                Process.Start(fullPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
