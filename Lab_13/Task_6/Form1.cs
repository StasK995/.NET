using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Task_6
{
    public partial class Form1 : Form
    {
        private Chart chart;
        private Series series; // Переменная серии теперь доступна для всего класса

        public Form1()
        {
            InitializeComponent();
            InitializeChart(); // Вызываем метод для инициализации графика
            Button button = new Button();
            button.Location = new Point(630, 200);
            button.Size = new Size(120, 30);
            button.Text = "Update";
            Controls.Add(button);
            button.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Random random = new Random();  // Создаем объект для генерации случайных чисел

            // Очищаем старые данные
            series.Points.Clear();

            // Добавляем случайные точки
            for (int i = 1; i < 11; i++)
            {
                double num = 30 + random.NextDouble() * 2;  // Генерируем случайное число от 30 до 32
                series.Points.AddXY(i, num);  // Добавляем точку на график
            }

            // Обновляем график
            chart.Series.Clear();  // Очищаем старые серии
            chart.Series.Add(series);  // Добавляем обновленную серию
        }



        private void InitializeChart()
        {
            // Создаем график
            chart = new Chart();
            chart.Size = new Size(600, 400);
            chart.Location = new Point(10, 10);

            // Создаем область графика
            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            // Настроим внешний вид области графика
            chartArea.BackColor = Color.White;
            chartArea.BorderColor = Color.Black;
            chartArea.BorderWidth = 1;

            // Создаем серию данных
            series = new Series(); // Инициализация серии
            series.ChartType = SeriesChartType.Line;
            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerSize = 8;
            series.BorderWidth = 2;
            series.Color = Color.Blue;
            series.BorderDashStyle = ChartDashStyle.Solid;

            // Отключаем сетку
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;

            // Настроим оси
            chartArea.AxisY.Minimum = 30.0;
            chartArea.AxisY.Maximum = 32.0;

            // Добавляем заголовок
            Title title = new Title();
            title.Text = "Зміна курсу національної валюти";
            title.Font = new Font("Arial", 12, FontStyle.Regular);
            title.Docking = Docking.Top;
            chart.Titles.Add(title);

            // Добавляем график на форму
            this.Controls.Add(chart);
        }
    }
}
