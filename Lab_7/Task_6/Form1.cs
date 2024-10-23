using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button_Click;
            button2.Click += Button_Click;
            button3.Click += Button_Click;

            button1.MouseEnter += Button_MouseEnter;
            button1.MouseLeave += Button_MouseLeave;

            button2.MouseEnter += Button_MouseEnter;
            button2.MouseLeave += Button_MouseLeave;

            button3.MouseEnter += Button_MouseEnter;
            button3.MouseLeave += Button_MouseLeave;
        }

        public void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                MessageBox.Show($"Натиснули: {clickedButton.Text}");
            }
        }
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.Location = new Point(button.Location.X, button.Location.Y - 20);
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.Location = new Point(button.Location.X, button.Location.Y + 20);
            }
        }
    }
}
