using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem_Entity
{
    public class PatientInfo
    {
        public int PatientID { get; set; }
        public string PatientName { get; set; }
        public string Issue { get; set; }
        public string ReferralDoct { get; set; }
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string PatientStatus { get; set; }
        public string PatientPwd { get; set; }

    }
}
