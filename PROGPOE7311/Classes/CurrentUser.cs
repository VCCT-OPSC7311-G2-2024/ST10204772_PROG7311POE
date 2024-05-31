using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROGPOE7311.Classes
{
    public class CurrentUser
    {
        public static int uID { get; set; }
        public static string uName { get; set; }
        public static string uEmail { get; set; }
        public static string uPassword { get; set; }
        public static string uType { get; set; }


        public CurrentUser() { }


        public CurrentUser(int cID, string cName, string cEmail, string cPassword, string cType)
        {
            uID = cID;
            uName = cName;
            uEmail = cEmail;
            uPassword = cPassword;
            uType = cType;
        }

        public int GetUserID() { return uID; }

        public string GetUserType() { return uType; }
    }
}