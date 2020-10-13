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
    public partial class Form2 : Form
    {
        public Form2(string a,string b,string c,string d,string e)
        {
            InitializeComponent();
            
            label6.Text = a;
            label7.Text = b;
            label8.Text = c;
            label9.Text = d;
            label10.Text = e;

            
        }
    }
}
