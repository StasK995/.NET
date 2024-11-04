using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form1 : Form
    {
        private static decimal UAHToJPY = 3.63m;
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var UAH = decimal.Parse(textBox1.Text);
            var resulr = UAH * UAHToJPY;
            label2.Text = "Ціна в японських єнах = " + resulr;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            if (input != null)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            char keyChar = (char)e.KeyCode;

            if (!char.IsDigit(keyChar) && !char.IsControl(keyChar))
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
