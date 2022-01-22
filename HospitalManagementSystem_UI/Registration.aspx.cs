using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HospitalManagementSystem_Business;
using HospitalManagementSystem_Entity;
using System.Data;

namespace HospitalManagementSystem_UI
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            PatientInfoBusiness patientInfoBusinessObj = new PatientInfoBusiness();
            PatientInfo patientInfoObj = new PatientInfo();
            patientInfoObj.PatientID = Convert.ToInt32(txtPatientID.Text);
            patientInfoObj.PatientName = txtPatientName.Text;
            patientInfoObj.Issue = txtIssue.Text;
            patientInfoObj.ReferralDoct = txtReferralDoctor.Text;
            patientInfoObj.EmpID = Convert.ToInt32(txtEmployeeID.Text);
            patientInfoObj.EmpName = txtEmployeeName.Text;
            patientInfoObj.PatientStatus = txtPatientStatus.Text;
            patientInfoObj.PatientPwd = txtPatientPassword.Text;

            string msg = patientInfoBusinessObj.Insertion(patientInfoObj);
            lblResult.Text = msg;
            LoadData();

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            PatientInfoBusiness doctorInfoBusinessObj = new PatientInfoBusiness();
            DataTable dt = doctorInfoBusinessObj.Edit(int.Parse(txtPatientID.Text));

            txtPatientName.Text = dt.Rows[0][1].ToString();
            txtIssue.Text = dt.Rows[0][2].ToString();
            txtReferralDoctor.Text = dt.Rows[0][3].ToString();
            txtEmployeeID.Text = dt.Rows[0][4].ToString();
            txtEmployeeName.Text = dt.Rows[0][5].ToString();
            txtPatientStatus.Text = dt.Rows[0][6].ToString();
            txtPatientPassword.Text = dt.Rows[0][7].ToString();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            PatientInfoBusiness patientInfoBusinessObj = new PatientInfoBusiness();
            PatientInfo patientInfoObj = new PatientInfo();
            patientInfoObj.PatientID = Convert.ToInt32(txtPatientID.Text);
            patientInfoObj.PatientName = txtPatientName.Text;
            patientInfoObj.Issue = txtIssue.Text;
            patientInfoObj.ReferralDoct = txtReferralDoctor.Text;
            patientInfoObj.EmpID = Convert.ToInt32(txtEmployeeID.Text);
            patientInfoObj.EmpName = txtEmployeeName.Text;
            patientInfoObj.PatientStatus = txtPatientStatus.Text;
            patientInfoObj.PatientPwd = txtPatientPassword.Text;

            string msg = patientInfoBusinessObj.Updation(patientInfoObj);
            lblResult.Text = msg;

            LoadData();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            PatientInfoBusiness patientInfoBusinessObj = new PatientInfoBusiness();
            string msg = patientInfoBusinessObj.Deletion(int.Parse(txtPatientID.Text));
            lblResult.Text = msg;

            LoadData();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            PatientInfoBusiness patientInfoBusinessObj = new PatientInfoBusiness();
            string msg = patientInfoBusinessObj.Reset();
            lblResult.Text = msg;

            LoadData();

        }
        public void LoadData()
        {
            PatientInfoBusiness patientInfoBusinessObj = new PatientInfoBusiness();
            DataTable dt = patientInfoBusinessObj.Selection();
            gvPatientInfo.DataSource = dt;
            gvPatientInfo.DataBind();
        }

    }
}