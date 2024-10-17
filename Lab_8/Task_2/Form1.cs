using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_2
{
    public partial class Form1 : Form
    {
        private int[] initialPositionsGroup1;
        private int[] initialPositionsGroup2;

        public Form1()
        {
            InitializeComponent();
  
            SaveInitialPositions(); // Зберігаємо початкові позиції під час ініціалізації форми
        }

        private void SaveInitialPositions()
        {

            initialPositionsGroup1 = new int[this.groupBox1.Controls.Count];
            initialPositionsGroup2 = new int[this.groupBox2.Controls.Count];

            int index = 0;
            foreach (Control control in this.groupBox1.Controls)
            {
                if (control is RadioButton)
                {
                    initialPositionsGroup1[index++] = control.Location.X; //Зберігаємо початкову позицію щодо X
                }
            }

            index = 0;
            foreach (Control control in this.groupBox2.Controls)
            {
                if (control is RadioButton)
                {
                    initialPositionsGroup2[index++] = control.Location.X; //Зберігаємо початкову позицію щодо X
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.groupBox1.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    control.Location = new Point(control.Location.X - 10, control.Location.Y);
                }
            }
            foreach (Control control in this.groupBox2.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    control.Location = new Point(control.Location.X - 10, control.Location.Y);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RestoreInitialPositions(this.groupBox1, initialPositionsGroup1);
            RestoreInitialPositions(this.groupBox2, initialPositionsGroup2);
            radioButton3.Checked = true;
            radioButton7.Checked = true;

        }

        // Метод відновлення початкових позицій радіокнопок
        private void RestoreInitialPositions(GroupBox groupBox, int[] initialPositions)
        {
            int index = 0;
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton)
                {
                    control.Location = new Point(initialPositions[index++], control.Location.Y); // Метод відновлення початкових позицій 
                }
            }
        }
    }
}
