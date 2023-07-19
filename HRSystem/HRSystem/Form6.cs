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

namespace HRSystem
{
    public partial class Form6 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-SMHOER59\\SQLEXPRESS;Initial Catalog=hrproject;Integrated Security=True");
        public Form6()
        {
            InitializeComponent();
        }

        private void populate()
        {
            con.Open();
            string query = "SELECT * FROM employeetable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm1 = new Form3();
            frm1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
