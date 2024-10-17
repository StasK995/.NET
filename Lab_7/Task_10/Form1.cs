using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.textBox1.Enter += TextBox_Enter;
            this.textBox2.Enter += TextBox_Enter;
            this.textBox3.Enter += TextBox_Enter;
            this.textBox1.Leave += TextBox_Leave;
            this.textBox2.Leave += TextBox_Leave;
            this.textBox3.Leave += TextBox_Leave;
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox; 
            if (textBox != null)
            {
                textBox.Location = new Point(textBox.Location.X, textBox.Location.Y + 20); 
            }
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox; 
            if (textBox != null)
            {
                textBox.Location = new Point(textBox.Location.X, textBox.Location.Y - 20); 
            }
        }
    }
}
