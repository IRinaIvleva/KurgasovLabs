using System;
using System.Windows.Forms;

namespace KurgasovLabs.Interaction
{
    public partial class InputBox : Form
    {
        public string Result { get; set; }

        public InputBox(string label)
        {
            InitializeComponent();

            label1.Text = label;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Result = textBox1.Text;
        }
    }
}
