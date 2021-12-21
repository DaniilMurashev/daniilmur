using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI__CALCULATOR_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double v = double.Parse(textBox2.Text);
            double r = double.Parse(textBox1.Text);
            double index = v / ((r / 100) * (r / 100));
            label7.Text = index.ToString("##.##");
            trackBar1.Value = Convert.ToInt32(index);
            if (radioButton1.Checked)
            {

                if (index < 18.5)
                {
                    pictureBox3.Image = Image.FromFile(@"C:\Users\ko72x\OneDrive\Документы\Документы\marathon-skills-2016-bmi-icons\bmi-underweight-icon.png");
                }

                else if (index < 25)
                {
                    pictureBox3.Image = Image.FromFile(@"C:\Users\ko72x\OneDrive\Документы\Документы\marathon-skills-2016-bmi-icons\bmi-healthy-icon.png");
                }

                else if (index < 30)
                {
                    pictureBox3.Image = Image.FromFile(@"C:\Users\ko72x\OneDrive\Документы\Документы\marathon-skills-2016-bmi-icons\bmi-overweight-icon.png");
                }

                else
                {
                    pictureBox3.Image = Image.FromFile(@"C:\Users\ko72x\OneDrive\Документы\Документы\marathon-skills-2016-bmi-icons\bmi-obese-icon.png");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            pictureBox3.Image = null;
            trackBar1.Value = 0;
            label7.Text = null;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
