using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_13
{
    public partial class Form1 : Form
    {
        private RadioButton rd1; 

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown; 
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.Shift && e.KeyCode == Keys.A)
            {
                // Перевірка, чи RadioButton вже існує, щоб уникнути повторного створення
                if (rd1 == null)
                {
                    rd1 = new RadioButton
                    {
                        Location = new Point(200, 200), // Встановлення позиції
                        Text = "Нова радіокнопка", 
                    };

                    this.Controls.Add(rd1); // Додавання RadioButton на форму
                }
            }
            else if (e.Alt && e.Shift && e.KeyCode == Keys.D)
            {
                // Видалення RadioButton, якщо він існує
                if (rd1 != null)
                {
                    this.Controls.Remove(rd1);
                    rd1.Dispose(); 
                    rd1 = null; 
                }
            }
        }
    }
}
