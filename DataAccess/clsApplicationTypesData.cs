using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class clsApplicationTypesData
    {

        public static bool  GetApplicationTypeByID(int AppID,ref string Titel,ref float Fees)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "SELECT * FROM ApplicationTypes WHERE ApplicationTypeID = @AppID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppID", AppID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    IsFound = true;
                    Titel = (string)reader["ApplicationTypeTitle"];
                    Fees = (float)reader["ApplicationFees"];

                }
                else
                {
                    // The record was not found
                    IsFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

                IsFound = false;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;


        }
        public static DataTable GetAllApplicationTypes()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = "Select * ApplicationTypes order by ApplicationTypeTitle ";

            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                dt.Load(reader);


                reader.Close();

            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }


            return dt;
        }

        public static int AddNewApplicationTypes(string Titel, float Fees)
        {
            int ApplicationTypeID = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string Query = @"INSERT INTO ApplicationTypes (ApplicationTypeTitle,ApplicationFees)
                             Values(@ApplicationTypeTitle,@ApplicationFees);
                               SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ApplicationTypeTitle", Titel);
            command.Parameters.AddWithValue("@ApplicationFees", Fees);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int insertedID))
                {
                    ApplicationTypeID = insertedID;
                }

            }
            catch (Exception ex)
            {
                //  Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();

            }

            return ApplicationTypeID;



        }

        public static bool UpdateApplicationTypes(int ApplicationTypeID,string Titel, float Fees)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string Query = @"UPDATE ApplicationTypes
                            SET
                                ApplicationTypeTitle   = @Titel ,
                                ApplicationFees    = @Fees  ,
                              
                               WHERE ApplicationTypeID = @ApplicationTypeID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ApplicationTypeTitle", Titel);
            command.Parameters.AddWithValue("@ApplicationFees", Fees);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //  Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();

            }

            return RowsAffected > 0;



        }




    }
}
