using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_4
{
    public partial class Form2_1 : Form
    {
        public int X {  get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Form2_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2_2 form2_2 = new Form2_2(this); // Передаємо посилання на поточну форму
            form2_2.ShowDialog();

            double res = CalculateProduct(X, Y, Z);

            // Якщо результат NaN або 0, виводимо повідомлення про помилку
            if (double.IsNaN(res) || res == 0)
            {
                label4.Text = "Ошибка: неверный результат!";
            }
            else
            {
                label4.Text = $"Результат = {res}";
            }

        }

        static double CalculateProduct(int x, int y, int z)
        {
            double result = 1.0; // Ініціалізація для твору

            for (int i = 1; i <= x + y; i++)
            {
                double numerator = 2 + i - z;
                double denominator = Math.Pow(x, 3) - i + Math.Pow(i, 2);

                // Перевірка поділу на нуль
                if (denominator == 0)
                {
                    return 0; 
                }

                // Перевірка на негативне значення під коренем
                if (numerator < 0)
                {
                    return 0;
                }

                double term = Math.Sqrt(numerator / denominator);

                // Перевірка на NaN
                if (Double.IsNaN(term))
                {
                    return 0; 
                }

                result *= term; 
            }

            return result; 
        }
    }
}
