using PROGPOE7311.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROGPOE7311
{
    public partial class ProductsView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    if (SQLdsPROGDB != null && SQLdsPROGDB.SelectParameters["UserID"] != null)
                    {
                        CurrentUser cUser = new CurrentUser();
                        int userID = cUser.GetUserID();
                        SQLdsPROGDB.SelectParameters["UserID"].DefaultValue = userID.ToString();
                    }
                }
                catch (NullReferenceException ex)
                {

                }

            }
        }
    }
}