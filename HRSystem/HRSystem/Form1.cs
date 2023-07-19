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

namespace HRSystem
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-SMHOER59\\SQLEXPRESS;Initial Catalog=hrproject;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM admintable WHERE [username] = @username and [password] = @password", con);
            cmd.Parameters.AddWithValue("@username", textBox1.Text);
            cmd.Parameters.AddWithValue("@password", textBox2.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count>0)
            {
                MessageBox.Show("Logged in Successfully");
                this.Hide();
                Form frm1 = new Form2();
                frm1.Show();
            }
            else
            {
                MessageBox.Show("Incorrect username or password");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
