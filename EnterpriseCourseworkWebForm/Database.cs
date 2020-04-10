using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.IO;
using System.Data;


namespace EnterpriseCourseworkWebForm
{
    //Useful LinQ : https://www.tutorialspoint.com/linq/linq_sql.htm

        /// <summary>
        /// All methods are wrapped in try catch statements. If an error occurs, the exception will be written to console and a default value will be returned.
        /// (int returns 0, bool returns false, string/arrays returns null)
        /// </summary>
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

        static private object GetDefaultReturn(Type type)
        {
            if (type.Equals(typeof(bool)))
            {
                return false;
            }
            else if (type.Equals(typeof(int)))
            {
                return 0;
            }
            else
            {
                return null;
            }
        }

        static public int LoginAllStaff(string username, string password)
        {
            try
            {
                var db = Connection();
                return (from staff in db.AllStaffs where staff.Username == username && staff.Password == password select staff.AllStaffID).FirstOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return (int) GetDefaultReturn(typeof(int));
            }
        }

        internal static int GetRatingByIdeaID(string ideaID, bool voteStatus)
        {
            try
            {
                var db = Connection();
                return (from r in db.Ratings where r.IdeaID == Convert.ToInt32(ideaID) && r.Vote == voteStatus select r).Count();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }
        }

        static public int LoginRegisteredStaff(string username, string password)
        {
            try
            {
                var db = Connection();
                return (from staff in db.RegisteredStaffs where staff.RUsername == username.ToLower() && staff.RPassword == password select staff.RegisteredStaffID).FirstOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return (int) GetDefaultReturn(typeof(int));
            }
        }

        static public bool UpdateRegisteredStaff(int rSftaffID, string username, string password)
        {
            try
            {
                var db = Connection();
                RegisteredStaff rs = db.RegisteredStaffs.FirstOrDefault(r => r.RegisteredStaffID.Equals(rSftaffID));

                rs.RUsername = username.ToLower();
                rs.RPassword = password;

                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return (bool)GetDefaultReturn(typeof(bool));
            }
        }

        static public bool IsEnabled(int id)
        {
            try
            {
                var db = Connection();
                return (Convert.ToBoolean((from r in db.RegisteredStaffs where r.RegisteredStaffID == id select r.IsEnabled.ToString()).FirstOrDefault()));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return (bool)GetDefaultReturn(typeof(bool));
            }
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
            try
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
            catch (Exception e)
            {
                Console.WriteLine(e);
                return (bool) GetDefaultReturn(typeof(bool));
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
            try
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
            catch (Exception e)
            {
                Console.WriteLine(e);
                return (bool)GetDefaultReturn(typeof(bool));
            }
        }

        /// <summary>
        /// Updates the username and password of a registered staff member
        /// </summary>
        /// <param name="id"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        static public bool UpdateRStaffUsernamePassword(int rsID, string username, string password)
        {
            try
            {
                var db = Connection();

                RegisteredStaff rs = db.RegisteredStaffs.FirstOrDefault(r => r.RegisteredStaffID.Equals(rsID));
                rs.RUsername = username;
                rs.RPassword = password;

                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return (bool)GetDefaultReturn(typeof(bool));
            }
        }

        /// <summary>
        /// Sets RegisteredStaff IsActive value
        /// </summary>
        /// <param name="rsID"></param>
        /// <param name="IsActive"></param>
        static public bool UpdateAccountActive(int rsID, bool IsActive)
        {
            try
            {
                var db = Connection();

                RegisteredStaff rs = db.RegisteredStaffs.FirstOrDefault(r => r.RegisteredStaffID.Equals(rsID));
                rs.IsActive = IsActive;

                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return (bool)GetDefaultReturn(typeof(bool));
            }
        }
        /// <summary>
        /// Gets RegisteredStaff IsActive Value
        /// </summary>
        /// <param name="rsID"></param>
        /// <returns></returns>
        static public bool GetAccountActive(int rsID)
        {
            var db = Connection();

            return (from staff in db.RegisteredStaffs where staff.RegisteredStaffID == rsID select staff.IsActive).FirstOrDefault(); 
        }

        /// <summary>
        /// Sets RegisteredStaff IsEnabled value
        /// </summary>
        /// <param name="rsID"></param>
        /// <param name="IsEnabled"></param>
        static public bool UpdateAccountEnabled(int rsID, bool IsEnabled)
        {
            try
            {
                var db = Connection();

                RegisteredStaff rs = db.RegisteredStaffs.FirstOrDefault(r => r.RegisteredStaffID.Equals(rsID));
                rs.IsEnabled = IsEnabled;

                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return (bool)GetDefaultReturn(typeof(bool));
            }
        }

        /// <summary>
        /// Gets RegisteredStaff IsEnabled value
        /// </summary>
        /// <param name="rsID"></param>
        /// <returns></returns>
        static public bool GetAccountEnabled(int rsID)
        {
            try
            {
                var db = Connection();

                return (from staff in db.RegisteredStaffs where staff.RegisteredStaffID == rsID select (bool)staff.IsEnabled).FirstOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return (bool)GetDefaultReturn(typeof(bool));
            }
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
            try
            {
                var db = Connection();
                return (from dep in db.Departments select dep.DepartementName).ToArray();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return (string[])GetDefaultReturn(typeof(string[]));
            }
        }
        #endregion

        #region Category
        /// <summary>
        /// Returns a list of all Categories stored in database (for filing dropdown lists)
        /// </summary>
        /// <returns></returns>
        static public string[] GetAllCategories(string search)
        {
            try
            {
                var db = Connection();
                return (from cat in db.Categories where cat.CategoryName.Contains(search) select cat.CategoryName).ToArray();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return (string[])GetDefaultReturn(typeof(string[]));
            }
        }

        static public bool InsertCategory(string name, string closure)
        {
            try
            {
                var db = Connection();
                var category = new Category
                {
                    CategoryName = name,
                    ClosureDate = closure
                    
                };
                db.Categories.InsertOnSubmit(category);
                db.SubmitChanges();
                return true;
            }
            catch (Exception em)
            {
                Console.WriteLine(em);
                return (bool)GetDefaultReturn(typeof(bool));
            }
        }

        static public bool IsOpen(int id)
        {
            try
            {
                var db = Connection();
                string date = (from e in db.Categories where e.CategoryID == id select e.ClosureDate.ToString()).FirstOrDefault();
                if (DateTime.Compare(Convert.ToDateTime(date), DateTime.Today) > 0 || date == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return (bool)GetDefaultReturn(typeof(bool));
            }
        }

        #endregion

        #region DepartmentCategory
        //Not sure what I'm meant to put in here

        static public bool InsertDepartmentCategory(int depID, int catID)
        {
            try
            {
                var db = Connection();

                DepartmentCategory dc = new DepartmentCategory
                {
                    DepartmentID = depID,
                    CategoryID = catID
                };

                db.DepartmentCategories.InsertOnSubmit(dc);
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return (bool)GetDefaultReturn(typeof(bool));
            }
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
        static public int InsertIdea(int categoryID, string title, string description, int staffID, bool IsAnnonymous, bool IsHidden)
        {
            try
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
                //return newIdea.IdeaID;
                return newIdea.IdeaID;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return (int)GetDefaultReturn(typeof(int));
            }
        }

        /// <summary>
        /// Gets all ideas relating to a category
        /// </summary>
        /// <param name="categoryID"></param>
        /// <returns></returns>
        static public string[][] SelectIdeas(int categoryID)
        {
            try
            {
                var db = Connection();
                return (from i in db.Ideas where i.CategoryID == categoryID select new string[] { i.Title, i.Description, i.RegisteredStaffID.ToString(), i.IsAnnonymous.ToString() }).ToArray();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return (string[][])GetDefaultReturn(typeof(string[][]));
            }
            //return all doc now?
        }

        static public List<Idea> GetAllIdeasByMostRecent() {
            try
            {
                var db = Connection();
                return (from i in db.Ideas
                        orderby i.IdeaID descending
                        select i).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return (List<Idea>)GetDefaultReturn(typeof(List<Idea>));
            }
        }

        static public string[][] GetLastIdeas(int categoryID, int page, int numberOfIdeas)
        {
            try
            {
                var db = Connection();
                return (from i in db.Ideas
                        join r in db.RegisteredStaffs on i.RegisteredStaffID equals r.RegisteredStaffID
                        join s in db.AllStaffs on r.AllStaffID equals s.AllStaffID              
                        orderby i.IdeaID 
                        descending where i.CategoryID == categoryID && i.IsHidden == false select new string[] {i.IdeaID.ToString(), i.Title, i.Description, i.RegisteredStaffID.ToString(), i.IsAnnonymous.ToString(), s.Name.ToString() }).Skip((page - 1 )* numberOfIdeas).Take(numberOfIdeas).AsEnumerable().ToArray();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return (string[][])GetDefaultReturn(typeof(string[][]));
            }
        }

        


        #endregion

        #region Document
        /// <summary>
        /// Saves document in db. More than 1 doc can be uploaded simultaneous, so either call this method in a loop or change this to loop through a list of documents
        /// </summary>
        /// <param name="ideaID"></param>
        /// <param name="docPath"></param>
        static public bool InsertDoc(int ideaID, string docPath)      //docpah will be changed to image?
        {
            try
            {
                var db = Connection();

                //foreach (var doc in docPath) {                     //ideaID would stay constant, so just loop through docs list
                Document newDoc = new Document
                {
                    IdeaID = ideaID,
                    DocPath = docPath
                };

                db.Documents.InsertOnSubmit(newDoc);
               // }

                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return (bool)GetDefaultReturn(typeof(bool));
            }
        }
       

       

        /// <summary>
        /// returns list of documents associated with selected idea
        /// </summary>
        /// <param name="ideaID"></param>
        /// <returns></returns>
        static public string[] GetDocs(int ideaID)
        {
            try
            {
                var db = Connection();
                return (from doc in db.Documents select doc.DocPath).ToArray();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return (string[])GetDefaultReturn(typeof(string[]));
            }
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
        static public bool InsertComment(string comment, int ideaID, int staffID, bool IsAnnonymous)
        {
            try
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
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return (bool)GetDefaultReturn(typeof(bool));
            }
        }

        /// <summary>
        /// Returns an object containing list of comments.
        /// object -> string, int, bool
        /// </summary>
        /// <param name="ideaID"></param>
        /// <returns></returns>
        static public object[] SelectAllComments(int ideaID)
        {
            try
            {
                var db = Connection();
                return (from c in db.Comments where c.IdeaID == ideaID select new { c.Comment1, c.RegisteredStaffID, c.IsAnnonymous }).ToArray();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return (object[])GetDefaultReturn(typeof(object[]));
            }
        }

        static public string[][] SelectAllCommentsByMostRecent(int ideaID, int page, int pageSize) {
            try
            {
                var db = Connection();
                return (from c in db.Comments
                        join r in db.RegisteredStaffs on c.RegisteredStaffID equals r.RegisteredStaffID
                        join s in db.AllStaffs on r.AllStaffID equals s.AllStaffID
                        where c.IdeaID == ideaID
                        orderby c.CommentID descending
                        select new string[] { c.CommentID.ToString(), c.Comment1, c.IsAnnonymous.ToString(), s.Name }).Skip((page - 1) * pageSize).Take(pageSize).ToArray();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return (string[][])GetDefaultReturn(typeof(string[][]));
            }
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
            try
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
            catch (Exception e)
            {
                Console.WriteLine(e);
                return (bool)GetDefaultReturn(typeof(bool));
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
            try
            {
                var db = Connection();

                return bool.Parse((from r in db.Ratings where r.IdeaID == ideaID && r.RegisteredStaffID == staffID select r.Vote).FirstOrDefault().ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return (bool)GetDefaultReturn(typeof(bool));
            }
        }

        /// <summary>
        /// Updates/creates rating depending on current state
        /// </summary>
        /// <param name="ideaID"></param>
        /// <param name="staffID"></param>
        /// <param name="voteValue"></param>
        static public bool UpdateRating(int ideaID, int staffID, bool voteValue)
        {
            try
            {
                var db = Connection();

                if (RatingExists(ideaID, staffID))
                {
                    //if rating exists, find stored user rating
                    Rating findRating = db.Ratings.FirstOrDefault(r => r.IdeaID.Equals(ideaID) && r.RegisteredStaffID.Equals(staffID));

                    //Get current value of rating
                    //bool currentValue = RatingValue(ideaID, staffID);


                    if (findRating.Vote == voteValue)
                    {
                        //if user has clicked same vote twice, delete the rating
                        //vote is the same, do nothing
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
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return (bool)GetDefaultReturn(typeof(bool));
            }
        }

        /// <summary>
        /// Returns a list containing all votes for idea
        /// </summary>
        /// <param name="ideaID"></param>
        /// <param name="staffID"></param>
        /// <returns></returns>
        static public bool[] GetVotesForIdeaByStaff(int ideaID, int staffID)
        {
            try
            {
                //1 for upvote, 0 for downvote
                var db = Connection();
                return (from r in db.Ratings where r.IdeaID == ideaID && r.RegisteredStaffID == staffID select (bool)r.Vote).ToArray();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return (bool[])GetDefaultReturn(typeof(bool[]));
            }



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
            try
            {
                //1 for upvote, 0 for downvote
                var db = Connection();
                return (from r in db.Ratings where r.IdeaID == ideaID select r).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return (List<Rating>)GetDefaultReturn(typeof(List<Rating>));
            }

        }
        #endregion

        #region Report

        static public bool InsertReport(int rStaffID, int ideaID, string desc, string status)
        {
            try { 
            var db = Connection();
            Report report = new Report
            {
                RegisteredStaffID = rStaffID,
                IdeaID = ideaID,
                Description = desc,
                Status = status
            };
                db.Reports.InsertOnSubmit(report);
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return (bool)GetDefaultReturn(typeof(bool));
            }
        }

        static public List<Report> GetAllReports()
        {
            try
            {
                var db = Connection();
                return (from r in db.Reports select r).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return (List<Report>)GetDefaultReturn(typeof(List<Report>));
            }
        }

        static public List<Report> GetAllReportsWithStatus(string status)
        {
            try
            {
                var db = Connection();
                return (from r in db.Reports where r.Status == status select r).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return (List<Report>)GetDefaultReturn(typeof(List<Report>));
            }
        }
        #endregion

        #region LoginSession



        public static string GetBrowserDetails()

        {

            string browserDetails = string.Empty;

            System.Web.HttpBrowserCapabilities browser = HttpContext.Current.Request.Browser;

            browserDetails = browser.Browser;

            return browserDetails;

        }
        static public void InsertLogin(int rStaffID)
        {
            
            try
            {
                var db = Connection();
                LoginSession login = new LoginSession
                {
                    RegisteredStaffID = rStaffID,
                    Date = DateTime.Today.ToShortDateString(),
                    Browser = GetBrowserDetails().ToString()
                };
                db.LoginSessions.InsertOnSubmit(login);
                db.SubmitChanges();
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
              
            }
        }

        static public string GetLastLogin(int rStaffID)
        {


            var db = Connection();
            List<string> query = (from r in db.LoginSessions
                         where r.RegisteredStaffID == rStaffID
                         select r.Date.ToString()).ToList();

            if (query.Count > 0)
            {
                return "The last date you logged in was " + query.Last().ToString();
                
            }
            else
            {
                return "Welcome! This is the first time you logged in.";
            }
           
        
        }


        #endregion

        #region ExportFiles

        static public string text;
        static public string line;
        static public bool ExportCSV()           
        {
            line = "";
            line += ("IdeaID");
            line += ", ";
            line += ("RegisteredStaf");
            line += ", ";
            line += ("Title");
            line += ", ";
            line += ("Description");
            text += line;
            var db = Connection();
            var query = from i in db.Ideas select i;
            foreach(var q in query)
            {
                line = "";
                line += (q.IdeaID.ToString());
                line += ", ";
                line += (q.RegisteredStaffID.ToString());
                line += ", ";
                line += (q.Title.ToString());
                line += ", ";
                line += (q.Description.ToString());               
                text += "\n" + line;
            }
            try
            {
        System.IO.File.WriteAllText(@"I:\\ideas.csv", text);
            return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

        }




        #endregion


        #region Statistics
        
        static public int MostActiveUser()
        {
            List<int> list = new List<int>();
            var db = Connection();
            var query = from i in db.Ideas select i;
            foreach(var q in query)
            {
                list.Add((int)q.RegisteredStaffID);
            }

            var most = (from i in list

                        group i by i into grp

                        orderby grp.Count() descending

                        select grp.Key).First();
            return most;

        }


        static public int MostActiveUserComment()
        {
            List<int> list = new List<int>();
            var db = Connection();
            var query = from i in db.Comments select i;
            foreach (var q in query)
            {
                list.Add((int)q.RegisteredStaffID);
            }

            try
            {
                var most = (from i in list

                            group i by i into grp

                            orderby grp.Count() descending

                            select grp.Key).First();


                return most;
            }
            catch
            {
                return 0;
            }

        }



        static public int MostLikedIdea()
        {
            List<int> list = new List<int>();
            var db = Connection();
            var query = from i in db.Ratings where i.Vote == true select i;
            foreach (var q in query)
            {
                list.Add((int)q.IdeaID);
            }

            try
            {
                var most = (from i in list

                            group i by i into grp

                            orderby grp.Count() descending

                            select grp.Key).First();


                return most;
            }
            catch
            {
                return 0;
            }

        }



        static public int MostPopularCategory()
        {
            List<int> list = new List<int>();
            var db = Connection();
            var query = from i in db.Ideas  select i;
            foreach (var q in query)
            {
                list.Add((int)q.CategoryID);
            }

            try
            {
                var most = (from i in list

                            group i by i into grp

                            orderby grp.Count() descending

                            select grp.Key).First();


                return most;
            }
            catch
            {
                return 0;
            }

        }

        #endregion



    }
}
