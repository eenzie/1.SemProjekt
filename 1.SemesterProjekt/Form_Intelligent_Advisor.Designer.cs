namespace _1.SemesterProjekt
{
    partial class Form_Intelligent_Advisor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmBox_IR_Colour = new System.Windows.Forms.ComboBox();
            this.cmBox_IR_Brand = new System.Windows.Forms.ComboBox();
            this.num_IR_MinPrice = new System.Windows.Forms.NumericUpDown();
            this.num_IR_MaxPrice = new System.Windows.Forms.NumericUpDown();
            this.num_IR_Length = new System.Windows.Forms.NumericUpDown();
            this.num_IR_Width = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_IR_Result = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.cmBox_IR_Shape = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmBox_IR_Material = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_IR_Search = new System.Windows.Forms.Button();
            this.cmBox_IR_SortPrice = new System.Windows.Forms.ComboBox();
            this.link_IRHelp = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.num_IR_MinPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_IR_MaxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_IR_Length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_IR_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IR_Result)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Velkommen til SynsPunkt Aps";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Intelligent Rådgivning";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hvad er din favoritfarve?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(998, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bredde";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(998, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Længde";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(378, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Har du et bestemt mærke i tankerne?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(314, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Justér pris?";
            // 
            // cmBox_IR_Colour
            // 
            this.cmBox_IR_Colour.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBox_IR_Colour.FormattingEnabled = true;
            this.cmBox_IR_Colour.Items.AddRange(new object[] {
            "Sort",
            "Hvid",
            "Sølv",
            "Guld",
            "Blå",
            "Rød",
            "Gul",
            "Grøn",
            "Lilla",
            "Lyserød ",
            "Orange"});
            this.cmBox_IR_Colour.Location = new System.Drawing.Point(15, 148);
            this.cmBox_IR_Colour.Margin = new System.Windows.Forms.Padding(4);
            this.cmBox_IR_Colour.Name = "cmBox_IR_Colour";
            this.cmBox_IR_Colour.Size = new System.Drawing.Size(327, 32);
            this.cmBox_IR_Colour.TabIndex = 7;
            // 
            // cmBox_IR_Brand
            // 
            this.cmBox_IR_Brand.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBox_IR_Brand.FormattingEnabled = true;
            this.cmBox_IR_Brand.Location = new System.Drawing.Point(18, 230);
            this.cmBox_IR_Brand.Margin = new System.Windows.Forms.Padding(4);
            this.cmBox_IR_Brand.Name = "cmBox_IR_Brand";
            this.cmBox_IR_Brand.Size = new System.Drawing.Size(327, 32);
            this.cmBox_IR_Brand.TabIndex = 8;
            // 
            // num_IR_MinPrice
            // 
            this.num_IR_MinPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_IR_MinPrice.Location = new System.Drawing.Point(712, 303);
            this.num_IR_MinPrice.Margin = new System.Windows.Forms.Padding(4);
            this.num_IR_MinPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_IR_MinPrice.Name = "num_IR_MinPrice";
            this.num_IR_MinPrice.Size = new System.Drawing.Size(108, 32);
            this.num_IR_MinPrice.TabIndex = 9;
            // 
            // num_IR_MaxPrice
            // 
            this.num_IR_MaxPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_IR_MaxPrice.Location = new System.Drawing.Point(896, 303);
            this.num_IR_MaxPrice.Margin = new System.Windows.Forms.Padding(4);
            this.num_IR_MaxPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_IR_MaxPrice.Name = "num_IR_MaxPrice";
            this.num_IR_MaxPrice.Size = new System.Drawing.Size(119, 32);
            this.num_IR_MaxPrice.TabIndex = 10;
            // 
            // num_IR_Length
            // 
            this.num_IR_Length.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_IR_Length.Location = new System.Drawing.Point(1099, 152);
            this.num_IR_Length.Margin = new System.Windows.Forms.Padding(4);
            this.num_IR_Length.Name = "num_IR_Length";
            this.num_IR_Length.Size = new System.Drawing.Size(160, 32);
            this.num_IR_Length.TabIndex = 11;
            // 
            // num_IR_Width
            // 
            this.num_IR_Width.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_IR_Width.Location = new System.Drawing.Point(1099, 193);
            this.num_IR_Width.Margin = new System.Windows.Forms.Padding(4);
            this.num_IR_Width.Name = "num_IR_Width";
            this.num_IR_Width.Size = new System.Drawing.Size(160, 32);
            this.num_IR_Width.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(662, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "Min";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(840, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "Max";
            // 
            // dgv_IR_Result
            // 
            this.dgv_IR_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_IR_Result.Location = new System.Drawing.Point(15, 351);
            this.dgv_IR_Result.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_IR_Result.Name = "dgv_IR_Result";
            this.dgv_IR_Result.RowHeadersWidth = 51;
            this.dgv_IR_Result.Size = new System.Drawing.Size(1264, 254);
            this.dgv_IR_Result.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(237, 33);
            this.label10.TabIndex = 16;
            this.label10.Text = "Synspunkt anbefaler";
            // 
            // cmBox_IR_Shape
            // 
            this.cmBox_IR_Shape.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBox_IR_Shape.FormattingEnabled = true;
            this.cmBox_IR_Shape.Items.AddRange(new object[] {
            "Rund",
            "Oval",
            "Firkant"});
            this.cmBox_IR_Shape.Location = new System.Drawing.Point(491, 151);
            this.cmBox_IR_Shape.Margin = new System.Windows.Forms.Padding(4);
            this.cmBox_IR_Shape.Name = "cmBox_IR_Shape";
            this.cmBox_IR_Shape.Size = new System.Drawing.Size(329, 32);
            this.cmBox_IR_Shape.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(486, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(396, 29);
            this.label11.TabIndex = 17;
            this.label11.Text = "Hvilken form passer bedst til dit ansigt?";
            // 
            // cmBox_IR_Material
            // 
            this.cmBox_IR_Material.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBox_IR_Material.FormattingEnabled = true;
            this.cmBox_IR_Material.Items.AddRange(new object[] {
            "Plastik",
            "Metal"});
            this.cmBox_IR_Material.Location = new System.Drawing.Point(491, 230);
            this.cmBox_IR_Material.Margin = new System.Windows.Forms.Padding(4);
            this.cmBox_IR_Material.Name = "cmBox_IR_Material";
            this.cmBox_IR_Material.Size = new System.Drawing.Size(329, 32);
            this.cmBox_IR_Material.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(486, 198);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(192, 29);
            this.label12.TabIndex = 19;
            this.label12.Text = "Hvilket materiale?";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(991, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(187, 29);
            this.label13.TabIndex = 21;
            this.label13.Text = "Hvilken størrelse?";
            // 
            // btn_IR_Search
            // 
            this.btn_IR_Search.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IR_Search.Location = new System.Drawing.Point(1056, 298);
            this.btn_IR_Search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_IR_Search.Name = "btn_IR_Search";
            this.btn_IR_Search.Size = new System.Drawing.Size(223, 41);
            this.btn_IR_Search.TabIndex = 22;
            this.btn_IR_Search.Text = "Søg";
            this.btn_IR_Search.UseVisualStyleBackColor = true;
            this.btn_IR_Search.Click += new System.EventHandler(this.btn_IR_Search_Click);
            // 
            // cmBox_IR_SortPrice
            // 
            this.cmBox_IR_SortPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBox_IR_SortPrice.FormattingEnabled = true;
            this.cmBox_IR_SortPrice.Items.AddRange(new object[] {
            "Lav til høj pris",
            "Høj til lav pris"});
            this.cmBox_IR_SortPrice.Location = new System.Drawing.Point(450, 304);
            this.cmBox_IR_SortPrice.Name = "cmBox_IR_SortPrice";
            this.cmBox_IR_SortPrice.Size = new System.Drawing.Size(194, 32);
            this.cmBox_IR_SortPrice.TabIndex = 23;
            // 
            // link_IRHelp
            // 
            this.link_IRHelp.AutoSize = true;
            this.link_IRHelp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_IRHelp.Location = new System.Drawing.Point(1045, 11);
            this.link_IRHelp.Name = "link_IRHelp";
            this.link_IRHelp.Size = new System.Drawing.Size(234, 24);
            this.link_IRHelp.TabIndex = 51;
            this.link_IRHelp.TabStop = true;
            this.link_IRHelp.Text = "Få hjælp til denne funktion";
            this.link_IRHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_IRHelp_LinkClicked);
            // 
            // Form_Intelligent_Advisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1295, 623);
            this.Controls.Add(this.link_IRHelp);
            this.Controls.Add(this.cmBox_IR_SortPrice);
            this.Controls.Add(this.btn_IR_Search);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmBox_IR_Material);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmBox_IR_Shape);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgv_IR_Result);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.num_IR_Width);
            this.Controls.Add(this.num_IR_Length);
            this.Controls.Add(this.num_IR_MaxPrice);
            this.Controls.Add(this.num_IR_MinPrice);
            this.Controls.Add(this.cmBox_IR_Brand);
            this.Controls.Add(this.cmBox_IR_Colour);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Intelligent_Advisor";
            this.Text = "Intelligent rådgivning";
            this.Load += new System.EventHandler(this.Form_Intelligent_Advisor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_IR_MinPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_IR_MaxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_IR_Length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_IR_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IR_Result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmBox_IR_Colour;
        private System.Windows.Forms.ComboBox cmBox_IR_Brand;
        private System.Windows.Forms.NumericUpDown num_IR_MinPrice;
        private System.Windows.Forms.NumericUpDown num_IR_MaxPrice;
        private System.Windows.Forms.NumericUpDown num_IR_Length;
        private System.Windows.Forms.NumericUpDown num_IR_Width;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv_IR_Result;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmBox_IR_Shape;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmBox_IR_Material;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_IR_Search;
        private System.Windows.Forms.ComboBox cmBox_IR_SortPrice;
        private System.Windows.Forms.LinkLabel link_IRHelp;
    }
}