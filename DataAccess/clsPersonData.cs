using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class clsPersonData
    {
        public static bool GetPersonInfoByPersonID(int ID, ref string NationalN,
        ref string Firstname, ref string secondname, ref string thirdname,
        ref string lastname, ref string Email, ref string Phone, ref string Address,
        ref DateTime dateOfbirth, ref byte Gender, ref string imagepath, ref int CountryID)
        {
            bool IsFound = false;

           const string Query = "select * from People where PersonID = @PersonID";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand(Query, connection))
                {
                    cmd.Parameters.AddWithValue("@PersonID", ID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (!reader.Read())
                                return false;

                            NationalN = (string)reader["NationalNO"];
                            Firstname = (string)reader["Firstname"];
                            secondname = (string)reader["Secondname"];
                            lastname = (string)reader["Lastname"];
                            //Thirdname: allows null in database so we should handle null
                            thirdname = reader["Thirdname"] as string ?? "";
                                //Email: allows null in database so we should handle null
                                Email = reader["Email"] as string ?? "";
                                Phone = (string)reader["Phone"];
                                Address = (string)reader["Address"];
                                CountryID = (int)reader["NationalityCountryID"];
                                Gender = (byte)(reader["Gendor"]);
                                dateOfbirth = (DateTime)reader["DateOfBirth"];
                                //ImagePath: allows null in database so we should handle null
                                imagepath = reader["ImagePath"] as string ?? "";
                            return true;
                           
                        }
                    }
                    catch (Exception ex )
                    {
                        clsEventLog.LogException("GetPersonInfoByPersonID", ex);
                        return false;
                    }
                }
            }
        }

       

        public static bool GetPersonInfoByNationalN( string NationalN, ref int ID,
        ref string Firstname, ref string secondname, ref string thirdname,
        ref string lastname, ref string Email, ref string Phone, ref string Address,
        ref DateTime dateOfbirth, ref byte Gender, ref string imagepath, ref int CountryID)
        {
            bool IsFound = false;

            const string Query = "select * from People where NationalNo = @NationalNo";

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(Query, connection))
                {
                    cmd.Parameters.AddWithValue("@NationalNo", NationalN);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (!reader.Read())
                                return false;


                            ID = (int)reader["PersonID"];
                            Firstname = (string)reader["Firstname"];
                            secondname = (string)reader["Secondname"];
                            lastname = (string)reader["Lastname"];
                            //Thirdname: allows null in database so we should handle null
                            thirdname = reader["Thirdname"] as string ?? "";
                            //Email: allows null in database so we should handle null
                            Email = reader["Email"] as string ?? "";
                            Phone = (string)reader["Phone"];
                            Address = (string)reader["Address"];
                            CountryID = (int)reader["NationalityCountryID"];
                            Gender = (byte)(reader["Gendor"]);
                            dateOfbirth = (DateTime)reader["DateOfBirth"];
                            //ImagePath: allows null in database so we should handle null
                            imagepath = reader["ImagePath"] as string ?? "";

                            return true;
                        }
                    }
                    catch (Exception ex)
                    {
                        clsEventLog.LogException("GetPersonInfoByNationalN", ex);
                        return false;
                    }
                }

            }
            
        }
        
        public static int AddNewPerson( string NatinalN,string Firstname,  string secondname,
        string thirdname,string lastname, string Email,
        string Phone,string Address,DateTime dateOfbirth,
        byte Gender,string imagepath,int CountryID)
        {
            int PersonID = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
                                                                                          
            SqlCommand command = new SqlCommand("SP_AddNewPerson", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@NationalNo", SqlDbType.NVarChar, 20).Value = NatinalN;
            command.Parameters.Add("@FirstName", SqlDbType.NVarChar, 20).Value = Firstname;
            command.Parameters.Add("@SecondName", SqlDbType.NVarChar, 20).Value = secondname;

            //Thirdname: allows null in database so we should handle null
            command.Parameters.Add("@ThirdName", SqlDbType.NVarChar, 20).Value =
                string.IsNullOrEmpty(thirdname) ? (object)DBNull.Value : thirdname;

            command.Parameters.Add("@LastName", SqlDbType.NVarChar, 20).Value = lastname;
            command.Parameters.Add("@DateOfBirth", SqlDbType.DateTime2).Value = dateOfbirth;
            command.Parameters.Add("@Gendor", SqlDbType.TinyInt).Value = Gender;
            command.Parameters.Add("@Address", SqlDbType.NVarChar, 500).Value = Address;
            command.Parameters.Add("@Phone", SqlDbType.NVarChar, 20).Value = Phone;

            //Email: allows null in database so we should handle null
            command.Parameters.Add("@Email", SqlDbType.NVarChar, 100).Value =
            string.IsNullOrEmpty(Email) ? (object)DBNull.Value : Email;

            //ImagePath: allows null in database so we should handle null
            command.Parameters.Add("@ImagePath", SqlDbType.NVarChar, 250).Value =
                string.IsNullOrEmpty(imagepath) ? (object)DBNull.Value : imagepath;

        
            
            command.Parameters.Add("@NationalityCountryID", SqlDbType.Int).Value = CountryID ;

            try
            {                                       
                connection.Open();

                object Result = command.ExecuteScalar();

                if(Result != null && int.TryParse(Result.ToString(), out int insertedID))
                {
                    PersonID = insertedID;
                }

            }
            catch (Exception ex)
            {
                clsEventLog.LogException("AddNewPerson", ex);
                
            }
            finally
            {
                connection.Close();
            }

            return PersonID;

        }

        public static bool UpdateContact(int ID, string NationalN, string FirstName, string SecondName, string ThirdName, string LastName,
        string Email, string Phone, string Address, byte Gender,
        DateTime DateOfBirth, int CountryID, string ImagePath)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand("SP_UpdatePerson", connection);
            command.CommandType = CommandType.StoredProcedure;  
            command.Parameters.Add("@NationalNo", SqlDbType.NVarChar, 20).Value = NationalN;
            command.Parameters.Add("@FirstName", SqlDbType.NVarChar, 20).Value = FirstName;
            command.Parameters.Add("@SecondName", SqlDbType.NVarChar, 20).Value = SecondName;

            //Thirdname: allows null in database so we should handle null
             command.Parameters.Add("@ThirdName", SqlDbType.NVarChar, 20).Value =
               string.IsNullOrEmpty( ThirdName) ? (object)DBNull.Value : ThirdName;


            command.Parameters.Add("@LastName", SqlDbType.NVarChar, 20).Value = LastName;
            command.Parameters.Add("@DateOfBirth", SqlDbType.DateTime2).Value = DateOfBirth;
            command.Parameters.Add("@Gendor", SqlDbType.TinyInt).Value = Gender;
            command.Parameters.Add("@Address", SqlDbType.NVarChar, 500).Value = Address;
            command.Parameters.Add("@Phone", SqlDbType.NVarChar, 20).Value = Phone;

            //Email: allows null in database so we should handle null
            command.Parameters.Add("@Email", SqlDbType.NVarChar, 250).Value =
                string.IsNullOrEmpty(Email) ? (object)DBNull.Value : Email ;


            //ImagePath: allows null in database so we should handle null
            command.Parameters.Add("@ImagePath", SqlDbType.NVarChar, 250).Value =
            string.IsNullOrEmpty(ImagePath) ? (object)DBNull.Value : ImagePath;

            command.Parameters.Add("@NationalityCountryID", SqlDbType.Int).Value = CountryID;
            command.Parameters.Add("@PersonID", SqlDbType.Int).Value = ID;

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) {

                clsEventLog.LogException("UpdateContact", ex);
            }
            finally
            {
                connection.Close();
            }

            return RowsAffected > 0;
        }

        public static DataTable GetallPeople()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);


            SqlCommand command = new SqlCommand("SP_GetAllPeople", connection);
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

              
                dt.Load(reader);
              
              
                reader.Close();

            }
            catch (Exception ex)
            {

                clsEventLog.LogException("GetallPeople", ex);
               
            }
            finally
            {
                connection.Close();
            }


           return dt;
        }

        public static int GetPeopleCount()
        {
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "SELECT COUNT(*) FROM People";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                return (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                clsEventLog.LogException("GetPeopleCount", ex);
                return 0;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool DeletePerson(int ID)
        {
            int RowAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);


            SqlCommand command = new SqlCommand("SP_DeletePerson", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@PersonID", ID);

            try
            {
                connection.Open();

                RowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsEventLog.LogException("DeletePerson", ex);
            }
            finally
            {
                connection.Close();
            }

            return RowAffected > 0;
        }

        public static bool IsPersonExist(int ID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

          
            SqlCommand command = new SqlCommand("SP_CheckPersonExsit", connection);
            command.CommandType = CommandType.StoredProcedure;  
            command.Parameters.Add("@PersonID", SqlDbType.Int).Value = ID;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                IsFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                clsEventLog.LogException("IsPersonExist", ex);
               IsFound = false;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static bool IsPersonExist(string NationalNo)
        {
            bool Isfound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);


            SqlCommand command = new SqlCommand("SP_CheckPersonExsitByNatinalNo", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@NationalNo", SqlDbType.NVarChar, 20).Value = NationalNo;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                Isfound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                clsEventLog.LogException("IsPersonExist", ex);
               Isfound = false;
            }
            finally
            {
                connection.Close();
            }

            return Isfound;
        }


    }
}
