using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            
            var selectedItem = listBox1.SelectedItem.ToString();
            MessageBox.Show("Місто: " + selectedItem.ToString());
            Form2 form2 = new Form2(selectedItem);
            form2.ShowDialog();

            

            
        }
    }
}
