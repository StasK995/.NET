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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task_8
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
            double res = 0;
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

                if (checkBox1.Checked && (number > 9))
                {
                    res = res * 0.9;
                    label2.Text = $"Загальна вартість: {res} \nзі знижкою 10%";
                }
                else
                {
                    // Результат
                    label2.Text = $"Загальна вартість: {res}";
                }
            }

        }

    }
}
