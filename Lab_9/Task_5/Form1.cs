using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_5
{
    public partial class Form1 : Form
    {
        public const double MainCost = 450;
        public double ResultCost = 0;
        public double AddCost = 0;

        public Form1()
        {
            InitializeComponent();
            label1.Text = "Базова вартість квитка: " + MainCost;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCost = 0; 

            foreach (var item in checkedListBox1.CheckedItems)
            {
               
                int index = checkedListBox1.Items.IndexOf(item);

                switch (index)
                {
                    case 0:
                        AddCost += 25;
                        break;
                    case 1:
                        AddCost += 50;
                        break;
                    case 2:
                        AddCost += 75;
                        break;
                    case 3:
                        AddCost += 100;
                        break;
                }
            }

            label3.Text = "Вартість додаткових послуг : " + AddCost;
            ResultCost = AddCost + MainCost;
            label4.Text = "Вартість додаткових послуг : " + ResultCost;
        }
    }
}
