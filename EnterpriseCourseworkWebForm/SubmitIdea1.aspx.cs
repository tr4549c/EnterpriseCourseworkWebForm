using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
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
            if (Request.UrlReferrer == null)
            {
                //If the url is entered directly, redirect to Login page
                Response.Redirect("Login2.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string[] validFileTypes = { ".pdf", ".doc", ".docx", ".png", ".PNG", ".jpg", ".jpeg", };      //TEMP Whatever files are meant to be
            bool allFilesValid = true;

            //check file size and extensions
            foreach (HttpPostedFile file in FileUpload1.PostedFiles)
            {
                if (file.FileName != "")
                {
                    bool fileValid = false;
                    foreach (string fileType in validFileTypes)
                    {
                        if (fileType == Path.GetExtension(file.FileName) && file.ContentLength < 2000000)
                        {   //temp value for file size --> to be determined
                            fileValid = true;
                        }
                    }

                    string a = Path.GetExtension(file.FileName);

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
                                
                                foreach (HttpPostedFile file in FileUpload1.PostedFiles)
                                {
                                    if (file.FileName != "")
                                    {
                                        string filename = SaveFile(FileUpload1.PostedFile); //need the saved filename in server, not from user input

                                        //upload all docs
                                        if (!Database.InsertDoc(ideaID, filename)) 
                                        {
                                            failUploads++;
                                        }
                                        
                                    }
                                }
                                if (failUploads == 0)
                                {
                                    Label1.Text = "File submitted successfully.";
                                }
                                else
                                {
                                    Label1.Text = "File Upload failed.";
                                }

                                //reset page
                                TextBox1.Text = "";
                                TextBoxIdeaInput.Text = "";
                                checkbox1.Checked = false;
                                CheckBox2.Checked = false;
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
            }
            else
            {
                Label1.Text = "The idea was not successfully submitted.";
            }
        }
        private string SaveFile(HttpPostedFile file)
        {
            // Get the name of the file to upload.
            string[] splitFileName = FileUpload1.FileName.Split(char.Parse("/"));
            string fileName = splitFileName[splitFileName.Length - 1];
            string savePath = Server.MapPath("~\\Uploads\\");
            // Create the path and file name to check for duplicates.
            string pathToCheck = savePath + fileName;
            // Create a temporary file name to use for checking duplicates.
            string tempfileName = "";
            // Check to see if a file already exists with the
            // same name as the file to upload.        
            if (File.Exists(pathToCheck))
            {
                int counter = 2;
                while (File.Exists(pathToCheck))
                {
                    // if a file with this name already exists,
                    // prefix the filename with a number.
                    tempfileName = counter + fileName;
                    pathToCheck = savePath + tempfileName;
                    counter++;
                }
                fileName = tempfileName;
                // Notify the user that the file name was changed.
                Label1.Text = "A file with the same name already exists." +
                    "<br />Your file was saved as " + fileName;
            }
            else
            {
                // Notify the user that the file was saved successfully.
                Label1.Text = "Your file was uploaded successfully.";
            }
            // Append the name of the file to upload to the path.
            savePath += fileName;
            // Call the SaveAs method to save the uploaded
            // file to the specified directory.
            FileUpload1.SaveAs(savePath);
            //just save the file name instead of whole path
            //if successful
            return fileName;
        }
    }
}