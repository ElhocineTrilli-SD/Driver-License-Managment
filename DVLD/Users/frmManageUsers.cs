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
    public partial class frmManageUsers : Form
    {

        public delegate void handler(object sender, int records);

        // Declare an event using the delegate
        public event handler DataBack;


        public frmManageUsers()
        {
            InitializeComponent();
        }

        private DataTable _dtUser;

        private void _FillcbfilteringwithItems()
        {
            cbfilterUsers.Items.Add("None");
            cbfilterUsers.Items.Add("User ID");
            cbfilterUsers.Items.Add("User Name");
            cbfilterUsers.Items.Add("Person ID");
            cbfilterUsers.Items.Add("Full Name");
            cbfilterUsers.Items.Add("Is Active");

            cbfilterUsers.SelectedIndex = 0;

        }

        public void _RefrechUserList()
        {
            _dtUser = clsUser.GetAllUser();
            dgvUser.DataSource = _dtUser;
            _RefrechRecordCount();
        }
        public void _RefrechRecordCount()
        {
            int Records = dgvUser.RowCount;
            lblRecordsCountUser.Text = Records.ToString();


            DataBack?.Invoke(this, Records);
        }


        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _RefrechUserList();
            _FillcbfilteringwithItems();
            
            if(dgvUser.Rows.Count > 0) 

            dgvUser.Columns[0].HeaderText = "User ID";
            dgvUser.Columns[0].Width = 110;

            dgvUser.Columns[1].HeaderText = "Person ID";
            dgvUser.Columns[1].Width = 120;

            dgvUser.Columns[2].HeaderText = "Full Name";
            dgvUser.Columns[2].Width = 250;

            dgvUser.Columns[3].HeaderText = "UserName";
            dgvUser.Columns[3].Width = 120;

            dgvUser.Columns[4].HeaderText = "Is Active";
            dgvUser.Columns[4].Width = 120;
        }

        private void cbfilterUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbfilterUsers.Text == "Is Active")
            {
                txtFilterValueUser.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.Focus();
                cbIsActive.SelectedIndex = 0;
            }
            else
            {

                txtFilterValueUser.Visible = (cbfilterUsers.Text != "None");
                cbIsActive.Visible = false;

                if (cbfilterUsers.Text == "None")
                {
                   txtFilterValueUser.Enabled = false;
                }
                else
                {
                    txtFilterValueUser.Enabled = true;
                    txtFilterValueUser.Text = "";
                    txtFilterValueUser.Focus();
                }

        

            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {

            this.Close();
        }

       

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is Not Implemented Yet! ", "Not Ready", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void phoneCallToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is Not Implemented Yet! ", "Not Ready", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void ChangePass_Click(object sender, EventArgs e)
        {
            //    MessageBox.Show("This feature is Not Implemented Yet! ", "Not Ready", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //change pass

            int UserID = (int)dgvUser.CurrentRow.Cells[0].Value;

           frmChangePassword frm = new frmChangePassword(UserID);
            frm.ShowDialog();
            frmManageUsers_Load(null, null);
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is Not Implemented Yet! ", "Not Ready", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //  MessageBox.Show("This feature is Not Implemented Yet! ", "Not Ready", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            int UserID = (int)dgvUser.CurrentRow.Cells[0].Value;

            frmAdd_Update_Users frm = new frmAdd_Update_Users(UserID);
            frm.ShowDialog();
            frmManageUsers_Load(null, null);

        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("This feature is Not Implemented Yet! ", "Not Ready", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //ADD NEW USER.
            frmAdd_Update_Users frm = new frmAdd_Update_Users();
            frm.ShowDialog();
            frmManageUsers_Load(null, null);

        }

        private void showDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUser.CurrentRow.Cells[0].Value;
            //MessageBox.Show("This feature is Not Implemented Yet! ", "Not Ready", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            frmUserInfo frm = new frmUserInfo(UserID);
            frm.ShowDialog();
        }

        private void txtFilterValueUser_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbfilterUsers.Text)
            {
                case "User ID":
                    FilterColumn = "UserID";
                    break;
                case "User Name":
                    FilterColumn = "UserName";
                    break;

                case "Person ID":
                    FilterColumn = "PersonID";
                    break;


                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValueUser.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtUser.DefaultView.RowFilter = "";
                lblRecordsCountUser.Text = _dtUser.Rows.Count.ToString();
                return;
            }


            if (FilterColumn != "FullName" && FilterColumn != "UserName")
                //in this case we deal with numbers not string.
                _dtUser.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValueUser.Text.Trim());
            else
                _dtUser.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValueUser.Text.Trim());

            lblRecordsCountUser.Text = _dtUser.Rows.Count.ToString();
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {

            string FilterColumn = "IsActive";
            string FilterValue = cbIsActive.Text;

            switch (FilterValue)
            {
                case "All":
                    break;
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
            }


            if (FilterValue == "All")
               _dtUser.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _dtUser.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            lblRecordsCountUser.Text = _dtUser.Rows.Count.ToString();


        }

        private void txtFilterValueUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            //we allow number incase person id or user id is selected.
            if (cbfilterUsers.Text == "Person ID" || cbfilterUsers.Text == "User ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAdd_Update_Users frm = new frmAdd_Update_Users();
            frm.ShowDialog();
            frmManageUsers_Load(null, null);

        }
    }
}
