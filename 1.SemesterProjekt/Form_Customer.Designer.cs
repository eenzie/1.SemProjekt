﻿namespace _1.SemesterProjekt
{
    partial class Form_Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Customer));
            this.dgv_Customers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_UpdateCustomer = new System.Windows.Forms.Button();
            this.bt_NewCustomer = new System.Windows.Forms.Button();
            this.tb_CustomerNumSearch = new System.Windows.Forms.TextBox();
            this.bt_DeleteCustomer = new System.Windows.Forms.Button();
            this.bt_SearchCustomer = new System.Windows.Forms.Button();
            this.bt_ShowAllCustomers = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.typeComboBo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Customers
            // 
            this.dgv_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customers.Location = new System.Drawing.Point(29, 209);
            this.dgv_Customers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Customers.Name = "dgv_Customers";
            this.dgv_Customers.RowHeadersWidth = 51;
            this.dgv_Customers.RowTemplate.Height = 24;
            this.dgv_Customers.Size = new System.Drawing.Size(748, 394);
            this.dgv_Customers.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kunde søgning";
            // 
            // bt_UpdateCustomer
            // 
            this.bt_UpdateCustomer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_UpdateCustomer.Image = ((System.Drawing.Image)(resources.GetObject("bt_UpdateCustomer.Image")));
            this.bt_UpdateCustomer.Location = new System.Drawing.Point(637, 60);
            this.bt_UpdateCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_UpdateCustomer.Name = "bt_UpdateCustomer";
            this.bt_UpdateCustomer.Size = new System.Drawing.Size(131, 43);
            this.bt_UpdateCustomer.TabIndex = 17;
            this.bt_UpdateCustomer.Text = "Opdatér";
            this.bt_UpdateCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_UpdateCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_UpdateCustomer.UseVisualStyleBackColor = true;
            // 
            // bt_NewCustomer
            // 
            this.bt_NewCustomer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_NewCustomer.Image = ((System.Drawing.Image)(resources.GetObject("bt_NewCustomer.Image")));
            this.bt_NewCustomer.Location = new System.Drawing.Point(637, 12);
            this.bt_NewCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_NewCustomer.Name = "bt_NewCustomer";
            this.bt_NewCustomer.Size = new System.Drawing.Size(131, 43);
            this.bt_NewCustomer.TabIndex = 14;
            this.bt_NewCustomer.Text = "Ny";
            this.bt_NewCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_NewCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_NewCustomer.UseVisualStyleBackColor = true;
            // 
            // tb_CustomerNumSearch
            // 
            this.tb_CustomerNumSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CustomerNumSearch.Location = new System.Drawing.Point(173, 15);
            this.tb_CustomerNumSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_CustomerNumSearch.Name = "tb_CustomerNumSearch";
            this.tb_CustomerNumSearch.Size = new System.Drawing.Size(260, 32);
            this.tb_CustomerNumSearch.TabIndex = 2;
            this.tb_CustomerNumSearch.Text = "IIIIIIIIIIII";
            // 
            // bt_DeleteCustomer
            // 
            this.bt_DeleteCustomer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DeleteCustomer.Image = ((System.Drawing.Image)(resources.GetObject("bt_DeleteCustomer.Image")));
            this.bt_DeleteCustomer.Location = new System.Drawing.Point(637, 108);
            this.bt_DeleteCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_DeleteCustomer.Name = "bt_DeleteCustomer";
            this.bt_DeleteCustomer.Size = new System.Drawing.Size(131, 43);
            this.bt_DeleteCustomer.TabIndex = 18;
            this.bt_DeleteCustomer.Text = "Slet";
            this.bt_DeleteCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_DeleteCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_DeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // bt_SearchCustomer
            // 
            this.bt_SearchCustomer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SearchCustomer.Image = ((System.Drawing.Image)(resources.GetObject("bt_SearchCustomer.Image")));
            this.bt_SearchCustomer.Location = new System.Drawing.Point(469, 12);
            this.bt_SearchCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_SearchCustomer.Name = "bt_SearchCustomer";
            this.bt_SearchCustomer.Size = new System.Drawing.Size(120, 43);
            this.bt_SearchCustomer.TabIndex = 1;
            this.bt_SearchCustomer.Text = "Søg";
            this.bt_SearchCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_SearchCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_SearchCustomer.UseVisualStyleBackColor = true;
            // 
            // bt_ShowAllCustomers
            // 
            this.bt_ShowAllCustomers.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ShowAllCustomers.Image = ((System.Drawing.Image)(resources.GetObject("bt_ShowAllCustomers.Image")));
            this.bt_ShowAllCustomers.Location = new System.Drawing.Point(173, 146);
            this.bt_ShowAllCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_ShowAllCustomers.Name = "bt_ShowAllCustomers";
            this.bt_ShowAllCustomers.Size = new System.Drawing.Size(236, 43);
            this.bt_ShowAllCustomers.TabIndex = 11;
            this.bt_ShowAllCustomers.Text = "Vis alle kunder";
            this.bt_ShowAllCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_ShowAllCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_ShowAllCustomers.UseVisualStyleBackColor = true;
            this.bt_ShowAllCustomers.Click += new System.EventHandler(this.bt_ShowAllCustomers_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "ID, navn, adresse, mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Produkttype";
            // 
            // typeComboBo
            // 
            this.typeComboBo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeComboBo.FormattingEnabled = true;
            this.typeComboBo.Location = new System.Drawing.Point(173, 92);
            this.typeComboBo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.typeComboBo.Name = "typeComboBo";
            this.typeComboBo.Size = new System.Drawing.Size(260, 31);
            this.typeComboBo.TabIndex = 28;
            // 
            // Form_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(805, 617);
            this.Controls.Add(this.typeComboBo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Customers);
            this.Controls.Add(this.bt_UpdateCustomer);
            this.Controls.Add(this.bt_NewCustomer);
            this.Controls.Add(this.bt_ShowAllCustomers);
            this.Controls.Add(this.tb_CustomerNumSearch);
            this.Controls.Add(this.bt_SearchCustomer);
            this.Controls.Add(this.bt_DeleteCustomer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Customer";
            this.Text = "Form_Customer";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Customers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_UpdateCustomer;
        private System.Windows.Forms.Button bt_NewCustomer;
        private System.Windows.Forms.TextBox tb_CustomerNumSearch;
        private System.Windows.Forms.Button bt_DeleteCustomer;
        private System.Windows.Forms.Button bt_SearchCustomer;
        private System.Windows.Forms.Button bt_ShowAllCustomers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox typeComboBo;
    }
}