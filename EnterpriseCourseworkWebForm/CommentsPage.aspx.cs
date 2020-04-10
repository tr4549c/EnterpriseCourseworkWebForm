using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnterpriseCourseworkWebForm
{
    public partial class CommentsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.UrlReferrer == null)
            {
                //If the url is entered directly, redirect to Login page
                Response.Redirect("Login2.aspx");
            }

            //TEMP --> post ideaID from previous page and selected page if page reloaded (number at bottom clicked) 
            int ideaID = Convert.ToInt32(Session["ideaID"]);

            int currentPage = 1;
            const int pageSize = 5;
            int commentCount = 0;

            string[][] comments = Database.SelectAllCommentsByMostRecent(ideaID, currentPage, pageSize);
            List<TextBox> txt = new List<TextBox> { TextBox1, TextBox2, TextBox3, TextBox4, TextBox5 };  //can be generated dynamically if we remove unneeded textboxes (shouldn't really matter tbh)
            List<Label> lbl = new List<Label> { Label7, Label5, Label1, Label2, Label3 }; //interesting label order...

            for (int i = 0; i < 5; i++)
            {
                txt[i].Visible = true;
                lbl[i].Visible = true;
            }

            while (commentCount < pageSize)
            {
                if (commentCount < comments.Length)
                {
                    txt[commentCount].Text = comments[commentCount][1];

                    if (!bool.Parse(comments[commentCount][2]))
                    {
                        lbl[commentCount].Text = comments[commentCount][3];
                    }
                    else
                    {
                        lbl[commentCount].Visible = false;  //if not doing the visible true/false, this can be set to "" instead.
                    }
                }
                else
                {
                    //Remove if this doesn't work or not needed
                    txt[commentCount].Visible = false;
                    lbl[commentCount].Visible = false;
                }
                commentCount++;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int ideaID = Convert.ToInt32(Session["ideaID"]);
            int staffID = Convert.ToInt32(Session["RStaffID"]);

            if (TextBoxIdeaInput.Text != "")
            {
                if (Database.InsertComment(TextBoxIdeaInput.Text, ideaID, staffID, checkbox2.Checked))
                {
                    Response.Redirect("CommentsPage.aspx");
                }
                else
                {
                    //error sending to database
                }
            }
            else
            {
                //Display Error message --> comment cannot be empty
            }
        }
    }
}