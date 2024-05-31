using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROGPOE7311.Classes;


namespace PROGPOE7311
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Validation val = new Validation();
            string uName = tbUsername.Text;
            string uPassword = tbPassword.Text;

            if (val.ValidateLogin(uName, uPassword))
            {
                CurrentUser cUser = new CurrentUser();
                string uType = cUser.GetUserType();

                switch (uType)
                {
                    case "Farmer":
                        Response.Redirect("FarmerHome.aspx");
                        break;

                    case "Employee":
                        Response.Redirect("EmployeeHome.aspx");
                        break;

                    default:
                        Response.Redirect(ErrorPage);
                        break;
                }
            }
            else
            {
                //Error
            }
        }
    }
}