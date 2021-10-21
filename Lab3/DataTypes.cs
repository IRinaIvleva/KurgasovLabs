using System;
using System.Windows.Forms;

namespace KurgasovLabs.Lab3
{
    public partial class DataTypes : Form
    {
        private bool varBool = false;
        private byte varByte = byte.MaxValue;
        private int varInt = int.MaxValue;
        private long varLong = long.MaxValue;
        private float varFloat = float.MaxValue;
        private char varChar = 'Ы';
        private string varString = "Pink Floyd";
        private object varObject = "hello, developer" + " " + 22;

        public DataTypes()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    label3.Text = varBool.ToString();
                    break;
                case 1:
                    label3.Text = varByte.ToString();
                    break;
                case 2:
                    label3.Text = varInt.ToString();
                    break;
                case 3:
                    label3.Text = varLong.ToString();
                    break;
                case 4:
                    label3.Text = varFloat.ToString();
                    break;
                case 5:
                    label3.Text = varChar.ToString();
                    break;
                case 6:
                    label3.Text = varString;
                    break;
                case 7:
                    label3.Text = varObject.ToString();
                    break;
            }
        }
    }
}
