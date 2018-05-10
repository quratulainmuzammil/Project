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
    public partial class Frmlogin : Form
    {
       public Frmlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Form1 m = new Form1();
            m.Show();
            this.Hide();
        }

        private void cmdlogin_Click(object sender, EventArgs e)
        {
            Boolean isfound=false;
            foreach(MyUser u in dataclass.dc)
            {
                if (u.Passward==txtpassward.Text && txtusername.Text == u.Username)
                {
                    isfound = true;
                }
                
            }
            if (isfound)
            { MessageBox.Show("valid");
            }
            else
            {
                MessageBox.Show("invalid");
            }
            
        }

        private void cmdresetpassward_Click(object sender, EventArgs e)
        {
            frmresetpassward k = new frmresetpassward();
            this.Hide();
            k.Show();
        }

        private void Frmlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
