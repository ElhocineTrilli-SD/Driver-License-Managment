using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Licenses.International_License
{
    public partial class frmInternationalLicenseInfo : Form
    {
        private int _InternationalLicenseID = -1;
        public frmInternationalLicenseInfo(int ID)
        {
            InitializeComponent();
            _InternationalLicenseID = ID;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlInternationalLicenseInfo1_Load(object sender, EventArgs e)
        {

        }

        private void frmInternationalLicenseInfo_Load(object sender, EventArgs e)
        {
            ctrlInternationalLicenseInfo1.LoadInfo(_InternationalLicenseID);
        }
    }
}
