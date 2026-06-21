using DVLD.Licenses.LocalLicenses;
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

namespace DVLD.Licenses.Control
{
    public partial class ctrlDriverLicenses : UserControl
    {
        private int _DriverID = -1;
        private clsDrivers _Drivers;
        DataTable _DtLocal;
       // DataTable _DtInternational;




        public ctrlDriverLicenses()
        {
            InitializeComponent();
        }

        public void LoadInfo(int DriverID)
        {
            _DriverID = DriverID;
            _Drivers = clsDrivers.FindByDriverID(DriverID);

            if( _Drivers == null )
            {
                MessageBox.Show("There is no Driver with ID : " + _DriverID, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _LoadLocalLicensesInfo();

        }
        public void LoadInfoByPersonId(int PersonID)
        {
            _Drivers = clsDrivers.FindByPersonID(PersonID);
            if (_Drivers == null)
            {
                MessageBox.Show("There is no Driver with ID : " + _DriverID, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

           _DriverID = _Drivers.DriverID;

            _LoadLocalLicensesInfo() ;
        }

        private void _LoadLocalLicensesInfo()
        {
            _DtLocal = clsDrivers.GetLicenses(_DriverID);
            dgvLocal.DataSource = _DtLocal;
            lblRecordsCount.Text = dgvLocal.Rows.Count.ToString();

            if (dgvLocal.Rows.Count > 0)
            {
                dgvLocal.Columns[0].HeaderText = "Lic.ID";
                dgvLocal.Columns[0].Width = 110;

                dgvLocal.Columns[1].HeaderText = "App.ID";
                dgvLocal.Columns[1].Width = 110;

                dgvLocal.Columns[2].HeaderText = "Class Name";
                dgvLocal.Columns[2].Width = 270;

                dgvLocal.Columns[3].HeaderText = "Issue Date";
                dgvLocal.Columns[3].Width = 170;

                dgvLocal.Columns[4].HeaderText = "Expiration Date";
                dgvLocal.Columns[4].Width = 170;

                dgvLocal.Columns[5].HeaderText = "Is Active";
                dgvLocal.Columns[5].Width = 110;

            }
        }

        public void Clear()
        {
            _DtLocal.Clear();
            //
        }

            

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo((int)dgvLocal.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
