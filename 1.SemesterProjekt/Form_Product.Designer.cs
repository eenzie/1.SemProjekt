namespace _1.SemesterProjekt
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
            this.bt_SearchProuctdNum = new System.Windows.Forms.Button();
            this.bt_DeleteProduct = new System.Windows.Forms.Button();
            this.tb_ProductNumSearch = new System.Windows.Forms.TextBox();
            this.bt_NewProduct = new System.Windows.Forms.Button();
            this.bt_UpdateProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Products)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Products
            // 
            this.dgv_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Products.Location = new System.Drawing.Point(20, 163);
            this.dgv_Products.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Products.Name = "dgv_Products";
            this.dgv_Products.RowHeadersWidth = 51;
            this.dgv_Products.RowTemplate.Height = 24;
            this.dgv_Products.Size = new System.Drawing.Size(561, 322);
            this.dgv_Products.TabIndex = 21;
            // 
            // bt_ShowAllProducts
            // 
            this.bt_ShowAllProducts.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ShowAllProducts.Image = ((System.Drawing.Image)(resources.GetObject("bt_ShowAllProducts.Image")));
            this.bt_ShowAllProducts.Location = new System.Drawing.Point(133, 110);
            this.bt_ShowAllProducts.Margin = new System.Windows.Forms.Padding(2);
            this.bt_ShowAllProducts.Name = "bt_ShowAllProducts";
            this.bt_ShowAllProducts.Size = new System.Drawing.Size(177, 35);
            this.bt_ShowAllProducts.TabIndex = 11;
            this.bt_ShowAllProducts.Text = "Vis alle varer";
            this.bt_ShowAllProducts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_ShowAllProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_ShowAllProducts.UseVisualStyleBackColor = true;
            // 
            // bt_SearchProuctdNum
            // 
            this.bt_SearchProuctdNum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SearchProuctdNum.Image = ((System.Drawing.Image)(resources.GetObject("bt_SearchProuctdNum.Image")));
            this.bt_SearchProuctdNum.Location = new System.Drawing.Point(358, 11);
            this.bt_SearchProuctdNum.Margin = new System.Windows.Forms.Padding(2);
            this.bt_SearchProuctdNum.Name = "bt_SearchProuctdNum";
            this.bt_SearchProuctdNum.Size = new System.Drawing.Size(90, 35);
            this.bt_SearchProuctdNum.TabIndex = 1;
            this.bt_SearchProuctdNum.Text = "Søg";
            this.bt_SearchProuctdNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_SearchProuctdNum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_SearchProuctdNum.UseVisualStyleBackColor = true;
            // 
            // bt_DeleteProduct
            // 
            this.bt_DeleteProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DeleteProduct.Image = ((System.Drawing.Image)(resources.GetObject("bt_DeleteProduct.Image")));
            this.bt_DeleteProduct.Location = new System.Drawing.Point(484, 50);
            this.bt_DeleteProduct.Margin = new System.Windows.Forms.Padding(2);
            this.bt_DeleteProduct.Name = "bt_DeleteProduct";
            this.bt_DeleteProduct.Size = new System.Drawing.Size(97, 35);
            this.bt_DeleteProduct.TabIndex = 18;
            this.bt_DeleteProduct.Text = "Slet";
            this.bt_DeleteProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_DeleteProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_DeleteProduct.UseVisualStyleBackColor = true;
            // 
            // tb_ProductNumSearch
            // 
            this.tb_ProductNumSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ProductNumSearch.Location = new System.Drawing.Point(133, 14);
            this.tb_ProductNumSearch.Name = "tb_ProductNumSearch";
            this.tb_ProductNumSearch.Size = new System.Drawing.Size(196, 27);
            this.tb_ProductNumSearch.TabIndex = 2;
            this.tb_ProductNumSearch.Text = "IIIIIIIIIIII";
            // 
            // bt_NewProduct
            // 
            this.bt_NewProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_NewProduct.Image = ((System.Drawing.Image)(resources.GetObject("bt_NewProduct.Image")));
            this.bt_NewProduct.Location = new System.Drawing.Point(484, 11);
            this.bt_NewProduct.Margin = new System.Windows.Forms.Padding(2);
            this.bt_NewProduct.Name = "bt_NewProduct";
            this.bt_NewProduct.Size = new System.Drawing.Size(97, 35);
            this.bt_NewProduct.TabIndex = 14;
            this.bt_NewProduct.Text = "Nyt";
            this.bt_NewProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_NewProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_NewProduct.UseVisualStyleBackColor = true;
            // 
            // bt_UpdateProduct
            // 
            this.bt_UpdateProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_UpdateProduct.Image = ((System.Drawing.Image)(resources.GetObject("bt_UpdateProduct.Image")));
            this.bt_UpdateProduct.Location = new System.Drawing.Point(484, 89);
            this.bt_UpdateProduct.Margin = new System.Windows.Forms.Padding(2);
            this.bt_UpdateProduct.Name = "bt_UpdateProduct";
            this.bt_UpdateProduct.Size = new System.Drawing.Size(97, 35);
            this.bt_UpdateProduct.TabIndex = 17;
            this.bt_UpdateProduct.Text = "Opdatér";
            this.bt_UpdateProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_UpdateProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_UpdateProduct.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Produktsøgning";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "ID, navn, mærke, type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Produkttype";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(133, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 26);
            this.comboBox1.TabIndex = 27;
            // 
            // Form_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(611, 496);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_UpdateProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_DeleteProduct);
            this.Controls.Add(this.bt_NewProduct);
            this.Controls.Add(this.dgv_Products);
            this.Controls.Add(this.tb_ProductNumSearch);
            this.Controls.Add(this.bt_SearchProuctdNum);
            this.Controls.Add(this.bt_ShowAllProducts);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Product";
            this.Text = "Products Form";
            this.Load += new System.EventHandler(this.Form_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Products;
        private System.Windows.Forms.Button bt_ShowAllProducts;
        private System.Windows.Forms.Button bt_SearchProuctdNum;
        private System.Windows.Forms.Button bt_DeleteProduct;
        private System.Windows.Forms.TextBox tb_ProductNumSearch;
        private System.Windows.Forms.Button bt_NewProduct;
        private System.Windows.Forms.Button bt_UpdateProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

