using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnterpriseCourseworkWebForm
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Temp while no event created
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginPressed(object sender, EventArgs e)
        {
            //int staffID = Database.LoginRegisteredStaff(TXT_Username.Text, TXT_Password.Text);
            int staffID = 1;
            if (staffID > 0)
            {
                Session["StaffID"] = staffID;

                Response.Redirect("HomePage.aspx");
            }
            else
            {
                //display error
            }
        }
    }
}