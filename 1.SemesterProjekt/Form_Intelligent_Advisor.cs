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
    public partial class Form_Intelligent_Advisor : Form
    {
        public Form_Intelligent_Advisor()
        {
            InitializeComponent();
        }

        private void Form_Intelligent_Advisor_Load(object sender, EventArgs e)
        {

        }

        private void btn_IR_Search_Click(object sender, EventArgs e)
        {
            ProductService productService = new ProductService();
            List<Frames> frames =  productService.GetFrames();

            string color = cmBox_IR_Colour.SelectedText.ToLower();
            // Sort by color
            if (!string.IsNullOrWhiteSpace(color))
                frames = frames.Where(c => c.Colour.ToLower() == color).ToList();

            Brand brand = (Brand)cmBox_IR_Brand.SelectedItem;
            // Sort by brand
            if (brand != null)
                frames = frames.Where(c => c.Brand == brand).ToList();

            string shape = cmBox_IR_Shape.SelectedText.ToLower();
            // Sort by shape
            if (!string.IsNullOrWhiteSpace(shape))
                frames = frames.Where(c => c.Shape.ToLower() == shape).ToList();

            string material = cmBox_IR_Material.SelectedText.ToLower();
            // Sort by materiel
            if (!string.IsNullOrWhiteSpace(material))
                frames = frames.Where(c => c.Material.ToLower() == material).ToList();

            decimal length = num_IR_Length.Value;
            // Sort by length
            if (length > 0)
                frames = frames.Where(c => c.Length == length).ToList();

            decimal width = num_IR_Width.Value;
            // Sort by width
            if (width > 0)
                frames = frames.Where(c => c.Width == width).ToList();

            decimal minPrice = num_IR_MinPrice.Value;
            // Sort by min price
            if (minPrice > 0)
                frames = frames.Where(c => c.Price >= minPrice).ToList();

            decimal maxPrice = num_IR_MaxPrice.Value;
            // Sort by ma price
            if (maxPrice > 0)
                frames = frames.Where(c => c.Price <= maxPrice).ToList();


            dgv_IR_Result.DataSource = frames;
        }
    }
}
