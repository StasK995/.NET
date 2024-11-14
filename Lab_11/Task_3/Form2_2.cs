using System;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form2_2 : Form
    {
        private int a, b, c;

        // Подія передачі даних назад у Form2_1
        public event Action<int, int, int> OnDataEntered;

        public Form2_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Перевірка
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Пожалуйста, введите значения для всех сторон параллелепипеда.");
                return;
            }

            // Спроба перетворити введені значення цілі числа
            if (!int.TryParse(textBox1.Text, out a) || !int.TryParse(textBox2.Text, out b) || !int.TryParse(textBox3.Text, out c))
            {
                MessageBox.Show("Пожалуйста, введите корректные целые числа для сторон.");
                return;
            }

            // Подія передачі даних у Form2_1
            OnDataEntered?.Invoke(a, b, c);

            // Закриття поточної форми після передачі даних
            this.Close();
        }
    }
}
