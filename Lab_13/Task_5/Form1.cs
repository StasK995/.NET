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
            this.Size = new Size(400, 400);
            this.BackColor = Color.Aqua;

            // Створюємо PictureBox і властивості
            PictureBox pictureBox = new PictureBox();
            pictureBox.Location = new Point(50, 50);
            pictureBox.Size = new Size(250, 250);
            pictureBox.BackColor = Color.White; 
            Controls.Add(pictureBox);

            pictureBox.Paint += PictureBox_Paint;

            Label label = new Label();
            label.Text = "Конденсатор";
            label.Location = new Point(50, 20);
            label.Font = new Font("Arial", 14, FontStyle.Bold);
            label.AutoSize = true;
            Controls.Add(label);
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Рисуємо конденсатор
            g.DrawRectangle(Pens.Black, 70, 90, 80, 20);

            g.DrawLine(Pens.Black, 70, 130, 150, 130);
            g.DrawLine(Pens.Black, 110, 90, 110, 60);
            g.DrawLine(Pens.Black, 110, 130, 110, 160);

            g.DrawLine(Pens.Black, 80, 70, 80, 50);
            g.DrawLine(Pens.Black, 70, 60, 90, 60);
        }
    }
}
