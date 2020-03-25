using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnterpriseCourseworkWebForm
{
    public partial class LogIn2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public int id;
        protected void loginB_Click(object sender, EventArgs e)
        {
            //example login username: dignissim  password: DVD49JKR0JO
            int staffID = Database.LoginRegisteredStaff(TextBox1.Text, TextBox2.Text);

            if (staffID > 0)
            {
                if (Database.GetAccountEnabled(staffID))
                {
                    Response.Redirect("TestWebForm.aspx");
                    Session["RStaffID"] = staffID;
                }
                else
                {
                    //Display error (Account not enabled)  (difference between enabled and active?)
                }
            }
            else
            {
                //display error (username/password incorrect)
            }
        }
    }
}