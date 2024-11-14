using System;
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
    public partial class Form4_2 : Form
    {
        private int X, Y, Z;
        private Form4_1 form4_1;
        public Form4_2(Form4_1 form4_1)
        {
            InitializeComponent();
            this.form4_1 = form4_1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out X) || !int.TryParse(textBox2.Text, out Y) || !int.TryParse(textBox3.Text, out Z))
            {
                MessageBox.Show("Введены некоректні числа");
                return;
            }

            form4_1.X = X;
            form4_1.Y = Y;
            form4_1.Z = Z;
            this.Close();
        }
    }
}
