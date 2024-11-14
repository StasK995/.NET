using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form4_3 : Form
    {
        private Form4_1 form4_1;
        public Form4_3(Form4_1 form4_1)
        {
            InitializeComponent();
            this.form4_1 = form4_1;
            int a = form4_1.A;
            int b = form4_1.B;
            int c = form4_1.C;

           
            double volume = a * b * c;
            double surfaceArea = 2 * (a * b + b * c + a * c);

            
            label4.Text = $"Об'єм = {volume}";
            label5.Text = $"Площа = {surfaceArea}";
        }
    }
}
