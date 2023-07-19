using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace HRSystem
{
    public partial class Form5 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-SMHOER59\\SQLEXPRESS;Initial Catalog=hrproject;Integrated Security=True");
        public Form5()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm4 = new Form5();
            frm4.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm4 = new Form5();
            frm4.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm3 = new Form4();
            frm3.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm3 = new Form4();
            frm3.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm2 = new Form3();
            frm2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm2 = new Form3();
            frm2.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm1 = new Form2();
            frm1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm1 = new Form2();
            frm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM employeetable WHERE empid=@empid", con);
                cmd.Parameters.AddWithValue("@empid", employeeid.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Click ok to see the results");
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();

                        textsal.Text = sdr["salary"].ToString();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        double salary, etfamount, epfamount, grosssal, allow, netsal;

        private void salarycal_Click(object sender, EventArgs e)
        {
            salary = Double.Parse(textsal.Text);

            if (checketf.Checked == true)
            {
                etfamount = salary * 3 / 100;
            }
            if (checkepf.Checked == true)
            {
                epfamount = salary * 9 / 100;
            }
            textetf.Text = etfamount.ToString();
            textepf.Text = epfamount.ToString();


            if (salary >= 100000)
            {
                allow = 3500;
            }
            else if (salary >= 70000)
            {
                allow = 2500;
            }
            else if (salary >= 50000)
            {
                allow = 1700;
            }
            else if (salary >= 30000)
            {
                allow = 1000;
            }
            else
            {
                allow = 0;
            }
            grosssal = salary + etfamount + epfamount + allow;
            textgross.Text = grosssal.ToString();

            textallowance.Text = allow.ToString();
            netsal = salary - (etfamount + epfamount);
            textnet.Text = netsal.ToString();
        }
    }
}
