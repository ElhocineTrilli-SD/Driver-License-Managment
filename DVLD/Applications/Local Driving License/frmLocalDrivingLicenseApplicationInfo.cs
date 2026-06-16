using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Applications.Local_Driving_License
{
    public partial class frmLocalDrivingLicenseApplicationInfo : Form
    {
        public int _ApplicationID = -1;


        public frmLocalDrivingLicenseApplicationInfo(int applicationID)
        {
            InitializeComponent();
            _ApplicationID = applicationID;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            ctrlDrivingLicenseApplication1.LoadApplicationInfoByLocalDrivingAppID(_ApplicationID);
        }
    }
}
