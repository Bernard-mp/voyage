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
    public partial class mainsettting : UserControl
    {
        Timer timer = new Timer();

        public mainsettting()
        {
            InitializeComponent();
            this.date.Text = DateTime.Now.ToString();
            timer.Tick += new EventHandler(timer1_Tick);
            this.timer.Interval = 1000;
            this.timer.Enabled = true;
        }

        private void mainsettting_Load(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.date.Text = DateTime.Now.ToString();
        }
    }
}
