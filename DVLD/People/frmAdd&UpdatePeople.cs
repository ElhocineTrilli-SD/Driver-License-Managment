
using DVLD.Globle_Classes;
using DVLD.Properties;
using DVLD_BUSINESS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DVLD
{
    public partial class frmAddUpdatePerson : Form
    {

        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        public enum enMode { AddNew = 0, Update = 1 };
        public enum enGendor { Male = 0, Female = 1 };

        private enMode _Mode;

        private int _PersonID = -1;
        clsPerson _Person;

        public frmAddUpdatePerson()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;

        }

        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _PersonID = PersonID;
        }

        private void _ResetDefualtValues()
        {
            //this will initialize the reset the defaule values
            _FillCountriesInComoboBox();

            if (_Mode == enMode.AddNew)
            {
                lbltitel.Text = "Add New Person";
                _Person = new clsPerson();
            }
            else
            {
                lbltitel.Text = "Update Person";
            }

            //set default image for the person.
            if (rbMale.Checked)
                PBFoto.Image = Resources.man;
            else
                PBFoto.Image = Resources.women;

            //hide/show the remove linke incase there is no image for the person.
            lblRemove.Visible = (PBFoto.ImageLocation != null);

            //we set the max date to 18 years from today, and set the default value the same.
            dtp_DateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtp_DateOfBirth.Value = dtp_DateOfBirth.MaxDate;

            //should not allow adding age more than 100 years
            dtp_DateOfBirth.MinDate = DateTime.Now.AddYears(-100);

            //this will set default country to jordan.
            cbCountries.SelectedIndex = cbCountries.FindString("Algeria");

            txtFirstname.Text = "";
            txtSecondname.Text = "";
            txtThirdname.Text = "";
            txtlastname.Text = "";
            txtnationaln.Text = "";
            rbMale.Checked = true;
            txtPhone.Text = "";
            txtemail.Text = "";
            txtaddress.Text = "";
        }

        private void _FillCountriesInComoboBox()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();

            foreach (DataRow row in dtCountries.Rows)
            {
                cbCountries.Items.Add(row["CountryName"]);
            }
        }

        private void _LoadData()
        {
            _Person = clsPerson.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("No Person with ID = " + _PersonID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            //the following code will not be executed if the person was not found
            txtPersonID.Text = _PersonID.ToString();
            txtFirstname.Text = _Person.Firstname;
            txtSecondname.Text = _Person.Secondname;
            txtThirdname.Text = _Person.thirdname;
            txtlastname.Text = _Person.lastname;
            txtnationaln.Text = _Person.NationalNo;
            dtp_DateOfBirth.Value = _Person.DateOfBirth;

            if (_Person.Gender == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            txtaddress.Text = _Person.Address;
            txtPhone.Text = _Person.Phone;
            txtemail.Text = _Person.Email;
            cbCountries.SelectedIndex = cbCountries.FindString(_Person.CountryInfo.CountryName);


            //load person image incase it was set.
            if (_Person.ImagePath != "")
            {
                PBFoto.ImageLocation = _Person.ImagePath;

            }

            //hide/show the remove linke incase there is no image for the person.
            lblRemove.Visible = (_Person.ImagePath != "");

        }

        private void frmadd_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();

        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // JustNumbers
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {

            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            TextBoxBase  Temp = ((TextBoxBase)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            int CountryID = clsCountry.Find(cbCountries.Text).CountryID;

            _Person.NationalNo = txtnationaln.Text.Trim();
            _Person.Email = txtemail.Text.Trim();
            _Person.Phone = txtPhone.Text.Trim();
            _Person.Address = txtaddress.Text.Trim();
            _Person.DateOfBirth = dtp_DateOfBirth.Value;
          
            _Person.Firstname = txtFirstname.Text.Trim();
            _Person.Secondname = txtSecondname.Text.Trim();
            _Person.thirdname = txtThirdname.Text.Trim();
            _Person.lastname = txtlastname.Text.Trim();

            if (rbMale.Checked)
                _Person.Gender = (byte)enGendor.Male;
            else
                _Person.Gender = (byte)enGendor.Female;
            _Person.NationalityCountryID = CountryID;
            /////////////////////
            if (PBFoto.ImageLocation != null)
                _Person.ImagePath = PBFoto.ImageLocation;
            else
                _Person.ImagePath = "";
            /////////////////////

            if (_Person.Save())
            {
               txtPersonID.Text = _Person.PersonID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lbltitel.Text = "Update Person";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

          

        }

        private void RemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PBFoto.ImageLocation = null;



            if (rbMale.Checked)
                PBFoto.Image = Resources.man;
            else
                PBFoto.Image = Resources.women;

            lblRemove.Visible = false;

        }

        private void SetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                PBFoto.Load(selectedFilePath);
                lblRemove.Visible = true;
                // ...

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //      _ManagePeople._RefrechPeopleList();

            this.Close();

        }
     
        private void txtemail_Validating(object sender, CancelEventArgs e)
        {

            //no need to validate the email incase it's empty.
            if (txtemail.Text.Trim() == "")
                return;

            //validate email format
            if (!clsValidation.ValidateEmail(txtemail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtemail, "Invalid Email Address Format!");
            }
            else
            {
                errorProvider1.SetError(txtemail, null);
            }
            ;
        }

        private void txtnationaln_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtnationaln.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtnationaln, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtnationaln, null);
            }

            //Make sure the national number is not used by another person
            if (txtnationaln.Text.Trim() != _Person.NationalNo && clsPerson.IsPersonExist(txtnationaln.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtnationaln, "National Number is used for another person!");

            }
            else
            {
                errorProvider1.SetError(txtnationaln, null);
            }
        }

        private void rbMale_Click(object sender, EventArgs e)
        {
            //change the defualt image to male incase there is no image set.
            if (PBFoto.ImageLocation == null)
                PBFoto.Image = Resources.man;
        }       
        private void rbFemale_Click(object sender, EventArgs e)
        {
            //change the defualt image to female incase there is no image set.
            if (PBFoto.ImageLocation == null)
                PBFoto.Image = Resources.women;
        }
    }
}
