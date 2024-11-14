using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_2
{
    public partial class Form1 : Form
    {
        private PictureBox pictureBox2;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Size = new Size(200, 100);
            pictureBox1.Paint += PictureBox1_Paint;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.Blue, 0, 0, 200, 50);
            g.FillRectangle(Brushes.Yellow, 0, 50, 200, 50);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            if (pictureBox2 == null)
            {
                pictureBox2 = new PictureBox();

                pictureBox2.Location = new Point(pictureBox1.Location.X + 250, pictureBox1.Location.Y);

                pictureBox2.Size = pictureBox1.Size;

                pictureBox2.Paint += PictureBox2_Paint;

                this.Controls.Add(pictureBox2);
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
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
