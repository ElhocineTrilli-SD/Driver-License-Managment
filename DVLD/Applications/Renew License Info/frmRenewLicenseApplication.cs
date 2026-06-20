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

namespace DVLD.Applications.Renew_License_Info
{
    public partial class frmRenewLicenseApplication : Form
    {
        private int _NewLicenseID = -1;
        public frmRenewLicenseApplication()
        {
            InitializeComponent();
        }

        private void frmRenewLicenseApplication_Load(object sender, EventArgs e)
        {
            ctrlLicenseInfoWithFilter1.FilterFocus();

            lblAppDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblIssueDate.Text = lblAppDate.Text;

            lblExpDate.Text = "???";
            lblAppFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.RenewDrivingLicense).Fees.ToString();
            lblCreatedBy.Text = GlobalClass.CurrentUser.UserName;
        }

        private void ctrlLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            int SelectedLicenseID = obj;

            lblOldLicenseID.Text = SelectedLicenseID.ToString();
            llblShowHistory.Enabled = (SelectedLicenseID != -1);

            if (SelectedLicenseID == -1) { return; }

            int defaultValidityLength = ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClassIfo.DefaultValidityLength;
            lblExpDate.Text = DateTime.Now.AddYears(defaultValidityLength).ToString();
            lblLicenseFees.Text = ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClassIfo.ClassFees.ToString();
            lblTotalFees.Text = (Convert.ToSingle(lblAppFees.Text) + Convert.ToSingle(lblLicenseFees.Text)).ToString();
            txtNotes.Text = ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.Notes;

            if (!ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.IsLicenseExpired())
            {
                MessageBox.Show("Selected License Is not yet expired,it will expired : "
                    + ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.ExpirationDate.ToString("dd mm yyyy"),"Not Allowed"
                    ,MessageBoxButtons.OK,MessageBoxIcon.Error);
                btnRenew.Enabled = false;
                return;
            }

            //check the license is not Active.
            if (!ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.IsActive)
            {
                MessageBox.Show("Selected License is not Not Active, choose an active license."
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenew.Enabled = false;
                return;
            }

            btnRenew.Enabled = true;
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Renew the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }


            clsLicense NewLicense =
                ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.RenewLicense(txtNotes.Text.Trim(),
                GlobalClass.CurrentUser.UserID);

            if (NewLicense == null)
            {
                MessageBox.Show("Faild to Renew the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            lblRLAppID.Text = NewLicense.ApplicationID.ToString();
            _NewLicenseID = NewLicense.LicenseID;
            lblRenewedLicenseID.Text = _NewLicenseID.ToString();

            MessageBox.Show("Licensed Renewed Successfully with ID=" + _NewLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ctrlLicenseInfoWithFilter1.FilterEnabled = false;
            btnRenew.Enabled =false;
            llblShowNewLicenseInfo.Enabled = true;
        }

        private void llblShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm =
               new frmShowLicenseInfo(_NewLicenseID);
            frm.ShowDialog();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
