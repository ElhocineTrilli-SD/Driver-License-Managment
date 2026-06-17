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

namespace DVLD.Tests.Controlls
{
    public partial class ctrlsechdueldTest : UserControl
    {
        private clsTestType.enTestType _TestTypeID;
        private int _TestID = -1;

        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
        public clsTestType.enTestType TestTypeID
        {
            get
            {
                return _TestTypeID;
            }
            set
            {
                _TestTypeID = value;

                switch (_TestTypeID)
                {

                    case clsTestType.enTestType.VisionTest:
                        {
                            lblTitle.Text = "Vision Test";
                            picture.Image = Resources.eye_test;
                            break;
                        }

                    case clsTestType.enTestType.WrittenTest:
                        {
                            lblTitle.Text = "Written Test";
                            picture.Image = Resources.exam;
                            break;
                        }
                    case clsTestType.enTestType.StreetTest:
                        {
                            lblTitle.Text = "Street Test";
                            picture.Image = Resources.drive;
                            break;
                        }

                }

            }
        }

        public int TestAppointmentID
        {
            get
            {
                return _TestAppointmentID;
            }
        }

        public int TestID
        {
            get
            {
                return _TestID;
            }
        }

        private int _TestAppointmentID = -1;
        private int _LocalDrivingLicenseApplicationID = -1;
        private clsTestAppoitments _TestAppointment;

        public ctrlsechdueldTest()
        {
            InitializeComponent();
        }

        public  void LoadInfo(int testAppoitmentID)
        {
            _TestAppointmentID = testAppoitmentID;

            _TestAppointment = clsTestAppoitments.Find(_TestAppointmentID);

            //incase we did not find any appointment .
            if (_TestAppointment == null)
            {
                MessageBox.Show("Error: No  Appointment ID = " + _TestAppointmentID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _TestAppointmentID = -1;
                return;
            }

            _TestID = _TestAppointment.TestID ;

            _LocalDrivingLicenseApplicationID = _TestAppointment.LocalDrivingLicenseApplicationID;
            _LocalDrivingLicenseApplication = 
                clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseApplicationID);



            if (_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("Error: No Local Driving License Application with ID = " + _LocalDrivingLicenseApplicationID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblLocalDrivingLicenseAppID.Text = _LocalDrivingLicenseApplicationID.ToString();
            lblDrivingClass.Text = _LocalDrivingLicenseApplication.LicenseClassInfo.ClassName;

            lblTrial.Text = _LocalDrivingLicenseApplication.TotalTrialsPerTest(_TestTypeID).ToString();

            lblDate.Text = _TestAppointment.AppoitmentDate.ToShortDateString();

            lblFees.Text = _TestAppointment.PaidFees.ToString();

            lblTestID.Text = _TestAppointment.TestID.ToString();
        }


        private void grTestType_Enter(object sender, EventArgs e)
        {

        }
    }
}
