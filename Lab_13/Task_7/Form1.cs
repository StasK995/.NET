using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Task_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Text = "График функции";
            this.Size = new Size(800, 600);

            Chart chart = new Chart();
            chart.Dock = DockStyle.Fill;

            this.Controls.Add(chart);

            ChartArea chartArea = new ChartArea("MainArea");
            chartArea.AxisX.Title = "X";
            chartArea.AxisY.Title = "Y";
            chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;

            chart.ChartAreas.Add(chartArea);

            Series series = new Series
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 2,
                Color = Color.Blue
            };

            chart.Series.Add(series);

            for (double x = 0; x <= 20; x += 0.25)
            {
                double y;

                if (x <= 1)
                    y = Math.Sqrt(1 - Math.Pow(x - 1, 2));
                else if (x <= 4)
                    y = -1 / 3.0 * x + 4 / 3.0;
                else
                    continue; // Ігноруємо x > 4, тому що функція там не визначена

                series.Points.AddXY(x, y);
            }
        }
    }
}
