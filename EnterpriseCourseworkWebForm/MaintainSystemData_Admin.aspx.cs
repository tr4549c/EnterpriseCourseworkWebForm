using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnterpriseCourseworkWebForm
{
    public partial class MaintainSystemData_Admin : System.Web.UI.Page
    {
        GridViewRow row;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.UrlReferrer == null)
            {
                //If the url is entered directly, redirect to Login page
                Response.Redirect("Login2.aspx");
            }

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            row = GridView1.Rows[e.RowIndex];        
        }

        protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {
            Database.UpdateRegisteredStaff(int.Parse(row.Cells[0].Text), ((TextBox)(row.Cells[1].Controls[0])).Text, Encryption.Encrypt(((TextBox)row.Cells[2].Controls[0]).Text));
            GridView1.DataBind();
        }
    }
}