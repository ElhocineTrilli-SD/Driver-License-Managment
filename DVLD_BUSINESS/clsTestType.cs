using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BUSINESS
{
    public class clsTestType
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;
        public enum enTestType { VisionTest = 1, WrittenTest = 2,StreetTest = 3 };

        public clsTestType.enTestType ID {  get; set; }
        public string Titel { get; set; }
        public string Description { get; set; }
        public float Fees { get; set; }

        public clsTestType()
        {
            this.ID = clsTestType.enTestType.VisionTest;
            this.Titel = string.Empty;
            this.Fees = 0;
            this.Description = string.Empty;
            Mode = enMode.AddNew;

        }

        public clsTestType(clsTestType.enTestType ID , string TestTitel, string TestDescription,float TestFees)
        {
            this.ID = ID;
            this.Titel= TestTitel;
            this.Description = TestDescription;
            this.Fees = TestFees;
            Mode = enMode.Update;
        }


        private bool _AddNewTestType()
        {
            this.ID = (clsTestType.enTestType)clsTestTypeData.AddNewTestTypes(this.Titel, this.Description, this.Fees);

            return (this.Titel != "" );
        }

        private bool _UpdateTestType()
        {
            return clsTestTypeData.UpdateTestTypes((int)this.ID,this.Titel,this.Description,this.Fees);
        }

        public static DataTable GetAllTestTypes()
        {
            //call dataAccess
            return clsTestTypeData.GetAllTestTypes();
        }

        public bool Save()
        {

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTestType())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else { return false; }

                case enMode.Update:

                    return _UpdateTestType();
            }


            return false;
        }

        public static clsTestType Find(clsTestType.enTestType ID)
        {
            string Titel = "",Description ="";
            float Fees = 0.0f;

            bool Isfound = clsTestTypeData.GetTestTypeByID((int)ID,ref Description,ref Titel,ref Fees);

            if (Isfound)
            {
                return new clsTestType(ID,Titel,Description, Fees);
            }
            else
            {
                return null;
            }


        }

    }
}
