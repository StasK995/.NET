using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Task_3
{
    public partial class Form_Start : Form
    {
        Thread th;
        public Form_Start()
        {
            InitializeComponent();
        }

        public void Form1Open()
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Form1Open);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Form2_1Open);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        public void Form2_1Open()
        {
            Form2_1 form2_1 = new Form2_1(0,0,0);
            form2_1.ShowDialog(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Form3_1Open);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        public void Form3_1Open()
        {
            Form3_1 form3_1 = new Form3_1();
            form3_1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4_1 form4_1 = new Form4_1();
            form4_1.ShowDialog();
        }

        public void Form4_1Open()
        {
            Form4_1 form4_1 = new Form4_1();
            form4_1.ShowDialog();
        }
    }
}