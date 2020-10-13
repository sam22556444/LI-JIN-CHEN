using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        string x;
        string y;
        string z;
        string n;
        int total;
        private void 酒_Click(object sender, EventArgs e)
        {
            Class1.winemoney = Class1.winemoney + 100;
            Class1.winemany = Class1.winemany + 1;


            x = "啤酒數量" + Class1.winemany.ToString() + "總額:" + Class1.winemoney.ToString() + "\n";
            allmoney.Text = x + y + z + n;
            total = Class1.frimoney + Class1.hammoney + Class1.winemoney + Class1.redmoney;
            totalmoney.Text = total.ToString();
        }

        private void 漢堡_Click(object sender, EventArgs e)
        {
            Class1.hammoney = Class1.hammoney + 200;
            Class1.hammany = Class1.hammany + 1;

            y = "漢堡數量" + Class1.hammany.ToString() + "總額:" + Class1.hammoney + "\n";
            allmoney.Text = x + y + z + n;
            total = Class1.frimoney + Class1.hammoney + Class1.winemoney + Class1.redmoney;
            totalmoney.Text = total.ToString();


        }

        private void 薯條_Click(object sender, EventArgs e)
        {
            Class1.frimoney = Class1.frimoney + 150;
            Class1.frimany = Class1.frimany + 1;
            z = "薯條數量" + Class1.frimany.ToString() + "總額:" + Class1.frimoney + "\n";
            allmoney.Text = x + y + z + n;
            total = Class1.frimoney + Class1.hammoney + Class1.winemoney + Class1.redmoney;
            totalmoney.Text = total.ToString();
           

        }
        private void btn_red_Click(object sender, EventArgs e)
        {
            Class1.redmoney = Class1.redmoney + 50;
            Class1.redmany = Class1.redmany + 1;
            n = "紅茶數量" + Class1.redmany.ToString() + "總額:" + Class1.redmoney + "\n";
            allmoney.Text = x + y + z + n;
            total = Class1.frimoney + Class1.hammoney + Class1.winemoney+Class1.redmoney;
            totalmoney.Text = total.ToString();
        }

        private void allclear_Click(object sender, EventArgs e)
        {
            Class1.frimoney = 0;
            Class1.frimany = 0;
            Class1.hammoney = 0;
            Class1.hammany = 0;
            Class1.winemoney = 0;
            Class1.winemany = 0;
            Class1.redmoney = 0;
            Class1.redmany = 0;
            x = y = z = n= "";
            total -= total;
            totalmoney.Text ="0";
            allmoney.Text = "尚未點餐";
        }

        private void paymoney_Click(object sender, EventArgs e)
        {
            if (total == 0)
            {
                MessageBox.Show("尚未點餐");
            }
            else
            {
                MessageBox.Show("請付:" + totalmoney.Text);
            }
        }

        private void paycridi_Click(object sender, EventArgs e)
        {
            if (total == 0)
            {
                MessageBox.Show("尚未點餐");

            }
            else
            {
                int cri = total * 9 / 10;
                MessageBox.Show("請付:" + cri);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void totalmoney_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        
    }
}


