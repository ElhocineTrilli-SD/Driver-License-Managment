using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BUSINESS
{
    public class clsTestAppoitments
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int TestAppoitmentID { get; set; }
        public clsTestType.enTestType TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID {get;set;}
        public DateTime AppoitmentDate { get; set; }
        public int CreatedByUserID { get; set; }
        public float PaidFees { get; set; }
        public bool IsLocked { get; set; }
        public int RetakeTestApplicationID { get; set; }
        public clsApplication RetakeTestAppInfo;
        public int TestID 
            {
            get
            {
                return _GetTestID();
            }
            }
            

        public clsTestAppoitments()
        {
            this.TestAppoitmentID = -1;
            this.RetakeTestApplicationID = -1;
            this.PaidFees = 0;
            this.IsLocked = false;
            this.CreatedByUserID = -1;
            this.TestTypeID = clsTestType.enTestType.VisionTest;
            this.AppoitmentDate = DateTime.Now;
            this.LocalDrivingLicenseApplicationID = -1;

            Mode = enMode.AddNew;
        }

        public clsTestAppoitments(int TestAppointmentID, clsTestType.enTestType TestTypeID,
          int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, float PaidFees,
          int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)

        {
            this.TestAppoitmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppoitmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
            this.RetakeTestApplicationID = RetakeTestApplicationID;
            this.RetakeTestAppInfo = clsApplication.FindBaseApplication(RetakeTestApplicationID);
            Mode = enMode.Update;
        }


        public static clsTestAppoitments Find(int TestAppoitment)
        {
            int TestTypeID = 1; int LocalDrivingLicenseApplicationID = -1;
            DateTime AppointmentDate = DateTime.Now; float PaidFees = 0;
            int CreatedByUserID = -1; bool IsLocked = false; int RetakeTestApplicationID = -1;

            if (clsTestAppointmentData.GetTestAppoitmentByID(TestAppoitment, ref TestTypeID, ref LocalDrivingLicenseApplicationID,
          ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID))

                return new clsTestAppoitments(TestAppoitment, (clsTestType.enTestType)TestTypeID, LocalDrivingLicenseApplicationID,
                    AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
            else
                return null;



        }

        public static clsTestAppoitments GetLastTestAppointment(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestTypeID)
        {
            int TestAppointmentID = -1;
            DateTime AppointmentDate = DateTime.Now; float PaidFees = 0;
            int CreatedByUserID = -1; bool IsLocked = false; int RetakeTestApplicationID = -1;

            if (clsTestAppointmentData.GetLastTestAppoitment(LocalDrivingLicenseApplicationID, (int)TestTypeID,
                ref TestAppointmentID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID))

                return new clsTestAppoitments(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID,
             AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
            else
                return null;

        }
        private bool _AddNewTestAppointment()
        {
            //call DataAccess Layer 

            this.TestAppoitmentID = clsTestAppointmentData.AddNewTestApoitment((int)this.TestTypeID, this.LocalDrivingLicenseApplicationID,
                this.AppoitmentDate, this.PaidFees, this.CreatedByUserID,this.IsLocked,this.RetakeTestApplicationID);

            return (this.TestAppoitmentID != -1);
        }

        private bool _UpdateTestAppointment()
        {
            //call DataAccess Layer 

            return clsTestAppointmentData.UpdateTestApoitment(this.TestAppoitmentID, (int)this.TestTypeID, this.LocalDrivingLicenseApplicationID,
                this.AppoitmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked, this.RetakeTestApplicationID);
        }
        public static DataTable GetAllTestAppointments()
        {
            return clsTestAppointmentData.GetAllTestAppoitment();

        }

        public DataTable GetApplicationTestAppointmentsPerTestType(clsTestType.enTestType TestTypeID)
        {
            return clsTestAppointmentData.GetApplicationTestAppointmentsPerTestType(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);

        }

        public static DataTable GetApplicationTestAppointmentsPerTestType(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestTypeID)
        {
            return clsTestAppointmentData.GetApplicationTestAppointmentsPerTestType(LocalDrivingLicenseApplicationID, (int)TestTypeID);

        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTestAppointment())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateTestAppointment();

            }

            return false;
        }

        private int _GetTestID()
        {
            return clsTestAppointmentData.GetTestID(TestAppoitmentID);
        }
    }
}
