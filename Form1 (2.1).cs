using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Form_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y;
            x = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox2.Text);

            if ((x * x + y * y < 144) && y < x)
            {
                textBox3.Text = Convert.ToString("Да");
            }

            else if ((x * x + y * y == 144) || y == x)
            {
                textBox3.Text = Convert.ToString("На границе");
            }

            else
            {
                textBox3.Text = Convert.ToString("Нет");
            }
        }
    }
}
