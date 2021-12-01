using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Form_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int a = n / 100;
            int c = n % 10;
            int b = n % 100 / 10;
            if (a == b && b == c)
            {
                textBox2.Text = ("Цифры трехзначного числа одинаковые");
            }
            else
            {
                textBox2.Text = ("Цифры трехзначного числа не одинаковые");
            }
        }
    }
}
