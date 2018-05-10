using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frmregistration
{
    public partial class show : Form
    {
        public show()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void show_Load(object sender, EventArgs e)
        {
            foreach(MyUser u in dataclass.dc)
            {
                ucuserprofile uc = new ucuserprofile(u.Image, u.Username);
                flowLayoutPanel1.Controls.Add(uc);
            }
        }
    }
}
