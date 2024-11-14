using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_4
{
    public partial class Form1 : Form
    {
        private ListView listView1;

        public Form1()
        {
            InitializeComponent();
            InitializeList();

            
            button1.Click += Calculate;
        }

        public void InitializeList()
        {
            listView1 = new ListView
            {
                Location = new Point(51, 289),
                Size = new Size(445, 218),
                FullRowSelect = true,
                GridLines = true,
                HideSelection = false,
                View = View.Details 
            };

            
            listView1.Columns.Add("Місяць", 70);
            listView1.Columns.Add("Борг", 150);
            listView1.Columns.Add("Відсоток", 150);
            listView1.Columns.Add("Платіж", 150);

            
            this.Controls.Add(listView1);
        }

        private void Calculate(object sender, EventArgs e)
        {
            try
            {
                
                if (!double.TryParse(textBox1.Text, out double amount) || amount <= 0)
                {
                    MessageBox.Show("Введіть коректну суму кредиту.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(textBox2.Text, out int term) || term <= 0)
                {
                    MessageBox.Show("Введіть коректний термін у місяцях.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!double.TryParse(textBox3.Text, out double annualRate) || annualRate < 0)
                {
                    MessageBox.Show("Введіть коректну річну процентну ставку.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                double monthlyRate = annualRate / 12 / 100;
                double monthlyPayment = amount * (monthlyRate * Math.Pow(1 + monthlyRate, term))
                                       / (Math.Pow(1 + monthlyRate, term) - 1);

                
                listView1.Items.Clear();
                double remainingBalance = amount;

                
                for (int month = 1; month <= term; month++)
                {
                    double interest = remainingBalance * monthlyRate;
                    double principal = monthlyPayment - interest;
                    remainingBalance -= principal;

                    
                    ListViewItem item = new ListViewItem(month.ToString());
                    item.SubItems.Add(remainingBalance.ToString("N2"));
                    item.SubItems.Add(interest.ToString("N2"));
                    item.SubItems.Add(monthlyPayment.ToString("N2"));
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при розрахунках: " + ex.Message,
                                "Помилка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
