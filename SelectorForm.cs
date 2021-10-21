using System;
using System.Windows.Forms;

using KurgasovLabs.Lab2;
using KurgasovLabs.Lab3;

namespace KurgasovLabs
{
    public partial class SelectorForm : Form
    {
        public SelectorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var helloWorld = new HelloWorld();
            helloWorld.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var birthday = new Birthday();
            birthday.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var sells = new Sells();
            sells.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var variableTest = new VariableTest();
            variableTest.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var inputBox = new MyInputBox();
            inputBox.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var dataTypes = new DataTypes();
            dataTypes.ShowDialog();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            var basicMath = new BasicMath();
            basicMath.ShowDialog();
        }
    }
}
