using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnterpriseCourseworkWebForm
{
    public partial class TestWebform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Idea> ideas = Database.GetAllIdeasByMostRecent();

            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    try
                    {
                        List<Rating> idea1rating = Database.GetVotesForIdea(ideas[0].IdeaID);
                        int thumbsUpNo = idea1rating.Where(x => x.Vote == true).Count();
                        int thumbsDownNo = idea1rating.Where(X => X.Vote == false).Count();

                        //set the first box
                        TextBox1.Text = ideas[0].Description;
                        lblUpIdea1.Text = thumbsUpNo.ToString();
                        lblDownIdea1.Text = thumbsDownNo.ToString();
                    }
                    catch (Exception)
                    {
                        TextBox1.Text = "No Ideas available";
                        lblUpIdea1.Text = "0";
                        lblDownIdea1.Text = "0";
                    }
                   

                    
                }
                else if (i == 1)
                {
                    try
                    {
                        List<Rating> idea1rating = Database.GetVotesForIdea(ideas[1].IdeaID);
                        int thumbsUpNo = idea1rating.Where(x => x.Vote == true).Count();
                        int thumbsDownNo = idea1rating.Where(X => X.Vote == false).Count();

                        TextBox2.Text = ideas[1].Description;
                        Label1.Text = thumbsUpNo.ToString();
                        Label2.Text = thumbsDownNo.ToString();
                    }
                    catch (Exception ex)
                    {
                        TextBox2.Text = "No Ideas available";
                        Label1.Text = "0";
                        Label2.Text = "0";

                    }
                }
                else
                {
                    try
                    {
                        List<Rating> idea1rating = Database.GetVotesForIdea(ideas[2].IdeaID);
                        int thumbsUpNo = idea1rating.Where(x => x.Vote == true).Count();
                        int thumbsDownNo = idea1rating.Where(X => X.Vote == false).Count();

                        TextBox3.Text = ideas[2].Description;
                        Label3.Text = thumbsUpNo.ToString();
                        Label4.Text = thumbsDownNo.ToString();
                    }
                    catch (Exception ex)
                    {
                        TextBox3.Text = "No Ideas available";
                        Label3.Text = "0";
                        Label4.Text = "0";

                    }
                }
            }

         }

        protected void LinkButtonMore_Click(object sender, EventArgs e)
        {
            Response.Redirect("LogIn2.aspx");
        }

        protected void ImageButtonThumbsUp_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("LogIn2.aspx");

        }

        protected void ImageButtonThumbsDwn_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("LogIn2.aspx");

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("LogIn2.aspx");

        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("LogIn2.aspx");

        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("LogIn2.aspx");

        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("LogIn2.aspx");

        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("LogIn2.aspx");

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("LogIn2.aspx");

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("LogIn2.aspx");

        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("LogIn2.aspx");

        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("LogIn2.aspx");

        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("LogIn2.aspx");

        }
    }
}