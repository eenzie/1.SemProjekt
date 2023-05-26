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
            this.cmBox_ProductType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderLines)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_SelectCustomer
            // 
            this.bt_SelectCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SelectCustomer.Image = ((System.Drawing.Image)(resources.GetObject("bt_SelectCustomer.Image")));
            this.bt_SelectCustomer.Location = new System.Drawing.Point(653, 217);
            this.bt_SelectCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.bt_SelectCustomer.Name = "bt_SelectCustomer";
            this.bt_SelectCustomer.Size = new System.Drawing.Size(100, 37);
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
            this.tb_CustomerSearch.Location = new System.Drawing.Point(261, 9);
            this.tb_CustomerSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tb_CustomerSearch.Name = "tb_CustomerSearch";
            this.tb_CustomerSearch.Size = new System.Drawing.Size(379, 32);
            this.tb_CustomerSearch.TabIndex = 20;
            this.tb_CustomerSearch.Text = "IIIIIIIIIII";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 55);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(740, 154);
            this.dataGridView1.TabIndex = 19;
            // 
            // bt_SearchCustomer
            // 
            this.bt_SearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SearchCustomer.Image = ((System.Drawing.Image)(resources.GetObject("bt_SearchCustomer.Image")));
            this.bt_SearchCustomer.Location = new System.Drawing.Point(653, 6);
            this.bt_SearchCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.bt_SearchCustomer.Name = "bt_SearchCustomer";
            this.bt_SearchCustomer.Size = new System.Drawing.Size(100, 37);
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
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Søg kundenr eller navn";
            // 
            // bt_SelectProduct
            // 
            this.bt_SelectProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SelectProduct.Image = ((System.Drawing.Image)(resources.GetObject("bt_SelectProduct.Image")));
            this.bt_SelectProduct.Location = new System.Drawing.Point(612, 508);
            this.bt_SelectProduct.Margin = new System.Windows.Forms.Padding(4);
            this.bt_SelectProduct.Name = "bt_SelectProduct";
            this.bt_SelectProduct.Size = new System.Drawing.Size(141, 37);
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
            this.tb_ProductSearch.Location = new System.Drawing.Point(261, 311);
            this.tb_ProductSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ProductSearch.Name = "tb_ProductSearch";
            this.tb_ProductSearch.Size = new System.Drawing.Size(379, 32);
            this.tb_ProductSearch.TabIndex = 25;
            this.tb_ProductSearch.Text = "IIIIIIIIIIIIIIIIIII";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(16, 359);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(737, 145);
            this.dataGridView2.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 315);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Søg produktnr eller navn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(811, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Kunde navn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(811, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "Kunde adresse:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(811, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "Kunde telefonnr:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1201, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 24);
            this.label6.TabIndex = 30;
            this.label6.Text = "Kunde mail:";
            // 
            // dgv_OrderLines
            // 
            this.dgv_OrderLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OrderLines.Location = new System.Drawing.Point(816, 144);
            this.dgv_OrderLines.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_OrderLines.Name = "dgv_OrderLines";
            this.dgv_OrderLines.RowHeadersWidth = 51;
            this.dgv_OrderLines.RowTemplate.Height = 24;
            this.dgv_OrderLines.Size = new System.Drawing.Size(733, 241);
            this.dgv_OrderLines.TabIndex = 31;
            // 
            // tb_Amount
            // 
            this.tb_Amount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Amount.Location = new System.Drawing.Point(484, 512);
            this.tb_Amount.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Amount.Name = "tb_Amount";
            this.tb_Amount.Size = new System.Drawing.Size(115, 32);
            this.tb_Amount.TabIndex = 32;
            this.tb_Amount.Text = "iiiiiii";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(417, 519);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 24);
            this.label7.TabIndex = 33;
            this.label7.Text = "Antal:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1337, 396);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 24);
            this.label8.TabIndex = 35;
            this.label8.Text = "Subtotal:";
            // 
            // tb_Subtotal
            // 
            this.tb_Subtotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Subtotal.Location = new System.Drawing.Point(1433, 393);
            this.tb_Subtotal.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Subtotal.Name = "tb_Subtotal";
            this.tb_Subtotal.Size = new System.Drawing.Size(115, 32);
            this.tb_Subtotal.TabIndex = 34;
            this.tb_Subtotal.Text = "oooo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1352, 436);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 24);
            this.label9.TabIndex = 37;
            this.label9.Text = "Moms:";
            // 
            // tb_VAT
            // 
            this.tb_VAT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_VAT.Location = new System.Drawing.Point(1433, 432);
            this.tb_VAT.Margin = new System.Windows.Forms.Padding(4);
            this.tb_VAT.Name = "tb_VAT";
            this.tb_VAT.Size = new System.Drawing.Size(115, 32);
            this.tb_VAT.TabIndex = 36;
            this.tb_VAT.Text = "oooo";
            // 
            // tb_TotalSale
            // 
            this.tb_TotalSale.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TotalSale.Location = new System.Drawing.Point(1433, 469);
            this.tb_TotalSale.Margin = new System.Windows.Forms.Padding(4);
            this.tb_TotalSale.Name = "tb_TotalSale";
            this.tb_TotalSale.Size = new System.Drawing.Size(115, 32);
            this.tb_TotalSale.TabIndex = 38;
            this.tb_TotalSale.Text = "oooo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1365, 473);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 24);
            this.label10.TabIndex = 39;
            this.label10.Text = "Total:";
            // 
            // tb_CustNameOut
            // 
            this.tb_CustNameOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CustNameOut.Location = new System.Drawing.Point(1007, 23);
            this.tb_CustNameOut.Margin = new System.Windows.Forms.Padding(4);
            this.tb_CustNameOut.Name = "tb_CustNameOut";
            this.tb_CustNameOut.Size = new System.Drawing.Size(541, 32);
            this.tb_CustNameOut.TabIndex = 40;
            this.tb_CustNameOut.Text = "OOOO";
            // 
            // tb_CustAdressOut
            // 
            this.tb_CustAdressOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CustAdressOut.Location = new System.Drawing.Point(1007, 55);
            this.tb_CustAdressOut.Margin = new System.Windows.Forms.Padding(4);
            this.tb_CustAdressOut.Name = "tb_CustAdressOut";
            this.tb_CustAdressOut.Size = new System.Drawing.Size(541, 32);
            this.tb_CustAdressOut.TabIndex = 41;
            this.tb_CustAdressOut.Text = "OOOO";
            // 
            // tb_CustPhoneOut
            // 
            this.tb_CustPhoneOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CustPhoneOut.Location = new System.Drawing.Point(1007, 91);
            this.tb_CustPhoneOut.Margin = new System.Windows.Forms.Padding(4);
            this.tb_CustPhoneOut.Name = "tb_CustPhoneOut";
            this.tb_CustPhoneOut.Size = new System.Drawing.Size(185, 32);
            this.tb_CustPhoneOut.TabIndex = 42;
            this.tb_CustPhoneOut.Text = "OOOO";
            // 
            // tb_CustMailOut
            // 
            this.tb_CustMailOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CustMailOut.Location = new System.Drawing.Point(1331, 94);
            this.tb_CustMailOut.Margin = new System.Windows.Forms.Padding(4);
            this.tb_CustMailOut.Name = "tb_CustMailOut";
            this.tb_CustMailOut.Size = new System.Drawing.Size(217, 32);
            this.tb_CustMailOut.TabIndex = 43;
            this.tb_CustMailOut.Text = "OOOO";
            // 
            // bt_Payment
            // 
            this.bt_Payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Payment.Image = ((System.Drawing.Image)(resources.GetObject("bt_Payment.Image")));
            this.bt_Payment.Location = new System.Drawing.Point(1433, 506);
            this.bt_Payment.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Payment.Name = "bt_Payment";
            this.bt_Payment.Size = new System.Drawing.Size(116, 37);
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
            this.bt_SearchProduct.Location = new System.Drawing.Point(653, 308);
            this.bt_SearchProduct.Margin = new System.Windows.Forms.Padding(4);
            this.bt_SearchProduct.Name = "bt_SearchProduct";
            this.bt_SearchProduct.Size = new System.Drawing.Size(100, 37);
            this.bt_SearchProduct.TabIndex = 45;
            this.bt_SearchProduct.Text = "Find";
            this.bt_SearchProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_SearchProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_SearchProduct.UseVisualStyleBackColor = true;
            this.bt_SearchProduct.Click += new System.EventHandler(this.bt_SearchProduct_Click);
            // 
            // cmBox_ProductType
            // 
            this.cmBox_ProductType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBox_ProductType.FormattingEnabled = true;
            this.cmBox_ProductType.Location = new System.Drawing.Point(261, 271);
            this.cmBox_ProductType.Margin = new System.Windows.Forms.Padding(4);
            this.cmBox_ProductType.Name = "cmBox_ProductType";
            this.cmBox_ProductType.Size = new System.Drawing.Size(379, 32);
            this.cmBox_ProductType.TabIndex = 46;
            this.cmBox_ProductType.SelectedIndexChanged += new System.EventHandler(this.cmBox_ProductType_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 274);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 24);
            this.label11.TabIndex = 47;
            this.label11.Text = "Vælg produkttype";
            // 
            // cmBox
            // 
            this.cmBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBox.FormattingEnabled = true;
            this.cmBox.Location = new System.Drawing.Point(815, 453);
            this.cmBox.Margin = new System.Windows.Forms.Padding(4);
            this.cmBox.Name = "cmBox";
            this.cmBox.Size = new System.Drawing.Size(345, 32);
            this.cmBox.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(812, 425);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 24);
            this.label12.TabIndex = 49;
            this.label12.Text = "Medarbejder:";
            // 
            // Form_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1565, 554);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmBox_ProductType);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ComboBox cmBox_ProductType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmBox;
        private System.Windows.Forms.Label label12;
    }
}