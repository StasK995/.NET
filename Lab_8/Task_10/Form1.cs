using System;
using System.Windows.Forms;

namespace Task_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Подписываем обработчик для всех ToolStripButtons
            toolStripButton6.Click += ToolStripButton_Click;
            toolStripButton7.Click += ToolStripButton_Click;
            toolStripButton8.Click += ToolStripButton_Click;
            toolStripButton9.Click += ToolStripButton_Click;
            toolStripButton10.Click += ToolStripButton_Click;
        }

        private void ToolStripButton_Click(object sender, EventArgs e)
        {

            ToolStripButton button = (ToolStripButton)sender;


            string text = button.ToolTipText;
            MessageBox.Show(text);
        }

    }
}
