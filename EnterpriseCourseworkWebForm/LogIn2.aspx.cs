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
            //DataClassesUniversityDataContext context = new DataClassesUniversityDataContext();
            //var query = from q in context.RegisteredStaffs
            //            where ((q.RUsername == TextBox1.Text) && (q.RPassword == TextBox2.Text))
            //            select q;


            //example login username: odio  password: IGP76NQI8TW.
            int staffID = Database.LoginRegisteredStaff(TextBox1.Text, TextBox2.Text);

            //if (query.Any())

            if (staffID > 0)
            {
                ////HttpCookie Cookie = new HttpCookie("mycookie");
                //HttpCookie Cookie = new HttpCookie("RStaffID");
                ////Cookie.Value = TextBox1.Text;
                //Cookie.Value = staffID.ToString();
                //Cookie.Expires = DateTime.Now.AddDays(1);
                //Response.Cookies.Add(Cookie);
                Session["RStaffID"] = staffID;
                
                Application["RStaffID"] = staffID;

                //foreach (var query1 in query.ToList())
                //{
                //    id = query1.RegisteredStaffID;
                //    Application["mycookie"] = id.ToString();
                //}
                Response.Redirect("TestWebForm.aspx");
            }
            else
            {
                //display error
            }
        }
    }
}