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
using System.Windows.Forms.VisualStyles;

namespace DVLD.Licenses.Control
{
    public partial class ctrlLicenseInfo : UserControl
    {
      private  clsLicense _License;
      private  int _LicenseID = -1;

        public int LicenseID
        {
            get { return _LicenseID; }
        }

        public clsLicense SelectedLicenseInfo
        {
            get { return _License;  }
        }

        public ctrlLicenseInfo()
        {
            InitializeComponent();
        }
        private void _LoadPersonImage()
        {
            //initail Image
            if (_License.DriversInfo.PersonInfo.Gender == 0)
                pbPersonImage.Image = Resources.man;
            else
                pbPersonImage.Image = Resources.women;

            string ImagePath = _License.DriversInfo.PersonInfo.ImagePath;

            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPersonImage.Load(ImagePath);
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        public  void LoadInfo( int LicenseID)
        {
            _LicenseID = LicenseID;
            _License = clsLicense.Find(_LicenseID);

            if (_License == null)
            {
                MessageBox.Show("Could not find License ID = " + _LicenseID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _LicenseID = -1;
                return;
            }

            lblClassName.Text = _License.LicenseClassIfo.ClassName;
            lblPersonName.Text = _License.DriversInfo.PersonInfo.Fullname;
            lblLicenseID.Text = _LicenseID.ToString();
            lblNationalNo.Text = _License.DriversInfo.PersonInfo.NationalNo;
            lblGender.Text = _License.DriversInfo.PersonInfo.Gender == 0 ? "Male":"Female";
            lblIssueDate.Text = _License.IssueDate.ToString("dd MMM yyyy");
            lblIssueReason.Text = _License.IssueReason.ToString();
            lblNotes.Text = _License.Notes =="" ? "No Notes": _License.Notes;
            lblIsActive.Text = _License.IsActive == true ?"Yes":"No";
            lblDateOfBirth.Text = _License.DriversInfo.PersonInfo.DateOfBirth.ToString("dd MMM yyyy");
            lblDriverID.Text = _License.DriverID.ToString();
            lblExpirationDate.Text = _License.ExpirationDate.ToString("dd MMM yyyy");
            lblIsDetained.Text = _License.IsDetained == true ? "Yes" : "No";
          _LoadPersonImage();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
