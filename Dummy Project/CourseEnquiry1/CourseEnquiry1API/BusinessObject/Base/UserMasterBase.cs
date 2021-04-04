using System;
using CourseEnquiry1API.DataLayer;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CourseEnquiry1API.BusinessObject.Base
{
     /// <summary>
     /// Base class for UserMaster.  Do not make changes to this class,
     /// instead, put additional code in the UserMaster class
     /// </summary>
     public class UserMasterBase : CourseEnquiry1API.Models.UserMasterModel
     {

         /// <summary>
         /// Constructor
         /// </summary>
         public UserMasterBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static UserMaster SelectByPrimaryKey(int userId)
         {
             return UserMasterDataLayer.SelectByPrimaryKey(userId);
         }

         /// <summary>
         /// Gets the total number of records in the UserMaster table
         /// </summary>
         public static int GetRecordCount()
         {
             return UserMasterDataLayer.GetRecordCount();
         }

         /// <summary>
         /// Gets the total number of records in the UserMaster table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? userId, string userName, string password, string email, DateTime? createdOn, string createdBy, DateTime? modifiedOn, string modifiedBy)
         {
             return UserMasterDataLayer.GetRecordCountDynamicWhere(userId, userName, password, email, createdOn, createdBy, modifiedOn, modifiedBy);
         }

         /// <summary>
         /// Selects records as a collection (List) of UserMaster sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         public static List<UserMaster> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return UserMasterDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of UserMaster sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<UserMaster> SelectSkipAndTakeDynamicWhere(int? userId, string userName, string password, string email, DateTime? createdOn, string createdBy, DateTime? modifiedOn, string modifiedBy, int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return UserMasterDataLayer.SelectSkipAndTakeDynamicWhere(userId, userName, password, email, createdOn, createdBy, modifiedOn, modifiedBy, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects all records as a collection (List) of UserMaster
         /// </summary>
         public static List<UserMaster> SelectAll()
         {
             return UserMasterDataLayer.SelectAll();
         }

         /// <summary>
         /// Selects all records as a collection (List) of UserMaster sorted by the sort expression
         /// </summary>
         public static List<UserMaster> SelectAll(string sortByExpression)
         {
             List<UserMaster> objUserMasterCol = UserMasterDataLayer.SelectAll();
             return SortByExpression(objUserMasterCol, sortByExpression);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of UserMaster.
         /// </summary>
         public static List<UserMaster> SelectAllDynamicWhere(int? userId, string userName, string password, string email, DateTime? createdOn, string createdBy, DateTime? modifiedOn, string modifiedBy)
         {
             return UserMasterDataLayer.SelectAllDynamicWhere(userId, userName, password, email, createdOn, createdBy, modifiedOn, modifiedBy);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of UserMaster sorted by the sort expression.
         /// </summary>
         public static List<UserMaster> SelectAllDynamicWhere(int? userId, string userName, string password, string email, DateTime? createdOn, string createdBy, DateTime? modifiedOn, string modifiedBy, string sortByExpression)
         {
             List<UserMaster> objUserMasterCol = UserMasterDataLayer.SelectAllDynamicWhere(userId, userName, password, email, createdOn, createdBy, modifiedOn, modifiedBy);
             return SortByExpression(objUserMasterCol, sortByExpression);
         }

         /// <summary>
         /// Selects UserId and CreatedBy columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
         /// </summary>
         public static List<UserMaster> SelectUserMasterDropDownListData()
         {
             return UserMasterDataLayer.SelectUserMasterDropDownListData();
         }

         /// <summary>
         /// Sorts the List<UserMaster >by sort expression
         /// </summary>
         public static List<UserMaster> SortByExpression(List<UserMaster> objUserMasterCol, string sortExpression)
         {
             bool isSortDescending = sortExpression.ToLower().Contains(" desc");

             if (isSortDescending)
             {
                 sortExpression = sortExpression.Replace(" DESC", "");
                 sortExpression = sortExpression.Replace(" desc", "");
             }
             else
             {
                 sortExpression = sortExpression.Replace(" ASC", "");
                 sortExpression = sortExpression.Replace(" asc", "");
             }

             switch (sortExpression)
             {
                 case "UserId":
                     objUserMasterCol.Sort(CourseEnquiry1API.BusinessObject.UserMaster.ByUserId);
                     break;
                 case "UserName":
                     objUserMasterCol.Sort(CourseEnquiry1API.BusinessObject.UserMaster.ByUserName);
                     break;
                 case "Password":
                     objUserMasterCol.Sort(CourseEnquiry1API.BusinessObject.UserMaster.ByPassword);
                     break;
                 case "Email":
                     objUserMasterCol.Sort(CourseEnquiry1API.BusinessObject.UserMaster.ByEmail);
                     break;
                 case "CreatedOn":
                     objUserMasterCol.Sort(CourseEnquiry1API.BusinessObject.UserMaster.ByCreatedOn);
                     break;
                 case "CreatedBy":
                     objUserMasterCol.Sort(CourseEnquiry1API.BusinessObject.UserMaster.ByCreatedBy);
                     break;
                 case "ModifiedOn":
                     objUserMasterCol.Sort(CourseEnquiry1API.BusinessObject.UserMaster.ByModifiedOn);
                     break;
                 case "ModifiedBy":
                     objUserMasterCol.Sort(CourseEnquiry1API.BusinessObject.UserMaster.ByModifiedBy);
                     break;
                 default:
                     break;
             }

             if (isSortDescending)
                 objUserMasterCol.Reverse();

             return objUserMasterCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public int Insert()
         {
             UserMaster objUserMaster = (UserMaster)this;
             return UserMasterDataLayer.Insert(objUserMaster);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public void Update()
         {
             UserMaster objUserMaster = (UserMaster)this;
             UserMasterDataLayer.Update(objUserMaster);
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         public static void Delete(int userId)
         {
             UserMasterDataLayer.Delete(userId);
         }

         private static string GetSortExpression(string sortByExpression)
         {
             if (String.IsNullOrEmpty(sortByExpression) || sortByExpression == " asc")
                 sortByExpression = "UserId";
             else if (sortByExpression.Contains(" asc"))
                 sortByExpression = sortByExpression.Replace(" asc", "");

             return sortByExpression;
         }

         /// <summary>
         /// Compares UserId used for sorting
         /// </summary>
         public static Comparison<UserMaster> ByUserId = delegate(UserMaster x, UserMaster y)
         {
             return x.UserId.CompareTo(y.UserId);
         };

         /// <summary>
         /// Compares UserName used for sorting
         /// </summary>
         public static Comparison<UserMaster> ByUserName = delegate(UserMaster x, UserMaster y)
         {
             string value1 = x.UserName ?? String.Empty;
             string value2 = y.UserName ?? String.Empty;
             return value1.CompareTo(value2);
         };

         /// <summary>
         /// Compares Password used for sorting
         /// </summary>
         public static Comparison<UserMaster> ByPassword = delegate(UserMaster x, UserMaster y)
         {
             string value1 = x.Password ?? String.Empty;
             string value2 = y.Password ?? String.Empty;
             return value1.CompareTo(value2);
         };

         /// <summary>
         /// Compares Email used for sorting
         /// </summary>
         public static Comparison<UserMaster> ByEmail = delegate(UserMaster x, UserMaster y)
         {
             string value1 = x.Email ?? String.Empty;
             string value2 = y.Email ?? String.Empty;
             return value1.CompareTo(value2);
         };

         /// <summary>
         /// Compares CreatedOn used for sorting
         /// </summary>
         public static Comparison<UserMaster> ByCreatedOn = delegate(UserMaster x, UserMaster y)
         {
             return x.CreatedOn.CompareTo(y.CreatedOn);
         };

         /// <summary>
         /// Compares CreatedBy used for sorting
         /// </summary>
         public static Comparison<UserMaster> ByCreatedBy = delegate(UserMaster x, UserMaster y)
         {
             string value1 = x.CreatedBy ?? String.Empty;
             string value2 = y.CreatedBy ?? String.Empty;
             return value1.CompareTo(value2);
         };

         /// <summary>
         /// Compares ModifiedOn used for sorting
         /// </summary>
         public static Comparison<UserMaster> ByModifiedOn = delegate(UserMaster x, UserMaster y)
         {
             return Nullable.Compare(x.ModifiedOn, y.ModifiedOn);
         };

         /// <summary>
         /// Compares ModifiedBy used for sorting
         /// </summary>
         public static Comparison<UserMaster> ByModifiedBy = delegate(UserMaster x, UserMaster y)
         {
             string value1 = x.ModifiedBy ?? String.Empty;
             string value2 = y.ModifiedBy ?? String.Empty;
             return value1.CompareTo(value2);
         };

     }
}
