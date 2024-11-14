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
    public partial class Form3_2 : Form
    {
        private Form3_1 form3_1;
        private int X, Y, Z;
        public double res;

        // Конструктор, який ініціалізує форму та передає дані з іншої форми
        public Form3_2(Form3_1 form3_1)
        {
            InitializeComponent();
            this.form3_1 = form3_1;
            X = form3_1.X;  // Отримання значень X, Y, Z з іншої форми
            Y = form3_1.Y;
            Z = form3_1.Z;
            res = CalculateProduct(X, Y, Z);  // Обчислення результату
            InitializeLabel();  // Ініціалізація мітки для виведення результату
        }

        // Метод для обчислення добутку
        static double CalculateProduct(int x, int y, int z)
        {
            double result = 1.0; // Ініціалізація для добутку

            // Цикл для обчислення добутку за формулою
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

        // Ініціалізація мітки для відображення результату
        public void InitializeLabel()
        {
            if (double.IsNaN(res) || res == 0)
            {
                label4.Text = "Помилка: неправильний результат!";  // Повідомлення про помилку
            }
            else
            {
                label4.Text = $"Результат = {res}";  // Виведення обчисленого результату
            }
        }
    }
}
