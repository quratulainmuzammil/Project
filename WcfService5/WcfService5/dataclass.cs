using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace WcfService5
{
    public class dataclass
    {
       
        
            public static List<MyUser> dc = new List<MyUser>();
            public void registration(string doctorname, string password, string secretquestion, string answer)
            {

                MyUser l = new MyUser();
                l.DoctorName = doctorname;
                l.Password = password;
                l.Secretquestion = secretquestion;
                l.Answer = answer;
                dataclass.dc.Add(l);
            }

            public bool isvalid(string doctorname, string password)
            {
                bool ch = false;
                foreach (MyUser u in dataclass.dc)
                {
                    if (u.DoctorName == doctorname && u.Password == password)
                        ch = true;
                }
                return ch;
            }
            public bool resetpassword(string doctorname, string password, string secretquestion, string answer)
            {
                bool check = false;
                foreach (MyUser u in dataclass.dc)
                {
                    if (u.Secretquestion == secretquestion && u.Answer == answer)
                        check = true;
                }
                return check;
            }
       
            
            
        
    }
}