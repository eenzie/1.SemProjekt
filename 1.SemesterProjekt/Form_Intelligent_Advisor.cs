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

namespace _1.SemesterProjekt
{
    public partial class Form_Intelligent_Advisor : Form
    {
        public Form_Intelligent_Advisor()
        {
            InitializeComponent();
            cmBox_IR_SortPrice.Text = "Høj til lav pris";
        }

        private void Form_Intelligent_Advisor_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Written by Anh and Ina
        /// Main search method that filters and sorts the results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_IR_Search_Click(object sender, EventArgs e)
        {
            ProductService productService = new ProductService();
            List<Frames> frames =  productService.GetFrames();

            string color = cmBox_IR_Colour.Text.ToLower();
            // Filter by color
            if (!string.IsNullOrWhiteSpace(color))
                frames = frames.Where(c => c.Colour.ToLower() == color).ToList();

            string brand = cmBox_IR_Brand.Text.ToLower();
            // Filter by brand
            if (!string.IsNullOrWhiteSpace(brand))
                frames = frames.Where(c => c.Brand.Name.ToLower() == brand).ToList();

            string shape = cmBox_IR_Shape.Text.ToLower();
            // Filter by shape
            if (!string.IsNullOrWhiteSpace(shape))
                frames = frames.Where(c => c.Shape.ToLower() == shape).ToList();

            string material = cmBox_IR_Material.Text.ToLower();
            // Filter by materiel
            if (!string.IsNullOrWhiteSpace(material))
                frames = frames.Where(c => c.Material.ToLower() == material).ToList();

            decimal length = num_IR_Length.Value;
            // Filter by length
            if (length > 0)
                frames = frames.Where(c => c.Length == length).ToList();

            decimal width = num_IR_Width.Value;
            // Filter by width
            if (width > 0)
                frames = frames.Where(c => c.Width == width).ToList();

            decimal minPrice = num_IR_MinPrice.Value;
            // Filter by min price
            if (minPrice > 0)
                frames = frames.Where(c => c.Price >= minPrice).ToList();

            decimal maxPrice = num_IR_MaxPrice.Value;
            // Filter by max price
            if (maxPrice > 0)
                frames = frames.Where(c => c.Price <= maxPrice).ToList();

            string sortByPrice = cmBox_IR_SortPrice.Text;
            // sort by price, asc or desc
            if (sortByPrice == "Lav til høj pris")
                frames = frames.OrderBy(c => c.Price).ToList();
            else if (sortByPrice == "Høj til lav pris")
                frames = frames.OrderByDescending(c => c.Price).ToList();


            dgv_IR_Result.DataSource = frames;
        }

        /// <summary>
        /// Written by Ina
        /// Link label method to open local Help File for the Intelligent Advisor window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void link_IRHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string fileName = "Intelligent Rådgivning Hjælp.pdf";

            try
            {
                Process.Start(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
