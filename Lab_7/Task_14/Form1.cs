using System;
using System.Windows.Forms;

namespace Task_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.Load += new EventHandler(Form1_Load); // Прив'язка до події Load
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            // Запит 
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете продовжити?",
                                                   "Підтвердження",
                                                   MessageBoxButtons.YesNo);

            
            if (result == DialogResult.No)
            {
                this.Close(); 
            }
            
        }
    }
}
