using System;
using System.Windows.Forms;

namespace Task_4
{
    public partial class Form1 : Form
    {
        private int X, Y, Z;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Спробуємо перетворити введені значення
            if (!int.TryParse(textBox1.Text, out X) || !int.TryParse(textBox2.Text, out Y) || !int.TryParse(textBox3.Text, out Z))
            {
                label4.Text = "Помилка: введіть цілі числа!";
                return;
            }

            double res = CalculateProduct(X, Y, Z);

            // Якщо результат NaN або 0, виводимо повідомлення про помилку
            if (double.IsNaN(res) || res == 0)
            {
                label4.Text = "Помилка: неправильний результат!";
            }
            else
            {
                label4.Text = $"Результат = {res}";
            }
        }

        static double CalculateProduct(int x, int y, int z)
        {
            double result = 1.0; // Ініціалізація для добутку

            for (int i = 1; i <= x + y; i++)
            {
                double numerator = 2 + i - z;
                double denominator = Math.Pow(x, 3) - i + Math.Pow(i, 2);

                // Перевірка ділення на нуль
                if (denominator == 0)
                {
                    return 0; // Повертаємо 0, якщо ділення на нуль
                }

                // Перевірка на від'ємне значення під коренем
                if (numerator < 0)
                {
                    return 0; // Повертаємо 0, якщо під коренем від'ємне число
                }

                double term = Math.Sqrt(numerator / denominator);

                // Перевірка на NaN
                if (Double.IsNaN(term))
                {
                    return 0; // Повертаємо 0, якщо результат обчислень NaN
                }

                result *= term; // Множимо кожен член на загальний результат
            }

            return result; // Повертаємо кінцевий результат
        }
    }
}
