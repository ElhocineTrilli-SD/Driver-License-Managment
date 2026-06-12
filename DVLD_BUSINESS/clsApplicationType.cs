using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BUSINESS
{
    public class clsApplicationType
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;

        public int ID {  get; set; }
        public string Titel { get; set; }
        public float Fees { get; set; }

        public clsApplicationType()
        {
            this.ID = 0;
            this.Titel = string.Empty;
            this.Fees = 0;
            Mode = enMode.AddNew;
        }

        public clsApplicationType(int ID , string ApplicationTypeTitel, float ApplicationTypeFees)
        {
           this.ID = ID;
           this.Titel = ApplicationTypeTitel;
           this.Fees = ApplicationTypeFees;

            Mode = enMode.Update;

        }

        private bool _AddNewApplicationType()
        {
            this.ID = clsApplicationTypesData.AddNewApplicationTypes(this.Titel, this.Fees);

            return (this.ID != -1 );
        }

        private bool _UpdateApplicationType()
        {
            return clsApplicationTypesData.UpdateApplicationTypes(this.ID, this.Titel, this.Fees);
        }

        public static DataTable GetAllApplicationTypes()
        {
            //call dataAccess
            return clsApplicationTypesData.GetAllApplicationTypes();
        }

        public bool Save()
        {

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplicationType())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }

                case enMode.Update:

                    return _UpdateApplicationType();
            }


            return false;
        }

        public static clsApplicationType Find(int ID)
        {
            string Titel = "";
            float Fees = 0.0f;

            bool Isfound = clsApplicationTypesData.GetApplicationTypeByID(ID,ref Titel,ref  Fees);

            if(Isfound)
            {
                return new clsApplicationType(ID,Titel,Fees);
            }
            else
            {
                return null;
            }


        }

    }
}
