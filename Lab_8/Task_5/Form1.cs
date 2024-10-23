using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Item11.Click += (s, e) => MessageBox.Show("Вибрано пункт меню: Item11");
            item211ToolStripMenuItem.Click += (s, e) => MessageBox.Show("Вибрано пункт меню: Item121");
            item212ToolStripMenuItem.Click += (s, e) => MessageBox.Show("Вибрано пункт меню: Item122");
            item123ToolStripMenuItem.Click += (s, e) => MessageBox.Show("Вибрано пункт меню: Item123");
            item13ToolStripMenuItem.Click += (s, e) => MessageBox.Show("Вибрано пункт меню: Item13");
            item14ToolStripMenuItem.Click += (s, e) => MessageBox.Show("Вибрано пункт меню: Item14");

            // Item2 підменю
            item211ToolStripMenuItem1.Click += (s, e) => MessageBox.Show("Вибрано пункт меню: Item211");
            item212ToolStripMenuItem1.Click += (s, e) => MessageBox.Show("Вибрано пункт меню: Item212");
            item213ToolStripMenuItem.Click += (s, e) => MessageBox.Show("Вибрано пункт меню: Item213");
            item214ToolStripMenuItem.Click += (s, e) => MessageBox.Show("Вибрано пункт меню: Item214");
            item22ToolStripMenuItem.Click += (s, e) => MessageBox.Show("Вибрано пункт меню: Item22");
            item23ToolStripMenuItem.Click += (s, e) => MessageBox.Show("Вибрано пункт меню: Item23");

            // Item3 підменю
            item31ToolStripMenuItem.Click += (s, e) => MessageBox.Show("Вибрано пункт меню: Item31");
            toolStripMenuItem2.Click += (s, e) => MessageBox.Show("Вибрано пункт меню: Item32");
            item33ToolStripMenuItem.Click += (s, e) => MessageBox.Show("Вибрано пункт меню: Item33");
            item34ToolStripMenuItem.Click += (s, e) => MessageBox.Show("Вибрано пункт меню: Item34");

            // Item4 підменю
            item41ToolStripMenuItem.Click += (s, e) => MessageBox.Show("Вибрано пункт меню: Item41");
            item42ToolStripMenuItem.Click += (s, e) => MessageBox.Show("Вибрано пункт меню: Item42");
            item43ToolStripMenuItem.Click += (s, e) => MessageBox.Show("Вибрано пункт меню: Item43");
            item411ToolStripMenuItem.Click += (s, e) => MessageBox.Show("Вибрано пункт меню: Item441");
            item412ToolStripMenuItem.Click += (s, e) => MessageBox.Show("Вибрано пункт меню: Item442");
            item443ToolStripMenuItem.Click += (s, e) => MessageBox.Show("Вибрано пункт меню: Item443");
            item444ToolStripMenuItem.Click += (s, e) => MessageBox.Show("Вибрано пункт меню: Item444");
            item445ToolStripMenuItem.Click += (s, e) => MessageBox.Show("Вибрано пункт меню: Item445");
            item45ToolStripMenuItem.Click += (s, e) => MessageBox.Show("Вибрано пункт меню: Item45");

            // Item5 підменю
            item51ToolStripMenuItem.Click += (s, e) => MessageBox.Show("Вибрано пункт меню: Item51");
            item52ToolStripMenuItem.Click += (s, e) => MessageBox.Show("Вибрано пункт меню: Item52");
            item53ToolStripMenuItem.Click += (s, e) => MessageBox.Show("Вибрано пункт меню: Item53");
            item54ToolStripMenuItem.Click += (s, e) => MessageBox.Show("Вибрано пункт меню: Item54");
            item55ToolStripMenuItem.Click += (s, e) => MessageBox.Show("Вибрано пункт меню: Item55");
            item561ToolStripMenuItem.Click += (s, e) => MessageBox.Show("Вибрано пункт меню: Item561");
            item562ToolStripMenuItem.Click += (s, e) => MessageBox.Show("Вибрано пункт меню: Item562");
            item563ToolStripMenuItem.Click += (s, e) => MessageBox.Show("Вибрано пункт меню: Item563");
            item57ToolStripMenuItem.Click += (s, e) => MessageBox.Show("Вибрано пункт меню: Item57");

        }



    }
}