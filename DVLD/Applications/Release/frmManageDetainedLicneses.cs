using DVLD.Licenses;
using DVLD.Licenses.DetainedLisenses;
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

namespace DVLD.Applications.Release
{
    public partial class frmManageDetainedLicneses : Form
    {
        public frmManageDetainedLicneses()
        {
            InitializeComponent();
        }
        public DataTable _dtDetained;
        private void _FillcbfilteringwithItems()
        {
            cbfilter.Items.Add("None");
            cbfilter.Items.Add("Detained ID");
            cbfilter.Items.Add("Is Release");
            cbfilter.Items.Add("NationalNo");
            cbfilter.Items.Add("Full Name");
            cbfilter.Items.Add("Release Application ID");
            cbfilter.SelectedIndex = 0;

        }
        public void _RefrechList()
        {
            _dtDetained = clsDetainedLicense.GetAllDetainedLicenses();
            dgvDetainedLicense.DataSource = _dtDetained;
            _RefrechRecordCount();
        }
        public void _RefrechRecordCount()
        {
            int Records = dgvDetainedLicense.RowCount;
            lblRecordsCountUser.Text = Records.ToString();
        }
        private void frmManageDetainedLicneses_Load(object sender, EventArgs e)
        {
            _RefrechList();
            _FillcbfilteringwithItems();

            if(_dtDetained.Rows.Count > 0 )
            {
                dgvDetainedLicense.Columns[0].HeaderText = "D.ID";
                dgvDetainedLicense.Columns[0].Width = 90;

                dgvDetainedLicense.Columns[1].HeaderText = "L.ID";
                dgvDetainedLicense.Columns[1].Width = 90;

                dgvDetainedLicense.Columns[2].HeaderText = "D.Date";
                dgvDetainedLicense.Columns[2].Width = 130;

                dgvDetainedLicense.Columns[3].HeaderText = "Is Released";
                dgvDetainedLicense.Columns[3].Width = 110;

                dgvDetainedLicense.Columns[4].HeaderText = "Fine Fees";
                dgvDetainedLicense.Columns[4].Width = 110;

                dgvDetainedLicense.Columns[5].HeaderText = "Release Date";
                dgvDetainedLicense.Columns[5].Width = 130;

                dgvDetainedLicense.Columns[6].HeaderText = "N.No.";
                dgvDetainedLicense.Columns[6].Width = 90;

                dgvDetainedLicense.Columns[7].HeaderText = "Full Name";
                dgvDetainedLicense.Columns[7].Width = 300;

                dgvDetainedLicense.Columns[8].HeaderText = "Rlease App.ID";
                dgvDetainedLicense.Columns[8].Width = 150;

            }
        }
        private void cbfilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbfilter.Text == "Is Release")
            {
                txtFilterValue.Visible = false;
                cbisRelease.Visible = true;
                cbisRelease.Focus();
                cbisRelease.SelectedIndex = 0;

            }
            else
            {
                txtFilterValue.Visible = (cbfilter.Text != "None");
                    cbisRelease.Visible = false;

                if(cbfilter.Text == "None")
                {
                    txtFilterValue.Enabled = false;

                }
                else
                {
                    txtFilterValue.Enabled= true;
                    txtFilterValue.Focus();
                    txtFilterValue.Text = "";
                }

            }



        }
        private void cbisRelease_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsReleased";
            string FilterValue = cbisRelease.Text;

            switch (FilterValue)
            {
                case "All":
                    break;
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
            }


            if (FilterValue == "All")
                _dtDetained.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _dtDetained.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            lblRecordsCountUser.Text = _dtDetained.Rows.Count.ToString();
        }
        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbfilter.Text)
            {
                case "Detained ID":
                    FilterColumn = "DetainID";
                    break;
                case "Is Release":
                    FilterColumn = "IsRelease";
                    break;

                case "NationalNo":
                    FilterColumn = "NationalNo";
                    break;


                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                    
                case "Release Application ID":
                    FilterColumn = "ReleaseApplicationID";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtDetained.DefaultView.RowFilter = "";
                lblRecordsCountUser.Text = _dtDetained.Rows.Count.ToString();
                return;
            }


            if (FilterColumn != "FullName" && FilterColumn != "NationalNo")
                //in this case we deal with numbers not string.
                _dtDetained.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtDetained.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCountUser.Text = _dtDetained.Rows.Count.ToString();



        }
        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //we allow number incase person id or user id is selected.
            if (cbfilter.Text == "Detained ID" || cbfilter.Text == "Release Application ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowLicenseInfo frm
                = new frmShowLicenseInfo((int)dgvDetainedLicense.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }
        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvDetainedLicense.CurrentRow.Cells[1].Value;
            int PersonID = clsLicense.Find(LicenseID).DriversInfo.PersonID;

            ShowPersonDetails frm =
                new ShowPersonDetails(PersonID) ;
            frm.ShowDialog();
        }
        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvDetainedLicense.CurrentRow.Cells[1].Value;
            int PersonID = clsLicense.Find(LicenseID).DriversInfo.PersonID;

            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(PersonID) ;
            frm.ShowDialog();
        }

        private void releasedDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedlicense frm = new frmReleaseDetainedlicense((int)dgvDetainedLicense.CurrentRow.Cells[1].Value) ;
            frm.ShowDialog();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedlicense frm =
                new frmReleaseDetainedlicense();
            frm.ShowDialog();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            frmDetainLicenseApplication frm = new frmDetainLicenseApplication();
            frm.ShowDialog();
        }
    }
}
