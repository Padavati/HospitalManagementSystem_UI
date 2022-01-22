using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HospitalManagementSystem_Entity;
using HospitalManagementSystem_Business;
using System.Data;

namespace HospitalManagementSystem_UI
{
    public partial class Administration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            DoctorInfoBusiness doctorInfoBusinessObj = new DoctorInfoBusiness();
            DoctorInfo doctorInfoObj = new DoctorInfo();
            doctorInfoObj.DoctID = Convert.ToInt32(txtDoctorID.Text);
            doctorInfoObj.DoctName = txtDoctorName.Text;
            doctorInfoObj.DoctType = txtSpecialization.Text;
            doctorInfoObj.DoctMaster = txtQualification.Text;
            doctorInfoObj.ConsultFee = Convert.ToInt32(txtFee.Text);
            string msg = doctorInfoBusinessObj.Insertion(doctorInfoObj);
            lblResult.Text = msg;
            LoadData();
            

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            DoctorInfoBusiness doctorInfoBusinessObj = new DoctorInfoBusiness();
            DataTable dt = doctorInfoBusinessObj.Edit(int.Parse(txtDoctorID.Text));
            
            txtDoctorName.Text = dt.Rows[0][1].ToString();
            txtSpecialization.Text = dt.Rows[0][2].ToString();
            txtQualification.Text = dt.Rows[0][3].ToString();
            txtFee.Text = dt.Rows[0][4].ToString();

        
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            DoctorInfoBusiness doctorInfoBusinessObj = new DoctorInfoBusiness();
            DoctorInfo doctorInfoObj = new DoctorInfo();
            doctorInfoObj.DoctID = Convert.ToInt32(txtDoctorID.Text);
            doctorInfoObj.DoctName = txtDoctorName.Text;
            doctorInfoObj.DoctType = txtSpecialization.Text;
            doctorInfoObj.DoctMaster = txtQualification.Text;
            doctorInfoObj.ConsultFee =Convert.ToInt32 (txtFee.Text);

            string msg = doctorInfoBusinessObj.Updation(doctorInfoObj);
            lblResult.Text = msg;

            LoadData();   
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            DoctorInfoBusiness doctorInfoBusinessObj = new DoctorInfoBusiness();
            string msg = doctorInfoBusinessObj.Deletion(int.Parse(txtDoctorID.Text));
            lblResult.Text = msg;

            LoadData();
        }

       
        public void LoadData()
        {
            DoctorInfoBusiness doctorInfoBusinessObj = new DoctorInfoBusiness();
            DataTable dt = doctorInfoBusinessObj.Selection();
            gvDoctorInfo.DataSource = dt;
            gvDoctorInfo.DataBind();
        }
    }
}