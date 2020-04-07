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
    
        protected void Button2_Click(object sender, EventArgs e)
        {
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
                if (Database.IsEnabled((int)Session["RStaffID"]))
                {
                    if (Database.IsOpen(Convert.ToInt32(DropDownList2.Text)) == true)
                    {
                        //insert into database
                        if (CheckBox2.Checked)
                        {
                            if (Database.InsertIdea(Convert.ToInt32(DropDownList2.Text), TextBox1.Text, TextBoxIdeaInput.Text, (int)Session["RStaffID"], checkbox1.Checked, false))
                            {
                                MessageBox.Show("ok");
                            }
                            else
                            {
                                Label1.Text = "Failed to submit idea";
                            }
                        }
                        else
                        {
                            Label1.Text = "Please accept T&C.";
                        }
                    }
                    else
                    {
                        Label1.Text = "Category is closed";
                    }
                }
                else
                {
                    Label1.Text = "You are not allowed to post ideas";
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