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
    public partial class Form_StartPage : Form
    {
        public Form_StartPage()
        {
            InitializeComponent();
        }

        private void Form_StartPage_Load(object sender, EventArgs e)
        {

        }

        private void bt_Form_Customer_Click(object sender, EventArgs e)
        {
            Form_Customer form_Customer = new Form_Customer();
            form_Customer.ShowDialog();
        }

        private void bt_Form_Employee_Click(object sender, EventArgs e)
        {

        }

        private void bt_Form_Products_Click(object sender, EventArgs e)
        {
            Form_Product form_Product = new Form_Product();
            form_Product.ShowDialog();
        }

        private void bt_Form_Eyetest_Click(object sender, EventArgs e)
        {

        }

        private void bt_Form_Statistics_Click(object sender, EventArgs e)
        {

        }
    }
}
