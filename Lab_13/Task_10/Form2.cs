using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_10
{
    public partial class Form2 : Form
    {
        public int NumberOfBalls { get; private set; }
        public Color BallColor { get; private set; }
        public int BallDiameter { get; private set; }
        public int BallSpeed { get; private set; }

        public Form2()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // Кількість кульок
            Label lblNumber = new Label { Text = "Кількість кульок:", Location = new Point(20, 20), AutoSize = true };
            NumericUpDown nudNumber = new NumericUpDown { Minimum = 1, Maximum = 20, Value = 5, Location = new Point(150, 20), Width = 60 };

            // Колір
            Label lblColor = new Label { Text = "Колір кулі:", Location = new Point(20, 60), AutoSize = true };
            Button btnColor = new Button { Text = "Вибрати колір", Location = new Point(150, 60), Width = 100 };
            btnColor.Click += (s, e) => {
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    BallColor = colorDialog.Color;
                    btnColor.BackColor = BallColor;
                }
            };

            // Діаметр
            Label lblDiameter = new Label { Text = "Діаметр кулі:", Location = new Point(20, 100), AutoSize = true };
            NumericUpDown nudDiameter = new NumericUpDown { Minimum = 10, Maximum = 100, Value = 40, Location = new Point(150, 100), Width = 60 };

            // Швидкість
            Label lblSpeed = new Label { Text = "Швидкість кулі:", Location = new Point(20, 140), AutoSize = true };
            NumericUpDown nudSpeed = new NumericUpDown { Minimum = 1, Maximum = 10, Value = 5, Location = new Point(150, 140), Width = 60 };

            // Кнопка "Застосувати"
            Button btnApply = new Button { Text = "Застосувати", Location = new Point(100, 180), Width = 100 };
            btnApply.Click += (s, e) => {
                NumberOfBalls = (int)nudNumber.Value;
                BallDiameter = (int)nudDiameter.Value;
                BallSpeed = (int)nudSpeed.Value;
                if (BallColor == Color.Empty)
                {
                    BallColor = Color.Red; // Колір за замовчуванням,
                }
                DialogResult = DialogResult.OK;
                Close();
            };

            Controls.AddRange(new Control[] {
                lblNumber, nudNumber,
                lblColor, btnColor,
                lblDiameter, nudDiameter,
                lblSpeed, nudSpeed,
                btnApply
            });

            // Встановити властивості форми
            Text = "Параметри кулі";
            Size = new Size(300, 250);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            MaximizeBox = false;
        }
    }
}
