using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using HospitalManagementSystem_Entity;
using System.Data.SqlClient;

namespace HospitalManagementSystem_Data
{
    public class PatientDBConnection
    {
        string sqlConnectionStr = "Data Source=LAPTOP-DL0P9UEA;Initial Catalog=HMS;Integrated Security=True";
        public string InsertPatientInfo(PatientInfo patientInfoObj)
        {
            DataTable dataTableObj = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter("Insert into PatientInfo values("+patientInfoObj.PatientID+",'" + patientInfoObj.PatientName + "','" + patientInfoObj.Issue + "','" + patientInfoObj.ReferralDoct + "',"+patientInfoObj.EmpID+",'"+patientInfoObj.EmpName+"','"+patientInfoObj.PatientStatus+"','"+patientInfoObj.PatientPwd+"')", sqlConnectionObj);
            sqlDataAdapterObj.Fill(dataTableObj);
            return "Patient Information Inserted Successfully";
        }            

        public string UpdatePatientInfo(PatientInfo patientInfoObj)
        {
            DataTable dataTableObj = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter("Update PatientInfo set PatientName='" + patientInfoObj.PatientName + "',Issue='" + patientInfoObj.Issue + "',ReferralDoct='" + patientInfoObj.ReferralDoct + "',EmpID=" + patientInfoObj.EmpID + ",EmpName='"+patientInfoObj.EmpName+"',PatientStatus='"+patientInfoObj.PatientStatus+ "',PatientPwd='"+patientInfoObj.PatientPwd+"' where PatientID=" + patientInfoObj.PatientID + "", sqlConnectionObj);
            sqlDataAdapterObj.Fill(dataTableObj);
            return "Patient Information Updated Successfully";
        }
        public DataTable EditPatientInfoByID(int PatientID)
        {
            DataTable dataTableObj = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter(" select*from PatientInfo where PatientID=" + PatientID + "", sqlConnectionObj);
            sqlDataAdapterObj.Fill(dataTableObj);
            return dataTableObj;
        }
        public DataTable SelectPatientInfo()
        {
            DataTable dataTableObj = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter(" select*from PatientInfo", sqlConnectionObj);
            sqlDataAdapterObj.Fill(dataTableObj);
            return dataTableObj;
        }
        public string DeletePatientInfoByID(int PatientID)
        {
            DataTable dataTableObj = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter(" Delete from PatientInfo where PatientID=" + PatientID + "", sqlConnectionObj);
            sqlDataAdapterObj.Fill(dataTableObj);
            return "Deleted Successfully";
        }
        public string ResetAll()
        {
            DataTable dataTableObj = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter(" truncate table PatientInfo ", sqlConnectionObj);
            sqlDataAdapterObj.Fill(dataTableObj);
            return "Reset Successfully";
        }
        public DataTable LoginCheck(int PatientID,string PatientPwd)
        {
                 DoctorInfo doctorInfo = new DoctorInfo();
                 DataTable dt = new DataTable();
                SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
                SqlDataAdapter adp = new SqlDataAdapter("select PatientName,Issue,ReferralDoct,EmpID,EmpName,PatientStatus,DoctName,ConsultFee from PatientInfo,DoctorInfo where DoctorInfo.DoctType=PatientInfo.Issue and PatientID ='" + PatientID + "' and PatientPwd='" + PatientPwd + "'", sqlConnectionObj);
                adp.Fill(dt);
                return dt;
            

        }

    }
}
