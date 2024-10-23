using System;
using System.Windows.Forms;

namespace Task_11
{
    public partial class Form1 : Form
    {

        private bool isMinimized = false;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (isMinimized)
            {
                this.WindowState = FormWindowState.Normal; 
            }
            else
            {
                this.WindowState = FormWindowState.Minimized; 
            }

            isMinimized = !isMinimized;
        }
    }
}
