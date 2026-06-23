using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    //DetainDate]
    //FineFees]
    //CreatedByUserID]
    //IsReleased]
    //ReleaseDate]
    //ReleasedByUserID]
    //ReleaseApplicationID]
    //DVLD].[dbo].[DetainedLicenses]


    public class clsDetainLicenseData
    {
        public static bool GetDetainlicenseInfoByID(int DetainID,ref int LicenseID,
            ref DateTime DetainDate,ref float FineFees,ref int CreatedByUserID,
            ref bool IsReleased , ref DateTime ReleaseDate ,ref int  ReleasedByUserID,
            ref int ReleaseApplicationID)
        {
            bool Isfound = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT * FROM DetainedLicenses WHERE DetainID = @DetainID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DetainID", DetainID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    Isfound = true;
                    LicenseID = (int)reader["LicenseID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees = (float)reader["FineFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsReleased = (bool)reader["IsReleased"];
                    ReleaseDate = (DateTime)reader["ReleaseDate"];
                    ReleasedByUserID = (int)reader["ReleasedByUserID"];
                    ReleaseApplicationID = (int)reader["ReleaseApplicationID"];
                }

                reader.Close();
            }
            catch (Exception ex) { Isfound = false; }
            finally { connection.Close(); }
            return Isfound;
        }

        public static bool GetDetainlicenseInfoByLicenseID(int LicenseID, ref int DetainID,
         ref DateTime DetainDate, ref float FineFees, ref int CreatedByUserID,
         ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID,
         ref int ReleaseApplicationID)
        {
            bool Isfound = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT * FROM DetainedLicenses WHERE DetainID = @DetainID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DetainID", DetainID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Isfound = true;
                    DetainID = (int)reader["DetainID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees = (float)reader["FineFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsReleased = (bool)reader["IsReleased"];
                    ReleaseDate = (DateTime)reader["ReleaseDate"];
                    ReleasedByUserID = (int)reader["ReleasedByUserID"];
                    ReleaseApplicationID = (int)reader["ReleaseApplicationID"];
                }

                reader.Close();
            }
            catch (Exception ex) { Isfound = false; }
            finally { connection.Close(); }
            return Isfound;
        }

        public static DataTable GetAllDetainLicenses()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "SELECT * FROM DetainedLicenses_View ";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }


    }
}
