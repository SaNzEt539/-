using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Form_2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;
            num = Convert.ToInt32(textBox1.Text);
                if (num < 0)
                {
                textBox2.Text = Convert.ToString("Вы ошиблись");
                }
                else if (num < 1)
                {
                textBox2.Text = Convert.ToString("Младенец");
                }
                else if (1 < num && num < 11)
                {
                textBox2.Text = Convert.ToString("Ребёнок");
                }
                else if (12 < num && num < 15)
                {
                textBox2.Text = Convert.ToString("Подросток");
                }
                else if (16 < num && num < 25)
                {
                textBox2.Text = Convert.ToString("Юноша");
                }
                else if (26 < num && num < 70)
                {
                textBox2.Text = Convert.ToString("Мужчина");
                }
                else if (num > 70)
                {
                textBox2.Text = Convert.ToString("Пожилой человек");
                }
            else
            {
                textBox2.Text = Convert.ToString("Вы ошиблись");
            }
        }
    }
}
