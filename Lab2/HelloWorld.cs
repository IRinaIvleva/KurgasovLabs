using System;
using System.Windows.Forms;

namespace KurgasovLabs.Lab2
{
    public partial class HelloWorld : Form
    {
        public HelloWorld()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Hello, World!";
        }
    }
}
