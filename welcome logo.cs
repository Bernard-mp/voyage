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
    public partial class welcome_logo : Form
    {
        public welcome_logo()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            panel2.Width += 3;
            if (panel2.Width>=650)
                {
                timer1.Stop();
                loginform log = new loginform();
                log.Show();
                this.Hide();
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        { }
            
    }
}
