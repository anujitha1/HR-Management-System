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
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-SMHOER59\\SQLEXPRESS;Initial Catalog=hrproject;Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (employeeId.Text == "" || employeenamelb.Text == "" || emppnumber.Text == "" || address.Text == "" || empgendercombo.Text == "" || emppositioncombo.Text == "" || empjoineddate.Text == "" || empsalary.Text == "")
                {
                    MessageBox.Show("Missing fields");

                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO employeetable (empid,empname,empdob,empaddress,empphone,empgender,empposition,joineddate,salary)VALUES('" + employeeId.Text + "','" + employeenamelb.Text + "','" + dateTimePicker1.Text + "','" + address.Text + "','" + emppnumber.Text + "','" + empgendercombo.SelectedItem.ToString() + "','" + emppositioncombo.SelectedItem.ToString() + "','" + dateTimePicker2.Text + "', '" + empsalary.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data inserted");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (employeeId.Text == "")
                {
                    MessageBox.Show("Please enter the employee id");
                }
                else
                {
                    con.Open();
                    string query = "DELETE FROM employeetable WHERE empid='" + employeeId.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted");
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (employeeId.Text == "" || employeenamelb.Text == "" || dateTimePicker1.Text == "" || address.Text == "" || emppnumber.Text == "" || empgendercombo.Text == "" || emppositioncombo.Text == "" || dateTimePicker2.Text == "" || empsalary.Text == "")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    con.Open();
                    string query = "UPDATE employeetable SET empname='" + employeenamelb.Text + "', empdob='" + dateTimePicker1.Text + "', empaddress='" + address.Text + "', empphone='" + emppnumber.Text + "', empgender='" + empgendercombo.SelectedItem.ToString() + "', empposition='" + emppositioncombo.SelectedItem.ToString() + "', joineddate='" + dateTimePicker2.Text + "', salary='" + empsalary.Text + "' WHERE empid= '" + employeeId.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee edited");
                    con.Close();
                 
                }
            }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void label2_Click(object sender, EventArgs e)
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

        private void homebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm5 = new Form6();
            frm5.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
