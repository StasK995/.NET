using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_4
{
    public partial class Form2_2 : Form
    {
        private Form2_1 form2_1;
        private int X, Y, Z;
        public Form2_2(Form2_1 form2_1)
        {
            InitializeComponent();
            this.form2_1 = form2_1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (!int.TryParse(textBox1.Text, out X) || !int.TryParse(textBox2.Text, out Y) || !int.TryParse(textBox3.Text, out Z))
            {
                MessageBox.Show("Введены некоректні числа");
                return;
            }
            
            form2_1.X = X;
            form2_1.Y = Y;
            form2_1.Z = Z;
            this.Close();

            
        }
    }
}
