using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Task_10
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private List<Ball> balls;
        private Random random;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.ClientSize = new Size(800, 600);

            random = new Random();
            balls = new List<Ball>();

            // Додаємо кнопку для відкриття Form2
            Button btnSettings = new Button
            {
                Text = "Налаштування м'ячів",
                Location = new Point(10, 10),
                Size = new Size(100, 30)
            };
            btnSettings.Click += BtnSettings_Click;
            this.Controls.Add(btnSettings);

            // Ініціалізуємо з м'ячами за замовчуванням
            CreateBalls(5, Color.Red, 40, 5);

            // Налаштовуємо таймер
            timer = new Timer
            {
                Interval = 20
            };
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            using (Form2 settingsForm = new Form2())
            {
                if (settingsForm.ShowDialog() == DialogResult.OK)
                {
                    // Очищуємо існуючі м'ячі
                    balls.Clear();

                    // Створюємо нові м'ячі з заданими параметрами
                    CreateBalls(
                        settingsForm.NumberOfBalls,
                        settingsForm.BallColor,
                        settingsForm.BallDiameter,
                        settingsForm.BallSpeed
                    );
                }
            }
        }

        private void CreateBalls(int count, Color color, int diameter, int maxSpeed)
        {
            int radius = diameter / 2;
            for (int i = 0; i < count; i++)
            {
                int x = random.Next(radius, Width - radius);
                int y = random.Next(radius, Height - radius);

                balls.Add(new Ball(
                    radius,
                    x,
                    y,
                    random.Next(-maxSpeed, maxSpeed + 1),
                    random.Next(-maxSpeed, maxSpeed + 1),
                    color
                ));
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            foreach (var ball in balls)
            {
                ball.Move(ClientSize);

                // Перевірка зіткнення з іншими м'ячами
                foreach (var otherBall in balls.Where(b => b != ball))
                {
                    ball.CheckCollision(otherBall);
                }
            }
            Invalidate(); // Перемальовування форми
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (var ball in balls)
            {
                ball.Draw(g);
            }
        }
    }

    public class Ball
    {
        public int Radius { get; }
        public int X { get; private set; }
        public int Y { get; private set; }
        public int SpeedX { get; private set; }
        public int SpeedY { get; private set; }
        public Color Color { get; }

        public Ball(int radius, int x, int y, int speedX, int speedY, Color color)
        {
            Radius = radius;
            X = x;
            Y = y;
            SpeedX = speedX != 0 ? speedX : 1;
            SpeedY = speedY != 0 ? speedY : 1;
            Color = color;
        }

        public void Move(Size bounds)
        {
            X += SpeedX;
            Y += SpeedY;

            // Відскок від стінок
            if (X - Radius < 0)
            {
                X = Radius;
                SpeedX = -SpeedX;
            }
            else if (X + Radius > bounds.Width)
            {
                X = bounds.Width - Radius;
                SpeedX = -SpeedX;
            }

            if (Y - Radius < 0)
            {
                Y = Radius;
                SpeedY = -SpeedY;
            }
            else if (Y + Radius > bounds.Height)
            {
                Y = bounds.Height - Radius;
                SpeedY = -SpeedY;
            }
        }

        public void CheckCollision(Ball other)
        {
            int dx = X - other.X;
            int dy = Y - other.Y;
            int distance = (int)Math.Sqrt(dx * dx + dy * dy);

            if (distance < Radius + other.Radius)
            {
                // Обмін значеннями SpeedX
                int tempX = SpeedX;
                SpeedX = other.SpeedX;
                other.SpeedX = tempX;

                // Обмін значеннями SpeedY
                int tempY = SpeedY;
                SpeedY = other.SpeedY;
                other.SpeedY = tempY;
            }
        }

        public void Draw(Graphics g)
        {
            using (Brush brush = new SolidBrush(Color))
            {
                g.FillEllipse(brush, X - Radius, Y - Radius, Radius * 2, Radius * 2);
            }
        }
    }
}
