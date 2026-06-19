using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Licenses.LocalLicenses
{
    public partial class frmShowLicenseInfo : Form
    {
        public int _LicenseID = -1;
        public frmShowLicenseInfo(int LicenesID)
        {
            InitializeComponent();
            _LicenseID = LicenesID;
        }

        private void frmShowLicenseInfo_Load(object sender, EventArgs e)
        {
            ctrlLicenseInfo1.LoadInfo(_LicenseID);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
