using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            string text = toolStripButton6.ToolTipText;
            MessageBox.Show(text);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            string text = toolStripButton7.ToolTipText;
            MessageBox.Show(text);
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            string text = toolStripButton8.ToolTipText;
            MessageBox.Show(text);
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            string text = toolStripButton9.ToolTipText;
            MessageBox.Show(text);
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            string text = toolStripButton10.ToolTipText;
            MessageBox.Show(text);
        }
    }
}
