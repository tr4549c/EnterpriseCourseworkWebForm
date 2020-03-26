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
                    List<Rating> idea1rating = Database.GetVotesForIdea(ideas[0].IdeaID);
                    int thumbsUpNo = idea1rating.Where(x => x.Vote == true).Count();
                    int thumbsDownNo = idea1rating.Where(X => X.Vote == false).Count();

                    //set the first box
                    TextBox1.Text = ideas[0].Description;
                    lblUpIdea1.Text = thumbsUpNo.ToString();
                    lblDownIdea1.Text = thumbsDownNo.ToString();
                }
                else if (i == 1)
                {
                    //set the second box
                }
                else
                {

                }
            }

         }
    }
}