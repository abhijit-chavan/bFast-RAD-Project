using System;
using CourseEnquiryAPI.DataLayer;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CourseEnquiryAPI.BusinessObject.Base
{
     /// <summary>
     /// Base class for Admin.  Do not make changes to this class,
     /// instead, put additional code in the Admin class
     /// </summary>
     public class AdminBase : CourseEnquiryAPI.Models.AdminModel
     {

         /// <summary>
         /// Constructor
         /// </summary>
         public AdminBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static Admin SelectByPrimaryKey(int adminId)
         {
             return AdminDataLayer.SelectByPrimaryKey(adminId);
         }

         /// <summary>
         /// Gets the total number of records in the Admin table
         /// </summary>
         public static int GetRecordCount()
         {
             return AdminDataLayer.GetRecordCount();
         }

         /// <summary>
         /// Gets the total number of records in the Admin table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? adminId, string adminName, string adminPassword)
         {
             return AdminDataLayer.GetRecordCountDynamicWhere(adminId, adminName, adminPassword);
         }

         /// <summary>
         /// Selects records as a collection (List) of Admin sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         public static List<Admin> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return AdminDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of Admin sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<Admin> SelectSkipAndTakeDynamicWhere(int? adminId, string adminName, string adminPassword, int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return AdminDataLayer.SelectSkipAndTakeDynamicWhere(adminId, adminName, adminPassword, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects all records as a collection (List) of Admin
         /// </summary>
         public static List<Admin> SelectAll()
         {
             return AdminDataLayer.SelectAll();
         }

         /// <summary>
         /// Selects all records as a collection (List) of Admin sorted by the sort expression
         /// </summary>
         public static List<Admin> SelectAll(string sortByExpression)
         {
             List<Admin> objAdminCol = AdminDataLayer.SelectAll();
             return SortByExpression(objAdminCol, sortByExpression);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of Admin.
         /// </summary>
         public static List<Admin> SelectAllDynamicWhere(int? adminId, string adminName, string adminPassword)
         {
             return AdminDataLayer.SelectAllDynamicWhere(adminId, adminName, adminPassword);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of Admin sorted by the sort expression.
         /// </summary>
         public static List<Admin> SelectAllDynamicWhere(int? adminId, string adminName, string adminPassword, string sortByExpression)
         {
             List<Admin> objAdminCol = AdminDataLayer.SelectAllDynamicWhere(adminId, adminName, adminPassword);
             return SortByExpression(objAdminCol, sortByExpression);
         }

         /// <summary>
         /// Selects AdminId and AdminName columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
         /// </summary>
         public static List<Admin> SelectAdminDropDownListData()
         {
             return AdminDataLayer.SelectAdminDropDownListData();
         }

         /// <summary>
         /// Sorts the List<Admin >by sort expression
         /// </summary>
         public static List<Admin> SortByExpression(List<Admin> objAdminCol, string sortExpression)
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
                 case "AdminId":
                     objAdminCol.Sort(CourseEnquiryAPI.BusinessObject.Admin.ByAdminId);
                     break;
                 case "AdminName":
                     objAdminCol.Sort(CourseEnquiryAPI.BusinessObject.Admin.ByAdminName);
                     break;
                 case "AdminPassword":
                     objAdminCol.Sort(CourseEnquiryAPI.BusinessObject.Admin.ByAdminPassword);
                     break;
                 default:
                     break;
             }

             if (isSortDescending)
                 objAdminCol.Reverse();

             return objAdminCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public int Insert()
         {
             Admin objAdmin = (Admin)this;
             return AdminDataLayer.Insert(objAdmin);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public void Update()
         {
             Admin objAdmin = (Admin)this;
             AdminDataLayer.Update(objAdmin);
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         public static void Delete(int adminId)
         {
             AdminDataLayer.Delete(adminId);
         }

         private static string GetSortExpression(string sortByExpression)
         {
             if (String.IsNullOrEmpty(sortByExpression) || sortByExpression == " asc")
                 sortByExpression = "AdminId";
             else if (sortByExpression.Contains(" asc"))
                 sortByExpression = sortByExpression.Replace(" asc", "");

             return sortByExpression;
         }

         /// <summary>
         /// Compares AdminId used for sorting
         /// </summary>
         public static Comparison<Admin> ByAdminId = delegate(Admin x, Admin y)
         {
             return x.AdminId.CompareTo(y.AdminId);
         };

         /// <summary>
         /// Compares AdminName used for sorting
         /// </summary>
         public static Comparison<Admin> ByAdminName = delegate(Admin x, Admin y)
         {
             string value1 = x.AdminName ?? String.Empty;
             string value2 = y.AdminName ?? String.Empty;
             return value1.CompareTo(value2);
         };

         /// <summary>
         /// Compares AdminPassword used for sorting
         /// </summary>
         public static Comparison<Admin> ByAdminPassword = delegate(Admin x, Admin y)
         {
             string value1 = x.AdminPassword ?? String.Empty;
             string value2 = y.AdminPassword ?? String.Empty;
             return value1.CompareTo(value2);
         };

     }
}
