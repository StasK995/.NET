using System;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form2_1 : Form
    {
        private int a, b, c;

        
        public Form2_1(int a, int b, int c)
        {
            InitializeComponent();
            this.a = a;
            this.b = b;
            this.c = c;

            
            UpdateVolumeAndSurfaceArea();
        }

        private void UpdateVolumeAndSurfaceArea()
        {
           
            double volume = a * b * c;

           
            double surfaceArea = 2 * (a * b + b * c + a * c);

           
            label4.Text = $"Об'єм = {volume}";
            label5.Text = $"Площа = {surfaceArea}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form2_2 form2_2 = new Form2_2();
            form2_2.OnDataEntered += (a, b, c) =>
            {
                
                this.a = a;
                this.b = b;
                this.c = c;
                UpdateVolumeAndSurfaceArea();
            };
            form2_2.ShowDialog();
        }
    }
}
