using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw8
{
    public partial class Form1 : Form
    {
        public struct all
        {
            public double num1;
            public double num2;
        
        }

        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int ans1;
            bool isCovert1 = int.TryParse(tb_1.Text, out ans1);
            if (isCovert1 == false)
            {
                MessageBox.Show("請在欄位輸入數字");
                return;
            }
            int ans2;
            bool isCovert2 = int.TryParse(tb_2.Text, out ans2);
            if (isCovert2 == false)
            {
                MessageBox.Show("請在欄位輸入數字");
                return;
            }
            all a;
            a.num1 = double.Parse( tb_1.Text);
            a.num2 = double.Parse(tb_2.Text);
            all1.Text = (a.num1 + a.num2).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ans1;
            bool isCovert1 = int.TryParse(tb_1.Text, out ans1);
            if (isCovert1 == false)
            {
                MessageBox.Show("請在欄位輸入數字");
                return;
            }
            int ans2;
            bool isCovert2 = int.TryParse(tb_2.Text, out ans2);
            if (isCovert2 == false)
            {
                MessageBox.Show("請在欄位輸入數字");
                return;
            }
            all a;
            a.num1 = double.Parse(tb_1.Text);
            a.num2 = double.Parse(tb_2.Text);
            all1.Text = (a.num1 - a.num2).ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ans1;
            bool isCovert1 = int.TryParse(tb_1.Text, out ans1);
            if (isCovert1 == false)
            {
                MessageBox.Show("請在欄位輸入數字");
                return;
            }
            int ans2;
            bool isCovert2 = int.TryParse(tb_2.Text, out ans2);
            if (isCovert2 == false)
            {
                MessageBox.Show("請在欄位輸入數字");
                return;
            }
            all a;
            a.num1 = double.Parse(tb_1.Text);
            a.num2 = double.Parse(tb_2.Text);
            all1.Text = (a.num1 * a.num2).ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ans1;
            bool isCovert1 = int.TryParse(tb_1.Text, out ans1);
            if (isCovert1 == false)
            {
                MessageBox.Show("請在欄位輸入數字");
                return;
            }
            int ans2;
            bool isCovert2 = int.TryParse(tb_2.Text, out ans2);
            if (isCovert2 == false)
            {
                MessageBox.Show("請在欄位輸入數字");
                return;
            }
            all a;
            a.num1 = double.Parse(tb_1.Text);
            a.num2 = double.Parse(tb_2.Text);
            all1.Text = (a.num1 / a.num2).ToString();
        }
    }
}
