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

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            DataClassesUniversityDataContext context = new DataClassesUniversityDataContext();
            var report = new Report
            {
                //RegisteredStaffID = (int)Session["RStaffID"],
                RegisteredStaffID = 1,
                //IdeaID = ?
                IdeaID = 2,
                Description = TextBoxReportInput.Text.ToString(),
                Status = "Pending"
            };
            try
            {
                context.Reports.InsertOnSubmit(report);
                context.SubmitChanges();
                Response.Redirect("WebForm2.aspx");
            }
            catch (Exception em)
            {
                System.Console.WriteLine(em);
            }
        }
    }
}