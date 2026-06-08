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

namespace DVLD
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void linklblForgetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("This feature is Not Implemented Yet! ", "Not Ready", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
          clsUser user = clsUser.FindByUserNameAndPassword(txtUsername.Text.Trim(), txtPassword.Text.Trim());  

            if(user != null )
            {

                if (cbRememberMe.Checked)
                {
                    //store username and password
                    GlobalClass.RememberUsernameAndPassword(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                }
                else
                {
                    //store empty username and password
                    GlobalClass.RememberUsernameAndPassword("", "");
                }

                //incase the user is not active
                if (!user.IsActive)
                {

                    txtUsername.Focus();
                    MessageBox.Show("Your accound is not Active, Contact Admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                GlobalClass.CurrentUser = user;
                this.Hide();
                frmDashbord frm = new frmDashbord(this);
                frm.ShowDialog();

            }
            else
            {
                txtUsername.Focus();
                MessageBox.Show("Invalid Username/Password! ", "Wrong Credential",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            string username = "", password = "";

            if(GlobalClass.GetStoredCredential(ref username, ref password ))
            {
                txtUsername.Text = username;
                txtPassword.Text = password;
                cbRememberMe.Checked = true;

            }
            else
            {
                cbRememberMe.Checked= false;
            }




        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
