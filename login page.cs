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
using System.Data.OleDb;
using System.Data.Sql;
using System.Net.Mail;
using System.Net;

namespace hike
{
    public partial class loginform : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public loginform()
        {
            InitializeComponent();
            con.ConnectionString= @"Data Source=ANIMAL-LOVER;Initial Catalog=userreg;Integrated Security=True";
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void Register_Click(object sender, EventArgs e)
        {
            this.Hide();

            registration Program = new registration();
            Program.Show();
            
        }


        public void Loginbutton_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=ANIMAL-LOVER;Initial Catalog=userreg;Integrated Security=True";
            con.Open();
           
           
            string username = logusername.Text;
            string password = logpassword.Text;
            SqlCommand cmd = new SqlCommand("select username,password from register where username='" + logusername.Text + "'and password='" + logpassword.Text + "'", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (string.IsNullOrEmpty(logusername.Text) && string.IsNullOrEmpty(logpassword.Text))
            {
                MessageBox.Show("please enter the details");
            }
            else if (dt.Rows.Count > 0)
            {
                accessusername.Username = dt.Rows[0]["username"].ToString();
                MessageBox.Show("Login sucess Welcome to Homepage");
                this.Close();
                Dashboard program = new Dashboard();
                program.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            con.Close();
            

        }
          
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void logpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                logpassword.UseSystemPasswordChar = false;
            }
            else
            {
                logpassword.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void forgot_Click(object sender, EventArgs e)
        {
            this.Hide();
            forgotpass forgot = new forgotpass();
            forgot.Show();
        }

        private void logusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
