using System;
using fifth_tempDBAPI.DataLayer;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fifth_tempDBAPI.BusinessObject.Base
{
     /// <summary>
     /// Base class for UserRoles.  Do not make changes to this class,
     /// instead, put additional code in the UserRoles class
     /// </summary>
     public class UserRolesBase : fifth_tempDBAPI.Models.UserRolesModel
     {

         /// <summary>
         /// Constructor
         /// </summary>
         public UserRolesBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static UserRoles SelectByPrimaryKey(int userRoleId)
         {
             return UserRolesDataLayer.SelectByPrimaryKey(userRoleId);
         }

         /// <summary>
         /// Gets the total number of records in the UserRoles table
         /// </summary>
         public static int GetRecordCount()
         {
             return UserRolesDataLayer.GetRecordCount();
         }

         /// <summary>
         /// Gets the total number of records in the UserRoles table by UserId
         /// </summary>
         public static int GetRecordCountByUserId(int userId)
         {
             return UserRolesDataLayer.GetRecordCountByUserId(userId);
         }

         /// <summary>
         /// Gets the total number of records in the UserRoles table by RoleId
         /// </summary>
         public static int GetRecordCountByRoleId(int roleId)
         {
             return UserRolesDataLayer.GetRecordCountByRoleId(roleId);
         }

         /// <summary>
         /// Gets the total number of records in the UserRoles table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? userRoleId, int? userId, int? roleId, bool? status)
         {
             return UserRolesDataLayer.GetRecordCountDynamicWhere(userRoleId, userId, roleId, status);
         }

         /// <summary>
         /// Selects records as a collection (List) of UserRoles sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         public static List<UserRoles> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression, bool isIncludeRelatedProperties = true)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return UserRolesDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows, isIncludeRelatedProperties);
         }

         /// <summary>
         /// Selects records by UserId as a collection (List) of UserRoles sorted by the sortByExpression starting from the startRowIndex
         /// </summary>
         public static List<UserRoles> SelectSkipAndTakeByUserId(int rows, int startRowIndex, string sortByExpression, int userId)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return UserRolesDataLayer.SelectSkipAndTakeByUserId(sortByExpression, startRowIndex, rows, userId);
         }

         /// <summary>
         /// Selects records by RoleId as a collection (List) of UserRoles sorted by the sortByExpression starting from the startRowIndex
         /// </summary>
         public static List<UserRoles> SelectSkipAndTakeByRoleId(int rows, int startRowIndex, string sortByExpression, int roleId)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return UserRolesDataLayer.SelectSkipAndTakeByRoleId(sortByExpression, startRowIndex, rows, roleId);
         }

         /// <summary>
         /// Selects records as a collection (List) of UserRoles sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<UserRoles> SelectSkipAndTakeDynamicWhere(int? userRoleId, int? userId, int? roleId, bool? status, int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return UserRolesDataLayer.SelectSkipAndTakeDynamicWhere(userRoleId, userId, roleId, status, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects all records as a collection (List) of UserRoles
         /// </summary>
         public static List<UserRoles> SelectAll()
         {
             return UserRolesDataLayer.SelectAll();
         }

         /// <summary>
         /// Selects all records as a collection (List) of UserRoles sorted by the sort expression
         /// </summary>
         public static List<UserRoles> SelectAll(string sortByExpression)
         {
             List<UserRoles> objUserRolesCol = UserRolesDataLayer.SelectAll();
             return SortByExpression(objUserRolesCol, sortByExpression);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of UserRoles.
         /// </summary>
         public static List<UserRoles> SelectAllDynamicWhere(int? userRoleId, int? userId, int? roleId, bool? status)
         {
             return UserRolesDataLayer.SelectAllDynamicWhere(userRoleId, userId, roleId, status);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of UserRoles sorted by the sort expression.
         /// </summary>
         public static List<UserRoles> SelectAllDynamicWhere(int? userRoleId, int? userId, int? roleId, bool? status, string sortByExpression)
         {
             List<UserRoles> objUserRolesCol = UserRolesDataLayer.SelectAllDynamicWhere(userRoleId, userId, roleId, status);
             return SortByExpression(objUserRolesCol, sortByExpression);
         }

         /// <summary>
         /// Selects all UserRoles by UserMaster, related to column UserId
         /// </summary>
         public static List<UserRoles> SelectUserRolesCollectionByUserId(int userId)
         {
             return UserRolesDataLayer.SelectUserRolesCollectionByUserId(userId);
         }

         /// <summary>
         /// Selects all UserRoles by UserMaster, related to column UserId, sorted by the sort expression
         /// </summary>
         public static List<UserRoles> SelectUserRolesCollectionByUserId(int userId, string sortByExpression)
         {
             List<UserRoles> objUserRolesCol = UserRolesDataLayer.SelectUserRolesCollectionByUserId(userId);
             return SortByExpression(objUserRolesCol, sortByExpression);
         }

         /// <summary>
         /// Selects all UserRoles by RoleMaster, related to column RoleId
         /// </summary>
         public static List<UserRoles> SelectUserRolesCollectionByRoleId(int roleId)
         {
             return UserRolesDataLayer.SelectUserRolesCollectionByRoleId(roleId);
         }

         /// <summary>
         /// Selects all UserRoles by RoleMaster, related to column RoleId, sorted by the sort expression
         /// </summary>
         public static List<UserRoles> SelectUserRolesCollectionByRoleId(int roleId, string sortByExpression)
         {
             List<UserRoles> objUserRolesCol = UserRolesDataLayer.SelectUserRolesCollectionByRoleId(roleId);
             return SortByExpression(objUserRolesCol, sortByExpression);
         }

         /// <summary>
         /// Selects UserRoleId and Status columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
         /// </summary>
         public static List<UserRoles> SelectUserRolesDropDownListData()
         {
             return UserRolesDataLayer.SelectUserRolesDropDownListData();
         }

         /// <summary>
         /// Sorts the List<UserRoles >by sort expression
         /// </summary>
         public static List<UserRoles> SortByExpression(List<UserRoles> objUserRolesCol, string sortExpression)
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
                 case "UserRoleId":
                     objUserRolesCol.Sort(fifth_tempDBAPI.BusinessObject.UserRoles.ByUserRoleId);
                     break;
                 case "UserId":
                     objUserRolesCol.Sort(fifth_tempDBAPI.BusinessObject.UserRoles.ByUserId);
                     break;
                 case "RoleId":
                     objUserRolesCol.Sort(fifth_tempDBAPI.BusinessObject.UserRoles.ByRoleId);
                     break;
                 case "Status":
                     objUserRolesCol.Sort(fifth_tempDBAPI.BusinessObject.UserRoles.ByStatus);
                     break;
                 default:
                     break;
             }

             if (isSortDescending)
                 objUserRolesCol.Reverse();

             return objUserRolesCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public int Insert()
         {
             UserRoles objUserRoles = (UserRoles)this;
             return UserRolesDataLayer.Insert(objUserRoles);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public void Update()
         {
             UserRoles objUserRoles = (UserRoles)this;
             UserRolesDataLayer.Update(objUserRoles);
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         public static void Delete(int userRoleId)
         {
             UserRolesDataLayer.Delete(userRoleId);
         }

         private static string GetSortExpression(string sortByExpression)
         {
             if (String.IsNullOrEmpty(sortByExpression) || sortByExpression == " asc")
                 sortByExpression = "UserRoleId";
             else if (sortByExpression.Contains(" asc"))
                 sortByExpression = sortByExpression.Replace(" asc", "");

             return sortByExpression;
         }

         /// <summary>
         /// Compares UserRoleId used for sorting
         /// </summary>
         public static Comparison<UserRoles> ByUserRoleId = delegate(UserRoles x, UserRoles y)
         {
             return x.UserRoleId.CompareTo(y.UserRoleId);
         };

         /// <summary>
         /// Compares UserId used for sorting
         /// </summary>
         public static Comparison<UserRoles> ByUserId = delegate(UserRoles x, UserRoles y)
         {
             return Nullable.Compare(x.UserId, y.UserId);
         };

         /// <summary>
         /// Compares RoleId used for sorting
         /// </summary>
         public static Comparison<UserRoles> ByRoleId = delegate(UserRoles x, UserRoles y)
         {
             return Nullable.Compare(x.RoleId, y.RoleId);
         };

         /// <summary>
         /// Compares Status used for sorting
         /// </summary>
         public static Comparison<UserRoles> ByStatus = delegate(UserRoles x, UserRoles y)
         {
             return x.Status.CompareTo(y.Status);
         };

     }
}
