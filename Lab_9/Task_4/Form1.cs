﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_4
{
    public partial class Form1 : Form
    {
        private const decimal RodToKMeters = 198.83838614812m;
        private const decimal KMetersToRod = 1/RodToKMeters;

        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out decimal km))
            {
                decimal result = km * RodToKMeters;
                textBox2.Text = result.ToString("F2");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox2.Text, out decimal km))
            {
                decimal result = km * KMetersToRod;
                textBox1.Text = result.ToString("F2");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out decimal km) && km > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox2.Text, out decimal rod) && rod > 0)
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            char keyChar = (char)e.KeyCode;
            if (!char.IsDigit(keyChar) && keyChar != '.' && keyChar != (char)Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            char keyChar = (char)e.KeyCode;
            if (!char.IsDigit(keyChar) && keyChar != '.' && keyChar != (char)Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
