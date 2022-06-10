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
    public partial class change_password : Form
    {
        public change_password()
        {
            InitializeComponent();
        }

        private void fgtupdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fgtconfirm.Text) && !string.IsNullOrEmpty(fgtpass.Text))
            {

                if (fgtpass.Text == fgtconfirm.Text)
                {
                    usertxt.Text = accessusername.Username;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=ANIMAL-LOVER;Initial Catalog=userreg;Integrated Security=True";
                    SqlCommand cmd = new SqlCommand("UPDATE [dbo].[register] SET[password]  ='" + fgtconfirm.Text + "' where username='" + usertxt.Text + "'", con);

                    con.Open();



                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The details are updated");
                    con.Close();
                    loginform login = new loginform();
                    this.Close();
                    login.Show();

                }
                else
                {
                    MessageBox.Show("password mismatch");
                }
            }
            else
            {
                MessageBox.Show("enter password");
            }
        }

        private void fgtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void change_password_Load(object sender, EventArgs e)
        {
            usertxt.Text = accessusername.Username;
        }
    }
}
