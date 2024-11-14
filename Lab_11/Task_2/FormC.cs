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
    public partial class FormC : Form
    {
        public FormC(string data)
        {
            InitializeComponent();
            label2.Text = data;
        }
    }
}
