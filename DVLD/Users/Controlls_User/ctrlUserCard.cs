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

namespace DVLD.Users.Controlls_User
{
    public partial class ctrlUserCard : UserControl
    {

        private clsUser _User;
        private int _UserID = -1;

        public int UserID
        {
            get { return _UserID; }
        }


        public void LoadUserInfo(int UserID)
        {
            _UserID = UserID;
            _User = clsUser.FindByUserID(UserID);

            if(_User == null )
            {
                _ResetPersonInfo();
                MessageBox.Show("No User With this ID " + UserID, "User Not Found",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillUserInfo();
        }

        private void _FillUserInfo()
        {
            personInfoCard11.LoadPersonInfo(_User.PersonID);
            txtUserID.Text = _User.UserID.ToString();
            txtUserName.Text = _User.UserName.ToString();

            if(_User.IsActive == true )
            {
                txtIsActive.Text = "Yse";
            }
            else { txtIsActive.Text = "No"; }
        }

        private void _ResetPersonInfo()
        {
            
        }

        public ctrlUserCard()
        {
            InitializeComponent();
        }
    }
}
