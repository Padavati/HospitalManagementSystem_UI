using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HospitalManagementSystem_Business;
using System.Data;


namespace HospitalManagementSystem_UI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            PatientInfoBusiness patientInfoBusiness = new PatientInfoBusiness();
            DataTable dtLogin = patientInfoBusiness.LoginCheck(int.Parse(txtPatientID.Text), txtPatientPassword.Text);
            if (dtLogin.Rows.Count > 0)
            {
                gvPatientDetails.DataSource = dtLogin;
                gvPatientDetails.DataBind();
            }
            else
            {
                lblResult.Text = "Account does not exist!!! Register";
            }

        }
    }
}