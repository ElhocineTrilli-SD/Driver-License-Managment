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

namespace DVLD.Users
{
    public partial class frmChangePassword : Form
    {

        private int _UserID = -1;
        clsUser _User;

        public frmChangePassword(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            _User = clsUser.FindByUserID(_UserID);

            if (_User == null)
            {
                MessageBox.Show("No User With this ID " + _UserID, "User Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
                return;
            }
            ctrlUserCard1.LoadUserInfo(_UserID);
            btnclose.CausesValidation = false;
        }

        private void _ResetDefaultValues()
        {
            txtCurrentPass.Text = "";
            txtNewPassword.Text = "";
            txtConfirm_Password.Text = "";
            txtCurrentPass.Focus();
        }

        private void txtCurrentPass_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtCurrentPass.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPass, "Password can not be empty");
            }
            else
            {
                errorProvider1.SetError(txtCurrentPass, null );
            }

            if(_User.Password  != txtCurrentPass.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPass, "Current Password wrong.");
            }
            else
            {
                errorProvider1.SetError(txtCurrentPass, null);
            }


        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword, "New Password can not be empty");
            }
            else
            {
                errorProvider1.SetError(txtNewPassword, null);
            }
            if (txtNewPassword.Text == txtConfirm_Password.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword, "It is match the Current Password Try another Password!");
            }
            else
            {
                errorProvider1.SetError(txtNewPassword, "");

            }
        }

        private void txtConfirm_Password_Validating(object sender, CancelEventArgs e)
        {

            if(txtNewPassword.Text.Trim() != txtConfirm_Password.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirm_Password, "Password Confirmayion does not match the new password!");

            }
            else
            {
                errorProvider1.SetError(txtConfirm_Password, null);
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

            _User.Password = txtNewPassword.Text;

            if(_User.Save())
            {
                MessageBox.Show("Passwors changed Successfully","Saved",MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                _ResetDefaultValues();
            }
            else
            {
                MessageBox.Show("An Error Accured, Password did not change", "Error", MessageBoxButtons.OK
                   , MessageBoxIcon.Error);
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
