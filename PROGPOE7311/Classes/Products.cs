using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROGPOE7311.Classes
{
    public class Products
    {
        public static string ProdName { get; set; }
        public static string ProdCategory { get; set; }
        public static DateTime ProdDate { get; set; }
        public static string UserName { get; set; }

        public Products() { }

        public Products(string pName, string pCategory, DateTime pDate, string uName)
        {
            ProdName = pName;
            ProdCategory = pCategory;
            ProdDate = pDate;
            UserName = uName;
        }

    }
}