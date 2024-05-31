using PROGPOE7311.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROGPOE7311
{
    public partial class FarmerHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DatabaseController db = new DatabaseController();

            if(db.IsGeneratedPassword())
            {
                Label dynamicLabel = new Label();
                dynamicLabel.ForeColor = System.Drawing.Color.Red;
                dynamicLabel.Text = "Please change your password";
                this.Controls.Add(dynamicLabel);
            }
        }

        protected void btnView_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProducts.aspx");
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddProduct.aspx");
        }
    }
}