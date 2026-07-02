using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Licenses
{
    public partial class frmShowPersonLicenseHistory : Form
    {
        private int _PersonID = -1;
        public frmShowPersonLicenseHistory()
        {
            InitializeComponent();
        }
        public frmShowPersonLicenseHistory(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowPersonLicenseHistory_Load(object sender, EventArgs e)
        {
            if(_PersonID != -1)
            {
                personInfoWithFilter11.LoadPersonInfo(_PersonID);
                personInfoWithFilter11.FilterEnabled = false;
                ctrlDriverLicenses1.LoadInfoByPersonId(_PersonID);
            }
            else
            {
                personInfoWithFilter11.Enabled = true;
                personInfoWithFilter11.FilterFocus();
            }
                


        }

        private void personInfoWithFilter11_PersonSelected(object sender, People.Controlls.PersonInfoWithFilter1.PersonInfoEventArgs e)
        {
            _PersonID = e.PersonID;
            if (_PersonID == -1)
            {
                ctrlDriverLicenses1.Clear();

            }
            else
            {
                ctrlDriverLicenses1.LoadInfoByPersonId(_PersonID);
            }
        }

        //private void personInfoWithFilter11_OnPersonSelected(int obj)
        //{
        //    _PersonID = obj;
        //    if (_PersonID == -1)
        //    {
        //        ctrlDriverLicenses1.Clear();

        //    }
        //    else
        //    {
        //        ctrlDriverLicenses1.LoadInfoByPersonId(_PersonID);
        //    }
        //}
    }
}
