using DVLD.Properties;
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
using static DVLD_BUSINESS.clsTestType;

namespace DVLD.Tests
{
    public partial class frmListTestAppoitment : Form
    {
        public DataTable _dtLicenseAppoitment;
        private int _LocalDrivingLicenseApplication = -1;
        private clsTestType.enTestType _testType = clsTestType.enTestType.VisionTest;

        public frmListTestAppoitment(int Local, clsTestType.enTestType testType)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplication = Local;
            _testType = testType;
        }
        private void _LoadTestTypeImageAndTitle()
        {
            switch (_testType)
            {

                case clsTestType.enTestType.VisionTest:
                    {
                        lblTitle.Text = "Vision Test Appointments";
                        this.Text = lblTitle.Text;
                        picture.Image = Resources.eye_test;
                        break;
                    }

                case clsTestType.enTestType.WrittenTest:
                    {
                        lblTitle.Text = "Written Test Appointments";
                        this.Text = lblTitle.Text;
                        picture.Image = Resources.examination;
                        break;
                    }
                case clsTestType.enTestType.StreetTest:
                    {
                        lblTitle.Text = "Street Test Appointments";
                        this.Text = lblTitle.Text;
                        picture.Image = Resources.drive;
                        break;
                    }
            }
        }
        private void frmListTestAppoitment_Load(object sender, EventArgs e)
        {
            _LoadTestTypeImageAndTitle();

            ctrlDrivingLicenseApplication1.LoadApplicationInfoByLocalDrivingAppID(_LocalDrivingLicenseApplication);
            _dtLicenseAppoitment =
                clsTestAppoitments.GetApplicationTestAppointmentsPerTestType(_LocalDrivingLicenseApplication, _testType);
            dgvLicenseTestAppointments.DataSource = _dtLicenseAppoitment;

            if (dgvLicenseTestAppointments.Rows.Count > 0)
            {
                dgvLicenseTestAppointments.Columns[0].HeaderText = "Appointment ID";
                dgvLicenseTestAppointments.Columns[0].Width = 150;

                dgvLicenseTestAppointments.Columns[1].HeaderText = "Appointment Date";
                dgvLicenseTestAppointments.Columns[1].Width = 200;

                dgvLicenseTestAppointments.Columns[2].HeaderText = "Paid Fees";
                dgvLicenseTestAppointments.Columns[2].Width = 150;

                dgvLicenseTestAppointments.Columns[3].HeaderText = "Is Locked";
                dgvLicenseTestAppointments.Columns[3].Width = 100;
            }

            lblRecordsCountAppoitment.Text = dgvLicenseTestAppointments.RowCount.ToString();



        }

        private void btnAddAppoitment_Click(object sender, EventArgs e)
        {
            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication =
                clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseApplication);

            if(LocalDrivingLicenseApplication.IsThereAnActiveScheduledTest(_testType))
                {
                MessageBox.Show("Person Already have an active appoitment","error",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
                 }

            clsTest LastTest = LocalDrivingLicenseApplication.GetLastTestByTesttype(_testType);

            if(LastTest == null)
            {
                frmSechduelTest frm1 = new frmSechduelTest(_LocalDrivingLicenseApplication, _testType);
                frm1.ShowDialog();
                frmListTestAppoitment_Load(null, null);
                return;

            }


            if(LastTest.TestResult)
            {
                MessageBox.Show("This person already passed this test before, you can only retake faild test", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmSechduelTest frm = new frmSechduelTest(LastTest._TestAppoitmentsInfo.LocalDrivingLicenseApplicationID,_testType);
            frm.ShowDialog();
            frmListTestAppoitment_Load(null, null);

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppoitment = (int)dgvLicenseTestAppointments.CurrentRow.Cells[0].Value;

            frmSechduelTest frm = new frmSechduelTest(_LocalDrivingLicenseApplication,_testType, TestAppoitment);
            frm.ShowDialog();
            frmListTestAppoitment_Load(null, null);

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            int TestAppointmentID = (int)dgvLicenseTestAppointments.CurrentRow.Cells[0].Value;


            frmTakeTest frm = new frmTakeTest(TestAppointmentID, _testType);
            frm.ShowDialog();


        }
    }
}
