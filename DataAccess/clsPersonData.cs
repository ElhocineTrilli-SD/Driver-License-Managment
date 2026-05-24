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

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = "select * from People where PersonID = @PersonID";

            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@PersonID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    NationalN = (string)reader["NationalNO"];
                    Firstname = (string)reader["Firstname"];
                    secondname = (string)reader["Secondname"];
                    lastname = (string)reader["Lastname"];


                    //Thirdname: allows null in database so we should handle null
                    if ( reader["Thirdname"] != DBNull.Value)
                    {
                        thirdname = (string)reader["Thirdname"];
                    }
                    else
                    {
                        thirdname = "";
                    }

                    //Email: allows null in database so we should handle null
                    if (reader["Email"]!=DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    else
                    {
                        Email = "";
                    }

                    Phone = (string)reader["Phone"];
                    Address = (string)reader["Address"];
                    CountryID = (int)reader["NationalityCountryID"];
                    Gender = (byte)(reader["Gendor"]);
                    dateOfbirth = (DateTime)reader["DateOfBirth"];

                    //ImagePath: allows null in database so we should handle null
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        imagepath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        imagepath = "";
                    }
                }
                else
                {
                    IsFound= false;
                }
              
            }
            catch (Exception ex)
            {
               // Console.WriteLine(ex.Message);
               IsFound=false;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        public static bool GetPersonInfoByNationalN( string NationalN, ref int ID,
        ref string Firstname, ref string secondname, ref string thirdname,
        ref string lastname, ref string Email, ref string Phone, ref string Address,
        ref DateTime dateOfbirth, ref byte Gender, ref string imagepath, ref int CountryID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string Query = "select * from People where NationalNo = @NationalNo";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@NationalNo",NationalN);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    ID = (int)reader["PersonID"];  
                    Firstname = (string)reader["Firstname"];
                    secondname = (string)reader["Secondname"];
                    lastname = (string)reader["Lastname"];


                    //Thirdname: allows null in database so we should handle null
                    if (reader["Thirdname"] != DBNull.Value)
                    {
                        thirdname = (string)reader["Thirdname"];
                    }
                    else
                    {
                        thirdname = "";
                    }

                    //Email: allows null in database so we should handle null
                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    else
                    {
                        Email = "";
                    }

                    Phone = (string)reader["Phone"];
                    Address = (string)reader["Address"];
                    CountryID = (int)reader["NationalityCountryID"];
                    Gender = (byte)(reader["Gendor"]);
                    dateOfbirth = (DateTime)reader["DateOfBirth"];

                    //ImagePath: allows null in database so we should handle null
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        imagepath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        imagepath = "";
                    }
                }
                else
                {
                    IsFound = false;
                }

            }
            catch (Exception ex)
            {
                // Console.WriteLine(ex.Message);
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }
        
        public static int AddNewPerson( string NatinalN,string Firstname,  string secondname,
        string thirdname,string lastname, string Email,
        string Phone,string Address,DateTime dateOfbirth,
        byte Gender,string imagepath,int CountryID)
        {

            int PersonID = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string Query = @"INSERT INTO People (NationalNo,FirstName,SecondName,ThirdName ,
                            LastName,DateOfBirth, Gendor ,Address ,Phone, Email,
                            NationalityCountryID,ImagePath  )
                            VALUES (@NationalNo,@FirstName,@SecondName,@ThirdName,
                            @LastName,@DateOfBirth,@Gendor,@Address,@Phone,
                            @Email,@NationalityCountryID,@ImagePath);            
                            SELECT SCOPE_IDENTITY();";
                                                       
                                               
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@NationalNo", NatinalN);
            command.Parameters.AddWithValue("@FirstName", Firstname);
            command.Parameters.AddWithValue("@SecondName", secondname);

            //Thirdname: allows null in database so we should handle null
            if (thirdname != "" && thirdname != null )
            {
                command.Parameters.AddWithValue("@ThirdName", thirdname);
            }
            else
            {
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);
            }

            command.Parameters.AddWithValue("@LastName", lastname);
            command.Parameters.AddWithValue("@DateOfBirth",dateOfbirth);
            command.Parameters.AddWithValue("@Gendor", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);

            //Email: allows null in database so we should handle null
            if (Email != "" && Email != null)
            {
                command.Parameters.AddWithValue("@Email", Email);
            }
            else
            {
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);
            }

            //ImagePath: allows null in database so we should handle null
            if (imagepath != "")
            {
               command.Parameters.AddWithValue("@ImagePath", imagepath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }

            
            command.Parameters.AddWithValue("@NationalityCountryID", CountryID);

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
                Console.WriteLine(ex.Message);
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

            string query = @"UPDATE People
                             SET FirstName   = @FirstName  ,
                               NationalNo    = @NationalNo   ,
                               SecondName    = @SecondName   ,
                               ThirdName    = @ThirdName   ,
                               LastName    = @LastName   ,
                               Email       = @Email      ,
                               Phone       = @Phone      ,
                               Address     = @Address    ,
                               DateOfBirth = @DateOfBirth,
                               Gendor      = @Gendor,
                               NationalityCountryID   = @NationalityCountryID  ,
                               ImagePath   = @ImagePath  
                                 WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalN);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);

            //Thirdname: allows null in database so we should handle null
            if (ThirdName != "" && ThirdName != null)
            {
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            }
            else
            {
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);
            }

            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);

            //Email: allows null in database so we should handle null
            if (Email != "" && Email != null)
            {
                command.Parameters.AddWithValue("@Email", Email);
            }
            else
            {
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);
            }

            //ImagePath: allows null in database so we should handle null
            if (ImagePath != "" && ImagePath != null)
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }

            command.Parameters.AddWithValue("@NationalityCountryID", CountryID);

            command.Parameters.AddWithValue("@PersonID", ID);



            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { Console.WriteLine("error: " + ex.Message); }
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

            string Query = "Select * from PeopleList";

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
                Console.WriteLine(ex.Message);
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
            catch
            {
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

            string Query = "Delete People where PersonID = @PersonID ";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", ID);

            try
            {
                connection.Open();

                RowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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

            string Query = "select Found = 1  from People where PersonID = @PersonID ";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                IsFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
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

            string Query = "select Found = 1 from People where NationalNo = @NationalNo ";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("NationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                Isfound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
               // Console.WriteLine(ex.Message);
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
