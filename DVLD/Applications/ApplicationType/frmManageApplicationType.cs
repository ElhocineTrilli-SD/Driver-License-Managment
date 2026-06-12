using DVLD.Applications.ApplicationType;
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

namespace DVLD.Application.ApplicationType
{
    public partial class frmManageApplicationType : Form
    {

        private DataTable _dtApplicationType = clsApplicationType.GetAllApplicationTypes();

        public frmManageApplicationType()
        {
            InitializeComponent();
        }

        private void frmManageApplicationType_Load(object sender, EventArgs e)
        {
            _RefreschAplicationTypesList();

            if(dgvApplicationtypes.Rows.Count > 0 )
            {
                dgvApplicationtypes.Columns[0].HeaderText = "ID";
                dgvApplicationtypes.Columns[0].Width = 110;

                dgvApplicationtypes.Columns[1].HeaderText = "Titel";
                dgvApplicationtypes.Columns[1].Width = 400;

                dgvApplicationtypes.Columns[2].HeaderText = "Fees";
                dgvApplicationtypes.Columns[2].Width = 100;

            }

        }

        private void _RefreschAplicationTypesList()
        {
            dgvApplicationtypes.DataSource = _dtApplicationType;
            _RefreschCount();
        }

        private void _RefreschCount()
        {
            int Record = dgvApplicationtypes.RowCount;
            lblRecordsCountapptypes.Text = Record.ToString();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Id = (int)dgvApplicationtypes.CurrentRow.Cells[0].Value;
            frmEditApplicationType frm = new frmEditApplicationType(Id);
            frm.DataUpdated += LoadData;
            frm.ShowDialog();
        }

        private void LoadData()
        {
            _RefreschAplicationTypesList();
        }
    }
}
