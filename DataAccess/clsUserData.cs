using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class clsUserData
    {

        public static bool GetUserInfoByUserID(int UserID, ref int PersonID, ref string UserName,
          ref string Password, ref bool IsActive)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];


                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool GetUserInfoByPersonID(int PersonID, ref int UserID, ref string UserName,
        ref string Password, ref bool IsActive)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    UserID = (int)reader["UserID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];


                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool GetUserInfoByUsernameAndPassword(string UserName, string Password,
          ref int UserID, ref int PersonID, ref bool IsActive)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users WHERE Username = @Username and Password=@Password;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", UserName);
            command.Parameters.AddWithValue("@Password", Password);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;
                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];


                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static int AddNewUser( int PersonID ,string username,
                                      string password,bool IsActive)
        {
            int UserID = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string Query = @"INSERT INTO Users (PersonID,username,password,IsActive)
                             Values(@PersonID,@username,@password,@IsActive);
                               SELECT SCOPE_IDENTITY();";
            
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int insertedID))
                {
                    UserID = insertedID;
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

            return UserID;


        }

        public static bool UpdateUser(int UserID,int PersonID,string UserName,string Password
                                      ,bool IsActive)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = @"UPDATE Users
                            SET PersonID   = @PersonID  ,
                               UserName    = @UserName   ,
                               IsActive    = @IsActive   ,
                               Password    = @Password 
                               WHERE UserID = @UserID";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);


            try
            {
                connection.Open();
                RowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex) 
            {
                //Console.WriteLine("error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return RowsAffected > 0;





        }

        public static DataTable GetAllUser()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = "Select * from vwUsers";  

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

        public static int GetUsersCount()
        {
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "SELECT COUNT(*) FROM Users";

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

        public static bool DeleteUser(int UserID)
        {
            int RowAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = "Delete Users where UserID = @UserID ";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

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

        public static bool IsUserExist(int UserID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = "select Found = 1  from Users where UserID = @UserID ";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

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

        public static bool IsUserExist(string UserName)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = "Select Found = 1  from Users where UserName = @UserName ";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);

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

        public static bool IsUserExistForPersonID(int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Users WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool ChangePassword(int UserID, string NewPassword)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"Update  Users  
                            set Password = @Password
                            where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("Password", NewPassword);



            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }


    }
}
