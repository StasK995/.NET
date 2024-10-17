using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Location = new Point(textBox1.Location.X, textBox1.Location.Y-20);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.Location = new Point(textBox1.Location.X, textBox1.Location.Y + 20);
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Location = new Point(textBox2.Location.X, textBox2.Location.Y - 20);
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            textBox2.Location = new Point(textBox2.Location.X, textBox2.Location.Y + 20);
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.Location = new Point(textBox3.Location.X, textBox3.Location.Y - 20);
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            textBox3.Location = new Point(textBox3.Location.X, textBox3.Location.Y + 20);
        }
    }
}
