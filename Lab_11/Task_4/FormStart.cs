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
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2_1 form2_1 = new Form2_1();
            form2_1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3_1 form3_1 = new Form3_1();
            form3_1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4_1 form4_1 = new Form4_1();
            form4_1.ShowDialog();
        }
    }
}
