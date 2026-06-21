using DVLD.Globle_Classes;
using DVLD.Licenses;
using DVLD.Licenses.Control;
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
using static DVLD_BUSINESS.clsLicense;

namespace DVLD.Applications.ReplaceLostOrDamagedLicense
{
    public partial class frmReplecmentLicense : Form
    {
        private int _NewLicense = -1;
        public frmReplecmentLicense()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ctrlLicenseInfoWithFilter2.FilterFocus();

            lblAppDate.Text = DateTime.Now.ToString("dd MM yyyy");
            lblCreatedBy.Text = GlobalClass.CurrentUser.UserName;
            rbDamagedL.Checked = true;
        }

        private void ctrlLicenseInfoWithFilter2_OnLicenseSelected(int obj)
        {
            int SelectedLicenseID = obj;

            lblOldLicenseID.Text = SelectedLicenseID.ToString();
            llblShowHistory.Enabled = (SelectedLicenseID != -1);

            if (SelectedLicenseID == -1) { return; }

            //check the license is not Active.
            if (!ctrlLicenseInfoWithFilter2.SelectedLicenseInfo.IsActive)
            {
                MessageBox.Show("Selected License is not Not Active, choose an active license."
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssueReplacement.Enabled = false;
                return;
            }


            btnIssueReplacement.Enabled = true;
        }

        private void rbDamagedL_CheckedChanged(object sender, EventArgs e)
        {
            lblTitel.Text = "Replecement for Damaged License";
            this.Text = lblTitel.Text;

            lblAppFees.Text =
                clsApplicationType.Find(_GetApplicationTypeID()).Fees.ToString();
        }
        public int _GetApplicationTypeID()
        {
            if(rbDamagedL.Checked)
            {
                return (int)clsApplication.enApplicationType.ReplaceDamagedDrivingLicense;
            }
            else
            {
                return (int)clsApplication.enApplicationType.ReplaceLostDrivingLicense;

            }

        }
        private enIssueReason _GetIssueReason()
        {
            //this will decide which reason to issue a replacement for

            if (rbDamagedL.Checked)

                return enIssueReason.DamagedReplacement;
            else
                return enIssueReason.LostReplacement;
        }



        private void rbLostL_CheckedChanged(object sender, EventArgs e)
        {
            lblTitel.Text = "Replecement for Lost License";
            this.Text = lblTitel.Text;

            lblAppFees.Text =
                clsApplicationType.Find(_GetApplicationTypeID()).Fees.ToString();
        }

        private void ctrlLicenseInfoWithFilter2_Load(object sender, EventArgs e)
        {

        }

        private void btnIssueReplacement_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Replace the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }


            clsLicense NewLicense =
                ctrlLicenseInfoWithFilter2.SelectedLicenseInfo.Replace(_GetIssueReason(), GlobalClass.CurrentUser.UserID);

            if(NewLicense == null )
            {
                MessageBox.Show("Faild to Issue a replacemnet for this  License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            lblRLAppID.Text = NewLicense.ApplicationID.ToString();
            _NewLicense = NewLicense.LicenseID;
            lblReplacedLicenseID.Text = _NewLicense.ToString();
            MessageBox.Show("Licensed Replaced Successfully with ID=" + _NewLicense.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnIssueReplacement.Enabled = false;
            ctrlLicenseInfoWithFilter2.FilterEnabled = false;
            grReplacement.Enabled = false;
            llblShowNewLicenseInfo.Enabled = true;

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llblShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(_NewLicense);
            frm.ShowDialog();
         }

        private void llblShowHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicenseHistory frm =
                new frmShowPersonLicenseHistory(ctrlLicenseInfoWithFilter2.SelectedLicenseInfo.DriversInfo.PersonID);
            frm.ShowDialog();
        }
    }
}
