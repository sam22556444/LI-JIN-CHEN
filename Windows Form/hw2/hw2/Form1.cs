using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw2
{
    public partial class Form1 : Form
    {
        public struct pay
        {
            public double money;
            public double year;
            public double persent;
            public double firstpay;
            



        }
        
                      
          
            
        public Form1()
        {
            InitializeComponent();
        }
        public double a;
        


        public void btn_mp_Click(object sender, EventArgs e)
        {
            pay p;
            p.money = double.Parse(tb_money.Text);
            p.year = double.Parse(tb_time.Text);
            p.persent = double.Parse(tb_persent.Text);
            p.firstpay = double.Parse(tb_firstmoney.Text);
            
            
            a = ((Math.Pow(1 + (p.persent /1200), p.year * 12) * (p.persent / 1200)) /(Math.Pow(1 + (p.persent/1200), p.year * 12) - 1))*(p.money-p.firstpay);


            MessageBox.Show("月付額:"+(int)a);
            

        }

        public void btn_allpay_Click(object sender, EventArgs e)
        {
            pay p;
            p.money = double.Parse(tb_money.Text);
            p.year = double.Parse(tb_time.Text);
            p.persent = double.Parse(tb_persent.Text);
            p.firstpay = double.Parse(tb_firstmoney.Text);
            a = ((Math.Pow(1 + (p.persent / 1200), p.year * 12) * (p.persent / 1200)) / (Math.Pow(1 + (p.persent / 1200), p.year * 12) - 1)) * (p.money - p.firstpay);
            double b = a * 12;
            
            MessageBox.Show("總額:" + (int)b);
            
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            pay p;
            p.money = double.Parse(tb_money.Text);
            p.year = double.Parse(tb_time.Text);
            p.persent = double.Parse(tb_persent.Text);
            p.firstpay = double.Parse(tb_firstmoney.Text);
            a = ((Math.Pow(1 + (p.persent / 1200), p.year * 12) * (p.persent / 1200)) / (Math.Pow(1 + (p.persent / 1200), p.year * 12) - 1)) * (p.money - p.firstpay);
            double b = a * 12;
            int d = (int)a;
            int c = (int)b; 
            Form2 fr2 = new Form2(tb_money.Text,tb_time.Text,tb_persent.Text,d.ToString(),c.ToString());
            fr2.Show();
            

        }
    }
}