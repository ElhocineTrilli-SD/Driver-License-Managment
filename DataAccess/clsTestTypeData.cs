using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class clsTestTypeData
    {

        public static bool GetTestTypeByID(int TestTypeID, ref string testDescription ,ref string TestTitel, ref float TestFees)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "SELECT * FROM TestTypes WHERE TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    IsFound = true;
                    TestTitel = (string)reader["TestTypeTitle"];
                    TestFees = Convert.ToSingle(reader["TestTypeFees"]);
                    testDescription = (string)reader["TestTypeDescription"];
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
        public static DataTable GetAllTestTypes()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = "Select * from TestTypes order by TestTypeTitle  ";

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

        public static int AddNewTestTypes(string Titel,string Description, float Fees)
        {
            int TestTypeID = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string Query = @"INSERT INTO TestTypes (TestTypeTitle,TestTypeDescription,TestTypeFees)
                             Values(@TestTypeTitle,@TestTypeDescription,@TestTypeFees);
                               SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TestTypeTitle", Titel);
            command.Parameters.AddWithValue("@TestTypeFees", Fees);
            command.Parameters.AddWithValue("@TestTypeDescription", Description);



            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int insertedID))
                {
                    TestTypeID = insertedID;
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

            return TestTypeID;



        }

        public static bool UpdateTestTypes(int TestTypeID, string Titel,string Description, float Fees)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string Query = @"UPDATE TestTypes
                            SET
                                TestTypeTitle   = @Titel ,
                                TestTypeDescription = @Description ,
                                TestTypeFees    = @Fees  
                              
                               WHERE TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Titel", Titel);
            command.Parameters.AddWithValue("@Fees", Fees);
            command.Parameters.AddWithValue("@Description",Description);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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
