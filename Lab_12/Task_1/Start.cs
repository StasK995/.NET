using System;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            this.Hide(); 
            authorization.ShowDialog(); 
            this.Close(); 
        }
    }
}
