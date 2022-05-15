using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Device_Managament_App.Utility
{
    public class GlobalVariables
    {
        public static int UserID = 0;
        public static int RoleId = 0;
        public static string UserName = "";

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
    }
}
