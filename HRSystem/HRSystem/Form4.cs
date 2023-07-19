using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HRSystem
{
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-SMHOER59\\SQLEXPRESS;Initial Catalog=hrproject;Integrated Security=True");
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM employeetable WHERE empid=@empid", con);
                cmd.Parameters.AddWithValue("@empid", employeeId.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Click ok to see the results");
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();

                        textname.Text = sdr["empname"].ToString();
                        textbirth.Text = sdr["empdob"].ToString();
                        textaddress.Text = sdr["empaddress"].ToString();
                        textphone.Text = sdr["empphone"].ToString();
                        textgender.Text = sdr["empgender"].ToString();
                        textposition.Text = sdr["empposition"].ToString();
                        textjoineddate.Text = sdr["joineddate"].ToString();
                        textsalary.Text = sdr["salary"].ToString();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm1 = new Form2();
            frm1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm1 = new Form2();
            frm1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm2 = new Form3();
            frm2.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm2 = new Form3();
            frm2.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm3 = new Form4();
            frm3.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm3 = new Form4();
            frm3.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {
            employeeId.Clear();
            textname.Clear();
            textbirth.Clear();
            textaddress.Clear();
            textphone.Clear();
            textposition.Clear();
            textgender.Clear();
            textjoineddate.Clear();
            textsalary.Clear();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
