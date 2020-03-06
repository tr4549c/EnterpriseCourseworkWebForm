using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace EnterpriseCourseworkWebForm
{
    //Useful LinQ : https://www.tutorialspoint.com/linq/linq_sql.htm

    public class Database
    {
        #region Login
        /// <summary>
        /// Login
        /// If matching record is found in table, returns id
        /// If matching record in not found, return default (0)
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        static public int LoginAllStaff(string username, string password)
        {
            DataClassesUniversityDataContext db = new DataClassesUniversityDataContext();
            return (from staff in db.AllStaffs where staff.Username == username && staff.Password == password select staff.AllStaffID).FirstOrDefault();
        }

        static public int LoginRegisteredStaff(string username, string password)
        {
            DataClassesUniversityDataContext db = new DataClassesUniversityDataContext();
            return (from staff in db.RegisteredStaffs where staff.RUsername == username && staff.RPassword == password select staff.RegisteredStaffID).FirstOrDefault();
        }
        #endregion

        #region Register

        /// <summary>
        /// Register new employee in AllStaff. Returns true if successful (non duplicate).
        /// </summary>
        /// <param name="employeeID"></param>
        /// <param name="name"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        static public bool RegisterAllStaff(int employeeID, string name, string username, string password)
        {
            DataClassesUniversityDataContext db = new DataClassesUniversityDataContext();

            //check if username already exists
            var query = from staff in db.AllStaffs where staff.Username == username select staff;

            if (query.Any())
            {
                //if username exists, exit
                return false;
            }
            else
            {
                //if username not taken, create account
                AllStaff newStaff = new AllStaff();
                newStaff.EmployeeID = employeeID;
                newStaff.Name = name;
                newStaff.Username = username;
                newStaff.Password = password;

                db.AllStaffs.InsertOnSubmit(newStaff);
                db.SubmitChanges();

                return true;
            }
        }

        /// <summary>
        /// Register new employee in RegisteredStaff. Returns true if successful (non duplicate).
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="roleID"></param>
        /// <param name="departmentID"></param>
        /// <param name="allStaffID"></param>
        static public bool RegisterRStaff(string username, string password, int roleID, int departmentID, int allStaffID)
        {
            DataClassesUniversityDataContext db = new DataClassesUniversityDataContext();

            //check if username already exists
            var query = from staff in db.RegisteredStaffs where staff.RUsername == username select staff;

            if (query.Any())
            {
                //if username exists, exit
                return false;
            }
            else
            {
                //if username not taken, create account
                RegisteredStaff newStaff = new RegisteredStaff();
                newStaff.RUsername = username;
                newStaff.RPassword = password;
                newStaff.RoleID = roleID;
                newStaff.DepartmentID = departmentID;
                newStaff.AllStaffID = allStaffID;

                db.RegisteredStaffs.InsertOnSubmit(newStaff);
                db.SubmitChanges();
                return true;
            }
        }

        /// <summary>
        /// Updates the username and password of a registered staff member
        /// </summary>
        /// <param name="id"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        static public void UpdateRStaffUsernamePassword(int id, string username, string password)
        {
            DataClassesUniversityDataContext db = new DataClassesUniversityDataContext();

            RegisteredStaff rs = db.RegisteredStaffs.FirstOrDefault(r => r.RegisteredStaffID.Equals(id));
            rs.RUsername = username;
            rs.RPassword = password;

            db.SubmitChanges();
        }

        #endregion

        #region Role
        /// <summary>
        /// Returns a list of all roles stored in database (for filing dropdown lists)
        /// </summary>
        /// <returns></returns>
        static public string[] GetAllRoles()
        {
            DataClassesUniversityDataContext db = new DataClassesUniversityDataContext();
            return (from r in db.Roles select r.RoleName).ToArray();
        }
        #endregion

        #region Department
        /// <summary>
        /// Returns a list of all departments stored in database (for filing dropdown lists)
        /// </summary>
        /// <returns></returns>
        static public string[] GetAllDepartments()
        {
            DataClassesUniversityDataContext db = new DataClassesUniversityDataContext();
            return (from dep in db.Departments select dep.DepartementName).ToArray();
        }
        #endregion

        #region Category
        /// <summary>
        /// Returns a list of all Categories stored in database (for filing dropdown lists)
        /// </summary>
        /// <returns></returns>
        static public string[] GetAllCategories()
        {
            DataClassesUniversityDataContext db = new DataClassesUniversityDataContext();
            return (from cat in db.Categories select cat.CategoryName).ToArray();
        }
        #endregion

        #region DepartmentCategory
        //Not sure what I'm meant to put in here
        #endregion

        #region Idea
        /// <summary>
        /// Creates a new Idea
        /// </summary>
        /// <param name="categoryID"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="staffID"></param>
        /// <param name="IsAnnonymous"></param>
        static public void InsertIdea(int categoryID, string title, string description, int staffID, bool IsAnnonymous)
        {
            DataClassesUniversityDataContext db = new DataClassesUniversityDataContext();

            Idea newIdea = new Idea();
            newIdea.CategoryID = categoryID;
            newIdea.Title = title;
            newIdea.Description = description;
            newIdea.StaffID = staffID;
            newIdea.IsAnnonymous = IsAnnonymous;

            db.Ideas.InsertOnSubmit(newIdea);
            db.SubmitChanges();
        }

        /// <summary>
        /// Gets all ideas relating to a category
        /// </summary>
        /// <param name="categoryID"></param>
        /// <returns></returns>
        static public string[][] SelectIdeas(int categoryID)
        {
            //var db = Connection();
            DataClassesUniversityDataContext db = new DataClassesUniversityDataContext();
            return (from i in db.Ideas where i.CategoryID == categoryID select new string[] { i.Title, i.Description, i.StaffID.ToString(), i.IsAnnonymous.ToString() }).ToArray();
            //return all doc now?
        }
        #endregion

        #region Document
        /// <summary>
        /// Saves document in db. More than 1 doc can be uploaded simultaneous, so either call this method in a loop or change this to loop through a list of documents
        /// </summary>
        /// <param name="ideaID"></param>
        /// <param name="docPath"></param>
        static public void InsertDoc(int ideaID, string docPath)      //docpah will be changed to image?
        {
            DataClassesUniversityDataContext db = new DataClassesUniversityDataContext();

            //foreach (string doc in docPath) {                     //ideaID would stay constant, so just loop through docs list
            Document newDoc = new Document();
            newDoc.IdeaID = ideaID;
            newDoc.DocPath = docPath;

            db.Documents.InsertOnSubmit(newDoc);
            //}

            db.SubmitChanges();
        }

        /// <summary>
        /// returns list of documents associated with selected idea
        /// </summary>
        /// <param name="ideaID"></param>
        /// <returns></returns>
        static public string[] GetDocs(int ideaID)
        {
            DataClassesUniversityDataContext db = new DataClassesUniversityDataContext();
            return (from doc in db.Documents select doc.DocPath).ToArray();
        }
        #endregion

        #region Comments
        /// <summary>
        /// Inserts a comment attached to an idea
        /// </summary>
        /// <param name="comment"></param>
        /// <param name="ideaID"></param>
        /// <param name="staffID"></param>
        /// <param name="IsAnnonymous"></param>
        static public void InsertComment(string comment, int ideaID, int staffID, bool IsAnnonymous)
        {
            DataClassesUniversityDataContext db = new DataClassesUniversityDataContext();

            Comment newComment = new Comment();
            newComment.Comment1 = comment;
            newComment.IdeaID = ideaID;
            newComment.StaffID = staffID;
            newComment.IsAnnonymous = IsAnnonymous;

            db.Comments.InsertOnSubmit(newComment);
            db.SubmitChanges();
        }

        /// <summary>
        /// Returns an object containing list of comments.
        /// object -> string, int, bool
        /// </summary>
        /// <param name="ideaID"></param>
        /// <returns></returns>
        static public object[] SelectComment(int ideaID)
        {
            DataClassesUniversityDataContext db = new DataClassesUniversityDataContext();
            return (from c in db.Comments where c.IdeaID == ideaID select new { c.Comment1, c.StaffID, c.IsAnnonymous }).ToArray();
        }
        #endregion

        #region Rating
        /// <summary>
        /// Method to identify whether a user has already rated an idea
        /// </summary>
        /// <param name="ideaID"></param>
        /// <param name="staffID"></param>
        /// <returns></returns>
        static private bool RatingExists(int ideaID, int staffID)
        {
            DataClassesUniversityDataContext db = new DataClassesUniversityDataContext();

            var query = (from r in db.Ratings where r.IdeaID == ideaID && r.StaffID == staffID select r).FirstOrDefault();

            if (query != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Identifies how the user has currently rated the idea (1 positive, 0 negative)
        /// </summary>
        /// <param name="ideaID"></param>
        /// <param name="staffID"></param>
        /// <returns></returns>
        static private bool RatingValue(int ideaID, int staffID)
        {
            DataClassesUniversityDataContext db = new DataClassesUniversityDataContext();

            return bool.Parse((from r in db.Ratings where r.IdeaID == ideaID && r.StaffID == staffID select r.Vote).FirstOrDefault().ToString());

        }

        /// <summary>
        /// Updates/creates rating depending on current state
        /// </summary>
        /// <param name="ideaID"></param>
        /// <param name="staffID"></param>
        /// <param name="voteValue"></param>
        static public void UpdateRating(int ideaID, int staffID, bool voteValue)
        {
            DataClassesUniversityDataContext db = new DataClassesUniversityDataContext();

            if (RatingExists(ideaID, staffID))
            {
                //if rating exists, find stored user rating
                Rating findRating = db.Ratings.FirstOrDefault(r => r.IdeaID.Equals(ideaID) && r.StaffID.Equals(staffID));

                //Get current value of rating
                bool currentValue = RatingValue(ideaID, staffID);


                if (currentValue == voteValue)
                {
                    //if user has clicked same vote twice, delete the rating
                    db.Ratings.DeleteOnSubmit(findRating);
                }
                else
                {
                    //if the vote is different, update the vote value
                    findRating.Vote = voteValue;
                }
            }
            else
            {
                //No current rating so create new record
                Rating newRating = new Rating();
                newRating.IdeaID = ideaID;
                newRating.StaffID = staffID;
                newRating.Vote = voteValue;

                db.Ratings.InsertOnSubmit(newRating);
            }
            db.SubmitChanges();
        }

        /// <summary>
        /// Returns a list containing all votes for idea
        /// </summary>
        /// <param name="ideaID"></param>
        /// <param name="staffID"></param>
        /// <returns></returns>
        static public bool[] GetVotesForIdea(int ideaID, int staffID)
        {
            //1 for upvote, 0 for downvote
            DataClassesUniversityDataContext db = new DataClassesUniversityDataContext();
            return (from r in db.Ratings where r.IdeaID == ideaID && r.StaffID == staffID select (bool)r.Vote).ToArray();

            //loop through list here and return tupe of upvote/downvote?
        }
        #endregion
    }
}
