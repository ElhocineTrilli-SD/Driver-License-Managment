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

namespace DVLD.Tests
{
    public partial class frmSechduelTest : Form
    {
        private int _LocalDrivingLicenseApplication = -1;
        private int _TestAppoitment = -1;
        private clsTestType.enTestType _testTypeID = clsTestType.enTestType.VisionTest;


        public frmSechduelTest(int Local,clsTestType.enTestType testType, int TestAppoitment = -1)
        {

            InitializeComponent();
            _LocalDrivingLicenseApplication = Local;
            _TestAppoitment = TestAppoitment;
            _testTypeID = testType;
        }

        private void frmSechduelTest_Load(object sender, EventArgs e)
        {
            ctrlSechduelTest1.TestTypeID = _testTypeID;
            ctrlSechduelTest1.LoadInfo(_LocalDrivingLicenseApplication, _TestAppoitment);

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
