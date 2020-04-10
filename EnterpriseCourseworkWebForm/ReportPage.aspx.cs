using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnterpriseCourseworkWebForm
{
    public partial class ReportPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.UrlReferrer == null)
            {
                //If the url is entered directly, redirect to Login page
                Response.Redirect("Login2.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //temp
            int ideaID = 2;
            Session["RStaffID"] = 1;


            Database.InsertReport((int) Session["RStaffID"], ideaID, TextBoxReportInput.Text, "Pending");
            Response.Redirect("WebForm2.aspx");
        }
    }
}