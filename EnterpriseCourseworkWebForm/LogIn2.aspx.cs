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
            DataClassesUniversityDataContext context = new DataClassesUniversityDataContext();
            var query = from q in context.RegisteredStaffs
                        where ((q.RUsername == TextBox1.Text) && (q.RPassword == TextBox2.Text))
                        select q;
            if (query.Any())
            {
                HttpCookie Cookie = new HttpCookie("mycookie");
                Cookie.Value = TextBox1.Text;
                Cookie.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(Cookie);

                foreach (var query1 in query.ToList())
                {
                    id = query1.RegisteredStaffID;
                    Application["mycookie"] = id.ToString();
                }
                Response.Redirect("TestWebForm.aspx");
            }
            else
            {
                
            }
        }
    }
}