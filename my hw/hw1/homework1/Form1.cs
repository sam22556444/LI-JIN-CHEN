using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cb_male.SelectedIndex = 0;
            cb_star.SelectedIndex = 0;
        }

        private void cb_male_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_hello_Click(object sender, EventArgs e)
        {
            if (tb_name.Text == "")
            {
                MessageBox.Show("請輸入名子");
            }

            else if (tb_egname.Text == "")
            {
                MessageBox.Show("請輸入英文名");
            }
            else
            {
                MessageBox.Show($"hello 我是:{tb_name.Text} \n英文名子是:{tb_egname.Text}\n性別是:{cb_male.Text}\n星座是:{cb_star.Text}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_name.Text == "")
            {
                MessageBox.Show("請輸入名子");
            }

            else if (tb_egname.Text == "")
            {
                MessageBox.Show("請輸入英文名");
            }
            else
            {
                MessageBox.Show($"你好 我是:{tb_name.Text} \n英文名子是:{tb_egname.Text}\n性別是:{cb_male.Text}\n星座是:{cb_star.Text}");
            }
        }
    }
}
