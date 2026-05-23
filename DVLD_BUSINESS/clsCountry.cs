using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace DVLD_BUSINESS
{
    public class clsCountry
    {

        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public clsCountry()
        {
            this.CountryID = -1;
            this.CountryName = "";
            // Mode = enMode.AddNew;

        }

        private clsCountry(int CountryID, string Name)
        {
            this.CountryID = CountryID;
            this.CountryName = Name;
            //  Mode = enMode.Update;
        }

        public static clsCountry Find(string CountryName)
        {
            int CountryID = -1;

            if (clsCountryData.GetCountryInfoByName(CountryName, ref CountryID))
            {
                return new clsCountry(CountryID, CountryName);
            }
            else
                return null;

        }
        public static clsCountry Find(int CountryID)
        {
            string Countryname = "";

            if (clsCountryData.GetCountryInfoByID(CountryID, ref Countryname))
            {
                return new clsCountry(CountryID, Countryname);
            }
            else
                return null;

        }

        public static DataTable GetAllCountries()
        {
            return clsCountryData.GetAllCountries();
        }

    }
}
