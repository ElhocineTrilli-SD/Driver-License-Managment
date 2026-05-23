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
    public partial class ShowPersonDetails : Form
    {

      private  int _PersonID = 0;

        clsPerson _Person;

        frmManagePeopleScreen _managePeople;

        public ShowPersonDetails(int PersonID,frmManagePeopleScreen managePeople)
        {
            InitializeComponent();
            _PersonID = PersonID;
            _managePeople = managePeople;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PersonDetails_Load(object sender, EventArgs e)
        {
            _Person = clsPerson.Find(_PersonID);
            personInfo1.SetData(_Person);

        }

        private void lblEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new frmAddUpdatePerson(_PersonID );
            form.ShowDialog();
            _managePeople._RefrechPeopleList();

        }
    }
}
