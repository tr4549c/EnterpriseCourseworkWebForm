 using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
namespace EnterpriseCourseworkWebForm
{
    public partial class ManageStaff_Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.UrlReferrer == null)
            {
                //If the url is entered directly, redirect to Login page
                Response.Redirect("Login2.aspx");
            }
        }

        protected void grdPivot_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            bool isEnabled = false;
            if (e.CommandName == "Enable")
            {
                isEnabled = true;
            }

            Database.UpdateAccountEnabled(Convert.ToInt32(e.CommandArgument) + 1, isEnabled);
            Response.Redirect("ManageStaff_QAManager.aspx");
            
        }

        protected void grdPivot_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}