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

namespace Task_9
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
                int item = comboBox1.SelectedIndex;
                if (item == 0)
                {
                    res = number * Pl;
                }
                else if (item == 1)
                {
                    res = number * CP;
                }
                else if (item == 2)
                {
                    res = number * Luxe;
                }

                // Результат
                label2.Text = $"Загальна вартість: {res}";
            }

        }

    }
}
