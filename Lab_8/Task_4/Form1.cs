using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearForm();
            MessageBox.Show("Форму очищено!", "Повідомлення",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ClearForm()
        {
            foreach (Control control in this.Controls)
            {
                if (control is GroupBox groupBox)
                {
                    foreach (Control groupControl in groupBox.Controls)
                    {
                        if (groupControl is TextBox tb)
                            tb.Text = string.Empty; 
                        else if (groupControl is ComboBox cb)
                            cb.SelectedIndex = -1; 
                        else if (groupControl is CheckBox chk)
                            chk.Checked = false; 
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox4.Text;
            string phone = textBox3.Text;
            string email = textBox2.Text;
            string visitDate = textBox1.Text;
            string ageGroup = comboBox1.SelectedItem?.ToString();
            string favoriteCuisine = comboBox2.SelectedItem?.ToString();
            string favoriteDishes = textBox7.Text;

            CheckBox[] checkBoxes = { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6 };
            List<string> list = new List<string>();

            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox.Checked)
                {
                    list.Add(checkBox.Text);
                }
            }

            string selectedOptionsText;
            if (list.Count > 0)
            {
                selectedOptionsText = string.Join(", ", list);
            }
            else
            {
                selectedOptionsText = "-";
            }

            // Повідомлення
            StringBuilder messageBuilder = new StringBuilder();
            messageBuilder.AppendLine($"Ім'я: {name}");
            messageBuilder.AppendLine($"Телефон: {phone}");
            messageBuilder.AppendLine($"Пошта: {email}");
            messageBuilder.AppendLine($"Дата відвідування: {visitDate}");
            messageBuilder.AppendLine($"Вік: {ageGroup}");
            messageBuilder.AppendLine($"Улюблена кухня: {favoriteCuisine}");
            messageBuilder.AppendLine($"Страви, які ви б хотіли побачити: {favoriteDishes}");
            messageBuilder.AppendLine($"Оцінка установи: {selectedOptionsText}");

            // Получаем окончательное сообщение
            string message = messageBuilder.ToString();

            // Выводим сообщение
            MessageBox.Show(message, "Дані анкети", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
