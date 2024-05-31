using PROGPOE7311.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROGPOE7311.Classes;

namespace PROGPOE7311
{
    public partial class AddProduct : System.Web.UI.Page
    {
        CurrentUser cUser = new CurrentUser();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
//-------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        protected void lbtnAddCategory_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddCategory.aspx");
        }
//-------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        protected void btnAddProd_Click(object sender, EventArgs e)
        {
            Validation validation = new Validation();
            string prodName = tbProdName.Text;
            string prodCat = ddlCategory.Text;
            string ProdDate = tbProdDate.Text;

            if (validation.ValidString(prodName) && validation.ValidString(prodCat) && validation.ValidDate(ProdDate))
            {
                //Add Product SQL
                DatabaseController dbController = new DatabaseController();
                int uID = cUser.GetUserID();
                dbController.AddProduct(prodName, prodCat, ProdDate, uID);
                Response.Redirect("FarmerHome.aspx");
            }
            else
            {
                //input error
            }
        }
    }
}//-------------------------------.o0o.END OF FILE.o0o.-------------------------------------