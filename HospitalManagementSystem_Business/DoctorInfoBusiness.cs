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
    public class DoctorInfoBusiness
    {
        public string Insertion(DoctorInfo doctorInfoObj)
        {
            DoctorDBConnection doctorDBConnectionObj = new DoctorDBConnection();
            string msg = doctorDBConnectionObj.InsertDoctInfo(doctorInfoObj);
            return msg;
        }
        public string Updation(DoctorInfo doctorInfoObj)
        {
            DoctorDBConnection doctorDBConnectionObj = new DoctorDBConnection();
            string msg = doctorDBConnectionObj.UpdateDoctInfo(doctorInfoObj);
            return msg;
        }
        public DataTable Edit(int DoctID)
        {
            DoctorDBConnection doctorDBConnectionObj = new DoctorDBConnection();
            DataTable dt = doctorDBConnectionObj.EditDoctInfoByID(DoctID);
            return dt;
        }
        public DataTable Selection()
        {
            DoctorDBConnection doctorDBConnectionObj = new DoctorDBConnection();
            DataTable dt = doctorDBConnectionObj.SelectDoctInfo();
            return dt;
        }
        public string Deletion(int DoctID)
        {
            DoctorDBConnection doctorDBConnectionObj = new DoctorDBConnection();
            string msg = doctorDBConnectionObj.DeleteDoctInfoByID(DoctID);
            return msg;
        }
        public DataTable LoginCheck(int DoctID, string DoctName)
        {
            DoctorDBConnection doctorInfoDBConnection = new DoctorDBConnection();
            DataTable dt = doctorInfoDBConnection.LoginCheck(DoctID, DoctName);
            return dt;
        }

    }
}
