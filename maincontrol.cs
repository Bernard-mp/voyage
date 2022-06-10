using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hike
{
    class maincontrol
    {
        
        public static void showcontrol(Control control,Control content)
        {
            content.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
          content.Controls.Add(control);

            

        }

    }
}
