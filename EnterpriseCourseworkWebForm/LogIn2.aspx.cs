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
   
            //example login username: dignissim  password: Password   (Admin --> admin, Manager -> manager)
            staffID = Database.LoginRegisteredStaff(TextBox1.Text, Encryption.Encrypt(TextBox2.Text));

            if (staffID > 0)
            {

                Session["RStaffID"] = staffID;
                Database.InsertLogin(staffID);

                Session["page"] = 1;
                Response.Redirect("Post SignInIdeaPage.aspx");
                    
            }
            else
            {
                //display error (username/password incorrect)
            }
        }
    }
}