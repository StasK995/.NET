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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                DialogResult result = MessageBox.Show("Зберегти файл?", "Підтвердження", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(sender, e);
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            //textBox1.Clear();  
        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|Binary files (*.bin)|*.bin";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                if (Path.GetExtension(filePath) == ".txt")
                {
                    File.WriteAllText(filePath, textBox1.Text);
                }
                else if (Path.GetExtension(filePath) == ".bin")
                {
                    byte[] data = Encoding.UTF8.GetBytes(textBox1.Text);
                    File.WriteAllBytes(filePath, data);
                }

            }
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Розробник = Кузьмін С.О.");
            sb.AppendLine("Група КН-923с");
            sb.AppendLine("Дата створення 14.11.2024");
            MessageBox.Show(sb.ToString());
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|Binary files (*.bin)|*.bin";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                if (Path.GetExtension(filePath) == ".txt")
                {
                    textBox1.Text = File.ReadAllText(filePath);
                }
                else if (Path.GetExtension(filePath) == ".bin")
                {
                    byte[] data = File.ReadAllBytes(filePath);
                    string text = Encoding.UTF8.GetString(data);
                    textBox1.Text = text;
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int position = textBox1.SelectionStart;

            int lineNumber = textBox1.GetLineFromCharIndex(position);

            int columnNumber = position - textBox1.GetFirstCharIndexFromLine(lineNumber);

            toolStripStatusLabel1.Text = $"Строка: {lineNumber + 1}, Позиция: {columnNumber + 1}";
        }

    }
}
