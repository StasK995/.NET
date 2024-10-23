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
                Color color;

                switch (menuItem.Name)
                {
                    case "item1ToolStripMenuItem":
                        color = Color.Yellow;
                        break;
                    case "item2ToolStripMenuItem":
                        color = Color.Red;
                        break;
                    case "item3ToolStripMenuItem":
                        color = Color.White;
                        break;
                    case "item4ToolStripMenuItem":
                        color = Color.Purple;
                        break;
                    default:
                        return; 
                }

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
