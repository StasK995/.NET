using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form1 : Form
    {
        private PictureBox pictureBox2;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Size = new Size(200, 100);
            pictureBox1.Paint += PictureBox1_Paint;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int width = pictureBox1.Width;
            int height = pictureBox1.Height;

            g.FillRectangle(Brushes.Blue, 0, 0, width, height / 2);

            g.FillRectangle(Brushes.Yellow, 0, height / 2, width, height / 2);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (pictureBox2 == null)
            {
                pictureBox2 = new PictureBox();

                pictureBox2.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + pictureBox1.Height + 10);
                pictureBox2.Size = pictureBox1.Size;
                pictureBox2.Paint += PictureBox2_Paint;
                this.Controls.Add(pictureBox2);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (pictureBox2 != null)
            {
                this.Controls.Remove(pictureBox2);
                pictureBox2.Dispose();
                pictureBox2 = null;
            }
        }

        private void PictureBox2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int width = pictureBox2.Width;
            int height = pictureBox2.Height;

            g.FillRectangle(Brushes.Blue, 0, 0, width / 3, height);

            g.FillRectangle(Brushes.Yellow, width / 3, 0, width / 3, height);

            g.FillRectangle(Brushes.Red, 2 * (width / 3), 0, width / 3, height);
        }
    }
}
