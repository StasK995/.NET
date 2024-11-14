using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Task_1
{
    public partial class FormB : Form
    {
        Thread th;
        public FormB()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenFormC);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        public void OpenFormC()
        {
            Application.Run(new FormC());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();
            th = new Thread(OpenFormD);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void OpenFormD()
        {
            Application.Run(new FormD());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenFormF);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void OpenFormF()
            {
                
                Form FormF = new Form();

                
                Label label1 = new Label();
                label1.AutoSize = true;
                label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                label1.Location = new System.Drawing.Point(340, 209);
                label1.Name = "label1";
                label1.Size = new System.Drawing.Size(121, 33);
                label1.TabIndex = 3;
                label1.Text = "Form_F";

                
                FormF.Controls.Add(label1);

                
                Application.Run(FormF);
            }

        }
    }


