using System;
using System.IO;
using System.Windows.Forms;

namespace Task_1
{
    public partial class UserNameChange : Form
    {
        private int userID; // ID користувача
        private UserForm userForm; 
        private int usernameLineIndex = -1; 

        public UserNameChange(int userID, UserForm userForm)
        {
            InitializeComponent();
            this.userID = userID; // Ініціалізація ID користувача
            this.userForm = userForm; // Ініціалізація форми користувача
            LoadUserName(); 
        }

        // Метод для завантаження поточного імені користувача
        public void LoadUserName()
        {
            string filePath = "user_data.txt"; // Шлях до файлу з даними користувачів
            if (File.Exists(filePath)) // Перевірка, чи існує файл
            {
                string[] lines = File.ReadAllLines(filePath); // Читання всіх рядків з файлу
                string currentUserName = null; 

                // Проходимо по всіх рядках файлу
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].StartsWith("UserID:")) // Знаходимо рядок з UserID
                    {
                        int storedUserID = Convert.ToInt32(lines[i].Split(':')[1].Trim()); // Отримуємо ID користувача
                        if (storedUserID == userID) 
                        {
                            // Перевіряємо наявність рядка з іменем користувача
                            if (i + 2 < lines.Length && lines[i + 2].StartsWith("UserName:"))
                            {
                                currentUserName = lines[i + 2].Split(':')[1].Trim(); 
                                usernameLineIndex = i + 2; 
                            }
                            break; 
                        }
                    }
                }

                if (!string.IsNullOrEmpty(currentUserName))
                {
                    label1.Text = $"Current UserName: {currentUserName}"; // Відображаємо поточне ім'я користувача
                }
                else
                {
                    label1.Text = "User Name not found."; 
                }
            }
            else
            {
                MessageBox.Show("File not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        // Метод для зміни імені користувача
        private void button1_Click(object sender, EventArgs e)
        {
            string newUserName = textBox1.Text; 
            string filePath = "user_data.txt"; 

            if (File.Exists(filePath)) 
            {
                string[] lines = File.ReadAllLines(filePath); 

                // Перевіряємо, чи коректний індекс рядка для зміни імені
                if (usernameLineIndex >= 0 && usernameLineIndex < lines.Length)
                {
                    // Заміщуємо стару строку новим ім'ям користувача
                    lines[usernameLineIndex] = $"UserName: {newUserName}";

                    // Перезаписуємо файл з оновленим вмістом
                    File.WriteAllLines(filePath, lines);

                    MessageBox.Show("UserName updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); 

                    // Оновлюємо дані на формі UserForm
                    userForm.InitializeUser(); 
                    this.Close(); 
                }
            }
            else
            {
                MessageBox.Show("File not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
    }
}
