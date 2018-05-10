using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace WcfService5
{
    public class Add
    {   private string hospitalname;
        private string patientname;
        private string patientdisease;
        private string wardno;
        private int bedno;

        public string HospitalName
        {
            get
            {
                return hospitalname;
            }

            set
            {
                hospitalname = value;
            }
        }

        public string PatientName
        {
            get
            {
                return patientname;
            }

            set
            {
                patientname = value;
            }
        }

        public string PatientDisease
        {
            get
            {
                return patientdisease;
            }

            set
            {
                patientdisease = value;
            }
        }

        public string WardNo
        {
            get
            {
                return wardno;
            }

            set
            {
                wardno = value;
            }
        }

        public int BedNo
        {
            get
            {
                return bedno;
            }

            set
            {
                bedno = value;
            }
        }
    
    }
}