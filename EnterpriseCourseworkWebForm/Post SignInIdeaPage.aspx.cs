using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnterpriseCourseworkWebForm
{
    public partial class SubmitIdea2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.UrlReferrer == null)
            {
                //If the url is entered directly, redirect to Login page
                Response.Redirect("Login2.aspx");
            }

            if (!IsPostBack)
            {
                DropDownList1.Items.Clear();
                //fill departments dropdown from database
                foreach (string dep in Database.GetAllDepartments())
                {
                    DropDownList1.Items.Add(dep);
                }
            }

            if((int)Session["RStaffID"] == 102)//for manager
             {
                 Button3.Visible = true; //manage cat
                Button4.Visible = true;//view stats
                Button5.Visible = true;//resolve reports
                Button6.Visible = true;//enable users
            }
            if ((int)Session["RStaffID"] == 101) //for admin
             {
                Button7.Visible = true;//view stats
            }

            oldPage = (int) Session["page"];
            Session["page"] = 1;
            UpdateTagsList("");
            FillIdeas();
            Label14.Text = Database.GetLastLogin(LogIn2.staffID);
            FillThumbsDown();
            FillThumbsUp();
            FillUsername();

            
        }
        public static int oldPage;


        private void UpdateTagsList(string search)
        {
            DropDownList2.Items.Clear();
            foreach (string tag in Database.GetAllCategories(search))
            {
                DropDownList2.Items.Add(tag);
            }
        }

        private string[][] ideas;

        private void FillIdeas()
        {          
                int a = (int)Session["page"];
            ideas = Database.GetLastIdeas(DropDownList1.SelectedIndex + 1, (int) Session["page"], 5);

                List<TextBox> txt = new List<TextBox> { TextBox1, TextBox2, TextBox3, TextBox4, TextBox5 };

            for (int i = 0; i < txt.Count; i++)
            {
                if (i <= ideas.Length - 1)
                {
                    txt[i].Text = GenerateText(ideas[i]);
                }
                else
                {
                    txt[i].Text = "";
                }
            }         
        }


        private void FillUsername()
        {
            List<Label> lbl = new List<Label> { Label15, Label16, Label17, Label18, Label19 };
            for (int i = 0; i < 5; i++)
            {
                if (ideas.Length != i)
                {
                    lbl[i].Text = ideas[i][5];
                }
                else
                {
                    for (int j = i; j < 5; j++)
                    {
                        lbl[j].Text = "";
                    }

                    break;
                }
            }

        }

        private void FillThumbsUp()
        {
            //5131012
            List<Label> lbl = new List<Label> { Label5, Label1, Label3, Label10, Label12 };
            for (int i = 0; i < 5; i++)
            {
                if (ideas.Length != i)
                {
                    lbl[i].Text = Database.GetRatingByIdeaID(ideas[i][0], true).ToString();
                }
                else
                {
                    break;
                }
            }
        }


        private void FillThumbsDown()
        {
            //5131012
            List<Label> lbl = new List<Label> { Label6, Label2, Label4, Label11, Label13 };
            for (int i = 0; i < 5; i++)
            {
                if (ideas.Length != i)
                {
                    lbl[i].Text = Database.GetRatingByIdeaID(ideas[i][0], false).ToString();
                }
                else
                {
                    break;
                }
            }
        }

        private string GenerateText(string[] idea)
        {
            return idea[2];
        }

        protected void searchContainer2_TextChanged(object sender, EventArgs e)
        {
            UpdateTagsList(searchContainer2.Text);
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillIdeas();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("SubmitIdea1.aspx");
        }

        protected void hyperlink1_Click(object sender, EventArgs e)
        {

        }

       

        private void SendVote(int ideaID, int staffID, bool vote)
        {
            Database.UpdateRating(ideaID, staffID, vote);
        }

        protected void ImageButtonThumbsUp_Click(object sender, ImageClickEventArgs e)
        {
            SendVote(int.Parse(ideas[0][0]), (int)Session["RStaffID"], true);
            FillThumbsUp();
            FillThumbsDown();
        }

        protected void ImageButtonThumbsDwn_Click(object sender, ImageClickEventArgs e)
        {
            SendVote(int.Parse(ideas[0][0]), (int)Session["RStaffID"], false);
            FillThumbsUp();
            FillThumbsDown();
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            SendVote(int.Parse(ideas[1][0]), (int)Session["RStaffID"], true);
            FillThumbsUp();
            FillThumbsDown();
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            SendVote(int.Parse(ideas[1][0]), (int)Session["RStaffID"], false);
            FillThumbsUp();
            FillThumbsDown();
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            SendVote(int.Parse(ideas[2][0]), (int)Session["RStaffID"], true);
            FillThumbsUp();
            FillThumbsDown();
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            SendVote(int.Parse(ideas[2][0]), (int)Session["RStaffID"], false);
            FillThumbsUp();
            FillThumbsDown();
        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            SendVote(int.Parse(ideas[3][0]), (int)Session["RStaffID"], true);
            FillThumbsUp();
            FillThumbsDown();
        }

        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {
            SendVote(int.Parse(ideas[3][0]), (int)Session["RStaffID"], false);
            FillThumbsUp();
            FillThumbsDown();
        }

        protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
        {
            SendVote(int.Parse(ideas[4][0]), (int)Session["RStaffID"], true);
            FillThumbsUp();
            FillThumbsDown();
        }

        protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
        {
            SendVote(int.Parse(ideas[4][0]), (int)Session["RStaffID"], false);
            FillThumbsUp();
            FillThumbsDown();
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session["ideaID"] = ideas[2][0];
            Response.Redirect("CommentsPage.aspx");
        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Session["ideaID"] = ideas[3][0];
            Response.Redirect("CommentsPage.aspx");
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Session["ideaID"] = ideas[4][0];
            Response.Redirect("CommentsPage.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Session["ideaID"] = ideas[0][0];
            Response.Redirect("CommentsPage.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session["ideaID"] = ideas[1][0];
            Response.Redirect("CommentsPage.aspx");
        }

        protected void one_Click(object sender, EventArgs e)
        {
            Session["page"] = oldPage - 1;
            FillIdeas();
            FillUsername();
            FillThumbsDown();
            FillThumbsUp();
        }

        protected void two_Click(object sender, EventArgs e)
        {
            Session["page"] = oldPage + 1;
            FillIdeas();
            FillUsername();
            FillThumbsDown();
            FillThumbsUp();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageCategories_QAManager.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Statistics_QAmanager.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewReports_QAManager.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Session["ideaID"] = ideas[0][0];
            Response.Redirect("ReportPage.aspx");
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Session["ideaID"] = ideas[1][0];
            Response.Redirect("ReportPage.aspx");
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Session["ideaID"] = ideas[2][0];
            Response.Redirect("ReportPage.aspx");
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Session["ideaID"] = ideas[3][0];
            Response.Redirect("ReportPage.aspx");
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Session["ideaID"] = ideas[4][0];
            Response.Redirect("ReportPage.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageStaff_QAManager.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("MaintainSystemData_Admin.aspx");
        }
    }
}