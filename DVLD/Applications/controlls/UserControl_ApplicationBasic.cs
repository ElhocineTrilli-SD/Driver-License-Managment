using DVLD_BUSINESS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Applications.controlls
{
    public partial class UserControl_ApplicationBasic : UserControl
    {


        private clsApplication _Application;

        private int _ApplicationID = -1;

        public int ApplicationID
        {
            get { return _ApplicationID; }
        }
        public void LoadApplicationInfo(int ApplicationID)
        {
            _Application = clsApplication.FindBaseApplication(ApplicationID);
            if (_Application == null)
            {
                ResetApplicationInfo();
                MessageBox.Show("No Application with ApplicationID = " + ApplicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                _FillApplicationInfo();
        }

        private void _FillApplicationInfo()
        {
            _ApplicationID = _Application.ApplicationID;
            txtID.Text = _Application.ApplicationID.ToString();
            txtStatus.Text = _Application.StatusText;
            txtType.Text = _Application.ApplicationTypeInfo.Titel;
            txtFees.Text = _Application.PaidFees.ToString();
            txtApplicant.Text = _Application.ApplicantFullName;
            txtDate.Text = (_Application.ApplicationDate).ToShortDateString();
            txtStatusDate.Text = (_Application.LastStatusDate).ToShortDateString();
            txtCreatedBy.Text = _Application.CreatedByUserInfo.UserName;
        }

        public void ResetApplicationInfo()
        {
            _ApplicationID = -1;

            txtID.Text = "??";
            txtStatus.Text = "??";
            txtType.Text = "??";
            txtFees.Text = "??";
            txtApplicant.Text = "??";
            txtDate.Text = "??";
            txtStatusDate.Text = "??";
            txtCreatedBy.Text = "??";

        }

        
        public UserControl_ApplicationBasic()
        {
            InitializeComponent();
        }

        private void UserControl_ApplicationBasic_Load(object sender, EventArgs e)
        {

        }

        private void llShowPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPersonDetails frm = new ShowPersonDetails(_Application.ApplicantPersonID);
            frm.ShowDialog();

            //Refresh
            LoadApplicationInfo(_ApplicationID);
        }
    }
}
