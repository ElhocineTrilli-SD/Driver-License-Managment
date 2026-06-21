using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BUSINESS
{
    public class clsDrivers
    {
        public enum enMode { AddNew = 0, Update = 1 };
        enMode Mode;

        public clsPerson PersonInfo;

        public int DriverID { get; set; }
        public int PersonID {  get; set; }
        public int CreatedByUserID { get; set;  }

        public DateTime CreatedDate { get; set; }

        public clsDrivers()
        {
           // PersonInfo = new clsPerson();
            this.DriverID = -1;
            this.PersonID = -1;
            this.CreatedByUserID = -1;
            this.CreatedDate = DateTime.Now;
            Mode = enMode.AddNew;
        }
        public clsDrivers(int DriverID,int PersonID,int CreatedByUserID,DateTime CreatedDate)
        {
            this.DriverID= DriverID;
            this.PersonID= PersonID;
            this.CreatedByUserID= CreatedByUserID;
            this.CreatedDate = CreatedDate;
            this.PersonInfo = clsPerson.Find(PersonID);
            Mode = enMode.Update;
        }
        public static clsDrivers FindByPersonID(int PersonID)
        {
            int DriverID = -1, CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;
            bool IsFound =
                clsDriversData.GetDriverInfoByPersonID(PersonID, ref DriverID, ref CreatedByUserID, ref CreatedDate);

            if (IsFound)
            {
                return new clsDrivers(DriverID, PersonID, CreatedByUserID, CreatedDate);
            }
            else { return null; }

        }
        public static clsDrivers FindByDriverID(int DriverID)
        {
            int PersonID = -1, CreatedByUserID=-1; 
                DateTime CreatedDate = DateTime.Now;
            bool IsFound =
                clsDriversData.GetDriverInfoByDriverID(DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate);

            if(IsFound)
            {
                return new clsDrivers(DriverID, PersonID, CreatedByUserID, CreatedDate);
            }
            else { return null; }

        }
        private bool _AddNewDriver()
        {
            this.DriverID = clsDriversData.AddNewDriver(this.PersonID, this.CreatedByUserID);

            return (this.DriverID != -1);
        }
        private bool _UpdateDriver()
        {
            return clsDriversData.UpdateDriver(this.DriverID,this.PersonID,this.CreatedByUserID);
        }
        public static DataTable GetAllDrivers()
        {
            return clsDriversData.GetAllDrivers();
        }

        public static DataTable GetLicenses(int DriverID)
        {
            return clsLicenseData.GetDriverLicenses(DriverID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDriver())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateDriver();

            }

            return false;
        }

        //

        //

    }
}
