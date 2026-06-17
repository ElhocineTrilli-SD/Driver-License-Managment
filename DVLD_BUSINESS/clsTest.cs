using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BUSINESS
{
    public class clsTest
    {
        public enum enMode { AddNew = 0, Update = 1 };
        enMode Mode;
        public int TestID { get; set; }
        public int TestAppoitmentID { get; set; }
        public clsTestAppoitments _TestAppoitmentsInfo;
        public byte TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }
        public clsTest()
        {
            this.TestID = -1;
            this.TestAppoitmentID = -1;
            this.TestResult = 0;
            this.Notes = "";
            this.CreatedByUserID = -1;

            Mode = enMode.AddNew;
        }
        public clsTest ( int testID, int testAppoitmentID, byte testResult, string notes, int createdByUserID)
        {
            
            this.TestID = testID;
            this.TestAppoitmentID = testAppoitmentID;
            this._TestAppoitmentsInfo = clsTestAppoitments.Find(testAppoitmentID);
            this.TestResult = testResult;
            this.Notes = notes;
            this.CreatedByUserID = createdByUserID;
            Mode = enMode.Update;
        }
        public static clsTest Find(int TestID)
        {
           int  testAppoitmentID = -1  , createdByUserID = -1;
            byte testResult = 0;
            string notes = "";

            bool IsFound = clsTestData.GetTestInfoByID(TestID, ref testAppoitmentID, ref testResult, ref notes, ref createdByUserID);

            if(IsFound )
            {
             return new  clsTest(TestID, testAppoitmentID, testResult, notes, createdByUserID);

            }
            else { return null; }


        }
        
        public static clsTest FindLastTestByPersonAndLicenseClassAndTestType(int PersonID , int LicenseClassID,
            clsTestType.enTestType testTypeID)
        {
            int testAppoitmentID = -1, CreatedByUserID = -1, TestID = -1;
            byte testResult = 0;
            string notes = "";

            bool IsFound = clsTestData.GetLastTestByPersonAndTestTypeAndLicenseClass(PersonID, LicenseClassID,(int) testTypeID,
            ref TestID , ref testAppoitmentID, ref testResult, ref notes, ref CreatedByUserID);

            if (IsFound)
            {
                return new clsTest(TestID, testAppoitmentID, testResult, notes, CreatedByUserID);

            }
            else { return null; }


        }

        private bool _AddNewTest()
        {
            //call DataAccess Layer 

            this.TestID = clsTestData._AddNewTest(this.TestAppoitmentID,
                this.TestResult, this.Notes, this.CreatedByUserID);

            return (this.TestID != -1);
        }
        private bool _UpdateTest()
        {
            //call DataAccess Layer 
            return clsTestData._UpdateTest(this.TestID,this.TestAppoitmentID,this.TestResult,this.Notes, this.CreatedByUserID);
        }
        public static byte GetPassedTestCount(int LocalDrivingLicenseApplicationID)
        {
            return clsTestData.GetPassedTestCount(LocalDrivingLicenseApplicationID);

        }
        public static bool IsPassedAllTest(int LocalDrivingLicenseApplicationID)
        {
            return (clsTestData.GetPassedTestCount(LocalDrivingLicenseApplicationID) == 3);

        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTest())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateTest();

            }

            return false;
        }
    }
}
