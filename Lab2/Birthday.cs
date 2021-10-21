using System;
using System.Windows.Forms;

namespace KurgasovLabs.Lab2
{
    public partial class Birthday : Form
    {
        public Birthday()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ваш день рождения " + dateTimePicker1.Text);
            MessageBox.Show("День года " + dateTimePicker1.Value.DayOfYear);
            MessageBox.Show("Сегодня " + DateTime.Today.ToShortDateString());
        }
    }
}
