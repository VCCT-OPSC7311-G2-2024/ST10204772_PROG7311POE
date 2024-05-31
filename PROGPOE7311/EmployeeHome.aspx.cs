using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROGPOE7311
{
    public partial class EmployeeHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnProductView_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProducts.aspx");
        }

        protected void btnAddFarmer_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddFarmer.aspx");
        }
    }
}