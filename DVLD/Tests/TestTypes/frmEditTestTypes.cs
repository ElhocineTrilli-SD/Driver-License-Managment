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

namespace DVLD.Tests.TestTypes
{
    public partial class frmEditTestTypes : Form
    {

        private clsTestType.enTestType _TestTypeID = clsTestType.enTestType.VisionTest;
        private clsTestType _TestType;

        public event Action DataUpdated;

        public frmEditTestTypes(clsTestType.enTestType ID)
        {
            InitializeComponent();
            _TestTypeID = ID;
        }

        private void frmEditTestTypes_Load(object sender, EventArgs e)
        {
           

            _TestType = clsTestType.Find(_TestTypeID);

            if (_TestType != null)
            {
                lblID.Text = ((int)_TestTypeID).ToString();
                txtTitel.Text = _TestType.Titel;
                txtDescription.Text = _TestType.Description;
                txtFees.Text = _TestType.Fees.ToString();

            }
            else
            {
                MessageBox.Show("Could not find Test Type with ID " + _TestTypeID, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }


        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            _TestType.Titel = txtTitel.Text.Trim();
            _TestType.Description = txtDescription.Text.Trim();
            _TestType.Fees = Convert.ToSingle(txtFees.Text.Trim());

            if(_TestType.Save())
            {
                
                    MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    DataUpdated?.Invoke();
            }
            else
                    MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTitel_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtTitel.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTitel, "Titel Cannot be Empty!");
            }
            else
            {
                errorProvider1.SetError(txtTitel, null);
            }
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtTitel.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTitel, "Titel Cannot be Empty!");
            }
            else
            {
                errorProvider1.SetError(txtTitel, null);
            }
        }

        private void txtFees_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "Fees Cannot be Empty!");
            }
            else
            {
                errorProvider1.SetError(txtFees, null);
            }

            if (!clsValidation.IsNumber(txtFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "Envalid Number !");
            }
            else
            {
                errorProvider1.SetError(txtFees, null);
            }
        }
    }
}
