using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_6
{
    public partial class Form1 : Form
    {
        public const double UahToEuro = 0.0223;
        public const double EuroToUah = 44.7960;
        public const double MainCost = 450;
        public double ResultCost = 0;
        public double AddCost = 0;

        public Form1()
        {
            InitializeComponent();
            label2.Text = $"Базова вартість квитка: {MainCost} ГРН";
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            AddCost = 0;

            Count();
            label2.Text = $"Базова вартість квитка: {MainCost} ГРН";
            label3.Text = $"Вартість додаткових послуг: {AddCost} ГРН";
            ResultCost = AddCost + MainCost;
            label4.Text = $"Загальна вартість: {ResultCost} ГРН";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddCost = 0;
            Count();
            double MainUero = MainCost;
            MainUero *= UahToEuro;
            label2.Text = $"Базова вартість квитка: {MainUero} Euro";

            double EuroAdd = AddCost * UahToEuro;
            label3.Text = $"Вартість додаткових послуг: {EuroAdd} Euro";
            ResultCost = AddCost + MainCost;
            double EuroResult = ResultCost * UahToEuro;
            label4.Text = $"Загальна вартість: {EuroResult} Euro";
        }

        public void Count()
        {
            foreach (var item in checkedListBox1.CheckedItems)
            {

                int index = checkedListBox1.Items.IndexOf(item);

                switch (index)
                {
                    case 0:
                        AddCost += 25;
                        break;
                    case 1:
                        AddCost += 50;
                        break;
                    case 2:
                        AddCost += 75;
                        break;
                    case 3:
                        AddCost += 100;
                        break;
                }
            }
        }
    }
}
