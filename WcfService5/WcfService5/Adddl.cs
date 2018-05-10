using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Collections;

namespace WcfService5
{
    public class Adddl
    {
        public static List<Add> arr = new List<Add>();
        public void add(string hospitalname, string patientname, string patientdisease, string wardno, int bedno)
        {
            Add n = new Add();
            n.PatientName = patientname;
            n.PatientName = patientdisease;
            n.HospitalName = hospitalname;
            n.WardNo = wardno;
            n.BedNo = bedno;
            Adddl.arr.Add(n);
        }
    }
}