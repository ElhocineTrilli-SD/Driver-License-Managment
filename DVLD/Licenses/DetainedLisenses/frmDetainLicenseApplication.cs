using DVLD.Globle_Classes;
using DVLD.Licenses.LocalLicenses;
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
    public partial class frmDetainLicenseApplication : Form
    {
        private int _DetainID = -1;
        private int _SelectedLicenseID = -1;

        public frmDetainLicenseApplication()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            //are you sure.
          if(  MessageBox.Show("Are you sure you want to detain this license!",
                "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.No     )
            {
                return;
            }

            _DetainID = ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.
                Detain( Convert.ToSingle(txtFineFees.Text), GlobalClass.CurrentUser.UserID);
            if (_DetainID == -1)
            {
                MessageBox.Show("Faild to Detain License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            lblDetainID.Text = _DetainID.ToString();
            MessageBox.Show("License Detained Successfully with ID=" + _DetainID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnDetain.Enabled = false;
            ctrlLicenseInfoWithFilter1.FilterEnabled = false;
            txtFineFees.Enabled = false;
            llblShowLicenseInfo.Enabled = true;
        }

        private void frmDetainLicenseApplication_Load(object sender, EventArgs e)
        {
            ctrlLicenseInfoWithFilter1.Focus();
            lblCreatedBy.Text = GlobalClass.CurrentUser.UserName;

            lblDtainDate.Text = DateTime.Now.ToString("dd MM yyyy");

        }

        private void SelectedLicenseID(int obj)
        {
            _SelectedLicenseID = obj;
            lblLicenseID.Text = _SelectedLicenseID.ToString();
            llblShowHistory.Enabled = (_SelectedLicenseID != -1);

            if(_SelectedLicenseID ==  -1)
            {
                return;
            }


            // malke sure thet id is not already detained;
            if(ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.IsDetained)
            {
                MessageBox.Show("Selected License is Already Detained.choose another one.", "error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtFineFees.Focus();
            btnDetain.Enabled = true;
        }

        private void llblShowHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicenseHistory frm =
                new frmShowPersonLicenseHistory(ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.DriversInfo.PersonID);
            frm.ShowDialog();
        }

        private void llblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm =
                new frmShowLicenseInfo(_SelectedLicenseID);
            frm.ShowDialog();
        }

        private void txtFineFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFineFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFineFees, "Fees cannot be empty!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtFineFees, null);

            }
            ;


            if (!clsValidation.IsNumber(txtFineFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFineFees, "Invalid Number.");
            }
            else
            {
                errorProvider1.SetError(txtFineFees, null);
            }
            ;
        }
    }
}
