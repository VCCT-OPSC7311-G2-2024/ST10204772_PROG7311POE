using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROGPOE7311.Classes
{
    public class Validation
    {

        public bool ValidateLogin(string username, string password)
        {
            DatabaseController dbController = new DatabaseController();
            if (dbController.IsValidUser(username, password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidString(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }
            else
            {

                return true;
            }
        }

        public bool ValidDate(string dateval)
        {
            if (string.IsNullOrEmpty(dateval))
            {
                if (!DateTime.TryParse(dateval, out DateTime z))
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        


    }


}