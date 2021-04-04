using System;
using StudentEnquiryAPI.DataLayer;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentEnquiryAPI.BusinessObject.Base
{
     /// <summary>
     /// Base class for Couse.  Do not make changes to this class,
     /// instead, put additional code in the Couse class
     /// </summary>
     public class CouseBase : StudentEnquiryAPI.Models.CouseModel
     {

         /// <summary>
         /// Constructor
         /// </summary>
         public CouseBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static Couse SelectByPrimaryKey(int couseid)
         {
             return CouseDataLayer.SelectByPrimaryKey(couseid);
         }

         /// <summary>
         /// Gets the total number of records in the Couse table
         /// </summary>
         public static int GetRecordCount()
         {
             return CouseDataLayer.GetRecordCount();
         }

         /// <summary>
         /// Gets the total number of records in the Couse table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? couseid, string couseName, DateTime? courseStartDate, DateTime? courseEndDate, Int64? couseFees)
         {
             return CouseDataLayer.GetRecordCountDynamicWhere(couseid, couseName, courseStartDate, courseEndDate, couseFees);
         }

         /// <summary>
         /// Selects records as a collection (List) of Couse sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         public static List<Couse> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return CouseDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of Couse sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<Couse> SelectSkipAndTakeDynamicWhere(int? couseid, string couseName, DateTime? courseStartDate, DateTime? courseEndDate, Int64? couseFees, int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return CouseDataLayer.SelectSkipAndTakeDynamicWhere(couseid, couseName, courseStartDate, courseEndDate, couseFees, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects all records as a collection (List) of Couse
         /// </summary>
         public static List<Couse> SelectAll()
         {
             return CouseDataLayer.SelectAll();
         }

         /// <summary>
         /// Selects all records as a collection (List) of Couse sorted by the sort expression
         /// </summary>
         public static List<Couse> SelectAll(string sortByExpression)
         {
             List<Couse> objCouseCol = CouseDataLayer.SelectAll();
             return SortByExpression(objCouseCol, sortByExpression);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of Couse.
         /// </summary>
         public static List<Couse> SelectAllDynamicWhere(int? couseid, string couseName, DateTime? courseStartDate, DateTime? courseEndDate, Int64? couseFees)
         {
             return CouseDataLayer.SelectAllDynamicWhere(couseid, couseName, courseStartDate, courseEndDate, couseFees);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of Couse sorted by the sort expression.
         /// </summary>
         public static List<Couse> SelectAllDynamicWhere(int? couseid, string couseName, DateTime? courseStartDate, DateTime? courseEndDate, Int64? couseFees, string sortByExpression)
         {
             List<Couse> objCouseCol = CouseDataLayer.SelectAllDynamicWhere(couseid, couseName, courseStartDate, courseEndDate, couseFees);
             return SortByExpression(objCouseCol, sortByExpression);
         }

         /// <summary>
         /// Selects Couseid and CouseName columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
         /// </summary>
         public static List<Couse> SelectCouseDropDownListData()
         {
             return CouseDataLayer.SelectCouseDropDownListData();
         }

         /// <summary>
         /// Sorts the List<Couse >by sort expression
         /// </summary>
         public static List<Couse> SortByExpression(List<Couse> objCouseCol, string sortExpression)
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
                 case "Couseid":
                     objCouseCol.Sort(StudentEnquiryAPI.BusinessObject.Couse.ByCouseid);
                     break;
                 case "CouseName":
                     objCouseCol.Sort(StudentEnquiryAPI.BusinessObject.Couse.ByCouseName);
                     break;
                 case "CourseStartDate":
                     objCouseCol.Sort(StudentEnquiryAPI.BusinessObject.Couse.ByCourseStartDate);
                     break;
                 case "CourseEndDate":
                     objCouseCol.Sort(StudentEnquiryAPI.BusinessObject.Couse.ByCourseEndDate);
                     break;
                 case "CouseFees":
                     objCouseCol.Sort(StudentEnquiryAPI.BusinessObject.Couse.ByCouseFees);
                     break;
                 default:
                     break;
             }

             if (isSortDescending)
                 objCouseCol.Reverse();

             return objCouseCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public int Insert()
         {
             Couse objCouse = (Couse)this;
             return CouseDataLayer.Insert(objCouse);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public void Update()
         {
             Couse objCouse = (Couse)this;
             CouseDataLayer.Update(objCouse);
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         public static void Delete(int couseid)
         {
             CouseDataLayer.Delete(couseid);
         }

         private static string GetSortExpression(string sortByExpression)
         {
             if (String.IsNullOrEmpty(sortByExpression) || sortByExpression == " asc")
                 sortByExpression = "Couseid";
             else if (sortByExpression.Contains(" asc"))
                 sortByExpression = sortByExpression.Replace(" asc", "");

             return sortByExpression;
         }

         /// <summary>
         /// Compares Couseid used for sorting
         /// </summary>
         public static Comparison<Couse> ByCouseid = delegate(Couse x, Couse y)
         {
             return x.Couseid.CompareTo(y.Couseid);
         };

         /// <summary>
         /// Compares CouseName used for sorting
         /// </summary>
         public static Comparison<Couse> ByCouseName = delegate(Couse x, Couse y)
         {
             string value1 = x.CouseName ?? String.Empty;
             string value2 = y.CouseName ?? String.Empty;
             return value1.CompareTo(value2);
         };

         /// <summary>
         /// Compares CourseStartDate used for sorting
         /// </summary>
         public static Comparison<Couse> ByCourseStartDate = delegate(Couse x, Couse y)
         {
             return x.CourseStartDate.CompareTo(y.CourseStartDate);
         };

         /// <summary>
         /// Compares CourseEndDate used for sorting
         /// </summary>
         public static Comparison<Couse> ByCourseEndDate = delegate(Couse x, Couse y)
         {
             return x.CourseEndDate.CompareTo(y.CourseEndDate);
         };

         /// <summary>
         /// Compares CouseFees used for sorting
         /// </summary>
         public static Comparison<Couse> ByCouseFees = delegate(Couse x, Couse y)
         {
             return x.CouseFees.CompareTo(y.CouseFees);
         };

     }
}
