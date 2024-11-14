using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task_3
{
    public partial class Form3_2 : Form
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public Form3_2()
        {
            InitializeComponent();
            
        }
        public void UpdateVolumeAndSurfaceArea()
        {
            
            double volume = A * B * C;

            
            double surfaceArea = 2 * (A * B + B * C + A * C);

            
            label4.Text = $"Об'єм = {volume}";
            label5.Text = $"Площа = {surfaceArea}";
        }
    }
}
