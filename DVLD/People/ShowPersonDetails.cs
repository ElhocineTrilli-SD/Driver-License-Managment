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

      
        public ShowPersonDetails(int PersonID)
        {
            InitializeComponent();
           PersonInfoCard1.LoadPersonInfo(PersonID);
        }

        public ShowPersonDetails(string NationalNo)
        {
            InitializeComponent();
            PersonInfoCard1.LoadPersonInfo(NationalNo);
        }



        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
