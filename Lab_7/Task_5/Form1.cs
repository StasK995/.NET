using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button3.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            button1.Click += Button_Click;
            button2.Click += Button_Click;
            button3.Click += Button_Click;
        }
        public void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button; 
            if (clickedButton != null)
            {
                MessageBox.Show($"Ви натиснули: {clickedButton.Text}");
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Location = new Point(button1.Location.X, button1.Location.Y - 20);
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Location = new Point(button1.Location.X, button1.Location.Y + 20);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.Location = new Point(button2.Location.X, button2.Location.Y - 20);
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Location = new Point(button2.Location.X, button2.Location.Y + 20);
        }
        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.Location = new Point(button3.Location.X, button3.Location.Y - 20);
        }
        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Location = new Point(button3.Location.X, button3.Location.Y + 20);
        }
    }
}
