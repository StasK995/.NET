using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_7
{
    public partial class Form1 : Form
    {
        private Label selectedLabel;
        public Form1()
        {
            InitializeComponent();
        }

        private void item1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Label label) 
                {
                    label.BackColor = Color.Yellow; 
                }
            }
        }

        private void item2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Control control in this.Controls)
            {
                if (control is Label label)
                {
                    label.BackColor = Color.Red;
                }
            }
        }

        private void item3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Control control in this.Controls)
            {
                if (control is Label label)
                {
                    label.BackColor = Color.White;
                }
            }
        }

        private void item4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Control control in this.Controls)
            {
                if (control is Label label)
                {
                    label.BackColor = Color.Purple;
                }
            }
        }


    }
}
