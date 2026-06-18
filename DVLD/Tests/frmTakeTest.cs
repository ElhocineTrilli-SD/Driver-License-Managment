using DVLD.Globle_Classes;
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
    public partial class frmTakeTest : Form
    {
        private int _TestAppoitmentID;
        private clsTestType.enTestType _TestType;

        private int _testID;
        private clsTest _Test;
        public frmTakeTest(int TestAppoitment,clsTestType.enTestType testType)

        {
            InitializeComponent();
            _TestType = testType;
            _TestAppoitmentID = TestAppoitment;
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            ctrlsechdueldTest1.TestTypeID = _TestType;
            ctrlsechdueldTest1.LoadInfo(_TestAppoitmentID);

            if(ctrlsechdueldTest1.TestAppointmentID == -1)
            {
                btnsave.Enabled = false;
            }
            else { btnsave.Enabled = true; }

            int _TestID = ctrlsechdueldTest1.TestID;

            if (_TestID != -1)
            {
                _Test = clsTest.Find(_TestID);

                if (_Test.TestResult )
                    rbPass.Checked = true;
                else
                    rbFail.Checked = true;
                rtbNotes.Text = _Test.Notes;
                rbFail.Enabled = false;
                rbPass.Enabled = false;
                lblUserMessage.Visible = true;
            }
            else
                _Test = new clsTest();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save? After that you cannot change the Pass/Fail results after you save?.",
                   "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No
               )
            {
                return;
            }

            _Test.TestAppoitmentID = _TestAppoitmentID;
            _Test.TestResult = rbPass.Checked;
            _Test.Notes = rtbNotes.Text.Trim();
            _Test.CreatedByUserID = GlobalClass.CurrentUser.UserID;

            if(_Test.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnsave.Enabled = false;

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
