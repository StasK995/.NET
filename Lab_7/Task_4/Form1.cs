﻿using System;
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

        }

        private void DoubleClick(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label == label1)
            {
               label.Location = new Point(label.Location.X, label.Location.Y - 2);
            }
            else if (label == label2)
            {
                label.Location = new Point(label.Location.X, label.Location.Y - 2);
            }
            else if (label == label3)
            {
                label.Location = new Point(label.Location.X, label.Location.Y - 2);
            }
        }
    }
}