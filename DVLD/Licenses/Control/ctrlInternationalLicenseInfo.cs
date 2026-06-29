using DVLD.Properties;
using DVLD_BUSINESS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Licenses.Control
{
    public partial class ctrlInternationalLicenseInfo : UserControl
    {
        private int _InternationalLicenseID;
        private clsInternationalLicense _InternationalLicense;

        public ctrlInternationalLicenseInfo()
        {
            InitializeComponent();
        }
        public int InternationalLicenseID
        {
            get { return _InternationalLicenseID; }
        }
        private void _LoadPersonImage()
        {
            //initail Image
            if (_InternationalLicense.DriverInfo.PersonInfo.Gender == 0)
                pbPersonImage.Image = Resources.man;
            else
                pbPersonImage.Image = Resources.women;

            string ImagePath = _InternationalLicense.DriverInfo.PersonInfo.ImagePath;

            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPersonImage.Load(ImagePath);
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        public void LoadInfo(int International_LicenseID)
        {
            _InternationalLicenseID = International_LicenseID ;
            _InternationalLicense = clsInternationalLicense.Find(_InternationalLicenseID);
            if (_InternationalLicense == null)
            {
                MessageBox.Show("Could not find Internationa License ID = " + _InternationalLicenseID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _InternationalLicenseID = -1;
                return;
            }

            lblPersonName.Text = _InternationalLicense.DriverInfo.PersonInfo.Fullname;
            lblLicenseID.Text = _InternationalLicense.IssuedUsingLocalLicenseID.ToString();
            lblInter_LicenseID.Text = _InternationalLicenseID.ToString();     
            lblNationalNo.Text = _InternationalLicense.DriverInfo.PersonInfo.NationalNo;
            lblGender.Text = _InternationalLicense.DriverInfo.PersonInfo.Gender == 0 ? "Male" : "Female";
            lblIssueDate.Text = _InternationalLicense.IssueDate.ToString("dd MMM yyyy");
            lblIsActive.Text = _InternationalLicense.IsActive == true ? "Yes" : "No";
            lblAppID.Text = _InternationalLicense.ApplicationID.ToString();
            lblDateOfBirth.Text = _InternationalLicense.DriverInfo.PersonInfo.DateOfBirth.ToString("dd MMM yyyy");
            lblExpirationDate.Text = _InternationalLicense.ExpirationDate.ToString("dd MMM yyyy");

            lblDriver_ID.Text = _InternationalLicense.DriverID.ToString();


            _LoadPersonImage();

        }

        private void ctrlInternationalLicenseInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
