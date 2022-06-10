using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Sql;

namespace hike
{
    public partial class contactus : UserControl
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public contactus()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=ANIMAL-LOVER;Initial Catalog=userreg;Integrated Security=True";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mailid_TextChanged(object sender, EventArgs e)
        {

        }

        private void message_TextChanged(object sender, EventArgs e)
        {

        }

        private void send_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ANIMAL-LOVER;Initial Catalog=userreg;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[feedback]
           ([mailid]
            ,[message])
     VALUES
           ('" + mailid.Text + "', '" + message.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            if(string.IsNullOrEmpty(mailid.Text) && string.IsNullOrEmpty(message.Text))
            {
                MessageBox.Show("please enter the details");
            }
            else if(string.IsNullOrEmpty(message.Text))
            {
                MessageBox.Show("please feed some message");
            }
            else if(string.IsNullOrEmpty(mailid.Text))
            {
                MessageBox.Show("please enter mail id");
            }
            else
            MessageBox.Show("Thank you for your Feedback");
        }
    }
}
