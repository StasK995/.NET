using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Authorization : Form
    {
        private string userName, password;
        private int userID;

        public Authorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        private void Authorizate_Click(object sender, EventArgs e)
        {
            userName = textBox2.Text;
            password = textBox3.Text;
            string filePath = "user_data.txt";

            // Перевірка, чи існує файл
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                bool isAuthenticated = false;

                // Змінні для зберігання даних
                string storedUserName = null, storedPassword = null;
                int storedUserID = 0;

                foreach (var line in lines)
                {
                    if (line.StartsWith("UserID:"))
                    {
                        // Отримання UserID
                        storedUserID = Convert.ToInt32(line.Split(':')[1].Trim());
                    }
                    else if (line.StartsWith("UserName:"))
                    {
                        // Отримання UserName
                        storedUserName = line.Split(':')[1].Trim();
                    }
                    else if (line.StartsWith("Password:"))
                    {
                        // Отримання Password
                        storedPassword = line.Split(':')[1].Trim();
                    }

                    // Перевірка облікових даних з урахуванням регістру
                    if (storedUserName != null && storedPassword != null)
                    {
                        if (string.Equals(storedUserName, userName, StringComparison.OrdinalIgnoreCase) && storedPassword == password)
                        {
                            isAuthenticated = true;
                            userID = storedUserID; // Встановлюємо UserID поточного користувача
                            break;
                        }
                    }
                }

                if (isAuthenticated)
                {
                    MessageBox.Show($"Авторизація успішна! UserID: {userID:D4}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserForm userForm = new UserForm(userID);
                    this.Hide();
                    userForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Невірне ім’я користувача або пароль.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Файл даних користувачів не знайдений.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
