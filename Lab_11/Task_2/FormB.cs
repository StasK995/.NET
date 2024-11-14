using System;
using System.Threading;
using System.Windows.Forms;

namespace Task_2
{
    public partial class FormB : Form
    {
        Thread th;
        private string savedText;

        public FormB(string data)
        {
            InitializeComponent(); 

            
            label2.Text = data;
            MessageBox.Show("Переданий текст: " + data);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            savedText = textBox1.Text;
            this.Close();
            th = new Thread(OpenFormC);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        public void OpenFormC()
        {
            Application.Run(new FormD(savedText));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            savedText = textBox1.Text;
            this.Close();
            th = new Thread(OpenFormE);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        public void OpenFormE()
        {
            Application.Run(new FormE(savedText));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            savedText = textBox1.Text;
            this.Close();
            th = new Thread(OpenFormF);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        public void OpenFormF()
        {
            Form FormF = new Form();
            FormF.Text = "FormF";
            FormF.AutoSize = true;

            Label label1 = new Label();
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(340, 209);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(121, 33);
            label1.TabIndex = 3;
            label1.Text = "Form_F";

            FormF.Controls.Add(label1);
            Label label2 = new Label();
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(340, 300);
            label2.Name = "label1";
            label2.Size = new System.Drawing.Size(121, 33);
            label2.TabIndex = 3;
            label2.Text = savedText;

            FormF.Controls.Add(label2);
            Application.Run(FormF);
        }
    }
}
