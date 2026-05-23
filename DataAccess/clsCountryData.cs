using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class clsCountryData
    {
        public static DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string Query = "Select * from Countries";
            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                IDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    dt.Load(reader);
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }


            return dt;
        }

        public static bool GetCountryInfoByName(string Name, ref int CounrtyID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"Select * from Countries Where CountryName = @CountryName ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryName", Name);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    CounrtyID = (int)reader["CountryID"];
                  
                  
                }
                else
                {
                    // The record was not found
                    IsFound = false;
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {

                connection.Close();

            }


            return IsFound;
        }

        public static bool GetCountryInfoByID(int CountryID, ref string Name)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"Select * from Countries Where CountryID = @CountryID ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    Name = (string)reader["CountryName"];
                }
                else
                {
                    // The record was not found
                    IsFound = false;
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {

                connection.Close();

            }


            return IsFound;
        }

    }
}
