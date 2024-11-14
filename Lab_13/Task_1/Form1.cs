using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); ;
            
            pictureBox1.Paint += PictureBox1_Paint;
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int BlueY = (int)(pictureBox1.Height * 0.25);
            int BlueX = (int)(pictureBox1.Width * 0.25);
            int BlueWidth = (int)(pictureBox1.Width * 0.25);
            int BlueHeight = (int)(pictureBox1.Height * 0.25);
            g.FillRectangle(Brushes.Blue, BlueX, BlueY, BlueWidth, BlueHeight);
            int YellowY = (int)(pictureBox1.Height * 0.5);
            int YellowX = (int)(pictureBox1.Width * 0.25);
            int YellowWidth = (int)(pictureBox1.Width * 0.25);
            int YellowHeight = (int)(pictureBox1.Height * 0.25);
            g.FillRectangle(Brushes.Yellow, YellowX, YellowY, YellowWidth, YellowHeight);


            //g.FillRectangle(Brushes.Yellow, 0, 50, 200, 50);

        }
    }
}
