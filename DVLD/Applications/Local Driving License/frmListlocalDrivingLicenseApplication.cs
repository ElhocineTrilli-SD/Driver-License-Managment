using DVLD.Licenses.LocalLicenses;
using DVLD.Tests;
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

        private void cencelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure do want to cancel this Application", "Confirm"
               , MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                return;
            }
            int LocalDrivingLicenseApplicationID = (int)dgvLD.CurrentRow.Cells[0].Value;

            clsLocalDrivingLicenseApplication cls =
                clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseApplicationID);

            if(cls != null)
            {
                if(cls.Cancel())
                {
                    MessageBox.Show("Application Canceled Successfully", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmListlocalDrivingLicenseApplication_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Could Not Canceled Application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            


            }


        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalDrivingLicenseApplicationInfo frm = new frmLocalDrivingLicenseApplicationInfo((int)dgvLD.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            frmListlocalDrivingLicenseApplication_Load(null,null);
        }

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdd_EditLocalDrivingLicenseApplication frm = new frmAdd_EditLocalDrivingLicenseApplication((int)dgvLD.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListlocalDrivingLicenseApplication_Load(null, null);

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Are you Sure do want to delete this Application","Confirm"
                ,MessageBoxButtons.OKCancel  ) != DialogResult.OK)
            {
                return;
            }

            int LocalDrivingLicenseApplicationID = (int)dgvLD.CurrentRow.Cells[0].Value;

            clsLocalDrivingLicenseApplication cls = 
                clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseApplicationID);
            
            if( cls != null )
            {
                if(cls.Delete())
                {
                    MessageBox.Show("Application Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmListlocalDrivingLicenseApplication_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Could Not Deleted Application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }



            }




        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)dgvLD.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication =
                    clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID
                                                    (LocalDrivingLicenseApplicationID);

            int TotalPassedTests = (int)dgvLD.CurrentRow.Cells[5].Value;

            bool LicenseExists = LocalDrivingLicenseApplication.IsLicenseIssued();

            //Enabled only if person passed all tests and Does not have license. 
            issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = (TotalPassedTests == 3) && !LicenseExists;

            showLicenseToolStripMenuItem.Enabled = LicenseExists;
            editToolStripMenuItem.Enabled = !LicenseExists && (LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);
            ScheduleTestsMenue.Enabled = !LicenseExists;

            //Enable/Disable Cancel Menue Item
            //We only canel the applications with status=new.
            CancelApplicaitonToolStripMenuItem.Enabled = (LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);

            //Enable/Disable Delete Menue Item
            //We only allow delete incase the application status is new not complete or Cancelled.
            DeleteApplicationToolStripMenuItem.Enabled =
                (LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);



            //Enable Disable Schedule menue and it's sub menue
            bool PassedVisionTest = LocalDrivingLicenseApplication.DoesPassTestType(clsTestType.enTestType.VisionTest); ;
            bool PassedWrittenTest = LocalDrivingLicenseApplication.DoesPassTestType(clsTestType.enTestType.WrittenTest);
            bool PassedStreetTest = LocalDrivingLicenseApplication.DoesPassTestType(clsTestType.enTestType.StreetTest);

            ScheduleTestsMenue.Enabled = (!PassedVisionTest || !PassedWrittenTest || !PassedStreetTest) && (LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);

            if (ScheduleTestsMenue.Enabled)
            {
                //To Allow Schdule vision test, Person must not passed the same test before.
                scheduleVisionTestToolStripMenuItem.Enabled = !PassedVisionTest;

                //To Allow Schdule written test, Person must pass the vision test and must not passed the same test before.
                scheduleWrittenTestToolStripMenuItem.Enabled = PassedVisionTest && !PassedWrittenTest;

                //To Allow Schdule steet test, Person must pass the vision * written tests, and must not passed the same test before.
                scheduleStreetTestToolStripMenuItem.Enabled = PassedVisionTest && PassedWrittenTest && !PassedStreetTest;

            }

        }

        
        private void _ScheduleTest(clsTestType.enTestType TestType)
        {

            int LocalDrivingLicenseApplicationID = (int)dgvLD.CurrentRow.Cells[0].Value;
            frmListTestAppoitment frm = new frmListTestAppoitment(LocalDrivingLicenseApplicationID, TestType);
            frm.ShowDialog();
            //refresh
            frmListlocalDrivingLicenseApplication_Load(null, null);

        }
        private void sechduelVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ScheduleTest(clsTestType.enTestType.VisionTest);   
        }

        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ScheduleTest(clsTestType.enTestType.WrittenTest);

        }

        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ScheduleTest(clsTestType.enTestType.StreetTest);

        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)dgvLD.CurrentRow.Cells[0].Value;
            frmIssueLicenseForthefirsttime frm = new frmIssueLicenseForthefirsttime(LocalDrivingLicenseApplicationID);
            frm.ShowDialog();

            frmListlocalDrivingLicenseApplication_Load(null, null);
        }
    }
}
