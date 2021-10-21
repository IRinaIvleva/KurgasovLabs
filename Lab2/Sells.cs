using System;
using System.Windows.Forms;

namespace KurgasovLabs.Lab2
{
    public partial class Sells : Form
    {
        public Sells()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    pictureBox4.Image = Properties.Resources.HDD;
                    break;
                case 1:
                    pictureBox4.Image = Properties.Resources.Printer;
                    break;
                case 2:
                    pictureBox4.Image = Properties.Resources.Anten;
                    break;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                pictureBox5.Image = Properties.Resources.PC;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                pictureBox5.Image = Properties.Resources.MacPC;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                pictureBox5.Image = Properties.Resources.Laptop;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pictureBox1.Image = Properties.Resources.AnswMach;
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                pictureBox2.Image = Properties.Resources.Calc;
            }
            else
            {
                pictureBox2.Image = null;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                pictureBox3.Image = Properties.Resources.CopyMach;
            }
            else
            {
                pictureBox3.Image = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
