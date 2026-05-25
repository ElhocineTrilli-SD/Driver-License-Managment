using DVLD_BUSINESS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DVLD
{
    public partial  class PersonUserControl1 : UserControl
    {
        public PersonUserControl1()
        {
            InitializeComponent();
        }

        public  void SetData(clsPerson person)
        {
            if (person == null) return;

            txtPersonID.Text = person.PersonID.ToString();
            txtname.Text = person.Firstname + " " + person.Secondname + " "+person.thirdname + " " + person.lastname;
            txtNationalN.Text = person.NationalNo.ToString();

            if (person.Gender == 0)
                txtGender.Text = "Male";
            else txtGender.Text = "Female";

            txtEmail.Text = person.Email;
            txtAddress.Text = person.Address;
            txtDateofbirth.Text = person.DateOfBirth.ToString("yyyy-MM-dd");
            txtPhone.Text = person.Phone;
            //
           // txtCountry.Text = clsCountry.Find(person.NationalityCountryID).CountryName;
            var country = clsCountry.Find(person.NationalityCountryID);

            if (country != null)
            {
                txtCountry.Text = country.CountryName;
            }
            else
            {
                txtCountry.Text = "Unknown";
            }
            //
            if (!string.IsNullOrEmpty(person.ImagePath) && File.Exists(person.ImagePath))
            {
                picbFoto.Image = Image.FromFile(person.ImagePath);
            }




        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }
    }
}
