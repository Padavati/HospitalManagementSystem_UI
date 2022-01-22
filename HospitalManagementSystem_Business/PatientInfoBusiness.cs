using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementSystem_Data;
using HospitalManagementSystem_Entity;
using System.Data;

namespace HospitalManagementSystem_Business
{
    public class PatientInfoBusiness
    {
        public string Insertion(PatientInfo patientInfoObj)
        {
            PatientDBConnection doctorDBConnectionObj = new PatientDBConnection();
            string msg = doctorDBConnectionObj.InsertPatientInfo(patientInfoObj);
            return msg;
        }
        public string Updation(PatientInfo patientInfoObj)
        {
            PatientDBConnection doctorDBConnectionObj = new PatientDBConnection();
            string msg = doctorDBConnectionObj.UpdatePatientInfo(patientInfoObj);
            return msg;
        }
        public DataTable Edit(int PatientID)
        {
            PatientDBConnection doctorDBConnectionObj = new PatientDBConnection();
            DataTable dt = doctorDBConnectionObj.EditPatientInfoByID(PatientID);
            return dt;
        }
        public DataTable Selection()
        {
            PatientDBConnection doctorDBConnectionObj = new PatientDBConnection();
            DataTable dt = doctorDBConnectionObj.SelectPatientInfo();
            return dt;
        }
        public string Deletion(int PatientID)
        {
            PatientDBConnection doctorDBConnectionObj = new PatientDBConnection();
            string msg = doctorDBConnectionObj.DeletePatientInfoByID(PatientID);
            return msg;
        }
        public string Reset()
        {
            PatientDBConnection patientDBConnectionObj = new PatientDBConnection();
            string msg = patientDBConnectionObj.ResetAll();
            return msg;
        }
        public DataTable LoginCheck(int PatientID, string PatientPwd)
        {
            PatientDBConnection patientInfoDBConnection = new PatientDBConnection();
            DataTable dt = patientInfoDBConnection.LoginCheck(PatientID, PatientPwd);
            return dt;
        }
    }
}
