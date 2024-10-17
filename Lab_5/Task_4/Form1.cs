using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initializeTextBox();
        }
        private void initializeTextBox()
        {
            TextBox Box1 = new TextBox
            {
                Location = new Point(10, 10),
                Width = 200,
                Font = new Font("Arial", 10, FontStyle.Italic), 
                ForeColor = Color.Brown,
                BackColor = Color.Yellow,
                TextAlign = HorizontalAlignment.Center,
            };
            this.Controls.Add(Box1);

            TextBox Box2 = new TextBox
            {
                Location = new Point(10, 40),
                Width = 200,
                Font = new Font("Arial", 20, FontStyle.Underline),
                ForeColor = Color.Pink,
                BackColor = Color.Blue,
                TextAlign = HorizontalAlignment.Right,
            };
            this.Controls.Add(Box2);

            TextBox Box3 = new TextBox
            {
                Location = new Point(10, 80),
                Width = 200,
                Font = new Font("Arial", 13, FontStyle.Bold),
                ForeColor = Color.Violet,
                BackColor = Color.Red,
                TextAlign = HorizontalAlignment.Center,
            };
            this.Controls.Add(Box3);
        }
    }
}
