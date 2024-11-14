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

namespace Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string[] images; 
        private int currentIndex = 0; 

        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string path = dialog.SelectedPath;

                    
                    images = Directory.GetFiles(path, "*.*")
                        .Where(file => file.EndsWith(".jpg") ||
                                       file.EndsWith(".jpeg") ||
                                       file.EndsWith(".png") ||
                                       file.EndsWith(".bmp"))
                        .ToArray();

                    
                    if (images.Length > 0)
                    {
                        try
                        {
                            currentIndex = 0; 
                            pictureBox1.Image = Image.FromFile(images[currentIndex]);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Помилка під час завантаження зображення: " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("У вибраній папці немає зображень.");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (images != null && images.Length > 0)
            {
                
                currentIndex = (currentIndex + 1) % images.Length;
                try
                {
                    pictureBox1.Image = Image.FromFile(images[currentIndex]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка під час завантаження зображення: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Сначала выберите папку с изображениями.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (images != null && images.Length > 0)
            {
                
                currentIndex = (currentIndex - 1 + images.Length) % images.Length;
                try
                {
                    pictureBox1.Image = Image.FromFile(images[currentIndex]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке изображения: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("У вибраній папці немає зображень.");
            }
        }
    }
}
