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
    public partial class Form_Statistics : Form
    {
        public Form_Statistics()
        {
            InitializeComponent();
        }

        private void Form_Statistics_Load(object sender, EventArgs e)
        {

        }

        private void btn_GetSales_Click(object sender, EventArgs e)
        {

        }

        private void btn_PrintToFile_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Written by Ina
        /// Link label method to open local Help File for the Statistics window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void link_StatesticsHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string fileName = "Statistik Hjælp.pdf";
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
