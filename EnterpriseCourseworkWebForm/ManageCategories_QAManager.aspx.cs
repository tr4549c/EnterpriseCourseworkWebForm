using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnterpriseCourseworkWebForm
{
    public partial class ManageCategories_QAManager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.UrlReferrer == null)
            {
                //If the url is entered directly, redirect to Login page
                Response.Redirect("Login2.aspx");
            }

        }

        protected void grd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void grd_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            

        }

        public static bool IsDate(string tempDate)

        {

            DateTime fromDateValue;

            var formats = new[] { "dd/MM/yyyy", "yyyy-MM-dd" };

            if (DateTime.TryParseExact(tempDate, formats, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out fromDateValue))

            {

                return true;

            }

            else

            {

                return false;

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBoxClosure.Text != "" && TextBoxCategory.Text != "")
            {
                if (IsDate(TextBoxClosure.Text) == true)
                {
                    Database.InsertCategory(TextBoxCategory.Text, TextBoxClosure.Text);
                    Response.Redirect("ManageCategories_QAManager.aspx");
                }
                else
                {
                    Label1.Text = "Please insert valid date.";
                }
            }
            else
            {
                Label1.Text = "Please fill in all the fields.";
            }


        }

    }
}