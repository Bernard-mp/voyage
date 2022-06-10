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
    public partial class home : UserControl
    {
        
        public home()
        {
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        public void  banglore_Click(object sender, EventArgs e)
        {
            accessusername.city = 1;
            accessusername.cityname = "Bangalore";
            citypanel.BringToFront();
            alltrips all = new alltrips();
            maincontrol.showcontrol(all,citypanel );
           
          
            
        }

        private void mysore_Click(object sender, EventArgs e)
        {
            accessusername.city = 2;
            accessusername.cityname = "Mysore";
            citypanel.BringToFront();
            alltrips all = new alltrips();
            maincontrol.showcontrol(all, citypanel);


        }

        private void chennai_Click(object sender, EventArgs e)
        {
            accessusername.city = 3;
            accessusername.cityname = "Chennai";
            citypanel.BringToFront();
            alltrips all = new alltrips();
            maincontrol.showcontrol(all, citypanel);


        }

        private void goa_Click(object sender, EventArgs e)
        {
            accessusername.city = 4;
            accessusername.cityname = "Goa";
            citypanel.BringToFront();
            alltrips all = new alltrips();
            maincontrol.showcontrol(all, citypanel);


        }

        private void coorg_Click(object sender, EventArgs e)
        {
            accessusername.city = 5;
            accessusername.cityname = "Coorg";
            citypanel.BringToFront();
            alltrips all = new alltrips();
            maincontrol.showcontrol(all, citypanel);

        }

        private void hydrabad_Click(object sender, EventArgs e)
        {
            accessusername.city = 6;
            accessusername.cityname = "Hydrabad";
            citypanel.BringToFront();
            alltrips all = new alltrips();
            maincontrol.showcontrol(all, citypanel);


        }

        private void manglore_Click(object sender, EventArgs e)
        {
            accessusername.city = 7;
            accessusername.cityname = "Mangalore";
            citypanel.BringToFront();
            alltrips all = new alltrips();
            maincontrol.showcontrol(all, citypanel);


        }

        private void tirupathi_Click(object sender, EventArgs e)
        {
            accessusername.city = 8;
            accessusername.cityname = "Tirupathi";
            citypanel.BringToFront();
            alltrips all = new alltrips();
            maincontrol.showcontrol(all, citypanel);

        }
    }
}
