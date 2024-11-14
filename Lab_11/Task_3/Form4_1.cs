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
    
    public partial class Form4_1 : Form
    {
        
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }



        public Form4_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4_2 form4_2 = new Form4_2(this);
            form4_2.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form4_3 form4_3 = new Form4_3(this);
            form4_3.ShowDialog();
        }
    }
}
