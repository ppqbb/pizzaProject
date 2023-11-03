using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Pizza_new
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal totalAVT;
        decimal total;
        decimal sizeL;
        decimal sizeM;
        decimal chiken;
        decimal chssey;
        decimal toppings2;
        decimal toppings3;
        decimal toppings4;
        decimal toppings;
        decimal grand_total;
        decimal QQQ;
        private void btn_Add_TO_Order_Click(object sender, EventArgs e)
        {

            if (rad_Medium.Checked)
            {
                sizeL = 0;
                sizeM = 15.5m;
            }
            if (rad_Large.Checked)
            {
                sizeM = 0;
                sizeL = 20.5m;
            }
            if (rad_outChsse.Checked)
            {
                chssey = 0;
            }
            if (rad_Cheesy.Checked)
            {
                chssey = 6.5m;
            }
            if (chk_Chicken.Checked)
            {
                chiken = 5.5m;
            }
            if (chk_Tomato.Checked)
            {
                toppings = 1.25m;
            }
            if (chk_Green_Pepper.Checked)
            {
                toppings2 = 1.25m;
            }
            if (chk_Black_Olive.Checked)
            {
                toppings3 = 1.25m;
            }
            if (chk_Onion.Checked)
            {
                toppings4 = 1.25m;
            }
            total = sizeM + sizeL + chssey + chiken + toppings + toppings2 + toppings3 + toppings4;
            totalAVT = total / 100 * 15;
            grand_total = total + totalAVT;

            lbl_Total.Text = total.ToString();
            lbl_VAT.Text = totalAVT.ToString();
            try
            {
                QQQ = Convert.ToDecimal(txt_Quantity.Text);
                lbl_Grand_Total.Text = Convert.ToString(QQQ * grand_total);
            }
            catch { }
        }

        private void btn_Resrt_Click(object sender, EventArgs e)
        {
            lbl_Total.Text = "";
            lbl_VAT.Text = "";
            lbl_Grand_Total.Text = "";
            txt_Quantity.Text = "";
            lst_Order_Details.Items.Clear();
            rad_Medium.Checked = true;
            rad_Large.Checked = false;
            rad_Cheesy.Checked = false;
            rad_outChsse.Checked = true;
            chk_Black_Olive.Checked = false;
            chk_Chicken.Checked = false;
            chk_Green_Pepper.Checked = false;
            chk_Onion.Checked = false;
            chk_Tomato.Checked = false;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Place_Order_Click(object sender, EventArgs e)
        {
            lst_Order_Details.Items.Add("QT           Item           Price");
            lst_Order_Details.Items.Add(QQQ+ "           " + total+ "           " + QQQ * grand_total);
        }
    }
}

    

