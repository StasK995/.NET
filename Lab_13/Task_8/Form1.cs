using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Task_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreatePieChart();
        }

        private void CreatePieChart()
        {
            Chart pieChart = new Chart();
            pieChart.Dock = DockStyle.Fill;  

            ChartArea chartArea = new ChartArea();
            pieChart.ChartAreas.Add(chartArea);

            Legend legend = new Legend();
            pieChart.Legends.Add(legend);

            Series series = new Series
            {
                ChartType = SeriesChartType.Pie,  
                BorderWidth = 1
            };

            series.Points.AddXY("Шахи", 25);
            series.Points.AddXY("Карате", 50);
            series.Points.AddXY("Баскетбол", 20);
            series.Points.AddXY("Басейн", 5);

            pieChart.Series.Add(series);

            this.Controls.Add(pieChart);
        }
    }
}