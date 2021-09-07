using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(label2.Text);
            int b = int.Parse(label1.Text);
            int c = int.Parse(label3.Text);
            double d, x, x1, x2;
            d = (b * b) - (4 * a * c) ;
            if (d < 0)   {
                label5.Text = "pt vo nghiem";
            }
            if (d ==0)    {
                x = -b / 2 * a;
                label5.Text = "pt co nghiem x " + x;
            }
            if (d > 0) {
                x1 = (-b - Math.Sqrt(d)) / 2 * a;
                x2 = (-b + Math.Sqrt(d)) / 2 * a;
                label5.Text = "co 2 nghiem phan biet";
                label5.Text += "nghiem 1 " + x1;
                label5.Text += "                nghiem 2" + x2;
            }
            if (a == 0 && b!=0 && c != 0)
            {
                x = -b / c;
                label5.Text = "pt co nghiem doi x" + x;
            }
        }
    }
}
