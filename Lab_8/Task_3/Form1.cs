using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form1 : Form
    {
        private int[] initialPositionsGroup1;
        private bool[] initialCheckedStatesGroup1;
        public Form1()
        {
            InitializeComponent();
            SaveInitialPositions();
        }

        private void SaveInitialPositions()
        {
            initialPositionsGroup1 = new int[this.groupBox1.Controls.Count];
            initialCheckedStatesGroup1 = new bool[this.groupBox1.Controls.Count]; 

            int index = 0;
            foreach (Control control in this.groupBox1.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    initialPositionsGroup1[index] = control.Location.X;  //X
                    initialCheckedStatesGroup1[index] = checkBox.Checked; //  Checked
                    index++;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.groupBox1.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    control.Location = new Point(control.Location.X - 10, control.Location.Y);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RestoreInitialPositions(this.groupBox1, initialPositionsGroup1, initialCheckedStatesGroup1);
        }
        private void RestoreInitialPositions(GroupBox groupBox, int[] initialPositions, bool[] initialCheckedStates)
        {
            int index = 0;
            foreach (Control control in groupBox.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    // 
                    control.Location = new Point(initialPositions[index], control.Location.Y);
                    //  Checked
                    checkBox.Checked = initialCheckedStates[index];
                    index++;
                }
            }
        }

    }
}
