namespace _1.SemesterProjekt
{
    partial class Form_Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Order));
            this.bt_SelectCustomer = new System.Windows.Forms.Button();
            this.tb_CustomerSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_SearchCustomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_SelectProduct = new System.Windows.Forms.Button();
            this.tb_ProductSearch = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_OrderLines = new System.Windows.Forms.DataGridView();
            this.tb_Amount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_Subtotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_VAT = new System.Windows.Forms.TextBox();
            this.tb_TotalSale = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_CustNameOut = new System.Windows.Forms.TextBox();
            this.tb_CustAdressOut = new System.Windows.Forms.TextBox();
            this.tb_CustPhoneOut = new System.Windows.Forms.TextBox();
            this.tb_CustMailOut = new System.Windows.Forms.TextBox();
            this.bt_Payment = new System.Windows.Forms.Button();
            this.bt_SearchProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderLines)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_SelectCustomer
            // 
            this.bt_SelectCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SelectCustomer.Image = ((System.Drawing.Image)(resources.GetObject("bt_SelectCustomer.Image")));
            this.bt_SelectCustomer.Location = new System.Drawing.Point(490, 176);
            this.bt_SelectCustomer.Name = "bt_SelectCustomer";
            this.bt_SelectCustomer.Size = new System.Drawing.Size(75, 30);
            this.bt_SelectCustomer.TabIndex = 21;
            this.bt_SelectCustomer.Text = "Vælg";
            this.bt_SelectCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_SelectCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_SelectCustomer.UseVisualStyleBackColor = true;
            this.bt_SelectCustomer.Click += new System.EventHandler(this.bt_SelectCustomer_Click);
            // 
            // tb_CustomerSearch
            // 
            this.tb_CustomerSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CustomerSearch.Location = new System.Drawing.Point(196, 7);
            this.tb_CustomerSearch.Name = "tb_CustomerSearch";
            this.tb_CustomerSearch.Size = new System.Drawing.Size(285, 27);
            this.tb_CustomerSearch.TabIndex = 20;
            this.tb_CustomerSearch.Text = "IIIIIIIIIII";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(555, 125);
            this.dataGridView1.TabIndex = 19;
            // 
            // bt_SearchCustomer
            // 
            this.bt_SearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SearchCustomer.Image = ((System.Drawing.Image)(resources.GetObject("bt_SearchCustomer.Image")));
            this.bt_SearchCustomer.Location = new System.Drawing.Point(490, 5);
            this.bt_SearchCustomer.Name = "bt_SearchCustomer";
            this.bt_SearchCustomer.Size = new System.Drawing.Size(75, 30);
            this.bt_SearchCustomer.TabIndex = 18;
            this.bt_SearchCustomer.Text = "Find";
            this.bt_SearchCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_SearchCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_SearchCustomer.UseVisualStyleBackColor = true;
            this.bt_SearchCustomer.Click += new System.EventHandler(this.bt_SearchCustomer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Søg kundenr eller navn";
            // 
            // bt_SelectProduct
            // 
            this.bt_SelectProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SelectProduct.Image = ((System.Drawing.Image)(resources.GetObject("bt_SelectProduct.Image")));
            this.bt_SelectProduct.Location = new System.Drawing.Point(459, 398);
            this.bt_SelectProduct.Name = "bt_SelectProduct";
            this.bt_SelectProduct.Size = new System.Drawing.Size(106, 30);
            this.bt_SelectProduct.TabIndex = 26;
            this.bt_SelectProduct.Text = "Registrer";
            this.bt_SelectProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_SelectProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_SelectProduct.UseVisualStyleBackColor = true;
            this.bt_SelectProduct.Click += new System.EventHandler(this.bt_SelectProduct_Click);
            // 
            // tb_ProductSearch
            // 
            this.tb_ProductSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ProductSearch.Location = new System.Drawing.Point(196, 238);
            this.tb_ProductSearch.Name = "tb_ProductSearch";
            this.tb_ProductSearch.Size = new System.Drawing.Size(285, 27);
            this.tb_ProductSearch.TabIndex = 25;
            this.tb_ProductSearch.Text = "IIIIIIIIIIIIIIIIIII";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 277);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(553, 118);
            this.dataGridView2.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Søg produktnr eller navn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(608, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Kunde navn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(608, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Kunde adresse:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(608, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "Kunde telefonnr:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(901, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "Kunde mail:";
            // 
            // dgv_OrderLines
            // 
            this.dgv_OrderLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OrderLines.Location = new System.Drawing.Point(612, 117);
            this.dgv_OrderLines.Name = "dgv_OrderLines";
            this.dgv_OrderLines.RowHeadersWidth = 51;
            this.dgv_OrderLines.RowTemplate.Height = 24;
            this.dgv_OrderLines.Size = new System.Drawing.Size(550, 196);
            this.dgv_OrderLines.TabIndex = 31;
            // 
            // tb_Amount
            // 
            this.tb_Amount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Amount.Location = new System.Drawing.Point(363, 401);
            this.tb_Amount.Name = "tb_Amount";
            this.tb_Amount.Size = new System.Drawing.Size(87, 27);
            this.tb_Amount.TabIndex = 32;
            this.tb_Amount.Text = "iiiiiii";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(313, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 33;
            this.label7.Text = "Antal:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1003, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 19);
            this.label8.TabIndex = 35;
            this.label8.Text = "Subtotal:";
            // 
            // tb_Subtotal
            // 
            this.tb_Subtotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Subtotal.Location = new System.Drawing.Point(1075, 319);
            this.tb_Subtotal.Name = "tb_Subtotal";
            this.tb_Subtotal.Size = new System.Drawing.Size(87, 27);
            this.tb_Subtotal.TabIndex = 34;
            this.tb_Subtotal.Text = "oooo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1014, 354);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 19);
            this.label9.TabIndex = 37;
            this.label9.Text = "Moms:";
            // 
            // tb_VAT
            // 
            this.tb_VAT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_VAT.Location = new System.Drawing.Point(1075, 351);
            this.tb_VAT.Name = "tb_VAT";
            this.tb_VAT.Size = new System.Drawing.Size(87, 27);
            this.tb_VAT.TabIndex = 36;
            this.tb_VAT.Text = "oooo";
            // 
            // tb_TotalSale
            // 
            this.tb_TotalSale.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TotalSale.Location = new System.Drawing.Point(1075, 381);
            this.tb_TotalSale.Name = "tb_TotalSale";
            this.tb_TotalSale.Size = new System.Drawing.Size(87, 27);
            this.tb_TotalSale.TabIndex = 38;
            this.tb_TotalSale.Text = "oooo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1024, 384);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 19);
            this.label10.TabIndex = 39;
            this.label10.Text = "Total:";
            // 
            // tb_CustNameOut
            // 
            this.tb_CustNameOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CustNameOut.Location = new System.Drawing.Point(755, 19);
            this.tb_CustNameOut.Name = "tb_CustNameOut";
            this.tb_CustNameOut.Size = new System.Drawing.Size(407, 27);
            this.tb_CustNameOut.TabIndex = 40;
            this.tb_CustNameOut.Text = "OOOO";
            // 
            // tb_CustAdressOut
            // 
            this.tb_CustAdressOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CustAdressOut.Location = new System.Drawing.Point(755, 45);
            this.tb_CustAdressOut.Name = "tb_CustAdressOut";
            this.tb_CustAdressOut.Size = new System.Drawing.Size(407, 27);
            this.tb_CustAdressOut.TabIndex = 41;
            this.tb_CustAdressOut.Text = "OOOO";
            // 
            // tb_CustPhoneOut
            // 
            this.tb_CustPhoneOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CustPhoneOut.Location = new System.Drawing.Point(755, 74);
            this.tb_CustPhoneOut.Name = "tb_CustPhoneOut";
            this.tb_CustPhoneOut.Size = new System.Drawing.Size(140, 27);
            this.tb_CustPhoneOut.TabIndex = 42;
            this.tb_CustPhoneOut.Text = "OOOO";
            // 
            // tb_CustMailOut
            // 
            this.tb_CustMailOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CustMailOut.Location = new System.Drawing.Point(998, 76);
            this.tb_CustMailOut.Name = "tb_CustMailOut";
            this.tb_CustMailOut.Size = new System.Drawing.Size(164, 27);
            this.tb_CustMailOut.TabIndex = 43;
            this.tb_CustMailOut.Text = "OOOO";
            // 
            // bt_Payment
            // 
            this.bt_Payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Payment.Image = ((System.Drawing.Image)(resources.GetObject("bt_Payment.Image")));
            this.bt_Payment.Location = new System.Drawing.Point(1075, 411);
            this.bt_Payment.Name = "bt_Payment";
            this.bt_Payment.Size = new System.Drawing.Size(87, 30);
            this.bt_Payment.TabIndex = 44;
            this.bt_Payment.Text = "Betal";
            this.bt_Payment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Payment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Payment.UseVisualStyleBackColor = true;
            this.bt_Payment.Click += new System.EventHandler(this.bt_Payment_Click);
            // 
            // bt_SearchProduct
            // 
            this.bt_SearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SearchProduct.Image = ((System.Drawing.Image)(resources.GetObject("bt_SearchProduct.Image")));
            this.bt_SearchProduct.Location = new System.Drawing.Point(490, 236);
            this.bt_SearchProduct.Name = "bt_SearchProduct";
            this.bt_SearchProduct.Size = new System.Drawing.Size(75, 30);
            this.bt_SearchProduct.TabIndex = 45;
            this.bt_SearchProduct.Text = "Find";
            this.bt_SearchProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_SearchProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_SearchProduct.UseVisualStyleBackColor = true;
            this.bt_SearchProduct.Click += new System.EventHandler(this.bt_SearchProduct_Click);
            // 
            // Form_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1174, 450);
            this.Controls.Add(this.bt_SearchProduct);
            this.Controls.Add(this.bt_Payment);
            this.Controls.Add(this.tb_CustMailOut);
            this.Controls.Add(this.tb_CustPhoneOut);
            this.Controls.Add(this.tb_CustAdressOut);
            this.Controls.Add(this.tb_CustNameOut);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_TotalSale);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_VAT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_Subtotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_Amount);
            this.Controls.Add(this.dgv_OrderLines);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_SelectProduct);
            this.Controls.Add(this.tb_ProductSearch);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_SelectCustomer);
            this.Controls.Add(this.tb_CustomerSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_SearchCustomer);
            this.Controls.Add(this.label1);
            this.Name = "Form_Order";
            this.Text = "Order Form";
            this.Load += new System.EventHandler(this.Form_Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderLines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_SelectCustomer;
        private System.Windows.Forms.TextBox tb_CustomerSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_SearchCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_SelectProduct;
        private System.Windows.Forms.TextBox tb_ProductSearch;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_OrderLines;
        private System.Windows.Forms.TextBox tb_Amount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_Subtotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_VAT;
        private System.Windows.Forms.TextBox tb_TotalSale;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_CustNameOut;
        private System.Windows.Forms.TextBox tb_CustAdressOut;
        private System.Windows.Forms.TextBox tb_CustPhoneOut;
        private System.Windows.Forms.TextBox tb_CustMailOut;
        private System.Windows.Forms.Button bt_Payment;
        private System.Windows.Forms.Button bt_SearchProduct;
    }
}