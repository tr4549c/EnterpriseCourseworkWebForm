using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace EnterpriseCourseworkWebForm
{
   
    public partial class SubmitIdea1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        //static private DataClassesUniversityDataContext Connection()
       // {
         //   return new DataClassesUniversityDataContext();
       // }
        protected void Button2_Click(object sender, EventArgs e)
        {
            //int categoryID = 2; //Passed from previous page?
            //string title = "Title"; //No entry box --> is this even needed?

            //I HAVE NOT TESTED ANY OF THIS. (not fully implemented)

            
            string[] validFileTypes = { ".pdf", ".doc", ".docx", ".png", ".jpj", ".jpeg", };      //TEMP Whatever files are meant to be
            bool allFilesValid = true;
           
            //check file size and extensions
            foreach (HttpPostedFile file in FileUpload1.PostedFiles)
            {
                bool fileValid = false;
                foreach (string fileType in validFileTypes)
                {
                    if (fileType == System.IO.Path.GetExtension(file.FileName) && file.ContentLength < 10000) {   //temp value for file size --> to be determined
                        fileValid = true;
                    }
                }

                if (fileValid)
                {
                    allFilesValid = false;
                }
            }

            if (allFilesValid)
            {
                //insert into database
               // int ideaId= Database.InsertIdea(DropDownList2.SelectedIndex, TextBox1.Text, TextBoxIdeaInput.Text, (int)Session["RStaffID"], checkbox1.Checked, false);
               
                    DataClassesUniversityDataContext context = new DataClassesUniversityDataContext();

                   var newIdea = new Idea
                    {
                        CategoryID = DropDownList2.SelectedIndex,
                       
                        Description = TextBoxIdeaInput.Text,
                        RegisteredStaffID = 2,
                        IsAnnonymous = false,
                        IsHidden =false
                    };
                try
                {
                    context.Ideas.InsertOnSubmit(newIdea);
                    context.SubmitChanges();
                }
                catch (Exception a)
                {
                    Console.WriteLine(a);
      
                }
                //foreach (HttpPostedFile file in FileUpload1.PostedFiles)
                //{
                //upload all docs
                //     Database.InsertDoc(5, file.FileName);   //TEMP need the file to actually be uploaded somewhere
                //            }
                MessageBox.Show("yep");
            }
            else
            {
                MessageBox.Show("either invalid file type or filesize (+ what is allowed)");            }
            
        }
    }
}