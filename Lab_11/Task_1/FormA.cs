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
    public partial class FormA : Form
    {

        Thread th;
        public FormA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
            th = new Thread(OpenFormB);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        public void OpenFormB()
        {
            FormB formB = new FormB();
            formB.ShowDialog();
        }

        public void OpenFormC()
        {
            FormC formС = new FormC();
            formС.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenFormC);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
