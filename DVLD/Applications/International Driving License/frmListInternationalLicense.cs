using DVLD.Licenses;
using DVLD.Licenses.International_License;
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

namespace DVLD.Applications.International_Driving_License
{
    public partial class frmListInternationalLicense : Form
    {
        private DataTable _Inter_License;

        public frmListInternationalLicense()
        {
            InitializeComponent();
        }
        private void _FillcbfilteringwithItems()
        {
            cbfilter.Items.Add("None");
            cbfilter.Items.Add("International License ID");
            cbfilter.Items.Add("Application ID");

            cbfilter.Items.Add("Driver ID");
            cbfilter.Items.Add("Local License ID");
            cbfilter.Items.Add("Is Active");


            cbfilter.SelectedIndex = 0;

        }
        public void _RefrechList()
        {
            _Inter_License = clsInternationalLicense.GetAllInternationalLicenses();
            dgvInter_License.DataSource = _Inter_License;
            _RefrechRecordCount();
        }
        public void _RefrechRecordCount()
        {
            int Records = dgvInter_License.RowCount;
            lblRecordsCount.Text = Records.ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNewInternationalLicenseApplication frm
                = new frmNewInternationalLicenseApplication();
            frm.ShowDialog();

            frmListInternationalLicense_Load(null, null);
        }

        private void cbfilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbfilter.SelectedIndex == 5)
            {
                cbIsActive.Visible = true;
                txtFilterValue.Visible = false;
                cbIsActive.Enabled = true;
                txtFilterValue.Enabled = false;
                cbIsActive.SelectedIndex = 0;
                cbIsActive.Focus();
            }
            else
            {

                txtFilterValue.Visible = (cbfilter.SelectedIndex != 0);

                if (cbfilter.SelectedIndex == 0)
                {
                    txtFilterValue.Enabled = false;
                    cbIsActive.Visible = false;

                }
                else
                {
                    txtFilterValue.Enabled = true;
                    txtFilterValue.Text = "";
                    txtFilterValue.Focus();
                }
            }
        }

        private void frmListInternationalLicense_Load(object sender, EventArgs e)
        {
            _RefrechList();
            _FillcbfilteringwithItems();
            if (dgvInter_License.Rows.Count > 0)
            {
                dgvInter_License.Columns[0].HeaderText = "Int.License ID";
                dgvInter_License.Columns[0].Width = 160;

                dgvInter_License.Columns[1].HeaderText = "Application ID";
                dgvInter_License.Columns[1].Width = 150;

                dgvInter_License.Columns[2].HeaderText = "Driver ID";
                dgvInter_License.Columns[2].Width = 130;

                dgvInter_License.Columns[3].HeaderText = "L.License ID";
                dgvInter_License.Columns[3].Width = 130;

                dgvInter_License.Columns[4].HeaderText = "Issue Date";
                dgvInter_License.Columns[4].Width = 180;

                dgvInter_License.Columns[5].HeaderText = "Expiration Date";
                dgvInter_License.Columns[5].Width = 180;

                dgvInter_License.Columns[6].HeaderText = "Is Active";
                dgvInter_License.Columns[6].Width = 120;

            }
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbfilter.Text != "None" && cbfilter.Text != "Is Active"  )
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = cbIsActive.Text;

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
                _Inter_License.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _Inter_License.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            lblRecordsCount.Text = _Inter_License.Rows.Count.ToString();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbfilter.Text)
            {
                case "International License ID":
                    FilterColumn = "InternationalLicenseID";
                    break;
                case "Application ID":
                    FilterColumn = "ApplicationID";
                    break;

                case "Driver ID":
                    FilterColumn = "DriverID";
                    break;


                case "Local License ID":
                    FilterColumn = "IssuedUsingLocalLicenseID";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _Inter_License.DefaultView.RowFilter = "";
                lblRecordsCount.Text = _Inter_License.Rows.Count.ToString();
                return;
            }

            DataColumn col = _Inter_License.Columns[FilterColumn];

             
                _Inter_License.DefaultView.RowFilter =
                    $"[{FilterColumn}] = {txtFilterValue.Text.Trim()}";
            

        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = (int)dgvInter_License.CurrentRow.Cells[2].Value;
            int PersonID = clsDrivers.FindByDriverID(DriverID).PersonID;

            ShowPersonDetails frm = new ShowPersonDetails(PersonID);
            frm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int InternationalLicenseID = (int)dgvInter_License.CurrentRow.Cells[0].Value;
            frmInternationalLicenseInfo frm = new frmInternationalLicenseInfo(InternationalLicenseID);
            frm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = (int)dgvInter_License.CurrentRow.Cells[2].Value;
            int PersonID = clsDrivers.FindByDriverID(DriverID).PersonID;

            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(PersonID);
            frm.ShowDialog();
        }
    }
}
