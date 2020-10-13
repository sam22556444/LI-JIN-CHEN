using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        ArrayList ls = new ArrayList();
        Random ra = new Random();
        student ram;

        void member()
        {


            foreach (student ram in ls)
            {
                int total = 0;
                total = ram.chinese + ram.english + ram.math;

                string[] str = new[] { "數學", "中文", "英文" };
                int[] arr = new[] { ram.math, ram.chinese, ram.english };

                ListViewItem list = new ListViewItem(ram.name);
                list.SubItems.Add(ram.math.ToString());
                list.SubItems.Add(ram.english.ToString());
                list.SubItems.Add(ram.chinese.ToString());
                list.SubItems.Add(total.ToString());
                list.SubItems.Add(str[Array.IndexOf(arr, arr.Max())] + arr.Max());
                list.SubItems.Add(str[Array.IndexOf(arr, arr.Min())] + arr.Min());
                listView1.Items.Add(list);
                




            }


        }
        void clear1()
        {

            listView1.Items.Clear();
        }
        
        void rand()
        {  
            ram.name = ra.Next(0, 100).ToString();
            ram.chinese = int.Parse(ra.Next(0, 100).ToString());
            ram.english = int.Parse(ra.Next(0, 100).ToString());
            ram.math = int.Parse(ra.Next(0, 100).ToString());
            ls.Insert(ls.Count, ram);
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            clear1();
            int ans1;
            bool isCovert1 = int.TryParse(tb_math.Text, out ans1);
            bool isCovert2 = int.TryParse(tb_english.Text, out ans1);
            bool isCovert3 = int.TryParse(tb_chinese.Text, out ans1);
            if (tb_name.Text == "")
            {
                MessageBox.Show("姓名請打中文");
            }
            else if (isCovert1 == false)
            {
                MessageBox.Show("數學請打數字");
            }
            else if (isCovert2 == false)
            {
                MessageBox.Show("英文請打數字");
            }
            else if (isCovert3 == false)
            {
                MessageBox.Show("中文請打數字");
            }
            else
            {
                student stu;
                stu.name = tb_name.Text;
                stu.math = int.Parse(tb_math.Text);
                stu.english = int.Parse(tb_english.Text);
                stu.chinese = int.Parse(tb_chinese.Text);
                ls.Insert(ls.Count, stu);
                member();
            }
            btn_total.Enabled = true;
        }

        private void btn_ran_Click(object sender, EventArgs e)
        {
            
            clear1();
            rand();
            member();
            btn_total.Enabled = true;



        }

        private void btn_total_Click(object sender, EventArgs e)
        {

            listView2.Items.Clear();
            int sum = 0;
            List<int> ma = new List<int>();
            List<int> en = new List<int>();
            List<int> ch = new List<int>();

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                sum += int.Parse(listView1.Items[i].SubItems[1].Text);
                ma.Add(int.Parse(listView1.Items[i].SubItems[1].Text));
            }
            int sum1 = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                sum1 += int.Parse(listView1.Items[i].SubItems[2].Text);
                en.Add(int.Parse(listView1.Items[i].SubItems[2].Text));
            }
            int sum2 = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                sum2 += int.Parse(listView1.Items[i].SubItems[3].Text);
                ch.Add(int.Parse(listView1.Items[i].SubItems[3].Text));


            }


            int math = sum / listView1.Items.Count;
            int english = sum1 / listView1.Items.Count;
            int chinese = sum2 / listView1.Items.Count;

            int[] aa = new[] { sum, sum1, sum2 };
            ListViewItem list1 = new ListViewItem("總分:" + aa[0]);
            list1.SubItems.Add($"總分:{aa[1]}");
            list1.SubItems.Add("總分:" + aa[2]);

            ListViewItem list2 = new ListViewItem($"平均:{math}");
            list2.SubItems.Add($"平均:{english}");
            list2.SubItems.Add($"平均:{chinese}");

            ListViewItem list3 = new ListViewItem($"最高分:{ma.Max()}");
            list3.SubItems.Add($"最高分:{en.Max()}");
            list3.SubItems.Add($"最高分:{ch.Max()}");

            ListViewItem list4 = new ListViewItem($"最低分:{ma.Min()}");
            list4.SubItems.Add($"最低分:{en.Min()}");
            list4.SubItems.Add($"最低分:{ch.Min()}");

            listView2.Items.Add(list1);
            listView2.Items.Add(list2);
            listView2.Items.Add(list3);
            listView2.Items.Add(list4);

            btn_add.Enabled = false;
            btn_ran.Enabled = false;
            btn_ran20.Enabled = false;
            btn_total.Enabled = false;
        }

        private void lb_member_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < 20; i++)
            {
                clear1();
                rand();
                member();
            }
            btn_total.Enabled = true;
        }

        private void lb_alltotal_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            //btn_add.Enabled = true;
            //btn_ran.Enabled = true;
            //btn_ran20.Enabled = true;
            //btn_total.Enabled = false;
            ListViewItem list = new ListViewItem(ram.name);
            list.SubItems.Clear();
            //listView2.Items.Clear();
            this.Visible = false;                    
            Form1 fm = new Form1();
            fm.Show();           
        }
    }
}
