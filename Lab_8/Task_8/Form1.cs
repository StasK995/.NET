using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            item1ToolStripMenuItem.Click += ItemMenu_Click;
            item2ToolStripMenuItem.Click += ItemMenu_Click;
            item3ToolStripMenuItem.Click += ItemMenu_Click;
            item4ToolStripMenuItem.Click += ItemMenu_Click;
        }

        private void ItemMenu_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem)
            {
                string colorName = menuItem.Text;
                Color color;
                color = Color.FromName(colorName);

                ChangeLabelColors(color);
            }
        }

        private void ChangeLabelColors(Color color)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Label label)
                {
                    label.BackColor = color; 
                }
            }
        }
    }
}
