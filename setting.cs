using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace hike
{
    public partial class setting : Form
    {
        public setting()
        {
            InitializeComponent();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            
            Dashboard.counter = 0;

           
            
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void setting_Load(object sender, EventArgs e)
        {
            username.Text = accessusername.Username;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=ANIMAL-LOVER;Initial Catalog=userreg;Integrated Security=True";
            SqlCommand cmd = new SqlCommand("Select username,password,name,phone,gender,email from register where username =@username", con);
            cmd.Parameters.AddWithValue("@username", username.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                username.Text = dr.GetValue(0).ToString();
                password.Text = dr.GetValue(1).ToString();
                name.Text = dr.GetValue(2).ToString();
                phone.Text = dr.GetValue(3).ToString();
                gender.Text = dr.GetValue(4).ToString();
                email.Text = dr.GetValue(5).ToString();
            }
            con.Close();
            settingname.Select();


        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            username.Text = accessusername.Username;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=ANIMAL-LOVER;Initial Catalog=userreg;Integrated Security=True";
            SqlCommand cmd = new SqlCommand("update register set name=@name,phone=@phone,gender=@gender,email=@email,password=@password where username=@username", con);
            cmd.Parameters.AddWithValue("@username", username.Text);
            con.Open();
            
            cmd.Parameters.AddWithValue("@name", name.Text);
            if (string.IsNullOrWhiteSpace(phone.Text))
            {
                cmd.Parameters.AddWithValue("@phone", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@phone", phone.Text);
            }
            cmd.Parameters.AddWithValue("@gender", gender.Text);
            cmd.Parameters.AddWithValue("@email", email.Text);
            cmd.Parameters.AddWithValue("@password", password.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("The details are updated");
            con.Close();
        }

        private void deleteacc_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=ANIMAL-LOVER;Initial Catalog=userreg;Integrated Security=True";
            SqlCommand cmd = new SqlCommand("delete register  where username=@username", con);
            cmd.Parameters.AddWithValue("@username", username.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("The acccount was deleted !!!");
            con.Close();
            this.Close();
            Application.Exit();
           
        }
    }
}
