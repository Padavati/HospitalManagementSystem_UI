using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using HospitalManagementSystem_Entity;

namespace HospitalManagementSystem_Data
{
    public class DoctorDBConnection
    {
        string sqlConnectionStr = "Data Source=LAPTOP-DL0P9UEA;Initial Catalog=HMS;Integrated Security=True";
        public string InsertDoctInfo(DoctorInfo doctInfoObj)
        {
            DataTable dataTableObj = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter("Insert into DoctorInfo values("+doctInfoObj.DoctID+",'"+doctInfoObj.DoctName+"','"+doctInfoObj.DoctType+"','"+doctInfoObj.DoctMaster+"',"+doctInfoObj.ConsultFee+")",sqlConnectionObj);
            sqlDataAdapterObj.Fill(dataTableObj);
            return "Doctor Information Inserted Successfully";
        }
        public string UpdateDoctInfo(DoctorInfo doctInfoObj)
        {
            DataTable dataTableObj = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter("Update DoctorInfo set DoctName='" +doctInfoObj.DoctName + "',DoctType='" + doctInfoObj.DoctType + "',DoctMaster='" + doctInfoObj.DoctMaster + "',ConsultFee=" + doctInfoObj.ConsultFee + " where DoctID="+doctInfoObj.DoctID+"", sqlConnectionObj);
            sqlDataAdapterObj.Fill(dataTableObj);
            return "Doctor Information Updated Successfully";
        }
        public DataTable EditDoctInfoByID(int DoctID)
        {
            DataTable dataTableObj = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter(" select*from DoctorInfo where DoctID="+DoctID+"" , sqlConnectionObj);
            sqlDataAdapterObj.Fill(dataTableObj);
            return dataTableObj;
        }
        public DataTable SelectDoctInfo()
        {
            DataTable dataTableObj = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter(" select*from DoctorInfo order by DoctID", sqlConnectionObj);
            sqlDataAdapterObj.Fill(dataTableObj);
            return dataTableObj;
        }
        public string DeleteDoctInfoByID(int DoctID)
        {
            DataTable dataTableObj = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter(" Delete from DoctorInfo where DoctID=" + DoctID + "", sqlConnectionObj);
            sqlDataAdapterObj.Fill(dataTableObj);
            return "Deleted Successfully";
        }
        public DataTable LoginCheck(int DoctID, string DoctName)
        {

            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("select DoctName,DoctType,DoctMaster,ConsultFee from DoctorInfo where DoctID=" + DoctID + " and DoctName='" + DoctName + "'", sqlConnectionObj);
            adp.Fill(dt);
            return dt;


        }
       
    }
}
