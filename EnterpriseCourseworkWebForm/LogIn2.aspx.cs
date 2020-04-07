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
        public static int staffID;
        protected void loginB_Click(object sender, EventArgs e)
        {
   
            //example login username: dignissim  password: DVD49JKR0JO
             staffID = Database.LoginRegisteredStaff(TextBox1.Text, TextBox2.Text);

            //if (query.Any())

            if (staffID > 0)
            {

                Session["RStaffID"] = staffID;
                Database.InsertLogin(staffID);


                //if (Database.GetAccountEnabled(staffID))
               // {
                    Response.Redirect("Post SignInIdeaPage.aspx");
               // }
                //else
               // {
                    //Display error (Account not enabled)  (difference between enabled and active?)
                //}
            }
            else
            {
                //display error (username/password incorrect)
            }
        }
    }
}