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

namespace Task_6
{
    public partial class Form2 : Form
    {
        private Form1 mainForm;
        public Form2(Form1 form)
        {
            InitializeComponent();
            mainForm = form;

           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
           
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                
                mainForm.BackColor = colorDialog.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                mainForm.label1.ForeColor = colorDialog.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (Control control in mainForm.groupBox1.Controls)
                {
                    if (control is System.Windows.Forms.Label label)
                    {
                        label.ForeColor = colorDialog.Color;
                    }
                }
            }
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                mainForm.groupBox1.BackColor = colorDialog.Color;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (Control control in mainForm.groupBox2.Controls)
                {
                    if (control is System.Windows.Forms.Label label)
                    {
                        label.ForeColor = colorDialog.Color;
                    }
                }
            }
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                mainForm.groupBox2.BackColor = colorDialog.Color;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (Control control in mainForm.groupBox3.Controls)
                {
                    if (control is System.Windows.Forms.Label label)
                    {
                        label.ForeColor = colorDialog.Color;
                    }
                }
            }
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                mainForm.groupBox3.BackColor = colorDialog.Color;
            }
        }
    }
}
