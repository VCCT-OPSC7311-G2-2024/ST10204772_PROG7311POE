using PROGPOE7311.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROGPOE7311
{
    public partial class ViewProducts : System.Web.UI.Page
    {//-------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        DatabaseController dbController = new DatabaseController();
        //-------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //-------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        protected void btnFilter_Click(object sender, EventArgs e)
        {
            Validation validation = new Validation();
            string RangeBegin = tbRangeBegin.Text;
            string RangeEnd = tbRangeEnd.Text;
            string SelectedCategory = ddlCategory.Text;
            DateTime? startDate = null;
            DateTime? endDate = null;

            //If category selected and not range
            if ((string.IsNullOrEmpty(RangeBegin)) && (string.IsNullOrEmpty(RangeEnd) && (!string.IsNullOrEmpty(SelectedCategory))))
            {
                sqldsCategoryFilter.SelectParameters.Add("@ProdCategory", SelectedCategory);
                gvProducts.DataSourceID = null;
                gvProducts.DataSource = sqldsCategoryFilter;
                gvProducts.DataBind();
                
            }
            
            //Range Selected
            else if ((!string.IsNullOrEmpty(RangeBegin)) && (!string.IsNullOrEmpty(RangeEnd) && (string.IsNullOrEmpty(SelectedCategory))))
            {
                if (validation.ValidDate(RangeBegin) && (validation.ValidDate(RangeEnd)))
                {
                    startDate = DateTime.Parse(RangeBegin);
                    endDate = DateTime.Parse(RangeEnd);
                }


            }
            else
            {
                //Error
            }
        }
        //-------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        protected void tbRangeBegin_TextChanged(object sender, EventArgs e)
        {
            ddlCategory.Enabled = false;
        }
        //-------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        protected void tbRangeEnd_TextChanged(object sender, EventArgs e)
        {
            ddlCategory.Enabled = false;
        }
        //-------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbRangeBegin.Enabled = false;
            tbRangeEnd.Enabled = false;
        }
        //-------------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        protected void btnReset_Click(object sender, EventArgs e)
        {
            SQLdsPROGDB.SelectCommand = "SELECT ProdName AS [Product Name], ProdCategory AS [Product Category], ProdDate AS [Production Date], [User].FullName AS [Farmer] FROM Product JOIN [User] ON [User].UserID = Product.UserID";
        }
    }
}//-------------------------------.o0o.END OF FILE.o0o.-------------------------------------