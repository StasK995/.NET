using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PictureBox pictureBox = new PictureBox();
            pictureBox.Location = new Point(50, 50);
            pictureBox.Size = new Size(250, 250);
            Controls.Add(pictureBox);
            pictureBox.Paint += PictureBox_Paint;
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //  конденсатор
            g.DrawRectangle(Pens.Gray, 70,90,80,20);

            g.DrawLine(Pens.Black, 70,130,150,130);
            g.DrawLine(Pens.Black, 110, 90, 110, 60);
            g.DrawLine(Pens.Black, 110, 130, 110, 160);

            g.DrawLine(Pens.Black, 80,70,80,50);
            g.DrawLine(Pens.Black, 70,60,90,60);

        }
    }
}
