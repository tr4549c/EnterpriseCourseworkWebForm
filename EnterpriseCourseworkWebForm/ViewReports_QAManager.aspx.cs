using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnterpriseCourseworkWebForm
{
    public partial class ViewReports_Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.UrlReferrer == null)
            {
                //If the url is entered directly, redirect to Login page
                Response.Redirect("Login2.aspx");
            }

            foreach (GridViewRow row in grdPivot.Rows)
            {
                if (row.Cells[5].Text == "Resolved")
                {
                    row.Cells[0].Text = "";
                }
            }
               
        }

        protected void grdPivot_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void grdPivot_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            
            if (e.CommandName == "Resolve")
            {
                DataClassesUniversityDataContext context = new DataClassesUniversityDataContext();
                var query = from r in context.Reports
                            where r.ReportID == Convert.ToInt32(e.CommandArgument) + 1
                            select r;
                foreach (var q in query)
                {
                    if (q.Status == "Pending")
                    {
                        q.Status = "Resolved";
                    }
                    context.SubmitChanges();
                    Response.Redirect("ViewReports_QAManager.aspx");
                }
            }

        }
    }
}