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
using System.Net.Mail;
using System.Net;

namespace hike
{
    public partial class alltrips : UserControl
    {

        string randomcode;
        public static string to;
        public alltrips()
        {
            InitializeComponent();
           
            
        }
       

        private void alltrips_Load(object sender, EventArgs e)
        {
            Dashboard das = new Dashboard();
            
            switch (accessusername.city)
            {
                case 1:
                    city();
                    break;
                case 2:
                    city();
                    break;
                case 3:
                    city(); break;
                case 4:
                    city();
                    break;
                case 5:
                    city();
                    break;
                case 6:
                    city();
                    break;
                case 7:city();
                    break;
                case 8:
                    city();
                    break;

                default:
                    string ConnectionString = @"Data Source=ANIMAL-LOVER;Initial Catalog=userreg;Integrated Security=True";
                    using (SqlConnection sqlcon = new SqlConnection(ConnectionString))
                    {
                        sqlcon.Open();
                        SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM Package", sqlcon);
                        DataTable dtbl = new DataTable();
                        sqlda.Fill(dtbl);
                        guna2DataGridView1.DataSource = dtbl;
                    }
                    break;
            }
        }

        void city()
        {
            string ConnectionString = @"Data Source=ANIMAL-LOVER;Initial Catalog=userreg;Integrated Security=True";
            using (SqlConnection sqlcon = new SqlConnection(ConnectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM Package where Destination='"+accessusername.cityname+"'", sqlcon);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                guna2DataGridView1.DataSource = dtbl;
            }
        }

        public void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                
                
                ID.Text = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                Source.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                Destination.Text = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                days.Text = guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
              
                Seatsaval.Text = guna2DataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                amt.Text ="Amount per person Rs:"+ guna2DataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                nonamt.Text = guna2DataGridView1.SelectedRows[0].Cells[5].Value.ToString(); ;
               
                DataGridViewRow row = this.guna2DataGridView1.Rows[e.RowIndex];
                if(row.Cells[4].Value !=null)
                {
                    DateTime date = (DateTime)row.Cells[4].Value;
                    ddate.Text = date.ToShortDateString();
                }

                 SqlConnection con = new SqlConnection();
                 con.ConnectionString = "Data Source=ANIMAL-LOVER;Initial Catalog=userreg;Integrated Security=True";
                 SqlCommand cm = new SqlCommand("Select max(bookingid) from finalbooks", con);

                 con.Open();
                 SqlDataReader dr = cm.ExecuteReader();
                 if (dr.Read())
                 {
                     bookingid.Text = dr.GetValue(0).ToString();
                 }

                
                 
                int bookingnum = 0;
              bookingnum = Convert.ToInt32(bookingid.Text) + 1;
                bookingid.Text = bookingnum.ToString();
               con.Close();
            }
        }
        
        private void Searchbox_TextChanged(object sender, EventArgs e)
        {
           
            string ConnectionString = @"Data Source=ANIMAL-LOVER;Initial Catalog=userreg;Integrated Security=True";
            using (SqlConnection sqlcon = new SqlConnection(ConnectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM Package where Destination= '" + Searchbox.Text + "'", sqlcon);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                guna2DataGridView1.DataSource = dtbl;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Seatsaval_TextChanged(object sender, EventArgs e)
        {

        }

        private void Source_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirm_Click(object sender, EventArgs e)
        {
            int bookingnum;
            if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(phone.Text) || string.IsNullOrWhiteSpace(numberofpeople.Text))
            {
                MessageBox.Show("please enter the all the details");
            }
            else
            {
                string form, pass, messagebody;
                Random rand = new Random();
                randomcode = (bookingid).ToString();
                MailMessage mail = new MailMessage();
                to = (phone.Text).ToString();
                form = "projectdeepak14@gmail.com";
                pass = "deep@k2000";
                messagebody = " Your Booking ID is " + bookingid.Text+"\n Your Package ID is " + ID.Text+"\n Total Amount to be paid "+ total.Text;
                
                if (this.phone.Text.Contains('@') && this.phone.Text.Contains('.'))
                {
                    mail.To.Add(to);
                    SqlConnection con = new SqlConnection("Data Source=ANIMAL-LOVER;Initial Catalog=userreg;Integrated Security=True");
                    /* SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Bookings]
                ([bookingid]
                ,[packageid]
                ,[Name]
                ,[peoples]
                ,[phone]
                ,[Tamt]
                ,[Source]
                ,[Destination]
                ,[date]
                ,[days])
          VALUES
                ('" + bookingid.Text + "', '" + ID.Text + "','" + name.Text + "','" + numberofpeople.Text + "','" + phone.Text + "','" + total.Text + "','" + Source.Text + "','" + Destination.Text + "','" + days.Text + "')", con);*/
                    SqlCommand cmd = new SqlCommand("insert into finalbooks values(@bookingid,@packageid,@Name,@peoples,@phone,@Tamt,@Source,@Destination,@date,@days)", con);
                    cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = ddate.Text;
                    cmd.Parameters.AddWithValue("bookingid", bookingid.Text);
                    cmd.Parameters.AddWithValue("packageid", ID.Text);
                    cmd.Parameters.AddWithValue("Name", name.Text);
                    cmd.Parameters.AddWithValue("peoples", numberofpeople.Text);
                    cmd.Parameters.AddWithValue("phone", phone.Text);
                    cmd.Parameters.AddWithValue("Tamt", total.Text);
                    cmd.Parameters.AddWithValue("Source", Source.Text);
                    cmd.Parameters.AddWithValue("Destination", Destination.Text);
                    cmd.Parameters.AddWithValue("days", days.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    con.Close();
                    sss.Text = (Convert.ToInt32(Seatsaval.Text) - Convert.ToInt32(numberofpeople.Text)).ToString();
                    cmd = new SqlCommand("update Package set Seats=@Seats where id='" + ID.Text + "' ", con);
                    cmd.Parameters.AddWithValue("@Seats", sss.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();


                    con.ConnectionString = "Data Source=ANIMAL-LOVER;Initial Catalog=userreg;Integrated Security=True";
                    SqlCommand cm = new SqlCommand("Select max(bookingid) from finalbooks", con);

                    con.Open();
                    SqlDataReader dr = cm.ExecuteReader();
                    if (dr.Read())
                    {
                        bookingid.Text = dr.GetValue(0).ToString();
                    }


                    bookingnum = Convert.ToInt32(bookingid.Text) + 1;
                    con.Close();

                    /* string ConnectionString = @"Data Source=ANIMAL-LOVER;Initial Catalog=userreg;Integrated Security=True";
                     using (SqlConnection sqlcon = new SqlConnection(ConnectionString))
                     {
                         sqlcon.Open();
                         SqlDataAdapter sqlda = new SqlDataAdapter("UPDATE [dbo].[Package] SET[Seats]= availseat where id=packageid ", sqlcon);

                     }*/
                    MessageBox.Show("Your Booking is accepted");

                }
                else
                {
                    MessageBox.Show("enter valid mail address");
                }
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
                    MessageBox.Show("Please check your mail");
                    this.Hide();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                
                
                
               
            }
        }
       
        private void numberofpeople_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(numberofpeople.Text))
            {
                MessageBox.Show("Enter number of Peoples");
            }
            else
            {
                Decimal val1 = Convert.ToDecimal(numberofpeople.Text);
                Decimal val4 = Convert.ToDecimal(Seatsaval.Text);
                Decimal val3 = Convert.ToDecimal(nonamt.Text);
                if (val1 > val4)
                {
                    MessageBox.Show("seats not availabel");
                }
                else
                {
                    Decimal val2 = val1 * val3;
                    total.Text = val2.ToString();
                }
            }
        }

        private void total_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void ddate_TextChanged(object sender, EventArgs e)
        {

        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void bookingid_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancelbook_Click(object sender, EventArgs e)
        {

        }
    }
}
