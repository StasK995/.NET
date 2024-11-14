using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            NotifyIcon notifyIcon = new NotifyIcon();
            notifyIcon.Icon = SystemIcons.Application;
            notifyIcon.Text = "My Form";
            notifyIcon.Visible = true;
            var contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("Show",null, ShowForm);
            contextMenu.Items.Add("Hide", null, HideForm);
            notifyIcon.ContextMenuStrip = contextMenu;

            InitializeComponent();
            textBox1.TextChanged += TextBox1_TextChanged;

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBox1.Text))
            {

                string Data = DateTime.Now.ToString("dd.MM.yyyy");


                toolStripStatusLabel1.Text = Data;
                toolStripStatusLabel2.Text = textBox1.Text;
            }
            else
            {

                toolStripStatusLabel2.Text = string.Empty;
                toolStripStatusLabel1.Text = string.Empty;
            }
        }
        private void ShowForm(object sender, EventArgs e)
        {
            this.Show();
        }

        private void HideForm(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
