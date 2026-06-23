using DVLD.Application.ApplicationType;
using DVLD.Applications.Local_Driving_License;
using DVLD.Applications.Renew_License_Info;
using DVLD.Applications.ReplaceLostOrDamagedLicense;
using DVLD.Dricers;
using DVLD.Globle_Classes;
using DVLD.Tests.TestTypes;
using DVLD.Users;
using DVLD_BUSINESS;
using Guna.UI2.WinForms;
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
    public partial class frmDashbord : Form
    {
       
        frmLogIn _frmLogin;
        public frmDashbord(frmLogIn frm)
        {
            InitializeComponent();
            _frmLogin = frm;
        }

        //private void ActiveButton(Guna2Button btn)
        //{
        //    btn.ForeColor = Color.DarkOrange;
        //    btn.FillColor = Color.FromArgb(35,35,48);
        //}
        //private void inActiveButton(Guna2Button btn)
        //{
        //    btn.ForeColor = Color.DarkOrange;
        //    btn.FillColor = Color.FromArgb(35, 35, 48);
        //}

        private void OpenManagePeopleForm()
        {
            frmManagePeopleScreen form = new frmManagePeopleScreen();

            form.DataBack += RecieveData_DataBack;

            form.ShowDialog();
        }

        private void RecieveData_DataBack(object sender, int records)
        {
           lblTotalPeople.Text = records.ToString();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
           OpenManagePeopleForm();
           
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void _RefrechNumberOfPeople()
        {
            int Total_P = clsPerson.GetPeopleCount();

            lblTotalPeople.Text = Total_P.ToString();
        }
        private void _RefrechNumberOfApplication()
        {
            int Total_Application = clsApplication.GetApplicationCount();

            lblTotalA.Text = Total_Application.ToString();
        }


        private void Main_Load(object sender, EventArgs e)
        {
            _RefrechNumberOfPeople();
            _RefrechNumberOfApplication();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm tt");
            lblDate.Text = DateTime.Now.ToString("yyyy/MM/dd");

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
          frmManageUsers frm = new frmManageUsers();
          frm.ShowDialog();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ApplicationMenueStripe.Show(guna2Button1,0,guna2Button1.Height);
        }

        private void Drivers_Click(object sender, EventArgs e)
        {
           frmListDrivers frm = new frmListDrivers();
            frm.ShowDialog();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
          AccountMenu.Show(guna2Button6,0,guna2Button6.Height);
        }

      

      

     

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("This feature is Not Implemented Yet! ", "Not Ready", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            frmListlocalDrivingLicenseApplication frm = new frmListlocalDrivingLicenseApplication();
            frm.DataBack += Frm_DataBack;
            frm.ShowDialog();

        }

        private void localDrivingLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("This feature is Not Implemented Yet! ", "Not Ready", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            frmListlocalDrivingLicenseApplication frm = new frmListlocalDrivingLicenseApplication();
            frm.DataBack += Frm_DataBack;
            frm.ShowDialog();
        }

        private void Frm_DataBack(object sender, int records)
        {
            lblTotalA.Text = records.ToString();
        }

        private void intenationalDrivingLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is Not Implemented Yet! ", "Not Ready", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
                MessageBox.Show("This feature is Not Implemented Yet! ", "Not Ready", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is Not Implemented Yet! ", "Not Ready", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is Not Implemented Yet! ", "Not Ready", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  MessageBox.Show("This feature is Not Implemented Yet! ", "Not Ready", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            int UserID = GlobalClass.CurrentUser.UserID;
            frmUserInfo frm = new frmUserInfo(UserID);
            frm.ShowDialog();


        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("This feature is Not Implemented Yet! ", "Not Ready",
            //MessageBoxButtons.OK, MessageBoxIcon.Warning);
            int UserID = GlobalClass.CurrentUser.UserID;
            frmChangePassword frm = new frmChangePassword(UserID);
            frm.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalClass.CurrentUser = null;
            _frmLogin.Show();
            this.Close();

        }

        private void lblTotalPeople_Click(object sender, EventArgs e)
        {

        }

        private void UserPicture_Click(object sender, EventArgs e)
        {

            AccountMenu.Show(UserPicture, 0, UserPicture.Height);

        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageApplicationType frm = new frmManageApplicationType();
            frm.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTestTypes frm = new frmManageTestTypes();
            frm.ShowDialog();
        }

        private void localToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdd_EditLocalDrivingLicenseApplication frm = new frmAdd_EditLocalDrivingLicenseApplication();
            frm.ShowDialog();
        }

        private void RenewLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //
          //MessageBox.Show("This feature is Not Implemented Yet! ", "Not Ready", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          //renew
          frmRenewLicenseApplication frm = new frmRenewLicenseApplication();
            frm.ShowDialog();
        }

        private void replacmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("This feature is Not Implemented Yet! ", "Not Ready", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            // replacement
            frmReplecmentLicense frm = new frmReplecmentLicense();
            frm.ShowDialog();
        }

        private void releaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is Not Implemented Yet! ", "Not Ready", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
