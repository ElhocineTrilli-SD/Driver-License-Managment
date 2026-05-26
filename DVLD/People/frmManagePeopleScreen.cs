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


        public frmManagePeopleScreen()
        {
            InitializeComponent();
           
        }
        private void _FillcbfilteringwithItems()
        {
            cbfiltering.Items.Add("none");
            cbfiltering.Items.Add("PersonID");
            cbfiltering.Items.Add("NationalN");
            cbfiltering.Items.Add("First name");
            cbfiltering.Items.Add("Second name");
            cbfiltering.Items.Add("Third name");
            cbfiltering.Items.Add("Last name");
            cbfiltering.Items.Add("Natinality");
            cbfiltering.Items.Add("Gender");
            cbfiltering.Items.Add("Phone");
            cbfiltering.Items.Add("Email");
            
            cbfiltering.SelectedIndex = 0;
            
        }
        public  void _RefrechPeopleList()
        {
            dgvPeopleList.DataSource = clsPerson.GetallPeople();
            _RefrechRecordCount();
        }
        public void _RefrechRecordCount()
        {
            int Records = dgvPeopleList.RowCount;
            lblRecordCount.Text = Records.ToString();


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
        }
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbfiltering.SelectedIndex != 0)
            {
                txtSearch.Visible = true;
            }
            else { txtSearch.Visible = false; }

           

            
        }
        private void txtToFind_TextChanged(object sender, EventArgs e)
        {
            // Get the text entered by the user and convert it to lowercase
            // to make the search case-insensitive
            string searchValue = txtSearch.Text.ToLower();

            // Get the CurrencyManager associated with the DataGridView data source
            CurrencyManager currencyManager =
            (CurrencyManager)BindingContext[dgvPeopleList.DataSource];

            // Temporarily suspend data binding to avoid errors
            // when hiding/showing rows
            currencyManager.SuspendBinding();


            foreach (DataGridViewRow row in dgvPeopleList.Rows)
            {
                // Skip the empty "new row" at the bottom of the DataGridView
                if (row.IsNewRow)
                    continue;
                bool found = false;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Check if the cell contains a value
                    // and if that value contains the search text
                    if (cell.Value != null &&
                        cell.Value.ToString().ToLower().Contains(searchValue))
                    {
                        found = true;
                        break;// Stop searching in this row once a match is found
                    }
                   
                }

                row.Visible = found;

            }
            // Resume data binding after finishing the filtering process
            currencyManager.ResumeBinding();
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
          "[" + dgvPeopleList.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                if (clsPerson.DeletePerson((int)dgvPeopleList.CurrentRow.Cells[0].Value))
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

            Form frm = new frmAddUpdatePerson();
            frm.ShowDialog();
        }
        private void showDetailsTool_Click(object sender, EventArgs e)
        {
            Form form = new ShowPersonDetails((int)dgvPeopleList.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }
        private void EditTool_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePerson((int)dgvPeopleList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefrechPeopleList();
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
