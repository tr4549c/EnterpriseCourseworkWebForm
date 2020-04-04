using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnterpriseCourseworkWebForm
{
    public partial class SubmitIdea1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int categoryID = 2; //Passed from previous page?
            string title = "Title"; //No entry box --> is this even needed?

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

                if (!fileValid)
                {
                    allFilesValid = false;
                }
            }

            if (allFilesValid)
            {
                //insert into database
                int ideaID = Database.InsertIdea(categoryID, title, TextBoxIdeaInput.Text, (int)Session["RStaffID"], checkbox1.Checked, false);

                if (ideaID != 0)
                {
                    foreach (HttpPostedFile file in FileUpload1.PostedFiles)
                    {
                        //upload all docs
                        Database.InsertDoc(ideaID, file.FileName);   //TEMP need the file to actually be uploaded somewhere
                    }
                }
                else
                {
                    //error message --> uploading idea to database failed
                }
            }
            else
            {
                //error message --> either invalid file type or filesize (+ what is allowed)
            }
        }
    }
}