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
            //temp 
            Session["RStaffID"] = 1;
            string[] validFileTypes = { ".pdf", ".doc", ".docx", ".png", ".jpj", ".jpeg", };      //TEMP Whatever files are meant to be
            bool allFilesValid = true;

            //check file size and extensions
            foreach (HttpPostedFile file in FileUpload1.PostedFiles)
            {
                if (file.FileName != "")
                {
                    bool fileValid = false;
                    foreach (string fileType in validFileTypes)
                    {
                        if (fileType == System.IO.Path.GetExtension(file.FileName) && file.ContentLength < 10000)
                        {   //temp value for file size --> to be determined
                            fileValid = true;
                        }
                    }

                    //if valid file extension not found
                    if (!fileValid)
                    {
                        allFilesValid = false;
                        break;
                    }
                }
            }

            if (allFilesValid)
            {
                if (Database.IsEnabled((int)Session["RStaffID"]))
                {
                    if (Database.IsOpen(DropDownList2.SelectedIndex + 1))
                    {
                        //insert into database
                        if (CheckBox2.Checked)
                        {
                            int ideaID = Database.InsertIdea(DropDownList2.SelectedIndex + 1, TextBox1.Text, TextBoxIdeaInput.Text, (int)Session["RStaffID"], checkbox1.Checked, false);
                            int failUploads = 0;

                            if (ideaID > 0)
                            {
                                MessageBox.Show("ok");

                                foreach (HttpPostedFile file in FileUpload1.PostedFiles)
                                {
                                    if (file.FileName != "")
                                    {
                                        //upload all docs
                                        if (!Database.InsertDoc(ideaID, file.FileName)) //TEMP need the file to actually be uploaded somewhere
                                        {
                                            failUploads++;
                                        }
                                    }
                                }

                                if (failUploads > 0)
                                {
                                    Label1.Text = "Failed to upload a file";
                                }
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

                MessageBox.Show("yep");
            }
            else
            {
                MessageBox.Show("either invalid file type or filesize (+ what is allowed)");
            }
        }
    }
}