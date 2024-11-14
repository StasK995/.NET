using System;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form1 : Form
    {
        private int a, b, c;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Перевірка на порожні рядки та коректність введення
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Будь ласка, введіть значення для всіх сторін паралелепіпеда.");
                return;
            }

            // Спроба перетворити введені значення в цілі числа
            if (!int.TryParse(textBox1.Text, out a) || !int.TryParse(textBox2.Text, out b) || !int.TryParse(textBox3.Text, out c))
            {
                MessageBox.Show("Будь ласка, введіть коректні цілі числа для сторін.");
                return;
            }

            // Обчислення об'єму
            double volume = a * b * c;

            // Обчислення площі поверхні
            double surfaceArea = 2 * (a * b + b * c + a * c);

            // Виведення результатів у мітки
            label4.Text = $"Об'єм = {volume}";
            label5.Text = $"Площа = {surfaceArea}";
        }
    }
}
