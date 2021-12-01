using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Form_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r1, r2;

            r1 = Convert.ToDouble(textBox1.Text);

            r2 = Convert.ToDouble(textBox2.Text);

            double s = Math.PI * (r2 * r2 - r1 * r1);

            textBox3.Text = Convert.ToString(s);
        }
    }
}
