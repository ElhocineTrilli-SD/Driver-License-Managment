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

namespace DVLD.Applications.ApplicationType
{
    public partial class frmEditApplicationType : Form
    {
        private int _ApplicationTypeID = -1;
        private clsApplicationType _ApplicationType;

        public event Action DataUpdated;

        public frmEditApplicationType(int ApplicationTypeID)
        {
            InitializeComponent();
            _ApplicationTypeID = ApplicationTypeID;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void frmEditApplicationType_Load(object sender, EventArgs e)
        {
            lblID.Text = _ApplicationTypeID.ToString();

            _ApplicationType = clsApplicationType.Find(_ApplicationTypeID);

            if( _ApplicationType != null )
            {
                txtTitel.Text = _ApplicationType.Titel;
                txtFees.Text = _ApplicationType.Fees.ToString();
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
            if (_ApplicationType == null)
            {
                MessageBox.Show("_ApplicationType is null");
                return;
            }
            _ApplicationType.Titel = txtTitel.Text;
            _ApplicationType.Fees = Convert.ToSingle(txtFees.Text);

            if(_ApplicationType.Save() )
            {
            MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
                DataUpdated?.Invoke();
            } 
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void txtTitel_Validating(object sender, CancelEventArgs e)
        {
            if(String.IsNullOrEmpty(txtTitel.Text.Trim()))
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

            if(!clsValidation.IsNumber(txtFees.Text))
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
