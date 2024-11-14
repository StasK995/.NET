using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_4
{
    public partial class Form1 : Form
    {
        private PictureBox pictureBox2;
        private Timer timer;
        private int positionIndex; 

        public Form1()
        {
            InitializeComponent();

            
            pictureBox1.Size = new Size(200, 100);
            pictureBox1.Paint += PictureBox1_Paint;

            
            timer = new Timer();
            timer.Interval = 2000; 
            timer.Tick += Timer_Tick;
            timer.Start();

            
            pictureBox2 = new PictureBox();
            pictureBox2.Size = new Size(200, 100);
            pictureBox2.Paint += PictureBox2_Paint;
            this.Controls.Add(pictureBox2);

            
            positionIndex = 0; 
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int width = pictureBox1.Width;
            int height = pictureBox1.Height;

            
            g.FillRectangle(Brushes.Blue, 0, 0, width, height / 2);
            g.FillRectangle(Brushes.Yellow, 0, height / 2, width, height / 2);
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

        private void Timer_Tick(object sender, EventArgs e)
        {
            
            positionIndex++;

            if (positionIndex > 3) 
            {
                positionIndex = 0;
            }

            
            switch (positionIndex)
            {
                case 0: 
                    pictureBox2.Location = new Point(pictureBox1.Location.X + pictureBox1.Width + 10, pictureBox1.Location.Y);
                    break;
                case 1: 
                    pictureBox2.Location = new Point(pictureBox1.Location.X - pictureBox2.Width - 10, pictureBox1.Location.Y);
                    break;
                case 2: 
                    pictureBox2.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - pictureBox2.Height - 10);
                    break;
                case 3: 
                    pictureBox2.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + pictureBox1.Height + 10);
                    break;
            }
        }
    }
}
