using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.Click += MenuItem_Click;
            }
            private void MenuItem_Click(object sender, EventArgs e)
            { 
                

            }
        }

    }
}
