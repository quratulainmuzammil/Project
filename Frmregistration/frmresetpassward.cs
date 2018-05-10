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
    public partial class frmresetpassward : Form
    {
        public frmresetpassward()
        {
            InitializeComponent();
        }
            

        private void txtpssward_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdok_Click(object sender, EventArgs e)
        {
            foreach (MyUser u in dataclass.dc)
            {
                if(txtusername.Text ==u.Username)
                {
                    u.Passward=txtpssward.Text ;
                    u.Secretquestion =sercretquestion.Text  ;
                    u.Answer = txtanswer.Text;
                    if (txtpssward.Text!=txtconfirmpassward.Text )
                    {
                        MessageBox.Show("passward does not match");
                    }
                    else 
                    {
                        MessageBox.Show("your passward has been reset");
                    }}}
        }

        private void cmdlogin_Click(object sender, EventArgs e)
        {
            Frmlogin n = new Frmlogin();
            this.Hide();
            n.Show();
        }

        private void lblconfirmpassward_Click(object sender, EventArgs e)
        {

        }

        private void txtconfirmpassward_TextChanged(object sender, EventArgs e)
        {

        }

        private void sercretquestion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmresetpassward_Load(object sender, EventArgs e)
        {

        }
    }
}
