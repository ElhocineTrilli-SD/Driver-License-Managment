using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
namespace DVLD_BUSINESS
    {
   
        public class clsPerson
        {
            public enum enMode { AddNew = 0, Update = 1 };
            private enMode Mode;

            public int PersonID { get; set; }
            public string NationalNo { get; set; }
            public string Firstname { get; set; }
            public string Secondname { get; set; }
            public string thirdname { get; set; }
            public string lastname { get; set; }

            public string Fullname
            {
                get
                {
                    return Firstname + " " + Secondname + " " + thirdname + " " + lastname;
                }

            }

            public string Email { set; get; }
            public string Phone { set; get; }
            public string Address { set; get; }
            public DateTime DateOfBirth { set; get; }

            private string _ImagePath;
            //
            public string ImagePath
            {
                get { return _ImagePath; }
                set { _ImagePath = value; }
            }

            public byte Gender { set; get; }
            public int NationalityCountryID { set; get; }

            public clsCountry CountryInfo;


            public clsPerson()
            {
                //initial value
                this.PersonID = -1;
                this.NationalNo = "";
                this.Firstname = "";
                this.Secondname = "";
                this.thirdname = "";
                this.lastname = "";
                this.DateOfBirth = DateTime.Now;
                //this.Gender = 0;
                this.NationalityCountryID = -1;
                this.Address = "";
                this.Email = "";
                this.Phone = "";
                this.ImagePath = "";

                Mode = enMode.AddNew;
            }

            private clsPerson(int ID, string NatinalN, string Firstname,
            string secondname, string thirdname, string lastname,
            string Email, string Phone, string Address,
            DateTime dateOfbirth, byte Gender, string imagepath, int CountryID)
            {
                this.PersonID = ID;
                this.NationalNo = NatinalN;
                this.Firstname = Firstname;
                this.Secondname = secondname;
                this.thirdname = thirdname;
                this.lastname = lastname;
                this.Email = Email;
                this.Phone = Phone;
                this.Address = Address;
                this.DateOfBirth = dateOfbirth;
                this.Gender = Gender;
                this.ImagePath = imagepath;
                this.CountryInfo = clsCountry.Find(CountryID);

                Mode = enMode.Update;

            }

            private bool _AddnewPerson()
            {
                this.PersonID = clsPersonData.AddNewPerson(this.NationalNo, this.Firstname,
                                                        this.Secondname, this.thirdname, this.lastname,
                                                        this.Email, this.Phone, this.Address, this.DateOfBirth,
                                                        this.Gender, this.ImagePath, this.NationalityCountryID);

                return (this.PersonID != -1);
            }

            private bool _UpdatePerson()
            {
                return clsPersonData.UpdateContact(this.PersonID, this.NationalNo, this.Firstname,
                this.Secondname, this.thirdname, this.lastname, this.Email,
                this.Phone, this.Address, this.Gender, this.DateOfBirth, this.NationalityCountryID,
                this.ImagePath);
            }


            public static clsPerson Find(int ID)
            {
                string NatinalN = "", Firstname = "", secondname = "", thirdname = "";
                string lastname = "", Email = "", Phone = "", Address = "";
                string ImagePath = "";
                DateTime DateOfBirth = DateTime.Now;
                byte gender = 0;
                int NationalityCountryID = -1;
                //
                bool IsFound = clsPersonData.GetPersonInfoByPersonID
                    (
                      ID, ref NatinalN, ref Firstname,
                      ref secondname, ref thirdname, ref lastname, ref Email,
                      ref Phone, ref Address, ref DateOfBirth,
                      ref gender, ref ImagePath, ref NationalityCountryID

                      );

                if (IsFound)
                    return new clsPerson(
                        ID, NatinalN, Firstname, secondname,
                        thirdname, lastname, Email, Phone,
                        Address, DateOfBirth, gender, ImagePath,
                        NationalityCountryID
                        );

                else return null;

            }

            public static clsPerson Find(string NationalNo)
            {
               string Firstname = "", secondname = "", thirdname = "";
                string lastname = "", Email = "", Phone = "", Address = "";
                string ImagePath = "";
                DateTime DateOfBirth = DateTime.Now;
                byte gender = 0;
                int NationalityCountryID = -1, ID = -1;
                //
                bool IsFound = clsPersonData.GetPersonInfoByNationalN

                    (
                     NationalNo, ref ID, ref Firstname, ref secondname, ref thirdname,
                     ref lastname, ref Email,
                     ref Phone, ref Address, ref DateOfBirth, ref gender,
                     ref ImagePath, ref NationalityCountryID

                      );

                if (IsFound)
                    return new clsPerson(
                        ID,NationalNo, Firstname, secondname,
                        thirdname, lastname, Email, Phone,
                        Address, DateOfBirth, gender, ImagePath,
                        NationalityCountryID
                        );

                else return null;

            }

            public bool Save()
            {

                switch (Mode)
                {
                    case enMode.AddNew:
                        if (_AddnewPerson())
                        {

                            Mode = enMode.Update;
                            return true;
                        }
                        else { return false; }

                    case enMode.Update:

                        return _UpdatePerson();
                }


                return false;
            }

            public static DataTable GetallPeople()
            {
                return clsPersonData.GetallPeople();
            }


            public static int GetPeopleCount()
            {
                return clsPersonData.GetPeopleCount();
            }

            public static bool DeletePerson(int ID)
            {
                return clsPersonData.DeletePerson(ID);
            }

            public static bool IsPersonExist(int ID)
            {
                return clsPersonData.IsPersonExist(ID);
            }

            public static bool IsPersonExist(string NationalNo)
            {
                return clsPersonData.IsPersonExist(NationalNo);
            }





        }

    }


