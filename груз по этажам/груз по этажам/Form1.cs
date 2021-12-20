using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace груз_по_этажам
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                int x = Convert.ToInt32(textBox1.Text);
                textBox2.Text = Convert.ToString(x * 1000);
            }
            if (comboBox1.SelectedIndex == 1)
            {
                int x = Convert.ToInt32(textBox1.Text);
                textBox2.Text = Convert.ToString(x * 500);
            }
            else
            {
                int x = Convert.ToInt32(textBox1.Text);
                textBox2.Text = Convert.ToString(x * 200);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
