namespace _1.SemesterProjekt
{
    partial class Form_Customer_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Customer_Edit));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ckBox_IsDeleted = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_SaveCustomer = new System.Windows.Forms.Button();
            this.tb_CustomerName = new System.Windows.Forms.TextBox();
            this.tb_CustomerAddress = new System.Windows.Forms.TextBox();
            this.tb_CustomerPhone = new System.Windows.Forms.TextBox();
            this.tb_CustomerMail = new System.Windows.Forms.TextBox();
            this.num_postcode = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_postcode)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Navn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adresse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Postnummer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefonnummer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 258);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mail";
            // 
            // ckBox_IsDeleted
            // 
            this.ckBox_IsDeleted.AutoSize = true;
            this.ckBox_IsDeleted.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBox_IsDeleted.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ckBox_IsDeleted.Location = new System.Drawing.Point(8, 32);
            this.ckBox_IsDeleted.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckBox_IsDeleted.Name = "ckBox_IsDeleted";
            this.ckBox_IsDeleted.Size = new System.Drawing.Size(176, 28);
            this.ckBox_IsDeleted.TabIndex = 9;
            this.ckBox_IsDeleted.Text = "Deaktivér kunde?";
            this.ckBox_IsDeleted.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckBox_IsDeleted);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(16, 320);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(209, 70);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADVARSEL";
            // 
            // bt_SaveCustomer
            // 
            this.bt_SaveCustomer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SaveCustomer.Image = ((System.Drawing.Image)(resources.GetObject("bt_SaveCustomer.Image")));
            this.bt_SaveCustomer.Location = new System.Drawing.Point(308, 337);
            this.bt_SaveCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_SaveCustomer.Name = "bt_SaveCustomer";
            this.bt_SaveCustomer.Size = new System.Drawing.Size(128, 43);
            this.bt_SaveCustomer.TabIndex = 11;
            this.bt_SaveCustomer.Text = "Gem";
            this.bt_SaveCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_SaveCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_SaveCustomer.UseVisualStyleBackColor = true;
            this.bt_SaveCustomer.Click += new System.EventHandler(this.bt_SaveCustomer_Click);
            // 
            // tb_CustomerName
            // 
            this.tb_CustomerName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CustomerName.Location = new System.Drawing.Point(175, 9);
            this.tb_CustomerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_CustomerName.Name = "tb_CustomerName";
            this.tb_CustomerName.Size = new System.Drawing.Size(260, 32);
            this.tb_CustomerName.TabIndex = 12;
            this.tb_CustomerName.Text = "IIII (OOOO)";
            // 
            // tb_CustomerAddress
            // 
            this.tb_CustomerAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CustomerAddress.Location = new System.Drawing.Point(175, 70);
            this.tb_CustomerAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_CustomerAddress.Name = "tb_CustomerAddress";
            this.tb_CustomerAddress.Size = new System.Drawing.Size(260, 32);
            this.tb_CustomerAddress.TabIndex = 13;
            this.tb_CustomerAddress.Text = "IIII (OOOO)";
            // 
            // tb_CustomerPhone
            // 
            this.tb_CustomerPhone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CustomerPhone.Location = new System.Drawing.Point(175, 193);
            this.tb_CustomerPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_CustomerPhone.Name = "tb_CustomerPhone";
            this.tb_CustomerPhone.Size = new System.Drawing.Size(260, 32);
            this.tb_CustomerPhone.TabIndex = 15;
            this.tb_CustomerPhone.Text = "IIII (OOOO)";
            // 
            // tb_CustomerMail
            // 
            this.tb_CustomerMail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CustomerMail.Location = new System.Drawing.Point(175, 255);
            this.tb_CustomerMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_CustomerMail.Name = "tb_CustomerMail";
            this.tb_CustomerMail.Size = new System.Drawing.Size(260, 32);
            this.tb_CustomerMail.TabIndex = 16;
            this.tb_CustomerMail.Text = "IIII (OOOO)";
            // 
            // num_postcode
            // 
            this.num_postcode.Font = new System.Drawing.Font("Calibri", 12F);
            this.num_postcode.InterceptArrowKeys = false;
            this.num_postcode.Location = new System.Drawing.Point(175, 132);
            this.num_postcode.Margin = new System.Windows.Forms.Padding(4);
            this.num_postcode.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.num_postcode.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_postcode.Name = "num_postcode";
            this.num_postcode.Size = new System.Drawing.Size(260, 32);
            this.num_postcode.TabIndex = 17;
            this.num_postcode.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // Form_Customer_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(460, 410);
            this.Controls.Add(this.num_postcode);
            this.Controls.Add(this.tb_CustomerMail);
            this.Controls.Add(this.tb_CustomerPhone);
            this.Controls.Add(this.tb_CustomerAddress);
            this.Controls.Add(this.tb_CustomerName);
            this.Controls.Add(this.bt_SaveCustomer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Customer_Edit";
            this.Text = "Kundeoprettelse og redigering";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_postcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ckBox_IsDeleted;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_SaveCustomer;
        private System.Windows.Forms.TextBox tb_CustomerName;
        private System.Windows.Forms.TextBox tb_CustomerAddress;
        private System.Windows.Forms.TextBox tb_CustomerPhone;
        private System.Windows.Forms.TextBox tb_CustomerMail;
        private System.Windows.Forms.NumericUpDown num_postcode;
    }
}