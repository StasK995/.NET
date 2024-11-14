using System;
using System.Windows.Forms;

namespace Task_6
{
    public partial class Form1 : Form
    {
        public int Tsec = 0;
        public int Tmin = 0;
        public int Nsec = 0;
        public int Nmin = 0;
        private Timer timer;

        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000; 
            timer.Tick += Timer_Tick;
            timer.Enabled = false;

            
            label1.Text = $"{Tmin:D2}:{Tsec:D2}";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            
            Tsec++;

            
            if (Tsec >= 60)
            {
                Tsec = 0;
                Tmin++;
            }

            
            label1.Text = $"{Tmin:D2}:{Tsec:D2}";

            
            if (Tmin == Nmin && Tsec == Nsec)
            {
                timer.Stop();
                string show = label1.Text;
                MessageBox.Show($"Таймер досяг значення: {show}");
                Tsec = 0;
                Tmin = 0;
                label1.Text = $"{Tmin:D2}:{Tsec:D2}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Nmin = (int)numericUpDown1.Value;
            Nsec = (int)numericUpDown2.Value;
            

            
            if (!timer.Enabled)
            {
                timer.Start();
            }
            else
            {
                timer.Stop();
               

            }
        }
    }
}
