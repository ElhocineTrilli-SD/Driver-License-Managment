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

namespace DVLD.Tests.TestTypes
{
    public partial class frmManageTestTypes : Form
    {

        private DataTable _DtTests;

        public frmManageTestTypes()
        {
            InitializeComponent();
        }
      
        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            _RefreschTestTypesList();

            if (dgvTestTypes.Rows.Count > 0)
            {
                dgvTestTypes.Columns[0].HeaderText = "ID";
                dgvTestTypes.Columns[0].Width = 110;

                dgvTestTypes.Columns[1].HeaderText = "Titel";
                dgvTestTypes.Columns[1].Width = 200;

                dgvTestTypes.Columns[2].HeaderText = "Description";
                dgvTestTypes.Columns[2].Width = 400;

                dgvTestTypes.Columns[3].HeaderText = "Fees";
                dgvTestTypes.Columns[3].Width = 100;
            }
        }

        private void _RefreschTestTypesList()
        {
           _DtTests = clsTestType.GetAllTestTypes();
            dgvTestTypes.DataSource = _DtTests;
            _RefreschCount();
        }

       private void _RefreschCount()
        {
            int Record = dgvTestTypes.RowCount;
            lblRecordsCountTestTypes.Text = Record.ToString();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
