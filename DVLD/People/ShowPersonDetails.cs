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

       

        public ShowPersonDetails(int PersonID)
        {
            InitializeComponent();
            personUserControl11.LoadPersonInfo(PersonID); 
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
