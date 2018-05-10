 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Frmregistration
{
    public partial class Form1 : Form
    {
        private static Form1 registrationfrm;
        private static Form1 getinstance()
        {
            if (registrationfrm == null)
            {
                registrationfrm = new Form1();
                return registrationfrm;
            }
            else { return registrationfrm; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void cmdsignup_Click(object sender, EventArgs e)
        {
            foreach (MyUser m in dataclass.dc)
            {
                if (m.Username == txtusername.Text)
                {
                    MessageBox.Show("please enter a uni");
                }
            }
            if (txtpassward.Text!="" &&  txtusername.Text!="")
            {
                MyUser u = new MyUser();
                u.Username = txtusername.Text;
                u.Passward = txtpassward.Text;
                u.Secretquestion = comboBoxSecretques.Text;
                u.Answer = txtanswers.Text;
                u.Image = pictureBox1.Image;
                dataclass.dc.Add(u);
                MessageBox.Show("You are registered");
                 
            }
            
             
            else
            {
                MessageBox.Show("please Enter name and passward");
            }
            
        }

        private void cmdlogin_Click(object sender, EventArgs e)
        {
             Frmlogin n = new Frmlogin();
           
            Form1.getinstance().Hide();
            n.Show();
        }

        private void comboBoxSecretques_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Image img = Image.FromStream(openFileDialog1.OpenFile());
            pictureBox1.Image = img;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            show a = new show();
            a.Show();
            this.Hide();
        }
    }
}
