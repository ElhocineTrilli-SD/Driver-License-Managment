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

namespace DVLD.Licenses.Control
{
    public partial class ctrlLicenseInfoWithFilter : UserControl
    {
        // Define a custom event handler delegate with parameters
        public event Action<int> OnLicenseSelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void LicenseSelected(int LicenseID)
        {
            Action<int> handler = OnLicenseSelected;
            if (handler != null)
            {
                handler(LicenseID); // Raise the event with the parameter
            }
        }

        private int _LicenseID;
        private bool _FilterEnabled = true;

        public bool FilterEnabled
        {
            get { return _FilterEnabled; }
            set {
                _FilterEnabled = value;
                Filter.Enabled = _FilterEnabled;
            }
        }

        public int LicenseID
        {
            get { return ctrlLicenseInfo1.LicenseID; }
        }

        public clsLicense SelectedLicenseInfo
        {
            get { return ctrlLicenseInfo1.SelectedLicenseInfo;  }
        }

        public void LoadLicenseInfo(int licenseID)
        {
            txtFilter.Text = licenseID.ToString();
            ctrlLicenseInfo1.LoadInfo(licenseID);
            _LicenseID = ctrlLicenseInfo1.LicenseID;
            if(OnLicenseSelected != null && FilterEnabled)
            {
                LicenseSelected(licenseID);
            }
        }


        public ctrlLicenseInfoWithFilter()
        {
            InitializeComponent();
        }
        public void FilterFocus()
        {
            txtFilter.Focus();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            _LicenseID = int.Parse(txtFilter.Text);
            ctrlLicenseInfo1.LoadInfo(_LicenseID);
        }

        private void txtFilter_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilter.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilter, "This Field is required!");
            }
            else
            {
                errorProvider1.SetError(txtFilter, null);
            }
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);  

            if(e.KeyChar == (char)13)
            {
                btnSearch.PerformClick();
            }

        }
    }
}
