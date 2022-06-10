using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Sql;



namespace hike
{
    public partial class forgotpass : Form
    {
        string randomcode;
        public static string to;
        public forgotpass()
        {
            InitializeComponent();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void otpreader_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void fgtsend_Click(object sender, EventArgs e)
        {
            
              SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=ANIMAL-LOVER;Initial Catalog=userreg;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("select username from register where username='" + fgtusername.Text + "'", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
          
          



            accessusername.Username = fgtusername.Text.ToString();
            string form, pass, messagebody;
            Random rand = new Random();
            randomcode = (rand.Next(999999)).ToString();
            MailMessage mail = new MailMessage();
            to = (fgtmail.Text).ToString();
            form = "projectdeepak14@gmail.com";
            pass = "deep@k2000";
            messagebody = "your reset code is" + randomcode;
            if (!string.IsNullOrEmpty(fgtusername.Text) && !string.IsNullOrEmpty(fgtmail.Text))
            {
                if (this.fgtmail.Text.Contains('@') || this.fgtmail.Text.Contains('.'))
                {
                    mail.To.Add(to);
                }
                else
                {
                    MessageBox.Show("enter valid mail address");
                }
                if (dt.Rows.Count > 0)
                {
                    accessusername.Username = dt.Rows[0]["username"].ToString();
                    usermess.Text = "Username matched in database";

                    mail.From = new MailAddress(form);
                    mail.Body = messagebody;
                    mail.Subject = "password reseting code";
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(form, pass);
                    try
                    {
                        smtp.Send(mail);
                        otpsent.Text = "code sent successfully";

                        otpvalid.BringToFront();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        otpvalid.SendToBack();
                    }


                }
                else
                {
                    usermess.Text = "username not matched";
                    otpvalid.SendToBack();
                }
            }
           
          
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void forgotpass_Load(object sender, EventArgs e)
        {
           
        }

        private void otpverify_Click(object sender, EventArgs e)
        {
            if (randomcode == (otpreader.Text).ToString())
            {

                to = fgtusername.Text;
                change_password pass = new change_password();
                this.Hide();
                pass.Show();
            }
            else
            {
                MessageBox.Show("wrond code!!!");
            }
        }

        private void fgtmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void fgtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
