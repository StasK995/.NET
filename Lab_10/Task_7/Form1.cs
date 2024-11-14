using System;
using System.Windows.Forms;

namespace Task_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.TextChanged += TextBox1_TextChanged;
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                
                string Data = DateTime.Now.ToString("dd.MM.yyyy");

                
                toolStripStatusLabel1.Text = Data;
                toolStripStatusLabel2.Text = textBox1.Text;
            }
            else
            {
                
                toolStripStatusLabel2.Text = string.Empty;
                toolStripStatusLabel1.Text = string.Empty;
            }
        }

       
    }
}
