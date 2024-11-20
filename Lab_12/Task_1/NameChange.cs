using System;
using System.IO;
using System.Windows.Forms;

namespace Task_1
{
    public partial class NameChange : Form
    {
        private int userID;
        private UserForm userForm;
        private int nameLineIndex = -1; // Індекс рядка, де зберігається ім'я користувача

        public NameChange(int userID, UserForm userForm)
        {
            InitializeComponent();
            this.userID = userID;
            this.userForm = userForm;
            LoadName();
        }

        // Метод для завантаження поточного імені
        public void LoadName()
        {
            string filePath = "user_data.txt";
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                string currentName = null;

                // Перебираємо всі рядки файлу
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].StartsWith("UserID:"))
                    {
                        int storedUserID = Convert.ToInt32(lines[i].Split(':')[1].Trim());
                        if (storedUserID == userID)
                        {
                            // Перевіряємо наявність рядка "Name:" на наступній позиції
                            if (i + 1 < lines.Length && lines[i + 1].StartsWith("Name:"))
                            {
                                currentName = lines[i + 1].Split(':')[1].Trim();
                                nameLineIndex = i + 1; // Зберігаємо індекс рядка з іменем
                            }
                            break; // Виходимо з циклу, якщо знайшли потрібного користувача
                        }
                    }
                }

                // Виводимо ім'я або повідомлення про відсутність імені
                if (!string.IsNullOrEmpty(currentName))
                {
                    label1.Text = $"Current Name: {currentName}";
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
        public void button1_Click(object sender, EventArgs e)
        {
            string newName = textBox1.Text;
            string filePath = "user_data.txt";
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                // Перевіряємо, чи правильний індекс рядка для заміни
                if (nameLineIndex >= 0 && nameLineIndex < lines.Length)
                {
                    // Заміщаємо рядок на нове ім'я
                    lines[nameLineIndex] = $"Name: {newName}";

                    // Перезаписуємо файл з оновленим вмістом
                    File.WriteAllLines(filePath, lines);

                    MessageBox.Show("Name updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    userForm.InitializeUser();
                    this.Close();
                }
            }
        }
    }
}
