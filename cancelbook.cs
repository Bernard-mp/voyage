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

namespace hike
{
    public partial class cancelbook : UserControl
    {
        public cancelbook()
        {
            InitializeComponent();
            
        }

        private void cancelsearch_TextChanged(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=ANIMAL-LOVER;Initial Catalog=userreg;Integrated Security=True";
            using (SqlConnection sqlcon = new SqlConnection(ConnectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM finalbooks where bookingid= '" + cancelsearch.Text + "'", sqlcon);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                guna2DataGridView1.DataSource = dtbl;
                guna2DataGridView1.Visible = true;

            }
        }

        public void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                cancelid.Text = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                package.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                cancelseats.Text = guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                int cnlid = int.Parse(cancelid.Text);
                int pack = int.Parse(package.Text);
                int cance = int.Parse(cancelseats.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=ANIMAL-LOVER;Initial Catalog=userreg;Integrated Security=True";
                SqlCommand cmd = new SqlCommand("Select Seats from Package where id =@package", con);
                cmd.Parameters.AddWithValue("@package", package.Text);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dtabaseseat.Text = dr.GetValue(0).ToString();

                }
                con.Close();
                int databaseat = int.Parse(dtabaseseat.Text);
                finalseats.Text = (Convert.ToInt32(dtabaseseat.Text) + Convert.ToInt32(cancelseats.Text)).ToString();
                Cancel.Visible = true;
            }
            
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            if (this.guna2DataGridView1.SelectedRows.Count > 0)
            {
               

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=ANIMAL-LOVER;Initial Catalog=userreg;Integrated Security=True";
                SqlCommand cmd = new SqlCommand("delete finalbooks  where bookingid=@bookingid", con);
                cmd.Parameters.AddWithValue("@bookingid", cancelid.Text);
                con.Open();
                cmd.ExecuteNonQuery();
               
                seat();

                con.Close();
            }
        }
        void seat()
        {
            if (this.guna2DataGridView1.SelectedRows.Count > 0)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=ANIMAL-LOVER;Initial Catalog=userreg;Integrated Security=True";

                SqlCommand cmd = new SqlCommand("UPDATE [dbo].[Package] SET[Seats] = @Seats where id='" + package.Text + "'", con);
                cmd.Parameters.AddWithValue("@Seats", finalseats.Text);
                con.Open();



                cmd.ExecuteNonQuery();
                MessageBox.Show("Booking Cancelled");
                guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);
                con.Close();
            }
        else
            {
                MessageBox.Show("Double tap on the row");
            }
        }

        private void cancelbook_Load(object sender, EventArgs e)
        {

        }
    }
}
