namespace Project_Pizza_new
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_Medium = new System.Windows.Forms.RadioButton();
            this.rad_Large = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rad_outChsse = new System.Windows.Forms.RadioButton();
            this.rad_Cheesy = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chk_Black_Olive = new System.Windows.Forms.CheckBox();
            this.chk_Onion = new System.Windows.Forms.CheckBox();
            this.chk_Green_Pepper = new System.Windows.Forms.CheckBox();
            this.chk_Chicken = new System.Windows.Forms.CheckBox();
            this.chk_Tomato = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Resrt = new System.Windows.Forms.Button();
            this.btn_Place_Order = new System.Windows.Forms.Button();
            this.btn_Add_TO_Order = new System.Windows.Forms.Button();
            this.lst_Order_Details = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Grand_Total = new System.Windows.Forms.Label();
            this.lbl_VAT = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_Medium);
            this.groupBox1.Controls.Add(this.rad_Large);
            this.groupBox1.Location = new System.Drawing.Point(37, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pizza Size";
            // 
            // rad_Medium
            // 
            this.rad_Medium.AutoSize = true;
            this.rad_Medium.Checked = true;
            this.rad_Medium.Location = new System.Drawing.Point(27, 35);
            this.rad_Medium.Name = "rad_Medium";
            this.rad_Medium.Size = new System.Drawing.Size(169, 23);
            this.rad_Medium.TabIndex = 1;
            this.rad_Medium.TabStop = true;
            this.rad_Medium.Text = "Medium(15.5 SAR)";
            this.rad_Medium.UseVisualStyleBackColor = true;
            // 
            // rad_Large
            // 
            this.rad_Large.AutoSize = true;
            this.rad_Large.Location = new System.Drawing.Point(27, 71);
            this.rad_Large.Name = "rad_Large";
            this.rad_Large.Size = new System.Drawing.Size(152, 23);
            this.rad_Large.TabIndex = 0;
            this.rad_Large.Text = "Large(20.5 SAR)";
            this.rad_Large.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rad_outChsse);
            this.groupBox2.Controls.Add(this.rad_Cheesy);
            this.groupBox2.Location = new System.Drawing.Point(350, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 116);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pizza Type";
            // 
            // rad_outChsse
            // 
            this.rad_outChsse.AutoSize = true;
            this.rad_outChsse.Checked = true;
            this.rad_outChsse.Location = new System.Drawing.Point(41, 35);
            this.rad_outChsse.Name = "rad_outChsse";
            this.rad_outChsse.Size = new System.Drawing.Size(139, 23);
            this.rad_outChsse.TabIndex = 3;
            this.rad_outChsse.TabStop = true;
            this.rad_outChsse.Text = "with out Chees";
            this.rad_outChsse.UseVisualStyleBackColor = true;
            // 
            // rad_Cheesy
            // 
            this.rad_Cheesy.AutoSize = true;
            this.rad_Cheesy.Location = new System.Drawing.Point(41, 71);
            this.rad_Cheesy.Name = "rad_Cheesy";
            this.rad_Cheesy.Size = new System.Drawing.Size(154, 23);
            this.rad_Cheesy.TabIndex = 2;
            this.rad_Cheesy.Text = "Cheesy(6.5 SAR)";
            this.rad_Cheesy.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chk_Black_Olive);
            this.groupBox3.Controls.Add(this.chk_Onion);
            this.groupBox3.Controls.Add(this.chk_Green_Pepper);
            this.groupBox3.Controls.Add(this.chk_Chicken);
            this.groupBox3.Controls.Add(this.chk_Tomato);
            this.groupBox3.Location = new System.Drawing.Point(37, 170);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(564, 140);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Toppings";
            // 
            // chk_Black_Olive
            // 
            this.chk_Black_Olive.AutoSize = true;
            this.chk_Black_Olive.Location = new System.Drawing.Point(353, 27);
            this.chk_Black_Olive.Name = "chk_Black_Olive";
            this.chk_Black_Olive.Size = new System.Drawing.Size(196, 23);
            this.chk_Black_Olive.TabIndex = 8;
            this.chk_Black_Olive.Text = "Black Olive (1.25 SAR)";
            this.chk_Black_Olive.UseVisualStyleBackColor = true;
            // 
            // chk_Onion
            // 
            this.chk_Onion.AutoSize = true;
            this.chk_Onion.Location = new System.Drawing.Point(354, 56);
            this.chk_Onion.Name = "chk_Onion";
            this.chk_Onion.Size = new System.Drawing.Size(162, 23);
            this.chk_Onion.TabIndex = 7;
            this.chk_Onion.Text = "Onion (1.25 SAR)";
            this.chk_Onion.UseVisualStyleBackColor = true;
            // 
            // chk_Green_Pepper
            // 
            this.chk_Green_Pepper.AutoSize = true;
            this.chk_Green_Pepper.Location = new System.Drawing.Point(28, 111);
            this.chk_Green_Pepper.Name = "chk_Green_Pepper";
            this.chk_Green_Pepper.Size = new System.Drawing.Size(215, 23);
            this.chk_Green_Pepper.TabIndex = 6;
            this.chk_Green_Pepper.Text = "Green Pepper (1.25 SAR)";
            this.chk_Green_Pepper.UseVisualStyleBackColor = true;
            // 
            // chk_Chicken
            // 
            this.chk_Chicken.AutoSize = true;
            this.chk_Chicken.Location = new System.Drawing.Point(27, 27);
            this.chk_Chicken.Name = "chk_Chicken";
            this.chk_Chicken.Size = new System.Drawing.Size(165, 23);
            this.chk_Chicken.TabIndex = 5;
            this.chk_Chicken.Text = "Chicken (5.5 SAR)";
            this.chk_Chicken.UseVisualStyleBackColor = true;
            // 
            // chk_Tomato
            // 
            this.chk_Tomato.AutoSize = true;
            this.chk_Tomato.Location = new System.Drawing.Point(27, 71);
            this.chk_Tomato.Name = "chk_Tomato";
            this.chk_Tomato.Size = new System.Drawing.Size(174, 23);
            this.chk_Tomato.TabIndex = 4;
            this.chk_Tomato.Text = "Tomato (1.25 SAR)";
            this.chk_Tomato.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(619, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(37, 379);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(110, 27);
            this.txt_Quantity.TabIndex = 10;
            this.txt_Quantity.Text = "1";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(432, 531);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(98, 58);
            this.btn_Close.TabIndex = 11;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Resrt
            // 
            this.btn_Resrt.Location = new System.Drawing.Point(326, 531);
            this.btn_Resrt.Name = "btn_Resrt";
            this.btn_Resrt.Size = new System.Drawing.Size(98, 58);
            this.btn_Resrt.TabIndex = 12;
            this.btn_Resrt.Text = "Resrt";
            this.btn_Resrt.UseVisualStyleBackColor = true;
            this.btn_Resrt.Click += new System.EventHandler(this.btn_Resrt_Click);
            // 
            // btn_Place_Order
            // 
            this.btn_Place_Order.Location = new System.Drawing.Point(220, 531);
            this.btn_Place_Order.Name = "btn_Place_Order";
            this.btn_Place_Order.Size = new System.Drawing.Size(98, 58);
            this.btn_Place_Order.TabIndex = 13;
            this.btn_Place_Order.Text = "Place Order";
            this.btn_Place_Order.UseVisualStyleBackColor = true;
            this.btn_Place_Order.Click += new System.EventHandler(this.btn_Place_Order_Click);
            // 
            // btn_Add_TO_Order
            // 
            this.btn_Add_TO_Order.Location = new System.Drawing.Point(37, 448);
            this.btn_Add_TO_Order.Name = "btn_Add_TO_Order";
            this.btn_Add_TO_Order.Size = new System.Drawing.Size(152, 46);
            this.btn_Add_TO_Order.TabIndex = 14;
            this.btn_Add_TO_Order.Text = "Add TO Order";
            this.btn_Add_TO_Order.UseVisualStyleBackColor = true;
            this.btn_Add_TO_Order.Click += new System.EventHandler(this.btn_Add_TO_Order_Click);
            // 
            // lst_Order_Details
            // 
            this.lst_Order_Details.FormattingEnabled = true;
            this.lst_Order_Details.ItemHeight = 19;
            this.lst_Order_Details.Location = new System.Drawing.Point(608, 336);
            this.lst_Order_Details.Name = "lst_Order_Details";
            this.lst_Order_Details.Size = new System.Drawing.Size(204, 213);
            this.lst_Order_Details.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Quantity";
            // 
            // lbl_Grand_Total
            // 
            this.lbl_Grand_Total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Grand_Total.Location = new System.Drawing.Point(472, 465);
            this.lbl_Grand_Total.Name = "lbl_Grand_Total";
            this.lbl_Grand_Total.Size = new System.Drawing.Size(104, 29);
            this.lbl_Grand_Total.TabIndex = 17;
            this.lbl_Grand_Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_VAT
            // 
            this.lbl_VAT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_VAT.Location = new System.Drawing.Point(472, 419);
            this.lbl_VAT.Name = "lbl_VAT";
            this.lbl_VAT.Size = new System.Drawing.Size(104, 32);
            this.lbl_VAT.TabIndex = 18;
            this.lbl_VAT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Total
            // 
            this.lbl_Total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Total.Location = new System.Drawing.Point(472, 375);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(104, 31);
            this.lbl_Total.TabIndex = 19;
            this.lbl_Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "VAT (15%):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(347, 475);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "Grand Total:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(662, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 19);
            this.label8.TabIndex = 23;
            this.label8.Text = "Order Details";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 617);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lbl_Grand_Total);
            this.Controls.Add(this.btn_Add_TO_Order);
            this.Controls.Add(this.lbl_VAT);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Resrt);
            this.Controls.Add(this.btn_Place_Order);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lst_Order_Details);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Pizza Ordening system";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rad_Medium;
        private System.Windows.Forms.RadioButton rad_Large;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rad_outChsse;
        private System.Windows.Forms.RadioButton rad_Cheesy;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chk_Black_Olive;
        private System.Windows.Forms.CheckBox chk_Onion;
        private System.Windows.Forms.CheckBox chk_Green_Pepper;
        private System.Windows.Forms.CheckBox chk_Chicken;
        private System.Windows.Forms.CheckBox chk_Tomato;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Resrt;
        private System.Windows.Forms.Button btn_Place_Order;
        private System.Windows.Forms.Button btn_Add_TO_Order;
        private System.Windows.Forms.ListBox lst_Order_Details;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Grand_Total;
        private System.Windows.Forms.Label lbl_VAT;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

