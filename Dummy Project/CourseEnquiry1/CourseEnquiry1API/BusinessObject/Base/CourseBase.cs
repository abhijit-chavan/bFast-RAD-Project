using System;
using CourseEnquiry1API.DataLayer;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CourseEnquiry1API.BusinessObject.Base
{
     /// <summary>
     /// Base class for Course.  Do not make changes to this class,
     /// instead, put additional code in the Course class
     /// </summary>
     public class CourseBase : CourseEnquiry1API.Models.CourseModel
     {

         /// <summary>
         /// Constructor
         /// </summary>
         public CourseBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static Course SelectByPrimaryKey(int courseId)
         {
             return CourseDataLayer.SelectByPrimaryKey(courseId);
         }

         /// <summary>
         /// Gets the total number of records in the Course table
         /// </summary>
         public static int GetRecordCount()
         {
             return CourseDataLayer.GetRecordCount();
         }

         /// <summary>
         /// Gets the total number of records in the Course table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? courseId, string courseName, DateTime? startDate, DateTime? endDate, decimal? fees)
         {
             return CourseDataLayer.GetRecordCountDynamicWhere(courseId, courseName, startDate, endDate, fees);
         }

         /// <summary>
         /// Selects records as a collection (List) of Course sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         public static List<Course> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return CourseDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of Course sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<Course> SelectSkipAndTakeDynamicWhere(int? courseId, string courseName, DateTime? startDate, DateTime? endDate, decimal? fees, int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return CourseDataLayer.SelectSkipAndTakeDynamicWhere(courseId, courseName, startDate, endDate, fees, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects all records as a collection (List) of Course
         /// </summary>
         public static List<Course> SelectAll()
         {
             return CourseDataLayer.SelectAll();
         }

         /// <summary>
         /// Selects all records as a collection (List) of Course sorted by the sort expression
         /// </summary>
         public static List<Course> SelectAll(string sortByExpression)
         {
             List<Course> objCourseCol = CourseDataLayer.SelectAll();
             return SortByExpression(objCourseCol, sortByExpression);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of Course.
         /// </summary>
         public static List<Course> SelectAllDynamicWhere(int? courseId, string courseName, DateTime? startDate, DateTime? endDate, decimal? fees)
         {
             return CourseDataLayer.SelectAllDynamicWhere(courseId, courseName, startDate, endDate, fees);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of Course sorted by the sort expression.
         /// </summary>
         public static List<Course> SelectAllDynamicWhere(int? courseId, string courseName, DateTime? startDate, DateTime? endDate, decimal? fees, string sortByExpression)
         {
             List<Course> objCourseCol = CourseDataLayer.SelectAllDynamicWhere(courseId, courseName, startDate, endDate, fees);
             return SortByExpression(objCourseCol, sortByExpression);
         }

         /// <summary>
         /// Selects CourseId and CourseName columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
         /// </summary>
         public static List<Course> SelectCourseDropDownListData()
         {
             return CourseDataLayer.SelectCourseDropDownListData();
         }

         /// <summary>
         /// Sorts the List<Course >by sort expression
         /// </summary>
         public static List<Course> SortByExpression(List<Course> objCourseCol, string sortExpression)
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
                 case "CourseId":
                     objCourseCol.Sort(CourseEnquiry1API.BusinessObject.Course.ByCourseId);
                     break;
                 case "CourseName":
                     objCourseCol.Sort(CourseEnquiry1API.BusinessObject.Course.ByCourseName);
                     break;
                 case "StartDate":
                     objCourseCol.Sort(CourseEnquiry1API.BusinessObject.Course.ByStartDate);
                     break;
                 case "EndDate":
                     objCourseCol.Sort(CourseEnquiry1API.BusinessObject.Course.ByEndDate);
                     break;
                 case "Fees":
                     objCourseCol.Sort(CourseEnquiry1API.BusinessObject.Course.ByFees);
                     break;
                 default:
                     break;
             }

             if (isSortDescending)
                 objCourseCol.Reverse();

             return objCourseCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public int Insert()
         {
             Course objCourse = (Course)this;
             return CourseDataLayer.Insert(objCourse);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public void Update()
         {
             Course objCourse = (Course)this;
             CourseDataLayer.Update(objCourse);
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         public static void Delete(int courseId)
         {
             CourseDataLayer.Delete(courseId);
         }

         private static string GetSortExpression(string sortByExpression)
         {
             if (String.IsNullOrEmpty(sortByExpression) || sortByExpression == " asc")
                 sortByExpression = "CourseId";
             else if (sortByExpression.Contains(" asc"))
                 sortByExpression = sortByExpression.Replace(" asc", "");

             return sortByExpression;
         }

         /// <summary>
         /// Compares CourseId used for sorting
         /// </summary>
         public static Comparison<Course> ByCourseId = delegate(Course x, Course y)
         {
             return x.CourseId.CompareTo(y.CourseId);
         };

         /// <summary>
         /// Compares CourseName used for sorting
         /// </summary>
         public static Comparison<Course> ByCourseName = delegate(Course x, Course y)
         {
             string value1 = x.CourseName ?? String.Empty;
             string value2 = y.CourseName ?? String.Empty;
             return value1.CompareTo(value2);
         };

         /// <summary>
         /// Compares StartDate used for sorting
         /// </summary>
         public static Comparison<Course> ByStartDate = delegate(Course x, Course y)
         {
             return x.StartDate.CompareTo(y.StartDate);
         };

         /// <summary>
         /// Compares EndDate used for sorting
         /// </summary>
         public static Comparison<Course> ByEndDate = delegate(Course x, Course y)
         {
             return x.EndDate.CompareTo(y.EndDate);
         };

         /// <summary>
         /// Compares Fees used for sorting
         /// </summary>
         public static Comparison<Course> ByFees = delegate(Course x, Course y)
         {
             return x.Fees.CompareTo(y.Fees);
         };

     }
}
