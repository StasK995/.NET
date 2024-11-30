using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Task_9
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private List<Ball> balls;
        private Random random;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Для плавного відображення
            this.ClientSize = new Size(800, 600);

            random = new Random();
            balls = new List<Ball>();

            // Створюємо кілька кульок
            for (int i = 0; i < 5; i++)
            {
                balls.Add(new Ball(
                    random.Next(20, 50), // Радіус
                    random.Next(Width),  // Координата X
                    random.Next(Height), // Координата Y
                    random.Next(-5, 6),  // Швидкість по X
                    random.Next(-5, 6),  // Швидкість по Y
                    Color.Red
                ));
            }

            // Налаштовуємо таймер
            timer = new Timer();
            timer.Interval = 20; // Інтервал оновлення в мілісекундах
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            foreach (var ball in balls)
            {
                ball.Move(ClientSize);

                // Перевіряємо зіткнення з іншими кульками
                foreach (var otherBall in balls.Where(b => b != ball))
                {
                    ball.CheckCollision(otherBall);
                }
            }
            Invalidate(); // Перемальовуємо форму
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
            if (speedX != 0)
            {
                SpeedX = speedX;
            }
            else
            {
                SpeedX = 1;
            }

            if (speedY != 0)
            {
                SpeedY = speedY;
            }
            else
            {
                SpeedY = 1;
            }

            Color = color;
        }

        public void Move(Size bounds)
        {
            X += SpeedX;
            Y += SpeedY;

            // Відображення від стінок
            if (X - Radius < 0 || X + Radius > bounds.Width)
                SpeedX = -SpeedX;

            if (Y - Radius < 0 || Y + Radius > bounds.Height)
                SpeedY = -SpeedY;
        }

        public void CheckCollision(Ball other)
        {
            int dx = X - other.X;
            int dy = Y - other.Y;
            int distance = (int)Math.Sqrt(dx * dx + dy * dy);

            if (distance < Radius + other.Radius)
            {
                // Обмін значень SpeedX
                int tempX = SpeedX;
                SpeedX = other.SpeedX;
                other.SpeedX = tempX;

                // Обмін значень SpeedY
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