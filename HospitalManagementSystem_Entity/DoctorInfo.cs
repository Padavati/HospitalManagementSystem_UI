using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem_Entity
{
    public class DoctorInfo
    {
        public int DoctID { get; set; }
        public string DoctName { get; set; }
        public string DoctType { get; set; }
        public string DoctMaster { get; set; }
        public int ConsultFee { get; set; }
    }
}
