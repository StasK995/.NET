using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeButton();
            
        }
         private void InitializeButton()
        {
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.ColumnCount = 6;
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F)); 
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F)); 

            for (int i = 0; i < 6; i++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.67F));
            }

            Button button1 = new Button { Text = "Кнопка 1" };
            tableLayoutPanel.Controls.Add(button1, 0, 0);
            button1.Dock = DockStyle.Fill;

            Button button2 = new Button { Text = "Кнопка 2" };
            tableLayoutPanel.Controls.Add(button2, 0, 2);
            button2.Dock = DockStyle.Fill;


            Button button3 = new Button { Text = "Кнопка 3" };
            tableLayoutPanel.Controls.Add(button3, 2, 1);
            button3.Dock = DockStyle.Fill;


            Button button4 = new Button { Text = "Кнопка 4" };
            tableLayoutPanel.Controls.Add(button4, 4, 0);
            button4.Dock = DockStyle.Fill;

            Button button5 = new Button { Text = "Кнопка 5" };
            tableLayoutPanel.Controls.Add(button5, 4, 1);
            button5.Dock = DockStyle.Fill;

            this.Controls.Add(tableLayoutPanel);
        }

        
    }
}
