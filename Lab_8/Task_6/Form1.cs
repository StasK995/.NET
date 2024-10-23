using System;
using System.Windows.Forms;

namespace Task_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Рекурсивно додаємо обробник подій до кінцевих пунктів меню
            foreach (ToolStripMenuItem topItem in menuStrip1.Items)
            {
                AddClickEventToLeafItems(topItem);
            }
        }

        // Рекурсивно додаємо обробник до кінцевих пунктів меню
        private void AddClickEventToLeafItems(ToolStripMenuItem menuItem)
        {
            if (menuItem.DropDownItems.Count == 0) // Це кінцевий пункт меню
            {
                menuItem.Click += MenuItem_Click;
            }
            else
            {
                foreach (ToolStripMenuItem subItem in menuItem.DropDownItems)
                {
                    AddClickEventToLeafItems(subItem); // Рекурсія для підменю
                }
            }
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem)
            {
                MessageBox.Show($"Вибрано пункт меню: {menuItem.Text}");
            }
        }
    }
}
