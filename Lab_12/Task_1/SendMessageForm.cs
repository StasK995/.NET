using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Task_1
{
    public partial class SendMessageForm : Form
    {
        private UserForm UserForm;
        private string userName;
        public SendMessageForm(string userName, UserForm userForm)
        {
            InitializeComponent();
            this.userName = userName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string recipient = textBox1.Text;
            string theme = textBox2.Text;
            string messageText = textBox3.Text;
            if (string.IsNullOrEmpty(recipient) || string.IsNullOrEmpty(theme) || string.IsNullOrEmpty(messageText))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string filePath = "messages.txt"; 

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    // ID, имя, логин и пароль
                    writer.WriteLine($"FROM: {userName}"); 
                    writer.WriteLine("TO: " + recipient);
                    writer.WriteLine("THEME: " + theme);
                    writer.WriteLine("TEXT: " + messageText); 
                    writer.WriteLine("--------------------------------------------------");
                }
                MessageBox.Show("Message sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
