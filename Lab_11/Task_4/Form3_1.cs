using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_4
{
    public partial class Form3_1 : Form
    {
        public int X {  get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Form3_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int xTemp, yTemp, zTemp;

            
            if (!int.TryParse(textBox1.Text, out xTemp) || !int.TryParse(textBox2.Text, out yTemp) || !int.TryParse(textBox3.Text, out zTemp))
            {
                MessageBox.Show("Ошибка: введите целые числа");
                return;
            }

            // Після перевірки присвоюємо значення властивостей            X = xTemp;
            Y = yTemp;
            Z = zTemp;

            Form3_2 form3_2 = new Form3_2(this);
            form3_2.ShowDialog();
        }
    }
}
