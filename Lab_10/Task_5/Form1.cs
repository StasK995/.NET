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
        public int sec = 0;
        public int min = 0;
        private Timer timer;
        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            
            sec++;

            
            if (sec >= 60)
            {
                sec = 0; 
                min++;    
            }

            if (min < 10)
            {
                label1.Text = "0" + min.ToString(); 
            }
            else
            {
                label1.Text = min.ToString(); 
            }


            if (sec < 10)
            {
                label3.Text = "0" + sec.ToString(); 
            }
            else
            {
                label3.Text = sec.ToString(); 
            }

            ChangeText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void ChangeText()
        {
            int i = sec;
            if (i % 5 == 0)
            {
                this.label3.Font = new Font("Microsoft Sans Serif", 30, FontStyle.Regular);
                this.label2.Font = new Font("Microsoft Sans Serif", 30, FontStyle.Regular);
                this.label1.Font = new Font("Microsoft Sans Serif", 30, FontStyle.Regular);
            }
            else
            {
                this.label3.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Regular);
                this.label2.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Regular);
                this.label1.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Regular);
            }
        }
    }
}
