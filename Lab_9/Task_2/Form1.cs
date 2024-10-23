﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2
{
    public partial class Form1 : Form
    {
        private static double UAHToJPY = 3.63;
        private static double JPYtoUAH = 0.28;

        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double UAH = double.Parse(textBox1.Text);
            double resulr = UAH * UAHToJPY;
            textBox2.Text = resulr.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double UAH = double.Parse(textBox2.Text);
            double resulr = UAH * JPYtoUAH;
            textBox1.Text = resulr.ToString();
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            char keyChar = (char)e.KeyCode;

            if (!char.IsDigit(keyChar) && !char.IsControl(keyChar))
            {
                e.SuppressKeyPress = true;
            }
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            char keyChar = (char)e.KeyCode;

            if (!char.IsDigit(keyChar) && !char.IsControl(keyChar))
            {
                e.SuppressKeyPress = true;
            }
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
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            if (input != null)
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }
    }
}
