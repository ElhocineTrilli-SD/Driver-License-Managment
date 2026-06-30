using DVLD.Licenses;
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

namespace DVLD.Dricers
{

    public partial class frmListDrivers : Form
    {

        private DataTable _DtDrivers;


        public frmListDrivers()
        {
            InitializeComponent();
        }
        public void _RefrechDriversList()
        {
            _DtDrivers = clsDrivers.GetAllDrivers();
            dgvDrivers.DataSource = _DtDrivers;
            _RefrechRecordCount();
        }

        private void _RefrechRecordCount()
        {
            int Record = dgvDrivers.RowCount;
            lblRecordsCount.Text = Record.ToString();

        }

        private void frmListDrivers_Load(object sender, EventArgs e)
        {
            _RefrechDriversList();
            _FillcbfilteringwithItems();
            if (dgvDrivers.RowCount > 0)
            {
                dgvDrivers.Columns[0].HeaderText = "Driver ID";
                dgvDrivers.Columns[0].Width = 90;

                dgvDrivers.Columns[1].HeaderText = "Person ID";
                dgvDrivers.Columns[1].Width = 90;

                dgvDrivers.Columns[2].HeaderText = "NationalNo";
                dgvDrivers.Columns[2].Width = 90;

                dgvDrivers.Columns[3].HeaderText = "Full Name";
                dgvDrivers.Columns[3].Width = 250;

                dgvDrivers.Columns[4].HeaderText = "Date";
                dgvDrivers.Columns[4].Width = 110;

                dgvDrivers.Columns[5].HeaderText = "Is Active";
                dgvDrivers.Columns[5].Width = 120;

            }
        }

        private void _FillcbfilteringwithItems()
        {
            cbfilter.Items.Add("None");
            cbfilter.Items.Add("Driver ID");
            cbfilter.Items.Add("Person ID");
            cbfilter.Items.Add("NationalNo");
            cbfilter.Items.Add("Full Name");

            cbfilter.SelectedIndex = 0;

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbfilter.Text == "Driver ID" || cbfilter.Text == "Person ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);


            }
        }

        private void cbfilter_SelectedIndexChanged(object sender, EventArgs e)
        {
          txtFilterValue.Visible = (cbfilter.SelectedIndex != 0);

            if(cbfilter.Text == "None")
            {
                txtFilterValue.Enabled = false;
            }
            else
            {
                txtFilterValue.Enabled = true;
                txtFilterValue.Focus();
                txtFilterValue.Text = "";
            }

        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbfilter.Text)
            {
                case "Driver ID":
                    FilterColumn = "DriverID";
                    break;
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "NationalNo":
                    FilterColumn = "NationalNo";
                    break;


                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                //case "Date":
                //    FilterColumn = "Date";
                //    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            if (txtFilterValue.Text == "" || FilterColumn == "None")
            {
                _DtDrivers.DefaultView.RowFilter = "";
                lblRecordsCount.Text = _DtDrivers.Rows.Count.ToString();
                return;
            }

            if (FilterColumn != "FullName" || FilterColumn != "NationalNo")
            {
                _DtDrivers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());

            }
            else
                _DtDrivers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = _DtDrivers.Rows.Count.ToString();

        }

        private void showDriverInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ShowPersonDetails showPerson = new ShowPersonDetails((int)dgvDrivers.CurrentRow.Cells[1].Value);
            showPerson.ShowDialog();
        }

       

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory((int)dgvDrivers.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }
    }
    
}
