using System;
using System.Threading;
using System.Windows.Forms;

namespace Task_2
{
    public partial class FormA : Form
    {
        private string savedText;
        Thread th;

        public FormA()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            savedText = textBox1.Text;

            
            this.Close();

            
            th = new Thread(OpenFormB);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        
        public void OpenFormB()
        {
            FormB formB = new FormB(savedText); 
            formB.ShowDialog();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            savedText = textBox1.Text;
            // Закрытие текущей формы
            this.Close();

            
            th = new Thread(OpenFormC);
            th.SetApartmentState(ApartmentState.STA); 
            th.Start();
        }

        
        public void OpenFormC()
        {
            
            FormC formC = new FormC(savedText);
            formC.ShowDialog();  
        }
    }
}
