using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Drawing;

namespace Frmregistration
{
    class MyUser
    {
        private string username;
        private string secretquestion;
        private Image image; 

        public string Secretquestion
        {
            get { return secretquestion; }
            set { secretquestion = value; }
        }
        private string answer;

        public string Answer
        {
            get { return answer; }
            set { answer = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string passward;

        public string Passward
        {
            get { return passward; }
            set { passward = value; }
        }

        public Image Image
        {
            get
            {
                return image;
            }

            set
            {
                image = value;
            }
        }
    }
}
