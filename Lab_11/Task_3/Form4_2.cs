using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form4_2 : Form
    {
        private Form4_1 form4_1;

        public Form4_2(Form4_1 form4_1)
        {
            InitializeComponent();
            this.form4_1 = form4_1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);

            // Встановлюємо значення властивостей у form4_1
            form4_1.A = a;
            form4_1.B = b;
            form4_1.C = c;

            this.Close();// Закриваємо форму Form4_2
        }
    }
}
