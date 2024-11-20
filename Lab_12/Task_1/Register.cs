using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Register : Form
    {
        string name, username, password1, password2;
        int userId;

        public Register()
        {
            InitializeComponent();
            InitializeUserId(); // Ініціалізація ID користувача при запуску форми
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ініціалізація пароля, імені та логіну
            if (initializePassword() && initializeUsername() && initializeName())
            {
                // Збереження даних
                SaveData();

                // Дії після успішної реєстрації
                MessageBox.Show("Реєстрація успішна!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        // Метод для ініціалізації User ID 
        public void InitializeUserId()
        {
            string filePath = "user_data.txt";

            if (File.Exists(filePath))
            {
                // Якщо файл існує, зчитуємо останній ID
                string[] lines = File.ReadAllLines(filePath);
                string lastUserIdLine = lines.LastOrDefault(line => line.StartsWith("UserID:"));
                if (lastUserIdLine != null)
                {
                    string lastUserId = lastUserIdLine.Split(':')[1].Trim();
                    userId = int.Parse(lastUserId) + 1; // Збільшуємо на 1
                }
                else
                {
                    userId = 1; // Якщо немає користувачів, починаємо з 1
                }
            }
            else
            {
                userId = 1; // Якщо файлу немає, починаємо з 1
            }
        }

        // Метод для перевірки і ініціалізації імені користувача
        public bool initializeUsername()
        {
            // Перевірка на порожнє значення
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Username не може бути порожнім.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Перевірка на заборонені символи
            if (textBox2.Text.Any(c => "!@#$%^&*()_+={}[]:;\"'<>,.?/-".Contains(c)))
            {
                MessageBox.Show("Username не повинно містити символи.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Перевірка на наявність кириличних символів
            if (textBox2.Text.Any(c => c >= 'а' && c <= 'я' || c >= 'А' && c <= 'Я'))
            {
                MessageBox.Show("Username не повинно містити кириличні символи.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            username = textBox2.Text;
            return true;
        }

        // Метод для перевірки і ініціалізації імені
        public bool initializeName()
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Name не може бути порожнім.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            name = textBox1.Text;
            return true;
        }

        // Метод для перевірки і ініціалізації пароля
        public bool initializePassword()
        {
            // Перевірка збігу паролів
            password1 = textBox3.Text;
            password2 = textBox4.Text;

            if (password1 != password2)
            {
                MessageBox.Show("Паролі не збігаються.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Перевірка довжини пароля
            if (password1.Length < 12)
            {
                MessageBox.Show("Пароль повинен містити мінімум 12 символів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Перевірка на наявність хоча б однієї букви
            if (!password1.Any(c => char.IsLetter(c)))
            {
                MessageBox.Show("Пароль повинен містити хоча б одну букву.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Перевірка на наявність хоча б однієї цифри
            if (!password1.Any(c => char.IsDigit(c)))
            {
                MessageBox.Show("Пароль повинен містити хоча б одну цифру.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Перевірка на наявність хоча б одного спеціального символа
            if (!password1.Any(c => "!@#$%^&*()_+={}[]:;\"'<>,.?/-".Contains(c)))
            {
                MessageBox.Show("Пароль повинен містити хоча б один спеціальний символ.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true; // Пароль пройшов всі перевірки
        }

        // Метод для збереження даних у файл
        public void SaveData()
        {
            string filePath = "user_data.txt";

            // Записуємо дані у файл
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    // Зберігаємо ID, ім'я, логін та пароль
                    writer.WriteLine($"UserID: {userId:D4}"); // Форматуємо ID 
                    writer.WriteLine("Name: " + name);
                    writer.WriteLine("UserName: " + username);
                    writer.WriteLine("Password: " + password1); 
                    writer.WriteLine("--------------------------------------------------");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при збереженні даних: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
