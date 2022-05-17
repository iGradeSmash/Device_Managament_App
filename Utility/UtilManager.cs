using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Device_Managament_App.Utility
{
    public class UtilManager
    {
        public static class Constants
        {
            public const string DATABASE_CONNECTION = @"Data Source=(localdb)\ProjectModels; Database=Device_Management_db";
            public const string TABLE_NAME_DEVICES = "[Devices]";
            public const string TABLE_NAME_USERS = "[Users]";
            public const string TABLE_NAME_DEVICE_MANAGER = "[Device_Manager]";
           
        }
        public static class Variables
        {
            public static int UserID = 0;
            public static int RoleId = 0;
            public static string UserName = "";
        }
        public static class Validation
        {
            public static string PasswordEncode(string plainText)
            {
                var plainBytes = Encoding.UTF8.GetBytes(plainText);
                return System.Convert.ToBase64String(plainBytes);
            }
            public static string PasswordDecode(string encodedData)
            {
                var encodedBytes = System.Convert.FromBase64String(encodedData);
                return Encoding.UTF8.GetString(encodedBytes);
            }

            public static bool IsValidEmail(string email)
            {
              
                    bool isEmail = Regex.IsMatch(email.Trim(), @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);

                    return isEmail;
             
            }
        }
        

        
       
    }
  
}
