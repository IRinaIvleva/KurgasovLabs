using System;
using System.Windows.Forms;

namespace KurgasovLabs.Lab3
{
    public partial class VariableTest : Form
    {
        public VariableTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "Cидоров";
            textBox1.Text = name;

            name = "Боденштейн фон Карлштадт";
            textBox2.Text = name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
