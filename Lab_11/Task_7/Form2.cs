using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Task_7
{
    public partial class Form2 : Form
    {
        private Form1 mainForm;

        public Form2(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                mainForm.BackColor = colorDialog.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                mainForm.label1.ForeColor = colorDialog.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (Control control in mainForm.groupBox1.Controls)
                {
                    if (control is System.Windows.Forms.Label label)
                    {
                        label.ForeColor = colorDialog.Color;
                    }
                }
            }
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                mainForm.groupBox1.BackColor = colorDialog.Color;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (Control control in mainForm.groupBox2.Controls)
                {
                    if (control is System.Windows.Forms.Label label)
                    {
                        label.ForeColor = colorDialog.Color;
                    }
                }
            }
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                mainForm.groupBox2.BackColor = colorDialog.Color;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (Control control in mainForm.groupBox3.Controls)
                {
                    if (control is System.Windows.Forms.Label label)
                    {
                        label.ForeColor = colorDialog.Color;
                    }
                }
            }
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                mainForm.groupBox3.BackColor = colorDialog.Color;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.Title = "Зберегти параметри";
            saveFileDialog.Filter = "Text Files|*.txt|All Files|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // Збір налаштувань у словник
                Dictionary<string, string> settings = new Dictionary<string, string>
                {
                    { "BackColor", mainForm.BackColor.ToArgb().ToString() },
                    { "ForeColor", mainForm.ForeColor.ToArgb().ToString() },
                    { "LabelForeColor", mainForm.label1.ForeColor.ToArgb().ToString() },
                    { "GroupBox1BackColor", mainForm.groupBox1.BackColor.ToArgb().ToString() },
                    { "GroupBox2BackColor", mainForm.groupBox2.BackColor.ToArgb().ToString() },
                    { "GroupBox3BackColor", mainForm.groupBox3.BackColor.ToArgb().ToString() },
                };

                foreach (Control control in mainForm.groupBox1.Controls)
                {
                    if (control is System.Windows.Forms.Label label)
                    {
                        settings[$"GroupBox1_{label.Name}_ForeColor"] = label.ForeColor.ToArgb().ToString();
                    }
                }
                foreach (Control control in mainForm.groupBox2.Controls)
                {
                    if (control is System.Windows.Forms.Label label)
                    {
                        settings[$"GroupBox2_{label.Name}_ForeColor"] = label.ForeColor.ToArgb().ToString();
                    }
                }
                foreach (Control control in mainForm.groupBox3.Controls)
                {
                    if (control is System.Windows.Forms.Label label)
                    {
                        settings[$"GroupBox3_{label.Name}_ForeColor"] = label.ForeColor.ToArgb().ToString();
                    }
                }

                // Запис налаштувань у текстовий файл у форматі "ключ=значення"
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var setting in settings)
                    {
                        writer.WriteLine($"{setting.Key}={setting.Value}");
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                if (filePath != null)
                {
                    string[] lines = File.ReadAllLines(filePath);
                    Dictionary<string, string> settings = new Dictionary<string, string>();

                    foreach (string line in lines)
                    {
                        var parts = line.Split('=');
                        if (parts.Length == 2)
                        {
                            settings[parts[0]] = parts[1];
                        }
                    }

                    // Обробка фону для форми
                    if (settings.ContainsKey("BackColor"))
                    {
                        Color backColor = Color.FromArgb(int.Parse(settings["BackColor"]));
                        mainForm.BackColor = backColor;
                        Console.WriteLine($"BackColor: {backColor}");
                    }

                    // Обробка кольору тексту (ForeColor) для форми
                    if (settings.ContainsKey("ForeColor"))
                    {
                        Color foreColor = Color.FromArgb(int.Parse(settings["ForeColor"]));
                        mainForm.ForeColor = foreColor;
                        Console.WriteLine($"ForeColor: {foreColor}");
                    }

                    // Обробка кольору тексту для label1
                    if (settings.ContainsKey("LabelForeColor"))
                    {
                        Color labelForeColor = Color.FromArgb(int.Parse(settings["LabelForeColor"]));
                        mainForm.label1.ForeColor = labelForeColor;
                        Console.WriteLine($"LabelForeColor: {labelForeColor}");
                    }

                    // Обробка BackColor для GroupBox1
                    if (settings.ContainsKey("GroupBox1BackColor"))
                    {
                        Color groupBox1BackColor = Color.FromArgb(int.Parse(settings["GroupBox1BackColor"]));
                        mainForm.groupBox1.BackColor = groupBox1BackColor;
                        Console.WriteLine($"GroupBox1 BackColor встановлено на: {groupBox1BackColor}");
                    }

                    // Обробка BackColor для GroupBox2
                    if (settings.ContainsKey("GroupBox2BackColor"))
                    {
                        Color groupBox2BackColor = Color.FromArgb(int.Parse(settings["GroupBox2BackColor"]));
                        mainForm.groupBox2.BackColor = groupBox2BackColor;
                        Console.WriteLine($"GroupBox2 BackColor встановлено на: {groupBox2BackColor}");
                    }

                    // Обробка BackColor для GroupBox3
                    if (settings.ContainsKey("GroupBox3BackColor"))
                    {
                        Color groupBox3BackColor = Color.FromArgb(int.Parse(settings["GroupBox3BackColor"]));
                        mainForm.groupBox3.BackColor = groupBox3BackColor;
                        Console.WriteLine($"GroupBox3 BackColor встановлено на: {groupBox3BackColor}");
                    }

                    // Обробка кольору тексту для міток у groupBox1, groupBox2, groupBox3
                    foreach (Control control in mainForm.groupBox1.Controls)
                    {
                        if (control is System.Windows.Forms.Label label && settings.ContainsKey($"GroupBox1_{label.Name}_ForeColor"))
                        {
                            label.ForeColor = Color.FromArgb(int.Parse(settings[$"GroupBox1_{label.Name}_ForeColor"]));
                        }
                    }
                    foreach (Control control in mainForm.groupBox2.Controls)
                    {
                        if (control is System.Windows.Forms.Label label && settings.ContainsKey($"GroupBox2_{label.Name}_ForeColor"))
                        {
                            label.ForeColor = Color.FromArgb(int.Parse(settings[$"GroupBox2_{label.Name}_ForeColor"]));
                        }
                    }
                    foreach (Control control in mainForm.groupBox3.Controls)
                    {
                        if (control is System.Windows.Forms.Label label && settings.ContainsKey($"GroupBox3_{label.Name}_ForeColor"))
                        {
                            label.ForeColor = Color.FromArgb(int.Parse(settings[$"GroupBox3_{label.Name}_ForeColor"]));
                        }
                    }
                }
            }
        }

    }
}
