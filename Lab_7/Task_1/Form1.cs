using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form1 : Form
    {
        private Label label1; 

        public Form1()
        {
            InitializeComponent();
        }

       
        private void Button_Click(object sender, EventArgs e)
        {
            if (label1 == null)
            {
                InitializeLabel(); 
            }
        }

        public void InitializeLabel()
        {
            label1 = new Label()
            {
                Location = new Point(50, 400), // Позиція 
                Font = new Font("Arial", 20, FontStyle.Regular), // Шрифт і розмір
                AutoSize = true, 
                ForeColor = Color.Red, // Колір тексту
                Text = "Кнопка була натиснута", // Текст 
            };

            this.Controls.Add(label1); 
        }

        // Обробка натискання кнопки для видалення 
        private void button4_Click(object sender, EventArgs e)
        {
            if (label1 != null)
            {
                this.Controls.Remove(label1); // Видалення з форми
                label1.Dispose(); // Звільнення ресурсів
                label1 = null; // Очищення посилання на метку
            }
        }
    }
}
