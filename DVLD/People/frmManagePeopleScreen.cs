using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BUSINESS;

namespace DVLD
{
    public partial class frmManagePeopleScreen : Form
    {
        public delegate void handler (object sender, int records);

        // Declare an event using the delegate
        public event handler DataBack;

        private DataTable _dtPeople;

        public frmManagePeopleScreen()
        {
            InitializeComponent();
           
        }
        private void _FillcbfilteringwithItems()
        {
            cbfiltering.Items.Add("None");
            cbfiltering.Items.Add("Person ID");
            cbfiltering.Items.Add("National No");
            cbfiltering.Items.Add("First Name");
            cbfiltering.Items.Add("Second Name");
            cbfiltering.Items.Add("Third Name");
            cbfiltering.Items.Add("Last Name");
            cbfiltering.Items.Add("Natinality");
            cbfiltering.Items.Add("Gender");
            cbfiltering.Items.Add("Phone");
            cbfiltering.Items.Add("Email");
            
            cbfiltering.SelectedIndex = 0;
            
        }
        public  void _RefrechPeopleList()
        {
            _dtPeople = clsPerson.GetallPeople();
            dgvPeople.DataSource = _dtPeople;
            _RefrechRecordCount();
        }
        public void _RefrechRecordCount()
        {
            int Records = dgvPeople.RowCount;
            lblRecordsCount.Text = Records.ToString();


            DataBack?.Invoke(this, Records);
        }
      
        private void ManagePeople_Load(object sender, EventArgs e)
        {
            _RefrechPeopleList();
            _FillcbfilteringwithItems();
            


        }
        private void btnAddPeople_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            ManagePeople_Load(null, null);
        }
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbfiltering.Text != "None");
            if(txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
            

           

            
        }
        private void txtToFind_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbfiltering.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "National No.":
                    FilterColumn = "NationalNo";
                    break;

                case "First Name":
                    FilterColumn = "FirstName";
                    break;

                case "Second Name":
                    FilterColumn = "SecondName";
                    break;

                case "Third Name":
                    FilterColumn = "ThirdName";
                    break;

                case "Last Name":
                    FilterColumn = "LastName";
                    break;

                case "Nationality":
                    FilterColumn = "CountryName";
                    break;

                case "Gendor":
                    FilterColumn = "GendorCaption";
                    break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;

                case "Email":
                    FilterColumn = "Email";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }





            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtPeople.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "PersonID")
                //in this case we deal with integer not string.

                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();



        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbfiltering.Text == "PersonID" || cbfiltering.Text == "Phone")
            {
                // JustNumbers
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
          

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void deleteTool_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure do you want to delete Person " +
          "[" + dgvPeople.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int PersonID = (int)dgvPeople.CurrentRow.Cells[0].Value;
                if (clsPerson.DeletePerson(PersonID))
                {
                    MessageBox.Show("Contact Deleted Successfully.");
                    _RefrechPeopleList();
                }
                else
                    MessageBox.Show("Contact is not Deleted.");



            }
        }
        private void ADDTools_Click(object sender, EventArgs e)
        {

            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            ManagePeople_Load(null, null);

        }
        private void showDetailsTool_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeople.CurrentRow.Cells[0].Value;
            Form form = new ShowPersonDetails(PersonID);
            form.ShowDialog();
        }
        private void EditTool_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeople.CurrentRow.Cells[0].Value;
            Form frm = new frmAddUpdatePerson(PersonID);
            frm.ShowDialog();
            ManagePeople_Load(null, null);

        }
        private void sendEmailTool_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is Not Implemented Yet! ", "Not Ready", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void phoneCallTool_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is Not Implemented Yet! ", "Not Ready", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
