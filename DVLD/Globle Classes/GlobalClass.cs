using DVLD_BUSINESS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
namespace DVLD.Globle_Classes
{
    internal class GlobalClass
    {
        public static clsUser CurrentUser;

        public static bool RememberUsernameAndPassword(string Username, string Password)
        {
            string KeyPath = @"HKEY_CURRENT_USER\Software\DVLD";

            string UserNameTitel = "UserName";
            string UserNameData = Username;
            string PasswordTitel = "Password";
            string PasswordData = Password;

            try
            {
               Registry.SetValue(KeyPath,UserNameTitel,UserNameData,RegistryValueKind.String);
               Registry.SetValue(KeyPath, PasswordTitel, PasswordData, RegistryValueKind.String);

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }

        }

        public static bool GetStoredCredential(ref string Username, ref string Password)
        {
            //this will get the stored username and password and will return true if found and false if not found.
            string keyPath = @"HKEY_CURRENT_USER\Software\DVLD";
            string PasswordTitel = "Password";
            string UserNameTitel = "UserName";

            try
            {
                 Username = Registry.GetValue(keyPath, UserNameTitel, null) as string;
                 Password = Registry.GetValue(keyPath, PasswordTitel, null) as string;
                return true;
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }

        }
    }
}
