using PROGPOE7311.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROGPOE7311
{
    public partial class AddFarmer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddFarmer_Click(object sender, EventArgs e)
        {
            string fName = tbName.Text;
            string fEmail = tbEmail.Text;
            string fCell = tbCell.Text;

            //Check is valid
            if (string.IsNullOrEmpty(fName) || string.IsNullOrEmpty(fEmail))
            {
                DatabaseController db = new DatabaseController();
                //if farmer signs in with this password, they will be prompted to change it
                if(db.AddFarmer(fName, fEmail, fCell, "P@ssword1"))
                {
                    //yippee
                    Response.Redirect("EmployeeHome.aspx");
                }
                else
                {
                    // :(
                }
            }
        }
    }
}