using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
            InitializeListBox();

        }
        public void InitializeComboBox()
        {
            string[] city = { "Бухарест", "Клуж-Напока", "Тімішоара", "Ясси", "Брашов", "Сібіу" };
            ComboBox comboBox = new ComboBox()
            {
                Location = new Point(30, 30),
                Size = new Size(200, 30),

            };
            comboBox.Items.AddRange(city); 
            this.Controls.Add(comboBox); 
        }
        public void InitializeListBox()
        {
            string[] city = { "Бухарест", "Клуж-Напока", "Тімішоара", "Ясси", "Брашов", "Сібіу" };
            ListBox listBox = new ListBox()
            {
                Location = new Point(260, 30),
                Size = new Size(200, 100),
            };
            listBox.Items.AddRange(city);
            this.Controls.Add(listBox);

        }
    }
}
