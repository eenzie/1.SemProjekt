namespace _1.SemesterProjekt
{
    partial class Form_Statistics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmBox_Stat_Customer = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_Stat_From = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_Stat_To = new System.Windows.Forms.DateTimePicker();
            this.dgv_Stat_OrderResults = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_Stat_TotalSales = new System.Windows.Forms.TextBox();
            this.tb_Stat_SalesCount = new System.Windows.Forms.TextBox();
            this.tb_Stat_AverageDay = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_Stat_AverageOrder = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_PrintToFile = new System.Windows.Forms.Button();
            this.link_StatesticsHelp = new System.Windows.Forms.LinkLabel();
            this.cmBox_Stat_Employee = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.bt_PrintScreen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stat_OrderResults)).BeginInit();
            this.SuspendLayout();
            // 
            // cmBox_Stat_Customer
            // 
            this.cmBox_Stat_Customer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBox_Stat_Customer.FormattingEnabled = true;
            this.cmBox_Stat_Customer.Location = new System.Drawing.Point(179, 239);
            this.cmBox_Stat_Customer.Margin = new System.Windows.Forms.Padding(4);
            this.cmBox_Stat_Customer.Name = "cmBox_Stat_Customer";
            this.cmBox_Stat_Customer.Size = new System.Drawing.Size(327, 32);
            this.cmBox_Stat_Customer.TabIndex = 11;
            this.cmBox_Stat_Customer.SelectedValueChanged += new System.EventHandler(this.cmBox_Stat_Customer_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kunde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Datoer";
            // 
            // dtp_Stat_From
            // 
            this.dtp_Stat_From.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Stat_From.Location = new System.Drawing.Point(242, 115);
            this.dtp_Stat_From.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_Stat_From.Name = "dtp_Stat_From";
            this.dtp_Stat_From.Size = new System.Drawing.Size(263, 32);
            this.dtp_Stat_From.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Fra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Til";
            // 
            // dtp_Stat_To
            // 
            this.dtp_Stat_To.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Stat_To.Location = new System.Drawing.Point(242, 164);
            this.dtp_Stat_To.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_Stat_To.Name = "dtp_Stat_To";
            this.dtp_Stat_To.Size = new System.Drawing.Size(263, 32);
            this.dtp_Stat_To.TabIndex = 17;
            // 
            // dgv_Stat_OrderResults
            // 
            this.dgv_Stat_OrderResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Stat_OrderResults.Location = new System.Drawing.Point(564, 15);
            this.dgv_Stat_OrderResults.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Stat_OrderResults.Name = "dgv_Stat_OrderResults";
            this.dgv_Stat_OrderResults.RowHeadersWidth = 51;
            this.dgv_Stat_OrderResults.Size = new System.Drawing.Size(745, 321);
            this.dgv_Stat_OrderResults.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(559, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Total salg";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(559, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 29);
            this.label7.TabIndex = 22;
            this.label7.Text = "Antal salg";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(873, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(235, 29);
            this.label8.TabIndex = 23;
            this.label8.Text = "Gennemsnitssalg / dag";
            // 
            // tb_Stat_TotalSales
            // 
            this.tb_Stat_TotalSales.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Stat_TotalSales.Location = new System.Drawing.Point(692, 363);
            this.tb_Stat_TotalSales.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Stat_TotalSales.Name = "tb_Stat_TotalSales";
            this.tb_Stat_TotalSales.Size = new System.Drawing.Size(145, 32);
            this.tb_Stat_TotalSales.TabIndex = 24;
            this.tb_Stat_TotalSales.Text = "oooo";
            // 
            // tb_Stat_SalesCount
            // 
            this.tb_Stat_SalesCount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Stat_SalesCount.Location = new System.Drawing.Point(692, 411);
            this.tb_Stat_SalesCount.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Stat_SalesCount.Name = "tb_Stat_SalesCount";
            this.tb_Stat_SalesCount.Size = new System.Drawing.Size(145, 32);
            this.tb_Stat_SalesCount.TabIndex = 25;
            this.tb_Stat_SalesCount.Text = "oooo";
            // 
            // tb_Stat_AverageDay
            // 
            this.tb_Stat_AverageDay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Stat_AverageDay.Location = new System.Drawing.Point(1163, 363);
            this.tb_Stat_AverageDay.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Stat_AverageDay.Name = "tb_Stat_AverageDay";
            this.tb_Stat_AverageDay.Size = new System.Drawing.Size(145, 32);
            this.tb_Stat_AverageDay.TabIndex = 26;
            this.tb_Stat_AverageDay.Text = "oooo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(274, 37);
            this.label10.TabIndex = 29;
            this.label10.Text = "Indtast ønskede data";
            // 
            // tb_Stat_AverageOrder
            // 
            this.tb_Stat_AverageOrder.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Stat_AverageOrder.Location = new System.Drawing.Point(1163, 411);
            this.tb_Stat_AverageOrder.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Stat_AverageOrder.Name = "tb_Stat_AverageOrder";
            this.tb_Stat_AverageOrder.Size = new System.Drawing.Size(145, 32);
            this.tb_Stat_AverageOrder.TabIndex = 31;
            this.tb_Stat_AverageOrder.Text = "oooo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(873, 411);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(253, 29);
            this.label11.TabIndex = 30;
            this.label11.Text = "Gennemsnitssalg / ordre";
            // 
            // btn_PrintToFile
            // 
            this.btn_PrintToFile.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PrintToFile.Location = new System.Drawing.Point(1105, 476);
            this.btn_PrintToFile.Margin = new System.Windows.Forms.Padding(4);
            this.btn_PrintToFile.Name = "btn_PrintToFile";
            this.btn_PrintToFile.Size = new System.Drawing.Size(204, 48);
            this.btn_PrintToFile.TabIndex = 32;
            this.btn_PrintToFile.Text = "Print til fil";
            this.btn_PrintToFile.UseVisualStyleBackColor = true;
            this.btn_PrintToFile.Click += new System.EventHandler(this.btn_PrintToFile_Click);
            // 
            // link_StatesticsHelp
            // 
            this.link_StatesticsHelp.AutoSize = true;
            this.link_StatesticsHelp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_StatesticsHelp.Location = new System.Drawing.Point(14, 9);
            this.link_StatesticsHelp.Name = "link_StatesticsHelp";
            this.link_StatesticsHelp.Size = new System.Drawing.Size(234, 24);
            this.link_StatesticsHelp.TabIndex = 51;
            this.link_StatesticsHelp.TabStop = true;
            this.link_StatesticsHelp.Text = "Få hjælp til denne funktion";
            this.link_StatesticsHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_StatesticsHelp_LinkClicked);
            // 
            // cmBox_Stat_Employee
            // 
            this.cmBox_Stat_Employee.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBox_Stat_Employee.FormattingEnabled = true;
            this.cmBox_Stat_Employee.Location = new System.Drawing.Point(179, 304);
            this.cmBox_Stat_Employee.Margin = new System.Windows.Forms.Padding(4);
            this.cmBox_Stat_Employee.Name = "cmBox_Stat_Employee";
            this.cmBox_Stat_Employee.Size = new System.Drawing.Size(327, 32);
            this.cmBox_Stat_Employee.TabIndex = 12;
            this.cmBox_Stat_Employee.SelectedValueChanged += new System.EventHandler(this.cmBox_Stat_Employee_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Medarbejder";
            // 
            // bt_PrintScreen
            // 
            this.bt_PrintScreen.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_PrintScreen.Location = new System.Drawing.Point(301, 363);
            this.bt_PrintScreen.Margin = new System.Windows.Forms.Padding(4);
            this.bt_PrintScreen.Name = "bt_PrintScreen";
            this.bt_PrintScreen.Size = new System.Drawing.Size(204, 48);
            this.bt_PrintScreen.TabIndex = 52;
            this.bt_PrintScreen.Text = "Print til skærm";
            this.bt_PrintScreen.UseVisualStyleBackColor = true;
            this.bt_PrintScreen.Click += new System.EventHandler(this.bt_PrintScreen_Click);
            // 
            // Form_Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1325, 549);
            this.Controls.Add(this.bt_PrintScreen);
            this.Controls.Add(this.link_StatesticsHelp);
            this.Controls.Add(this.btn_PrintToFile);
            this.Controls.Add(this.tb_Stat_AverageOrder);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_Stat_AverageDay);
            this.Controls.Add(this.tb_Stat_SalesCount);
            this.Controls.Add(this.tb_Stat_TotalSales);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_Stat_OrderResults);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_Stat_To);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_Stat_From);
            this.Controls.Add(this.cmBox_Stat_Employee);
            this.Controls.Add(this.cmBox_Stat_Customer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Statistics";
            this.Text = "Statistik";
            this.Load += new System.EventHandler(this.Form_Statistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stat_OrderResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmBox_Stat_Customer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_Stat_From;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_Stat_To;
        private System.Windows.Forms.DataGridView dgv_Stat_OrderResults;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_Stat_TotalSales;
        private System.Windows.Forms.TextBox tb_Stat_SalesCount;
        private System.Windows.Forms.TextBox tb_Stat_AverageDay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_Stat_AverageOrder;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_PrintToFile;
        private System.Windows.Forms.LinkLabel link_StatesticsHelp;
        private System.Windows.Forms.ComboBox cmBox_Stat_Employee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button bt_PrintScreen;
    }
}