using System;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form1 : Form
    {
        private const double RodToKMeters = 198.83;

        public Form1()
        {
            InitializeComponent();

            button1.Enabled = false;

            textBox1.TextChanged += TextBox1_TextChanged;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double km) && km > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double km))
            {
                double result = km * RodToKMeters;
                label2.Text = "Род = " + result;
            }

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            char keyChar = (char)e.KeyCode;
            if (!char.IsDigit(keyChar))
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
