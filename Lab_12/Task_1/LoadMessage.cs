using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using System.Xml.Linq;

namespace Task_1
{
    public partial class LoadMessage : Form
    {
        private string userName;
        public LoadMessage(string userName)
        {
            InitializeComponent();
            this.userName = userName;
            LoadMessages(userName);
        }

        // Завантаження повідомлень з файлу та відображення їх у ListBox
        private void LoadMessages(string userName)
        {
            string filePath = "messages.txt";
            if (File.Exists(filePath))
            {
                try
                {
                    listBoxMessages.Items.Clear();  // Очищаємо список

                    string[] allMessages = File.ReadAllLines(filePath);
                    string currentTheme = string.Empty;

                    // Перебираємо всі рядки файлу
                    for (int i = 0; i < allMessages.Length; i++)
                    {
                        // Перевіряємо рядок на наявність TO
                        if (allMessages[i].StartsWith("TO:"))
                        {
                            string storedUserName = allMessages[i].Split(':')[1].Trim();
                            if (storedUserName == userName)
                            {
                                // Якщо наступний рядок починається з THEME це тема повідомлення
                                if (i + 1 < allMessages.Length && allMessages[i + 1].StartsWith("THEME:"))
                                {
                                    currentTheme = allMessages[i + 1].Split(':')[1].Trim();
                                    listBoxMessages.Items.Add(currentTheme);  
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при завантаженні повідомлень: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Файл повідомлень не знайдений.");
            }
        }

        private void listBoxMessages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxMessages.SelectedItem != null)
            {
                string selectedTheme = listBoxMessages.SelectedItem.ToString();
                ShowMessageDetails(selectedTheme);
            }
        }

        // Метод для відображення деталей повідомлення 
        private void ShowMessageDetails(string theme)
        {
            string filePath = "messages.txt";
            if (File.Exists(filePath))
            {
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;

                string[] allMessages = File.ReadAllLines(filePath);
                bool isMessageFound = false;  // Прапор для відстеження

                for (int i = 0; i < allMessages.Length; i++)
                {
                    // Шукаємо рядок з темою повідомлення
                    if (allMessages[i].StartsWith("THEME:"))
                    {
                        string storedTheme = allMessages[i].Split(':')[1].Trim();
                        if (storedTheme == theme)
                        {
                            // Отримуємо FROM
                            if (i - 2 >= 0 && allMessages[i - 2].StartsWith("FROM:"))
                            {
                                string currentFROM = allMessages[i - 2].Split(':')[1].Trim();
                                textBox1.Text = $"From: {currentFROM}";
                            }

                            // Отримуємо THEME
                            if (i < allMessages.Length && allMessages[i].StartsWith("THEME:"))
                            {
                                string currentTheme = allMessages[i].Split(':')[1].Trim();
                                textBox2.Text = $"Theme: {currentTheme}";
                            }

                            // Отримуємо "TEXT"
                            if (i + 1 < allMessages.Length && allMessages[i + 1].StartsWith("TEXT:"))
                            {
                                string currentTEXT = allMessages[i + 1].Split(':')[1].Trim();
                                textBox3.Text = $"{currentTEXT}";
                            }

                            isMessageFound = true;  
                            break;  
                        }
                    }
                }

                
                if (!isMessageFound)
                {
                    MessageBox.Show("Повідомлення з такою темою не знайдено.");
                }
            }
            else
            {
                MessageBox.Show("Файл повідомлень не знайдений.");
            }
        }

    }
}
