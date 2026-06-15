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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD.Applications.Local_Driving_License
{
    public partial class frmListlocalDrivingLicenseApplication : Form
    {
        public delegate void handler(object sender, int records);

        // Declare an event using the delegate
        public event handler DataBack;


        private DataTable _LDA = clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();

        public frmListlocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }
        private void _FillcbfilteringwithItems()
        {
           cbfilterLD.Items.Add("None");
           cbfilterLD.Items.Add("L.D.L AppID");
           cbfilterLD.Items.Add("NationalNO");
          
           cbfilterLD.Items.Add("Full Name");
           cbfilterLD.Items.Add("Status");

           cbfilterLD.SelectedIndex = 0;

        }

        public void _RefrechUserList()
        {
            dgvLD.DataSource = _LDA ;
            _RefrechRecordCount();
        }
        public void _RefrechRecordCount()
        {
            int Records = dgvLD.RowCount;
            lblRecordsCountLD.Text = Records.ToString();


            DataBack?.Invoke(this, Records);
        }
        private void frmListlocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            _RefrechUserList();
            _FillcbfilteringwithItems();

            if(_LDA.Rows.Count > 0)
            {
                dgvLD.Columns[0].HeaderText = "D.L.AppID";
                dgvLD.Columns[0].Width = 110;

                dgvLD.Columns[1].HeaderText = "Driving Class";
                dgvLD.Columns[1].Width = 220;

                dgvLD.Columns[2].HeaderText = "NationalNO";
                dgvLD.Columns[2].Width = 110;

                dgvLD.Columns[3].HeaderText = "Full Name";
                dgvLD.Columns[3].Width = 250;

                dgvLD.Columns[4].HeaderText = "Application Date";
                dgvLD.Columns[4].Width = 160;

                dgvLD.Columns[4].HeaderText = "Passed Tests";
                dgvLD.Columns[4].Width = 160;

                dgvLD.Columns[4].HeaderText = "Status";
                dgvLD.Columns[4].Width = 120;


            }

        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbfilterLD.Text == "L.D.L AppID" )
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAdd_EditLocalDrivingLicenseApplication frm = new frmAdd_EditLocalDrivingLicenseApplication();
            frm.ShowDialog();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbfilterLD.Text)
            {
                case "L.D.L AppID":
                    FilterColumn = "LocalDrivingLicenseApplicationID";
                    break;
                case "NationalNO":
                    FilterColumn = "NationalNo";
                    break;

                case "Full Name":
                    FilterColumn = "FullName";
                    break;


                case "Status":
                    FilterColumn = "Status";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _LDA.DefaultView.RowFilter = "";
                lblRecordsCountLD.Text = _LDA.Rows.Count.ToString();
                return;
            }

            DataColumn col = _LDA.Columns[FilterColumn];

            if (col.DataType == typeof(string))
            {
                _LDA.DefaultView.RowFilter =
                    $"[{FilterColumn}] LIKE '{txtFilterValue.Text.Trim()}%'";
            }
            else
            {
                _LDA.DefaultView.RowFilter =
                    $"[{FilterColumn}] = {txtFilterValue.Text.Trim()}";
            }

        }

        private void cbfilterLD_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            txtFilterValue.Visible = (cbfilterLD.SelectedIndex != 0);

            if(cbfilterLD.SelectedIndex == 0)
            {
                txtFilterValue.Enabled = false;
            }
            else
            {
                txtFilterValue.Enabled= true;
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }

        }
    }
}
