using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Session1
{
    public partial class FormSponsor : Form
    {
        public FormSponsor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FormSponsor_Load(object sender, EventArgs e)
        {
            var data = DBHelper.FillDataSet("SELECT * FROM Racer").Tables[0];
            List<DisplayRacer> racers = new List<DisplayRacer>();
            foreach (DataRow row in data.Rows)
            {
                var d = row.ItemArray;
                racers.Add(new DisplayRacer($"{d[1]} {d[2]} - 204 (UKR)", d[0].ToString()));
            }
            comboBox1.DataSource = racers;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "name";
        }

        private class DisplayRacer
        {
            public DisplayRacer(string name, string id)
            {
                this.name = name;
                this.id = id;
            }

            public string name { get; set; }
            public string id { get; set; }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormPayed form = new FormPayed(moneyLabel.Text, comboBox1.SelectedValue.ToString());
            form.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int money = int.Parse(moneyBox.Text);
                money -= 10;
                if (money < 0) money = 0;
                moneyBox.Text = money.ToString();
                moneyLabel.Text = $"$ {money}";
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int money = int.Parse(moneyBox.Text);
                money += 10;
                moneyBox.Text = money.ToString();
                moneyLabel.Text = $"$ {money}";
            }
            catch { }
        }
    }
}
