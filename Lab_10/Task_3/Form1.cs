using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form1 : Form
    {
        private string[] images; 

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string path = dialog.SelectedPath;
                    label1.Text = path;

                    
                    images = Directory.GetFiles(path, "*.*").ToArray();
                    listBox1.Items.Clear(); 

                    
                    foreach (string image in images)
                    {
                        string fileName = Path.GetFileName(image); 
                        listBox1.Items.Add(fileName);
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;

            
            if (index != -1)
            {
                
                string imagePath = images[index];

                try
                {
                    
                    pictureBox1.Image = System.Drawing.Image.FromFile(imagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка під час завантаження зображення: " + ex.Message);
                }
            }
        }
    }
}
