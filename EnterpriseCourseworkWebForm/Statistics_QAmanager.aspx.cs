using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnterpriseCourseworkWebForm
{
    public partial class Statistics_QAmanager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label3.Text = "Most Active User (Ideas): " + Database.MostActiveUser().ToString();
            Label4.Text = "Most Active User(Comments): " + Database.MostActiveUserComment().ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Database.ExportCSV()== true)
            {
                Label1.Text = "Please check in you I drive for the downloaded file";
            }
            else
            {
                Label1.Text = "Download failed";
            }
        }
    }
}