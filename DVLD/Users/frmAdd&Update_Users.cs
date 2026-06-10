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
    public partial class frmAdd_Update_Users : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private int _UserID = -1;
        clsUser _User;

        public frmAdd_Update_Users()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAdd_Update_Users(int UserID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _UserID = UserID;
        }

        private void frmAdd_Update_Users_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if(_Mode == enMode.Update)
            {
                _DataLoad();
            }

        }

        private void _DataLoad()
        {
            _User = clsUser.FindByUserID(_UserID);
            personInfoWithFilter11.FilterEnabled = false;

            if(_User == null)
            {
                MessageBox.Show("No User With this ID "+_UserID,"User Not Found",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);

                this.Close();
                return;
            }

            txtUserID.Text = _User.UserID.ToString();
            txtUserName.Text = _User.UserName.ToString();
            txtPassword.Text = _User.Password.ToString();
            txtConfirm_Password.Text = _User.Password.ToString();
            cbIsActive.Checked = _User.IsActive;
            personInfoWithFilter11.LoadPersonInfo(_User.PersonID);
        }

        private void _ResetDefaultValues()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitel.Text = "Add New User";
                this.Text = "Add New User";
                _User = new clsUser();

                

                personInfoWithFilter11.FilterFocus();

            }
            else
            {
                lblTitel.Text = "Update User";
                this.Text = "Update User";

                btnsave.Enabled = true;

            }

            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirm_Password.Text = "";
            cbIsActive.Checked = true;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(_Mode == enMode.Update)
            {
                tbUserInfo.SelectedTab = tbLogIn_Info;

                // tbUserInfo.SelectedTab = tbUserInfo.TabPages["tbLogIn_Info"];
                btnsave.Enabled = true;
                return;
            }

            if(personInfoWithFilter11.PersonID != -1)
            {
                if (clsUser.isUserExistForPersonID(personInfoWithFilter11.PersonID))
                {

                    MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    personInfoWithFilter11.FilterFocus();
                }

                else
                {
                    btnsave.Enabled = true;
                    tbLogIn_Info.Enabled = true;
                    tbUserInfo.SelectedTab = tbLogIn_Info;
                }


            }

            else

            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                personInfoWithFilter11.FilterFocus();

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

            _User.PersonID = personInfoWithFilter11.PersonID;
            _User.UserName = txtUserName.Text.Trim();
            _User.Password = txtPassword.Text.Trim();
            _User.IsActive = cbIsActive.Checked;


            if (_User.Save())
            {
               txtUserID.Text = _User.UserID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lblTitel.Text = "Update User";
                this.Text = "Update User";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void txtConfirm_Password_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirm_Password.Text.Trim() != txtPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirm_Password, "Password Confirmation does not match Password!");
            }
            else
            {
                errorProvider1.SetError(txtConfirm_Password, null);
            }
            ;
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Password cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            }
            ;
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            }
            ;

            if (_Mode == enMode.AddNew)
            {

                if (clsUser.IsUserExist(txtUserName.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtUserName, "username is used by another user");
                }
                else
                {
                    errorProvider1.SetError(txtUserName, null);
                }
                ;
            }
            else
            {
                //incase update make sure not to use anothers user name
                if (_User.UserName != txtUserName.Text.Trim())
                {
                    if (clsUser.IsUserExist(txtUserName.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txtUserName, "username is used by another user");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txtUserName, null);
                    }
                    ;
                }
            }
        }

        private void frmAdd_Update_Users_Activated(object sender, EventArgs e)
        {
            personInfoWithFilter11.FilterFocus();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
