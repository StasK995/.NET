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


namespace Task_5
{
    public partial class Form2 : Form
    {
        public Form2(string city)
        {
            InitializeComponent();
            string filePath = Path.Combine("City", city + ".txt");
            string fromFile = File.ReadAllText(filePath);
            string imagePath = Path.Combine("City", city + ".jpg");
            label1.Text = fromFile;
            pictureBox1.Image = Image.FromFile(imagePath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
