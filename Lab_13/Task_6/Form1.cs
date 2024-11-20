using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Task_6
{
    public partial class Form1 : Form
    {
        private Chart chart;
        private Series series; 

        public Form1()
        {
            InitializeComponent();
            InitializeChart(); 
            Button button = new Button();
            button.Location = new Point(630, 200);
            button.Size = new Size(120, 30);
            button.Text = "Update";
            Controls.Add(button);
            button.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Random random = new Random();  

            series.Points.Clear();

            for (int i = 1; i < 11; i++)
            {
                double num = 30 + random.NextDouble() * 2;  
                series.Points.AddXY(i, num); 
            }

            // Обновляем график
            chart.Series.Clear();  
            chart.Series.Add(series);  
        }



        private void InitializeChart()
        {
            // Графік
            chart = new Chart();
            chart.Size = new Size(600, 400);
            chart.Location = new Point(10, 10);

            // Область графіка
            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            // Зовнішній вигляд
            chartArea.BackColor = Color.White;
            chartArea.BorderColor = Color.Black;
            chartArea.BorderWidth = 1;

            // Створюємо серію даних
            series = new Series(); 
            series.ChartType = SeriesChartType.Line;
            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerSize = 8;
            series.BorderWidth = 2;
            series.Color = Color.Blue;
            series.BorderDashStyle = ChartDashStyle.Solid;

            // Відключаємо сітку
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;

            chartArea.AxisY.Minimum = 30.0;
            chartArea.AxisY.Maximum = 32.0;

            // заголовок
            Title title = new Title();
            title.Text = "Зміна курсу національної валюти";
            title.Font = new Font("Arial", 12, FontStyle.Regular);
            title.Docking = Docking.Top;
            chart.Titles.Add(title);

            this.Controls.Add(chart);
        }
    }
}
