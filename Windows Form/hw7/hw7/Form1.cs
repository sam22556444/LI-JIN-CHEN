using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_twi_Click(object sender, EventArgs e)
        {
            int num;
            bool numtry = int.TryParse(tb_num.Text, out num);
            if (numtry)
            {
                if (num % 2 == 0)
                {
                    lb_result.Text = num + "是偶數";
                }
                else if (num % 2 != 0)
                {
                    lb_result.Text = num + "是奇數";
                }
            }
            else
            {
                MessageBox.Show("請輸入數字");
            }
        }

        int[] arr = { 1, 15, 211, 41, 287, 158, 37, 82, 384, 421 };

        private void btn_max_Click(object sender, EventArgs e)
        {
            lb_result.Text = "陣列 [ 1, 15 , 211, 41 , 287 , 158 , 37, 82 , 384 , 421 ]\n" + "最大值:" +
                arr.Max() + "\n最小值:" + arr.Min();
        }

        private void btn_tri2_Click(object sender, EventArgs e)
        {
            int allone = 0;
            int alltri = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0) { alltri++; }
                else { allone++; }
            }
            lb_result.Text = $"陣列 [ 1, 15 , 211, 41 , 287 , 158 , 37, 82 , 384 , 421 ]\n" +
                $"奇數:{allone}個\n偶數:{alltri}個";
        }
        string[] arrstr = { "mother張", "emma", "迪克蕭", "J400", "Candy", "cindy", "Cocount", "Motherfacker" };
        private void btn_Cc_Click(object sender, EventArgs e)
        {
            int strcon = 0;
            foreach (string s in arrstr)
            {
                foreach (char c in s)
                {
                    if (c == 'c' | c == 'C')
                    {
                        strcon++;
                        break;
                    }
                }

                lb_result.Text = "陣列[mother張, emma, 迪克蕭, J400, Candy, cindy, Cocount, Motherfacker]" +
                        "\n有C,c共" + strcon + "個";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int maxindex = 0;
            int max = 0;
            int[] count1 = new int[8];

            for (int i = 0; i < arrstr.Length; i++)
            {
                count1[i] = arrstr[i].Length;
                max = count1.Max();

            }
            maxindex = Array.IndexOf(count1, max);
            lb_result.Text = "陣列[mother張, emma, 迪克蕭, J400, Candy, cindy, Cocount, Motherfacker]" +
                "\n最長的是:" + arrstr[maxindex];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lb_result.Text = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                    if (j == 0 | j == 9 | i == 0 | i == 9)
                    {
                        lb_result.Text += "1 ";
                    }
                    else lb_result.Text += "0 ";
                }
                lb_result.Text += "\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lb_result.Text = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                    if (j == 0 | j == 9 | i == 0 | i == 9)
                    {
                        lb_result.Text += "0 ";
                    }
                    else lb_result.Text += "1 ";
                }
                lb_result.Text += "\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lb_result.Text = "";
            int[,] a = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        a[0, 0] = 1;
                        j++;
                    }
                    if (i % 2 == 0)
                    {
                        a[i, 0] = 1;
                    }
                    else a[i, 0] = 0;
                    if (i != 0 && j == 0)
                    {
                        if (a[i - 1, 9] == 1)
                        {
                            a[i, j] = 0;
                        }
                        else a[i, j] = 1;
                    }
                    else if (a[i, j - 1] == 1)
                    {
                        a[i, j] = 0;
                    }
                    else if (a[i, j - 1] == 0)
                    {
                        a[i, j] = 1;
                    }
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                    lb_result.Text += a[i, j].ToString();
                }
                lb_result.Text += "\n";
            }
        }
        void Swap(ref int n1, ref int n2)
        {
            int t = n1;
            n1 = n2;
            n2 = t;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int n1 = 100, n2 = 50, n3 = 100, n4 = 50;
            Swap(ref n1, ref n2);
            lb_result.Text = "換位前n1=" + n3 + ",n2=" + n4 + "\n換位後n1=" + n1 + ",n2=" + n2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sum1= 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum1 += arr[i];
            }
            lb_result.Text = "陣列 [ 1, 15 , 211, 41 , 287 , 158 , 37, 82 , 384 , 421 ]\n " +
                "加總為:" + sum1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int max = arr.Max();
            lb_result.Text = "陣列 [ 1, 15 , 211, 41 , 287 , 158 , 37, 82 , 384 , 421 ]\n" +
                "最大值為:" + max;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int min = arr.Min();
            lb_result.Text = "陣列 [ 1, 15 , 211, 41 , 287 , 158 , 37, 82 , 384 , 421 ]\n" +
                "最小值為:" + min;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            lb_result.Text = "";
            tb_num.Text = "";
        }
    }
}
