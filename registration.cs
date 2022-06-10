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


namespace hike
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Regsignup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Regemail.Text) || string.IsNullOrWhiteSpace(Regname.Text) || string.IsNullOrWhiteSpace(Regpass.Text) || string.IsNullOrWhiteSpace(Regusername.Text))
            {
                MessageBox.Show("please enter the all the details");
            }
            else
            if (!usernamecheck())
            {
                SqlConnection con = new SqlConnection("Data Source=ANIMAL-LOVER;Initial Catalog=userreg;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[register]
           ([name]
           ,[email]
           ,[username]
           ,[password])
     VALUES
           ('" + Regname.Text + "', '" + Regemail.Text + "','" + Regusername.Text + "','" + Regpass.Text + "')", con);
                con.Open();

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Register successfull");






                this.Close();
                var Program = new loginform();
                Program.Show();
            }
            
           
        }
        public bool usernamecheck()
        {
            string constring = "Data Source=ANIMAL-LOVER;Initial Catalog=userreg;Integrated Security=True";
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand("select count(*) from register where username = @Regusername", con);
            cmd.Parameters.AddWithValue("@Regusername", this.Regusername.Text);
            con.Open();
            int TotalRows = 0;
            TotalRows = Convert.ToInt32(cmd.ExecuteScalar());
            if (TotalRows > 0)
            {
                MessageBox.Show("username Already exist");
                return true;
            }
            else
            {
                return false;
            }
        }
            private void Regsignin_Click(object sender, EventArgs e)
        {
            this.Close();
            loginform Program = new loginform();
            Program.Show();
        }

        private void Regemail_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void Regrpass_TextChanged(object sender, EventArgs e)
        {
        }

        private void registration_Load(object sender, EventArgs e)
        {
            Regname.Select();
        }
    }
}
