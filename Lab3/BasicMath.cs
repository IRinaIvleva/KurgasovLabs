using System;
using System.Windows.Forms;

namespace KurgasovLabs.Lab3
{
    public partial class BasicMath : Form
    {
        public BasicMath()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text)) return;

            double leftOperand = Convert.ToDouble(textBox1.Text);
            double rightOperand = Convert.ToDouble(textBox2.Text);
            double result = 0;

            if (radioButton1.Checked)
            {
                result = leftOperand + rightOperand;
            }
            else if (radioButton2.Checked)
            {
                result = leftOperand - rightOperand;
            }
            else if (radioButton3.Checked)
            {
                result = leftOperand * rightOperand;
            }
            else if (radioButton4.Checked)
            {
                result = leftOperand / rightOperand;
            }

            label4.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
