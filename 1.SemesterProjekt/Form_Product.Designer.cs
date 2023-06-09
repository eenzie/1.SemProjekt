﻿namespace _1.SemesterProjekt
{
    partial class Form_Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Product));
            this.dgv_Products = new System.Windows.Forms.DataGridView();
            this.bt_ShowAllProducts = new System.Windows.Forms.Button();
            this.bt_SearchProuct = new System.Windows.Forms.Button();
            this.bt_DeleteProduct = new System.Windows.Forms.Button();
            this.tb_ProductNumSearch = new System.Windows.Forms.TextBox();
            this.bt_NewProduct = new System.Windows.Forms.Button();
            this.bt_UpdateProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.link_ProductHelp = new System.Windows.Forms.LinkLabel();
            this.bt_PrintToFile = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Products)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Products
            // 
            this.dgv_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Products.Location = new System.Drawing.Point(20, 166);
            this.dgv_Products.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Products.MultiSelect = false;
            this.dgv_Products.Name = "dgv_Products";
            this.dgv_Products.ReadOnly = true;
            this.dgv_Products.RowHeadersWidth = 51;
            this.dgv_Products.RowTemplate.Height = 24;
            this.dgv_Products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Products.Size = new System.Drawing.Size(1029, 318);
            this.dgv_Products.TabIndex = 21;
            // 
            // bt_ShowAllProducts
            // 
            this.bt_ShowAllProducts.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ShowAllProducts.Image = ((System.Drawing.Image)(resources.GetObject("bt_ShowAllProducts.Image")));
            this.bt_ShowAllProducts.Location = new System.Drawing.Point(446, 103);
            this.bt_ShowAllProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_ShowAllProducts.Name = "bt_ShowAllProducts";
            this.bt_ShowAllProducts.Size = new System.Drawing.Size(168, 43);
            this.bt_ShowAllProducts.TabIndex = 11;
            this.bt_ShowAllProducts.Text = "Nulstil";
            this.bt_ShowAllProducts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_ShowAllProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_ShowAllProducts.UseVisualStyleBackColor = true;
            this.bt_ShowAllProducts.Click += new System.EventHandler(this.bt_ShowAllProducts_Click);
            // 
            // bt_SearchProuct
            // 
            this.bt_SearchProuct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SearchProuct.Image = ((System.Drawing.Image)(resources.GetObject("bt_SearchProuct.Image")));
            this.bt_SearchProuct.Location = new System.Drawing.Point(446, 57);
            this.bt_SearchProuct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_SearchProuct.Name = "bt_SearchProuct";
            this.bt_SearchProuct.Size = new System.Drawing.Size(168, 43);
            this.bt_SearchProuct.TabIndex = 1;
            this.bt_SearchProuct.Text = "Søg";
            this.bt_SearchProuct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_SearchProuct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_SearchProuct.UseVisualStyleBackColor = true;
            this.bt_SearchProuct.Click += new System.EventHandler(this.bt_SearchProduct_Click);
            // 
            // bt_DeleteProduct
            // 
            this.bt_DeleteProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DeleteProduct.Image = ((System.Drawing.Image)(resources.GetObject("bt_DeleteProduct.Image")));
            this.bt_DeleteProduct.Location = new System.Drawing.Point(913, 57);
            this.bt_DeleteProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_DeleteProduct.Name = "bt_DeleteProduct";
            this.bt_DeleteProduct.Size = new System.Drawing.Size(129, 43);
            this.bt_DeleteProduct.TabIndex = 18;
            this.bt_DeleteProduct.Text = "Slet";
            this.bt_DeleteProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_DeleteProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_DeleteProduct.UseVisualStyleBackColor = true;
            this.bt_DeleteProduct.Click += new System.EventHandler(this.bt_DeleteProduct_Click);
            // 
            // tb_ProductNumSearch
            // 
            this.tb_ProductNumSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ProductNumSearch.Location = new System.Drawing.Point(178, 62);
            this.tb_ProductNumSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ProductNumSearch.Name = "tb_ProductNumSearch";
            this.tb_ProductNumSearch.Size = new System.Drawing.Size(260, 32);
            this.tb_ProductNumSearch.TabIndex = 2;
            this.tb_ProductNumSearch.Text = "IIIIIIIIIIII";
            // 
            // bt_NewProduct
            // 
            this.bt_NewProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_NewProduct.Image = ((System.Drawing.Image)(resources.GetObject("bt_NewProduct.Image")));
            this.bt_NewProduct.Location = new System.Drawing.Point(644, 56);
            this.bt_NewProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_NewProduct.Name = "bt_NewProduct";
            this.bt_NewProduct.Size = new System.Drawing.Size(129, 43);
            this.bt_NewProduct.TabIndex = 14;
            this.bt_NewProduct.Text = "Nyt";
            this.bt_NewProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_NewProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_NewProduct.UseVisualStyleBackColor = true;
            this.bt_NewProduct.Click += new System.EventHandler(this.bt_NewProduct_Click);
            // 
            // bt_UpdateProduct
            // 
            this.bt_UpdateProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_UpdateProduct.Image = ((System.Drawing.Image)(resources.GetObject("bt_UpdateProduct.Image")));
            this.bt_UpdateProduct.Location = new System.Drawing.Point(779, 56);
            this.bt_UpdateProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_UpdateProduct.Name = "bt_UpdateProduct";
            this.bt_UpdateProduct.Size = new System.Drawing.Size(129, 43);
            this.bt_UpdateProduct.TabIndex = 17;
            this.bt_UpdateProduct.Text = "Opdatér";
            this.bt_UpdateProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_UpdateProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_UpdateProduct.UseVisualStyleBackColor = true;
            this.bt_UpdateProduct.Click += new System.EventHandler(this.bt_UpdateProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Produktsøgning";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "ID eller navn";
            // 
            // link_ProductHelp
            // 
            this.link_ProductHelp.AutoSize = true;
            this.link_ProductHelp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_ProductHelp.Location = new System.Drawing.Point(12, 9);
            this.link_ProductHelp.Name = "link_ProductHelp";
            this.link_ProductHelp.Size = new System.Drawing.Size(234, 24);
            this.link_ProductHelp.TabIndex = 30;
            this.link_ProductHelp.TabStop = true;
            this.link_ProductHelp.Text = "Få hjælp til denne funktion";
            this.link_ProductHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_ProductHelp_LinkClicked);
            // 
            // bt_PrintToFile
            // 
            this.bt_PrintToFile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_PrintToFile.Image = ((System.Drawing.Image)(resources.GetObject("bt_PrintToFile.Image")));
            this.bt_PrintToFile.Location = new System.Drawing.Point(881, 498);
            this.bt_PrintToFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_PrintToFile.Name = "bt_PrintToFile";
            this.bt_PrintToFile.Size = new System.Drawing.Size(168, 43);
            this.bt_PrintToFile.TabIndex = 31;
            this.bt_PrintToFile.Text = "Print til fil";
            this.bt_PrintToFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_PrintToFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_PrintToFile.UseVisualStyleBackColor = true;
            this.bt_PrintToFile.Click += new System.EventHandler(this.bt_PrintToFile_Click);
            // 
            // Form_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1068, 552);
            this.Controls.Add(this.bt_PrintToFile);
            this.Controls.Add(this.link_ProductHelp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_UpdateProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_DeleteProduct);
            this.Controls.Add(this.bt_NewProduct);
            this.Controls.Add(this.dgv_Products);
            this.Controls.Add(this.tb_ProductNumSearch);
            this.Controls.Add(this.bt_SearchProuct);
            this.Controls.Add(this.bt_ShowAllProducts);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Product";
            this.Text = "Produktsøgning";
            this.Load += new System.EventHandler(this.Form_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Products;
        private System.Windows.Forms.Button bt_ShowAllProducts;
        private System.Windows.Forms.Button bt_SearchProuct;
        private System.Windows.Forms.Button bt_DeleteProduct;
        private System.Windows.Forms.TextBox tb_ProductNumSearch;
        private System.Windows.Forms.Button bt_NewProduct;
        private System.Windows.Forms.Button bt_UpdateProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel link_ProductHelp;
        private System.Windows.Forms.Button bt_PrintToFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

