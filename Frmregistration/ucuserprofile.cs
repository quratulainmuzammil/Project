using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frmregistration
{
    public partial class ucuserprofile : UserControl
    {
        public ucuserprofile()
        {
            InitializeComponent();
        }
        public ucuserprofile(Image img,string username)
        {
            InitializeComponent();
            p1.Image = img;
            L1.Text = username;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ucuserprofile_Load(object sender, EventArgs e)
        {

        }
    }
}
