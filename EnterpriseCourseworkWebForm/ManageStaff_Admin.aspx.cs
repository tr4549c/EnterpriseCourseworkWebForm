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

        }

        protected void grdPivot_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            DataClassesUniversityDataContext context = new DataClassesUniversityDataContext();
            if (e.CommandName == "Disable")
            {
                
                var query = from r in context.RegisteredStaffs
                            where r.RegisteredStaffID == Convert.ToInt32(e.CommandArgument) + 1
                            select r;
                foreach (var q in query)
                {
                    if (q.IsEnabled == true)
                    {
                        q.IsEnabled = false;
                    }
                    context.SubmitChanges();
                    Response.Redirect("ManageStaff_Admin.aspx");
                }
            }
            else if (e.CommandName == "Enable")
            {
       
                var query = from r in context.RegisteredStaffs
                            where r.RegisteredStaffID == Convert.ToInt32(e.CommandArgument) + 1
                            select r;
                foreach (var q in query)
                {
                    if (q.IsEnabled == false)
                    {
                        q.IsEnabled = true;
                    }
                    context.SubmitChanges();
                    Response.Redirect("ManageStaff_Admin.aspx");
                }
            }
        }

        protected void grdPivot_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}