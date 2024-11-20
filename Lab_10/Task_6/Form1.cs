using System;
using System.Windows.Forms;

namespace Task_6
{
    public partial class Form1 : Form
    {
        public int Tsec = 0;
        public int Tmin = 0;
        private Timer timer;

        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 100; 
            timer.Tick += Timer_Tick;
            timer.Enabled = false;

            label1.Text = $"{Tmin:D2}:{Tsec:D2}";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (Tsec > 0)
            {
                Tsec--;
            }
            else if (Tmin > 0)
            {
                Tmin--;
                Tsec = 59;
            }

            label1.Text = $"{Tmin:D2}:{Tsec:D2}";

            if (Tmin == 0 && Tsec == 0)
            {
                timer.Stop();
                MessageBox.Show("Час вичерпано!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tmin = (int)numericUpDown1.Value;
            Tsec = (int)numericUpDown2.Value;

            label1.Text = $"{Tmin:D2}:{Tsec:D2}";
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
