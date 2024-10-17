using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            char keyChar = (char)e.KeyCode;

            if ((keyChar < 'A' || keyChar > 'M') &&
                (keyChar < 'a' || keyChar > 'm') &&
                !char.IsControl(keyChar)) 
            {
                e.SuppressKeyPress = true; 
            }
        }
    }
}
