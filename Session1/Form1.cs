using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormSponsor form = new FormSponsor();
            form.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormMenu form = new FormMenu();
            form.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FormAuth form = new FormAuth();
            form.Show();
        }
    }
}
