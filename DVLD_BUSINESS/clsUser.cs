using DataAccess;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BUSINESS
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;

        
        public int UserID { get; set; }

        public int PersonID { get; set; }

        clsPerson PersonInfo;
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public clsUser()
        {
            this.UserID = -1;
            this.UserName = "";
            this.Password = "";
            this.IsActive =true ;    
            this.PersonID = -1;

            Mode = enMode.AddNew;
        }
        private clsUser(int UserID, int PersonID,string UserName,string Password,bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.PersonInfo = clsPerson.Find(PersonID);
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;

            Mode = enMode.Update;

        }


        private bool _AddNewUser()
        {
            this.UserID = clsUserData.AddNewUser(this.PersonID, this.UserName
                                                , this.Password, this.IsActive);

            return (this.UserID != -1);

        }
        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser(this.UserID,this.PersonInfo.PersonID,
                this.UserName, this.Password, this.IsActive);
        }

        public static clsUser FindByUserID(int UserID)
        {
            int PersonID = -1;
            string UserName = "", Password = "";
            bool IsActive = false ;

            bool IsFound = clsUserData.GetUserInfoByUserID(UserID,ref PersonID,
                ref UserName,ref Password,ref IsActive);

            if(IsFound)
            {
              return new clsUser(UserID,PersonID,UserName,Password,IsActive);
            }
            else
                return null;
        }

        public static clsUser FindByPersonID(int PersonID)
        {
            int UserID = -1;
            string UserName = "", Password = "";
            bool IsActive = false;

            bool IsFound = clsUserData.GetUserInfoByPersonID(PersonID,ref UserID,ref  UserName,ref Password,ref IsActive);
               

            if (IsFound)
            {
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            }
            else
                return null;
        }

        public static clsUser FindByUserNameAndPassword(string UserName, string Password)
        {
            int UserID = -1;
            int PersonID = -1;
            bool IsActive = false;

            bool IsFound = clsUserData.GetUserInfoByUsernameAndPassword(UserName,Password,ref UserID,ref PersonID,ref IsActive);
                  


            if (IsFound)
            {
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            }
            else
                return null;
        }

        public bool Save()
        {

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }

                case enMode.Update:

                    return _UpdateUser();
            }


            return false;
        }

        public static DataTable GetAllUser()
        {
            //call dataAccess
            return clsUserData.GetAllUser();
        }

        public static int GetUsersCount()
        {
            //call dataAccess
            return clsUserData.GetUsersCount();
        }

        public static bool IsUserExist(int UserID)
        {
            //call dataAccess
            return clsUserData.IsUserExist(UserID);
        }

        public static bool IsUserExist(string UserName)
        {
            //call dataAccess
            return clsUserData.IsUserExist(UserName);
        }

        public static bool DeleteUser(int UserID)
        {
            //call dataAccess
            return clsUserData.DeleteUser(UserID);
        }

        public static bool isUserExistForPersonID(int PersonID)
        {
            return clsUserData.IsUserExistForPersonID(PersonID);
        }










    }
}
