using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRSystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm1 = new Form3();
            frm1.Show();
        }
        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm1 = new Form3();
            frm1.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form login = new Form1();
            login.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm2 = new Form4();
            frm2.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm2 = new Form4();
            frm2.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm3 = new Form5();
            frm3.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm3 = new Form5();
            frm3.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form login = new Form1();
            login.Show();
        }
    }
}
