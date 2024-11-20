using System;
using System.Windows.Forms;
using System.IO;

namespace Task_1
{
    public partial class UserForm : Form
    {
        private int userID; // Змінна для зберігання ID користувача
        private string userName; // Змінна для зберігання імені користувача

        // Конструктор форми, приймає ID користувача
        public UserForm(int userID)
        {
            InitializeComponent();
            this.userID = userID; // Ініціалізація userID
            InitializeUser(); // Завантаження даних користувача
        }

        // Метод для ініціалізації даних користувача
        public void InitializeUser()
        {
            label1.Text = $"UserID: {userID:D4}"; // Відображення поточного UserID на екрані
            string filePath = "user_data.txt"; // Шлях до файлу з даними користувачів

            // Перевірка, чи існує файл з даними
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath); // Читання всіх рядків з файлу
                for (int i = 0; i < lines.Length; i++)
                {
                    // Пошук рядка, що містить UserID
                    if (lines[i].StartsWith("UserID:"))
                    {
                        int storedUserID = Convert.ToInt32(lines[i].Split(':')[1].Trim()); // Отримання ID з файлу

                        // Якщо ID користувача збігається з поточним
                        if (storedUserID == userID)
                        {
                            // Ініціалізуємо змінні для зберігання даних
                            string name = string.Empty;
                            userName = string.Empty;
                            string password = string.Empty;

                            // Перевірка наступних рядків на наявність даних користувача
                            if (i + 1 < lines.Length && lines[i + 1].StartsWith("Name:"))
                                name = lines[i + 1].Split(':')[1].Trim(); // Отримання імені

                            if (i + 2 < lines.Length && lines[i + 2].StartsWith("UserName:"))
                                userName = lines[i + 2].Split(':')[1].Trim(); // Отримання логіну

                            if (i + 3 < lines.Length && lines[i + 3].StartsWith("Password:"))
                                password = lines[i + 3].Split(':')[1].Trim(); // Отримання пароля

                            // Оновлюємо елементи інтерфейсу для відображення даних користувача
                            label2.Text = $"Name: {name}";
                            label3.Text = $"UserName: {userName}";
                            label4.Text = $"Password: {password}";
                            break; // Зупиняємо пошук, оскільки користувача знайдено
                        }
                    }
                }
            }
            else
            {
                // Виведення повідомлення, якщо файл не знайдений
                MessageBox.Show("Файл даних користувачів не знайдений.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обробник події для кнопки зміни імені
        private void button1_Click(object sender, EventArgs e)
        {
            NameChange nameChange = new NameChange(userID, this); // Створюємо форму для зміни імені
            nameChange.ShowDialog(); // Відображаємо форму
        }

        // Обробник події для кнопки зміни логіну
        private void button2_Click(object sender, EventArgs e)
        {
            UserNameChange userNameChange = new UserNameChange(userID, this); 
            userNameChange.ShowDialog(); 
        }

        // Обробник події для кнопки зміни пароля
        private void button3_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword(userID, this); 
            changePassword.ShowDialog(); 
        }

        // Обробник події для кнопки відправлення повідомлення
        private void button4_Click(object sender, EventArgs e)
        {
            SendMessageForm sendMessageForm = new SendMessageForm(userName, this); 
            sendMessageForm.ShowDialog(); 
        }

        // Обробник події для кнопки завантаження повідомлення
        private void button5_Click(object sender, EventArgs e)
        {
            LoadMessage loadMessage = new LoadMessage(userName); 
            loadMessage.ShowDialog(); 
        }
    }
}
