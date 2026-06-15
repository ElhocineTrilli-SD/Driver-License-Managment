using DVLD.Globle_Classes;
using DVLD_BUSINESS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Hosting;
using System.Windows.Forms;

namespace DVLD.Applications.Local_Driving_License
{
    public partial class frmAdd_EditLocalDrivingLicenseApplication : Form
    {

        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private int _LocalDrivingLicenseApplicationID = -1;
        private int _SelectedPersonID = -1;

        public clsLocalDrivingLicenseApplication _localDrivingLicenseApplication;
        public frmAdd_EditLocalDrivingLicenseApplication()
        {
            _Mode = enMode.AddNew;
            InitializeComponent();
        }

        public frmAdd_EditLocalDrivingLicenseApplication(int ID)
        {
            _Mode = enMode.Update;
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = ID;
        }
        private void _ResetDefaultValues()
        {
            _FillCbWithLicenseClass();

            if (_Mode == enMode.AddNew)
            {
                lblTitel.Text = "New Local Driving License Application";
                this.Text = "New Local Driving License Application";
                _localDrivingLicenseApplication = new clsLocalDrivingLicenseApplication(); 
                personInfoWithFilter11.FilterFocus();

                cbLicenseClass.SelectedIndex = 2;
                txtAFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.NewDrivingLicense).Fees.ToString();
                txtADate.Text = DateTime.Now.ToShortDateString();
                txtAUser.Text = GlobalClass.CurrentUser.UserName;


            }
            else
            {
                lblTitel.Text = "Update Local Driving License Application";
                this.Text = "Update Local Driving License Application";



            }

                    
        }

        private void _FillCbWithLicenseClass()
        {
            DataTable LicenseClass = clsLicenseClass.GetAllLicenseClasses();

            foreach (DataRow row in LicenseClass.Rows)
            {
                cbLicenseClass.Items.Add(row["ClassName"]);
            }

        }

        private void _LoadData()
        {

            personInfoWithFilter11.FilterEnabled = false;
            _localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseApplicationID);

            if (_localDrivingLicenseApplication == null)
            {
                MessageBox.Show("No Application with ID = " + _LocalDrivingLicenseApplicationID, "Application Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }

            personInfoWithFilter11.LoadPersonInfo(_localDrivingLicenseApplication.ApplicantPersonID);
            txtApplicationID.Text = _localDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            txtADate.Text = _localDrivingLicenseApplication.ApplicationDate.ToShortDateString();
            txtAFees.Text = _localDrivingLicenseApplication.PaidFees.ToString();
            txtAUser.Text = clsUser.FindByUserID(_localDrivingLicenseApplication.CreatedByUserID).UserName;
            cbLicenseClass.SelectedIndex = cbLicenseClass.FindString(clsLicenseClass.Find(_localDrivingLicenseApplication.LicenseClassID).ClassName);
        }

        private void frmAdd_EditLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if(_Mode == enMode.Update)
            {
                _LoadData();
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                //btnSave.Enabled = true;
                //tpApplicationInfo.Enabled = true;
                tbAInfo.SelectedTab = tApplicationInfo;
                return;
            }
            //incase of add new mode.
            if (personInfoWithFilter11.PersonID != -1)
            {


                tbAInfo.SelectedTab = tApplicationInfo;

            }

            else

            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                personInfoWithFilter11.FilterFocus();
            }


        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            int LicenseClassID = clsLicenseClass.Find(cbLicenseClass.Text).LicenseClassID;

            int ActiveApplicationID = clsApplication.GetActiveApplicationIDForLicenseClass(_SelectedPersonID,
                clsApplication.enApplicationType.NewDrivingLicense, LicenseClassID);

            if (ActiveApplicationID != -1)
            {
                MessageBox.Show("Choose another License Class, the selected Person Already have an active application for the selected class with id=" + ActiveApplicationID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbLicenseClass.Focus();
                return;
            }

            //if (cls.IsLicenseExistByPersonID(personInfoWithFilter11.PersonID, LicenseClassID))
            //{
            //    MessageBox.Show("Person already have a license with the same applied driving class, Choose diffrent driving class", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            _localDrivingLicenseApplication.ApplicantPersonID = personInfoWithFilter11.PersonID; ;
            _localDrivingLicenseApplication.ApplicationDate = DateTime.Now;
            _localDrivingLicenseApplication.ApplicationTypeID = 1;
            _localDrivingLicenseApplication.ApplicationStatus = clsApplication.enApplicationStatus.New;
            _localDrivingLicenseApplication.LastStatusDate = DateTime.Now;
            _localDrivingLicenseApplication.PaidFees = Convert.ToSingle(txtAFees.Text);
            _localDrivingLicenseApplication.CreatedByUserID = GlobalClass.CurrentUser.UserID;
            _localDrivingLicenseApplication.LicenseClassID = LicenseClassID;


            if (_localDrivingLicenseApplication.Save())
            {
                txtApplicationID.Text = _localDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lblTitel.Text = "Update Local Driving License Application";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);




        }

        private void personInfoWithFilter11_OnPersonSelected(int obj)
        {
            _SelectedPersonID = obj;
        }

        private void frmAdd_EditLocalDrivingLicenseApplication_Activated(object sender, EventArgs e)
        {
            personInfoWithFilter11.FilterFocus();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
