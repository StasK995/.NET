using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_7
{
    public partial class Form1 : Form
    {
        public const int Pl = 350;
        //public int res = 0;
        public const int CP = 450;
        public const int Luxe = 850;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int res = 0;
            int number;

            // Текст в число
            if (int.TryParse(textBox1.Text, out number))
            {
                // 
                if (radioButton1.Checked)
                {
                    res = number * Pl;
                }
                else if (radioButton2.Checked)
                {
                    res = number * CP;
                }
                else if (radioButton3.Checked)
                {
                    res = number * Luxe;
                }

                // Результат
                label2.Text = $"Загальна вартість: {res}";
            }

        }

    }
}
