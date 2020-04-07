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
            if (!IsPostBack)
            {
                DropDownList1.Items.Clear();
                //fill departments dropdown from database
                foreach (string dep in Database.GetAllDepartments())
                {
                    DropDownList1.Items.Add(dep);
                }

                UpdateTagsList("");
                FillIdeas();
            }
            Label14.Text = Database.GetLastLogin(LogIn2.staffID);

        }


        private void UpdateTagsList(string search)
        {
            DropDownList2.Items.Clear();
            foreach (string tag in Database.GetAllCategories(search))
            {
                DropDownList2.Items.Add(tag);
            }
        }

        private void FillIdeas()
        {
            string[][] ideas = Database.GetLastIdeas(DropDownList1.SelectedIndex + 1, 5);

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

        private string GenerateText(string[] idea) {


            return idea[1];
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
    }
}