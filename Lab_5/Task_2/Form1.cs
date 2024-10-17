using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeLabels();
        }

        private void InitializeLabels()
        {
            Label label1 = new Label();
            label1.Text = "Перший рядок тексту";
            label1.Location = new Point(50, 30);
            label1.Name = "label1";
            label1.Font = new Font("Arial",10,FontStyle.Italic);
            label1.ForeColor = Color.Brown;
            label1.BackColor = Color.Yellow;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.AutoSize = true;
            this.Controls.Add(label1);

            Label label2 = new Label();
            label2.Text = "Другий рядок тексту";
            label2.Location = new Point(50, 80);
            label2.Name = "label2";
            label2.Font = new Font("Arial", 20, FontStyle.Underline);
            label2.ForeColor = Color.Pink;
            label2.BackColor = Color.Blue;
            label2.TextAlign = ContentAlignment.MiddleRight;
            label2.AutoSize = true;
            this.Controls.Add(label2);

            Label label3 = new Label();
            label3.Text = "Третій рядок тексту";
            label3.Location = new Point(50, 110);
            label3.Name = "label3";
            label3.Font = new Font("Arial", 13, FontStyle.Bold);
            label3.ForeColor = Color.Violet;
            label3.BackColor = Color.Red;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.AutoSize = true;
            this.Controls.Add(label3);
        }
    }
}
