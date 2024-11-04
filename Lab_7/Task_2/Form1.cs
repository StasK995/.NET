using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_2
{
    public partial class Form1 : Form
    {
        private Label label1;

        public Form1()
        {
            InitializeComponent();

            
            button1.Click += Button_Click;
            button2.Click += Button_Click;
            button3.Click += Button_Click;
        }

       
        private void Button_Click(object sender, EventArgs e)
        {
            
            InitializeLabel();

            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                
                InitializeLabel();
            }
        }

        
        public void InitializeLabel()
        {
            
            if (label1 == null)
            {
               
                label1 = new Label()
                {
                    Location = new Point(50, 400),
                    Font = new Font("Arial", 20, FontStyle.Regular),
                    AutoSize = true,
                    ForeColor = Color.Red,
                    Text = "Кнопка была нажата"
                };
                this.Controls.Add(label1);
            }
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            
            if (label1 != null)
            {
                this.Controls.Remove(label1);
                label1.Dispose();
                label1 = null;
            }
        }
    }
}
