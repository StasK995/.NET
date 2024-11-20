using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Task_1
{
    public partial class ChangePassword : Form
    {
        private int userID;
        private UserForm userForm;
        private int passwordLineIndex = -1;

        public ChangePassword(int userID, UserForm userForm)
        {
            InitializeComponent();
            this.userID = userID;
            this.userForm = userForm;
            LoadPassword();
        }

        public void LoadPassword()
        {
            string filePath = "user_data.txt";
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                string currentPassword = null;

                // Проходимо по всіх рядках файлу
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].StartsWith("UserID:"))
                    {
                        int storedUserID = Convert.ToInt32(lines[i].Split(':')[1].Trim());
                        if (storedUserID == userID)
                        {
                            // Перевіряємо наявність рядка "Password:" на наступній позиції
                            if (i + 3 < lines.Length && lines[i + 3].StartsWith("Password:"))
                            {
                                currentPassword = lines[i + 3].Split(':')[1].Trim();
                                passwordLineIndex = i + 3; // Зберігаємо індекс рядка з паролем
                            }
                            break; // Вихід з циклу, якщо знайдений потрібний користувач
                        }
                    }
                }

                // Відображаємо пароль або повідомлення про його відсутність
                if (!string.IsNullOrEmpty(currentPassword))
                {
                    label1.Text = $"Current password: {currentPassword}";
                }
                else
                {
                    label1.Text = "User Password not found.";
                }
            }
            else
            {
                MessageBox.Show("Файл не знайдений!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password1 = textBox1.Text;
            string password2 = textBox2.Text;
            string filePath = "user_data.txt";
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                if (password1 == password2)
                {
                    if (passwordLineIndex >= 0 && passwordLineIndex < lines.Length)
                    {
                        lines[passwordLineIndex] = $"Password: {password1}";

                        File.WriteAllLines(filePath, lines);

                        MessageBox.Show("Пароль успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        userForm.InitializeUser();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Паролі не співпадають.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
