using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hike
{
   
    public partial class aboutus : UserControl
    {
        
        public aboutus()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        private void knowmore_Click(object sender, EventArgs e)
        { knwcontent.BringToFront();

            developer dev = new developer();
            maincontrol.showcontrol(dev,knwcontent);
        }
       

    }
}
