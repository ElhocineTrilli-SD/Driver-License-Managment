using DVLD.Globle_Classes;
using DVLD.Licenses.LocalLicenses;
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

namespace DVLD.Licenses.DetainedLisenses
{
    public partial class frmReleaseDetainedlicense : Form
    {
        private int _SelectedLicenseID = -1; 

        public frmReleaseDetainedlicense()
        {
            InitializeComponent();
        }

        public frmReleaseDetainedlicense(int LicenseID)
        {
            InitializeComponent();
            _SelectedLicenseID  = LicenseID;
            ctrlLicenseInfoWithFilter1.LoadLicenseInfo(_SelectedLicenseID);
            ctrlLicenseInfoWithFilter1.FilterEnabled = false;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _SelectedLicenseID = obj;

            lblLicenseID.Text = _SelectedLicenseID.ToString();
            llblShowHistory.Enabled = (_SelectedLicenseID != -1);

            if (_SelectedLicenseID == -1)
            {
                return;
            }

            if(!ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.IsDetained)
            {
                MessageBox.Show("Selected License is not Detained.choose another one.", "error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            lblDetainID.Text  = ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedInfo.DetainID.ToString();
            lblLicenseID.Text =  ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseID.ToString();

            lblAppFees.Text =
                clsApplicationType.Find((int)clsApplication.enApplicationType.ReleaseDetainedDrivingLicsense).Fees.ToString();
            btnRelease.Enabled = true;

            lblCreatedBy.Text = GlobalClass.CurrentUser.UserName;
            lblFineFees.Text =
                ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedInfo.FineFees.ToString();
            lbltotalFees.Text = ( Convert.ToSingle(lblFineFees.Text) + Convert.ToSingle(lblAppFees.Text) ).ToString();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            //are you sure.
            if (MessageBox.Show("Are you sure you want to detain this license!",
                  "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            int ApplicationID = -1;

            bool isRelease =
                ctrlLicenseInfoWithFilter1.SelectedLicenseInfo
                .ReleaseDetainedLicense(GlobalClass.CurrentUser.UserID, ref ApplicationID);

            lblAppID.Text = ApplicationID.ToString();

            if (!isRelease)
            {
                MessageBox.Show("Faild to to release the Detain License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Detained License released Successfully ", "Detained License Released", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnRelease.Enabled = false;
            ctrlLicenseInfoWithFilter1.FilterEnabled = false;
            llblShowHistory.Enabled = true;
            llblShowLicenseInfo.Enabled = true;
        }

        private void ctrlLicenseInfoWithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void frmReleaseDetainedlicense_Load(object sender, EventArgs e)
        {
            ctrlLicenseInfoWithFilter1.FilterFocus();

        }

        private void llblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm =
           new frmShowLicenseInfo(_SelectedLicenseID);
            frm.ShowDialog();
        }

        private void llblShowHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicenseHistory frm =
            new frmShowPersonLicenseHistory(ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.DriversInfo.PersonID);
            frm.ShowDialog();
        }
    }
}
