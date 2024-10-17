using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initializePictureBox();
        }
        private void initializePictureBox()
        {
            PictureBox Box1 = new PictureBox
            {
                Location = new Point(10, 200),
                Size = new Size(100, 100),
                Image = Image.FromFile(@"C:\Users\nik_i\source\repos\Lab_5\Task_5\image4.jpg"),  
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            this.Controls.Add(Box1);

            PictureBox Box2 = new PictureBox
            {
                Location = new Point(120, 100),
                Size = new Size(100, 200),
                Image = Image.FromFile(@"C:\Users\nik_i\source\repos\Lab_5\Task_5\image1.png"), 
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            this.Controls.Add(Box2);

            PictureBox Box3 = new PictureBox
            {
                Location = new Point(230, 100),
                Size = new Size(100, 200),
                Image = Image.FromFile(@"C:\Users\nik_i\source\repos\Lab_5\Task_5\image2.png"), 
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            this.Controls.Add(Box3);

            PictureBox Box4 = new PictureBox
            {
                Location = new Point(340, 100),
                Size = new Size(100, 200),
                Image = Image.FromFile(@"C:\Users\nik_i\source\repos\Lab_5\Task_5\image3.jpg"), 
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            this.Controls.Add(Box4);

            PictureBox Box5 = new PictureBox
            {
                Location = new Point(450, 200),
                Size = new Size(100, 100),
                Image = Image.FromFile(@"C:\Users\nik_i\source\repos\Lab_5\Task_5\image5.png"), 
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            this.Controls.Add(Box5);
        }
    }
}
