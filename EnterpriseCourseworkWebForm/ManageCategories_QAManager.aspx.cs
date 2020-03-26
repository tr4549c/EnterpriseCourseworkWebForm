using System;
using System.Collections.Generic;
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
            
        }

        protected void grd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void grd_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
  
                DataClassesUniversityDataContext context = new DataClassesUniversityDataContext();
               var category = new Category
                {
                CategoryName = TextBoxCategory.Text.ToString()
                };
            try
            {
                context.Categories.InsertOnSubmit(category);
                context.SubmitChanges();
                Response.Redirect("ManageCategories_QAManager.aspx");
            }
            catch (Exception em)
            {
                System.Console.WriteLine(em);
            }
           
            
        }
    }
}