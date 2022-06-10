using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hike
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void gunaControlBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Max_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                
            }

        }

        public void dashboard_Load(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            lblwelcome.Text = "You logged in as " + accessusername.Username;
            home hm = new home();

            maincontrol.showcontrol(hm, maincontent);

        }

        private void dash_panel_Paint(object sender, PaintEventArgs e)
        {
            
        }

      

        private void aboutusbtn_Click(object sender, EventArgs e)
        {
            aboutus abt = new aboutus();
            maincontrol.showcontrol(abt, maincontent);
            settingp.Controls.Clear();
            
        }
     



        private void help_Click_1(object sender, EventArgs e)
        {
            contactus contact = new contactus();
            maincontrol.showcontrol(contact, maincontent);
            settingp.Controls.Clear();
        }

        private void Faq_Click(object sender, EventArgs e)
        {
            settingp.Controls.Clear();
            faq f = new faq();
            maincontrol.showcontrol(f, maincontent);
        }

        private void maincontent_Paint(object sender, PaintEventArgs e)
        {

        }
        public static int counter = 0;

        public void Accountbtn_Click(object sender, EventArgs e)
        {
            settingp.Controls.Clear();
            setting set = new setting();
            maincontent.Controls.Clear();
            if (counter == 0)
            {
                counter++;
                
                set.Show();


            }
            else
            {
                MessageBox.Show("tab is already open");
                
            }
        }

        private void lblwelcome_Click(object sender, EventArgs e)
        {

        }
        

        public void settingbtn_Click(object sender, EventArgs e)
        {
          
                mainsettting ms = new mainsettting();
                maincontrol.showcontrol(ms, settingp);
           


        }

        public void mytrip_Click(object sender, EventArgs e)
        {
            accessusername.city = 0;
            settingp.Controls.Clear();
            alltrips all = new alltrips();
            maincontrol.showcontrol(all, maincontent);
        }

        public void dashboardbtn_Click(object sender, EventArgs e)
        {
            home hm = new home();
     
            maincontrol.showcontrol(hm, maincontent);
            settingp.Controls.Clear();
           
        }

        private void Cancelbook_Click(object sender, EventArgs e)
        {
            cancelbook cnl = new cancelbook();
            maincontrol.showcontrol(cnl, maincontent);
            settingp.Controls.Clear();
        }
    }
}
