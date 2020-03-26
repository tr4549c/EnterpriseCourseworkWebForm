using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace EnterpriseCourseworkWebForm
{
    //Useful LinQ : https://www.tutorialspoint.com/linq/linq_sql.htm

    static public class Database
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
        /// 

        static private DataClassesUniversityDataContext Connection()
        {
            return new DataClassesUniversityDataContext();
        }

        static public int LoginAllStaff(string username, string password)
        {
            var db = Connection();
            return (from staff in db.AllStaffs where staff.Username == username && staff.Password == password select staff.AllStaffID).FirstOrDefault();
        }

        static public int LoginRegisteredStaff(string username, string password)
        {
            var db = Connection();
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
        static public bool RegisterAllStaff(int employeeID, string name, string username, string password, int roleID, int departmentID)
        {
            var db = Connection();

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
                AllStaff newStaff = new AllStaff
                {
                    EmployeeID = employeeID,
                    Name = name,
                    Username = username,
                    Password = password,
                    RoleID = roleID,
                    DepartmentID = departmentID

                };

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
        static public bool RegisterRStaff(string username, string password, int allStaffID)
        {
            var db = Connection();

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
                RegisteredStaff newStaff = new RegisteredStaff
                {
                    RUsername = username,
                    RPassword = password,
                    AllStaffID = allStaffID,
                    IsActive = true,
                    IsEnabled = true
                };

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
        static public void UpdateRStaffUsernamePassword(int rsID, string username, string password)
        {
            var db = Connection();

            RegisteredStaff rs = db.RegisteredStaffs.FirstOrDefault(r => r.RegisteredStaffID.Equals(rsID));
            rs.RUsername = username;
            rs.RPassword = password;

            db.SubmitChanges();
        }

        /// <summary>
        /// Sets RegisteredStaff IsActive value
        /// </summary>
        /// <param name="rsID"></param>
        /// <param name="IsActive"></param>
        static public void UpdateAccountActive(int rsID, bool IsActive)
        {
            var db = Connection();

            RegisteredStaff rs = db.RegisteredStaffs.FirstOrDefault(r => r.RegisteredStaffID.Equals(rsID));
            rs.IsActive = IsActive;

            db.SubmitChanges();
        }
        /// <summary>
        /// Gets RegisteredStaff IsActive Value
        /// </summary>
        /// <param name="rsID"></param>
        /// <returns></returns>
        static public bool GetAccountActive(int rsID)
        {
            var db = Connection();

            return (from staff in db.RegisteredStaffs where staff.RegisteredStaffID == rsID select (bool) staff.IsActive).FirstOrDefault(); 
        }

        /// <summary>
        /// Sets RegisteredStaff IsEnabled value
        /// </summary>
        /// <param name="rsID"></param>
        /// <param name="IsEnabled"></param>
        static public void UpdateAccountEnabled(int rsID, bool IsEnabled)
        {
            var db = Connection();

            RegisteredStaff rs = db.RegisteredStaffs.FirstOrDefault(r => r.RegisteredStaffID.Equals(rsID));
            rs.IsEnabled = IsEnabled;

            db.SubmitChanges();
        }

        /// <summary>
        /// Gets RegisteredStaff IsEnabled value
        /// </summary>
        /// <param name="rsID"></param>
        /// <returns></returns>
        static public bool GetAccountEnabled(int rsID)
        {
            var db = Connection();

            return (from staff in db.RegisteredStaffs where staff.RegisteredStaffID == rsID select (bool)staff.IsEnabled).FirstOrDefault();
        }
        #endregion

        #region Role
        /// <summary>
        /// Returns a list of all roles stored in database (for filing dropdown lists)
        /// </summary>
        /// <returns></returns>
        static public string[] GetAllRoles()
        {
            var db = Connection();
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
            var db = Connection();
            return (from dep in db.Departments select dep.DepartementName).ToArray();
        }
        #endregion

        #region Category
        /// <summary>
        /// Returns a list of all Categories stored in database (for filing dropdown lists)
        /// </summary>
        /// <returns></returns>
        static public string[] GetAllCategories(string search)
        {
            var db = Connection();
            return (from cat in db.Categories where cat.CategoryName.Contains(search) select cat.CategoryName).ToArray();
        }
        #endregion

        #region DepartmentCategory
        //Not sure what I'm meant to put in here

        static public void InsertDepartmentCategory(int depID, int catID)
        {
            var db = Connection();

            DepartmentCategory dc = new DepartmentCategory
            {
                DepartmentID = depID,
                CategoryID = catID
            };

            db.DepartmentCategories.InsertOnSubmit(dc);
            db.SubmitChanges();
        }


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
        static public void InsertIdea(int categoryID, string title, string description, int staffID, bool IsAnnonymous, bool IsHidden)
        {
            var db = Connection();

            Idea newIdea = new Idea
            {
                CategoryID = categoryID,
                Title = title,
                Description = description,
                RegisteredStaffID = staffID,
                IsAnnonymous = IsAnnonymous,
                IsHidden = IsHidden
            };

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
            var db = Connection();
            return (from i in db.Ideas where i.CategoryID == categoryID select new string[] { i.Title, i.Description, i.RegisteredStaffID.ToString(), i.IsAnnonymous.ToString() }).ToArray();
            //return all doc now?
        }

        static public List<Idea> GetAllIdeasByMostRecent() {
            var db = Connection();
            return (from i in db.Ideas
                    orderby i.IdeaID descending
                    select i).ToList();
        }

        static public string[][] GetLastIdeas(int categoryID, int numberOfIdeas)
        {
            var db = Connection();
            return (from i in db.Ideas orderby i.IdeaID descending where i.CategoryID == categoryID && i.IsHidden == false select new string[] { i.Title, i.Description, i.RegisteredStaffID.ToString(), i.IsAnnonymous.ToString() }).Take(numberOfIdeas).AsEnumerable().Reverse().ToArray();
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
            var db = Connection();

            //foreach (string doc in docPath) {                     //ideaID would stay constant, so just loop through docs list
            Document newDoc = new Document
            {
                IdeaID = ideaID,
                DocPath = docPath
            };

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
            var db = Connection();
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
            var db = Connection();

            Comment newComment = new Comment
            {
                Comment1 = comment,
                IdeaID = ideaID,
                RegisteredStaffID = staffID,
                IsAnnonymous = IsAnnonymous
            };

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
            var db = Connection();
            return (from c in db.Comments where c.IdeaID == ideaID select new { c.Comment1, c.RegisteredStaffID, c.IsAnnonymous }).ToArray();
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
            var db = Connection();

            var query = (from r in db.Ratings where r.IdeaID == ideaID && r.RegisteredStaffID == staffID select r).FirstOrDefault();

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
            var db = Connection();

            return bool.Parse((from r in db.Ratings where r.IdeaID == ideaID && r.RegisteredStaffID == staffID select r.Vote).FirstOrDefault().ToString());

        }

        /// <summary>
        /// Updates/creates rating depending on current state
        /// </summary>
        /// <param name="ideaID"></param>
        /// <param name="staffID"></param>
        /// <param name="voteValue"></param>
        static public void UpdateRating(int ideaID, int staffID, bool voteValue)
        {
            var db = Connection();

            if (RatingExists(ideaID, staffID))
            {
                //if rating exists, find stored user rating
                Rating findRating = db.Ratings.FirstOrDefault(r => r.IdeaID.Equals(ideaID) && r.RegisteredStaffID.Equals(staffID));

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
                Rating newRating = new Rating
                {
                    IdeaID = ideaID,
                    RegisteredStaffID = staffID,
                    Vote = voteValue
                };

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
        static public bool[] GetVotesForIdeaByStaff(int ideaID, int staffID)
        {
            //1 for upvote, 0 for downvote
            var db = Connection();
            return (from r in db.Ratings where r.IdeaID == ideaID && r.RegisteredStaffID == staffID select (bool)r.Vote).ToArray();

            //loop through list here and return tupe of upvote/downvote?
        }

        /// <summary>
        /// Returns a list containing all votes for idea
        /// </summary>
        /// <param name="ideaID"></param>
        /// <param name="staffID"></param>
        /// <returns></returns>
        static public List<Rating> GetVotesForIdea(int ideaID)
        {
            //1 for upvote, 0 for downvote
            var db = Connection();
            return (from r in db.Ratings where r.IdeaID == ideaID select r).ToList();

        }
        #endregion
    }
}
