using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string result;
        private void btn_stu_Click(object sender, EventArgs e)
        {
            score sc;
            sc.name = tb_name.Text;
            sc.chi = int.Parse(tb_chi.Text);
            sc.english = int.Parse(tb_english.Text);
            sc.math = int.Parse(tb_math.Text);
            result = "名子：" + sc.name + "\n國文分數:" + sc.chi + "\n英文分數:" + sc.english + "\n數學分數:" + sc.math;

            int[] arr = new[]
            {sc.chi,sc.english,sc.math};




        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            lb_sc.Text = "";
            lb_sc.Text = result;
        }

        private void bt_max_Click(object sender, EventArgs e)
        {
            score sc;
            sc.name = tb_name.Text;
            sc.chi = int.Parse(tb_chi.Text);
            sc.english = int.Parse(tb_english.Text);
            sc.math = int.Parse(tb_math.Text);
            int[] arr = new[]
            {sc.chi,sc.english,sc.math};
            string[] cla = new[]
            {"中文","英文","數學"};
            lb_max.Text = "最高分:" + cla[Array.IndexOf(arr, arr.Max())] + arr.Max() + 
                          "\n最低分:" + cla[Array.IndexOf(arr, arr.Min())]+ arr.Min();
            
}
    }
}
