using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Threading.Tasks;

namespace WcfService5
{
    public class MyUser
    {
        private string doctorname;
        private string secretquestion;

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

        public string DoctorName
        {
            get { return doctorname; }
            set { doctorname = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}