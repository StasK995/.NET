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
            this.label1.MouseDown += Label_MouseDown;
            this.label2.MouseDown += Label_MouseDown;
            this.label3.MouseDown += Label_MouseDown;
            this.label1.MouseUp += Label_MouseUp;
            this.label2.MouseUp += Label_MouseUp;
            this.label3.MouseUp += Label_MouseUp;
        }

        private void Label_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Label label = sender as Label; 
                if (label != null)
                {
                    label.Location = new Point(label.Location.X, label.Location.Y - 20); 
                }
            }
        }

        private void Label_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Label label = sender as Label; 
                if (label != null)
                {
                    label.Location = new Point(label.Location.X, label.Location.Y + 20); 
                }
            }
        }
    }
}
