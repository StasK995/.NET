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
    public partial class Form3_1 : Form
    {
        private int a, b, c;
        public Form3_1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = Convert.ToInt32(textBox3.Text);

            Form3_2 form3_2 = new Form3_2();
            form3_2.A = a;
            form3_2.B = b;
            form3_2.C = c;

            form3_2.UpdateVolumeAndSurfaceArea();
            form3_2.Show();
        }
    }
}
