using DVLD.Application.ApplicationType;
using DVLD.Globle_Classes;
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

        private void ActiveButton(Guna2Button btn)
        {
            btn.ForeColor = Color.DarkOrange;
            btn.FillColor = Color.FromArgb(35,35,48);
        }
        private void inActiveButton(Guna2Button btn)
        {
            btn.ForeColor = Color.DarkOrange;
            btn.FillColor = Color.FromArgb(35, 35, 48);
        }

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

        private void lblTime_Click(object sender, EventArgs e)
        {

            
        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void _RefrechNumberOfPeople()
        {
            int Total_P = clsPerson.GetPeopleCount();

            lblTotalPeople.Text += Total_P.ToString();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            _RefrechNumberOfPeople();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm tt");
            lblDate.Text = DateTime.Now.ToString("yyyy/MM/dd");

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show("This feature is Not Implemented Yet! ", "Not Ready", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          frmManageUsers frm = new frmManageUsers();
          frm.ShowDialog();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //     MessageBox.Show("This feature is Not Implemented Yet! ", "Not Ready", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ApplicationMenueStripe.Show(guna2Button1,0,guna2Button1.Height);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is Not Implemented Yet! ", "Not Ready", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show("This feature is Not Implemented Yet! ", "Not Ready", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          AccountMenu.Show(guna2Button6,0,guna2Button6.Height);
        }

      

        private void newDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is Not Implemented Yet! ", "Not Ready", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void drivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is Not Implemented Yet! ", "Not Ready", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void replacmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is Not Implemented Yet! ", "Not Ready", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void releaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is Not Implemented Yet! ", "Not Ready", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is Not Implemented Yet! ", "Not Ready", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void localDrivingLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is Not Implemented Yet! ", "Not Ready", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
    }
}
