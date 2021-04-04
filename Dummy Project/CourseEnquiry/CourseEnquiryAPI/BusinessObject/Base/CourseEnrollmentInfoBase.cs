using System;
using CourseEnquiryAPI.DataLayer;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CourseEnquiryAPI.BusinessObject.Base
{
     /// <summary>
     /// Base class for CourseEnrollmentInfo.  Do not make changes to this class,
     /// instead, put additional code in the CourseEnrollmentInfo class
     /// </summary>
     public class CourseEnrollmentInfoBase : CourseEnquiryAPI.Models.CourseEnrollmentInfoModel
     {

         /// <summary>
         /// Constructor
         /// </summary>
         public CourseEnrollmentInfoBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static CourseEnrollmentInfo SelectByPrimaryKey(int enrollmentId)
         {
             return CourseEnrollmentInfoDataLayer.SelectByPrimaryKey(enrollmentId);
         }

         /// <summary>
         /// Gets the total number of records in the CourseEnrollmentInfo table
         /// </summary>
         public static int GetRecordCount()
         {
             return CourseEnrollmentInfoDataLayer.GetRecordCount();
         }

         /// <summary>
         /// Gets the total number of records in the CourseEnrollmentInfo table by EnrollmentId
         /// </summary>
         public static int GetRecordCountByEnrollmentId(int enrollmentId)
         {
             return CourseEnrollmentInfoDataLayer.GetRecordCountByEnrollmentId(enrollmentId);
         }

         /// <summary>
         /// Gets the total number of records in the CourseEnrollmentInfo table by CourseId
         /// </summary>
         public static int GetRecordCountByCourseId(int courseId)
         {
             return CourseEnrollmentInfoDataLayer.GetRecordCountByCourseId(courseId);
         }

         /// <summary>
         /// Gets the total number of records in the CourseEnrollmentInfo table by StudentId
         /// </summary>
         public static int GetRecordCountByStudentId(int studentId)
         {
             return CourseEnrollmentInfoDataLayer.GetRecordCountByStudentId(studentId);
         }

         /// <summary>
         /// Gets the total number of records in the CourseEnrollmentInfo table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? enrollmentId, int? courseId, int? studentId, string comments)
         {
             return CourseEnrollmentInfoDataLayer.GetRecordCountDynamicWhere(enrollmentId, courseId, studentId, comments);
         }

         /// <summary>
         /// Selects records as a collection (List) of CourseEnrollmentInfo sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         public static List<CourseEnrollmentInfo> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression, bool isIncludeRelatedProperties = true)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return CourseEnrollmentInfoDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows, isIncludeRelatedProperties);
         }

         /// <summary>
         /// Selects records by EnrollmentId as a collection (List) of CourseEnrollmentInfo sorted by the sortByExpression starting from the startRowIndex
         /// </summary>
         public static List<CourseEnrollmentInfo> SelectSkipAndTakeByEnrollmentId(int rows, int startRowIndex, string sortByExpression, int enrollmentId)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return CourseEnrollmentInfoDataLayer.SelectSkipAndTakeByEnrollmentId(sortByExpression, startRowIndex, rows, enrollmentId);
         }

         /// <summary>
         /// Selects records by CourseId as a collection (List) of CourseEnrollmentInfo sorted by the sortByExpression starting from the startRowIndex
         /// </summary>
         public static List<CourseEnrollmentInfo> SelectSkipAndTakeByCourseId(int rows, int startRowIndex, string sortByExpression, int courseId)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return CourseEnrollmentInfoDataLayer.SelectSkipAndTakeByCourseId(sortByExpression, startRowIndex, rows, courseId);
         }

         /// <summary>
         /// Selects records by StudentId as a collection (List) of CourseEnrollmentInfo sorted by the sortByExpression starting from the startRowIndex
         /// </summary>
         public static List<CourseEnrollmentInfo> SelectSkipAndTakeByStudentId(int rows, int startRowIndex, string sortByExpression, int studentId)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return CourseEnrollmentInfoDataLayer.SelectSkipAndTakeByStudentId(sortByExpression, startRowIndex, rows, studentId);
         }

         /// <summary>
         /// Selects records as a collection (List) of CourseEnrollmentInfo sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<CourseEnrollmentInfo> SelectSkipAndTakeDynamicWhere(int? enrollmentId, int? courseId, int? studentId, string comments, int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return CourseEnrollmentInfoDataLayer.SelectSkipAndTakeDynamicWhere(enrollmentId, courseId, studentId, comments, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects all records as a collection (List) of CourseEnrollmentInfo
         /// </summary>
         public static List<CourseEnrollmentInfo> SelectAll()
         {
             return CourseEnrollmentInfoDataLayer.SelectAll();
         }

         /// <summary>
         /// Selects all records as a collection (List) of CourseEnrollmentInfo sorted by the sort expression
         /// </summary>
         public static List<CourseEnrollmentInfo> SelectAll(string sortByExpression)
         {
             List<CourseEnrollmentInfo> objCourseEnrollmentInfoCol = CourseEnrollmentInfoDataLayer.SelectAll();
             return SortByExpression(objCourseEnrollmentInfoCol, sortByExpression);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of CourseEnrollmentInfo.
         /// </summary>
         public static List<CourseEnrollmentInfo> SelectAllDynamicWhere(int? enrollmentId, int? courseId, int? studentId, string comments)
         {
             return CourseEnrollmentInfoDataLayer.SelectAllDynamicWhere(enrollmentId, courseId, studentId, comments);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of CourseEnrollmentInfo sorted by the sort expression.
         /// </summary>
         public static List<CourseEnrollmentInfo> SelectAllDynamicWhere(int? enrollmentId, int? courseId, int? studentId, string comments, string sortByExpression)
         {
             List<CourseEnrollmentInfo> objCourseEnrollmentInfoCol = CourseEnrollmentInfoDataLayer.SelectAllDynamicWhere(enrollmentId, courseId, studentId, comments);
             return SortByExpression(objCourseEnrollmentInfoCol, sortByExpression);
         }

         /// <summary>
         /// Selects all CourseEnrollmentInfo by CourseEnrollmentInfo, related to column EnrollmentId
         /// </summary>
         public static List<CourseEnrollmentInfo> SelectCourseEnrollmentInfoCollectionByEnrollmentId(int enrollmentId)
         {
             return CourseEnrollmentInfoDataLayer.SelectCourseEnrollmentInfoCollectionByEnrollmentId(enrollmentId);
         }

         /// <summary>
         /// Selects all CourseEnrollmentInfo by CourseEnrollmentInfo, related to column EnrollmentId, sorted by the sort expression
         /// </summary>
         public static List<CourseEnrollmentInfo> SelectCourseEnrollmentInfoCollectionByEnrollmentId(int enrollmentId, string sortByExpression)
         {
             List<CourseEnrollmentInfo> objCourseEnrollmentInfoCol = CourseEnrollmentInfoDataLayer.SelectCourseEnrollmentInfoCollectionByEnrollmentId(enrollmentId);
             return SortByExpression(objCourseEnrollmentInfoCol, sortByExpression);
         }

         /// <summary>
         /// Selects all CourseEnrollmentInfo by Course, related to column CourseId
         /// </summary>
         public static List<CourseEnrollmentInfo> SelectCourseEnrollmentInfoCollectionByCourseId(int courseId)
         {
             return CourseEnrollmentInfoDataLayer.SelectCourseEnrollmentInfoCollectionByCourseId(courseId);
         }

         /// <summary>
         /// Selects all CourseEnrollmentInfo by Course, related to column CourseId, sorted by the sort expression
         /// </summary>
         public static List<CourseEnrollmentInfo> SelectCourseEnrollmentInfoCollectionByCourseId(int courseId, string sortByExpression)
         {
             List<CourseEnrollmentInfo> objCourseEnrollmentInfoCol = CourseEnrollmentInfoDataLayer.SelectCourseEnrollmentInfoCollectionByCourseId(courseId);
             return SortByExpression(objCourseEnrollmentInfoCol, sortByExpression);
         }

         /// <summary>
         /// Selects all CourseEnrollmentInfo by Student, related to column StudentId
         /// </summary>
         public static List<CourseEnrollmentInfo> SelectCourseEnrollmentInfoCollectionByStudentId(int studentId)
         {
             return CourseEnrollmentInfoDataLayer.SelectCourseEnrollmentInfoCollectionByStudentId(studentId);
         }

         /// <summary>
         /// Selects all CourseEnrollmentInfo by Student, related to column StudentId, sorted by the sort expression
         /// </summary>
         public static List<CourseEnrollmentInfo> SelectCourseEnrollmentInfoCollectionByStudentId(int studentId, string sortByExpression)
         {
             List<CourseEnrollmentInfo> objCourseEnrollmentInfoCol = CourseEnrollmentInfoDataLayer.SelectCourseEnrollmentInfoCollectionByStudentId(studentId);
             return SortByExpression(objCourseEnrollmentInfoCol, sortByExpression);
         }

         /// <summary>
         /// Selects EnrollmentId and Comments columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
         /// </summary>
         public static List<CourseEnrollmentInfo> SelectCourseEnrollmentInfoDropDownListData()
         {
             return CourseEnrollmentInfoDataLayer.SelectCourseEnrollmentInfoDropDownListData();
         }

         /// <summary>
         /// Sorts the List<CourseEnrollmentInfo >by sort expression
         /// </summary>
         public static List<CourseEnrollmentInfo> SortByExpression(List<CourseEnrollmentInfo> objCourseEnrollmentInfoCol, string sortExpression)
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
                 case "EnrollmentId":
                     objCourseEnrollmentInfoCol.Sort(CourseEnquiryAPI.BusinessObject.CourseEnrollmentInfo.ByEnrollmentId);
                     break;
                 case "CourseId":
                     objCourseEnrollmentInfoCol.Sort(CourseEnquiryAPI.BusinessObject.CourseEnrollmentInfo.ByCourseId);
                     break;
                 case "StudentId":
                     objCourseEnrollmentInfoCol.Sort(CourseEnquiryAPI.BusinessObject.CourseEnrollmentInfo.ByStudentId);
                     break;
                 case "Comments":
                     objCourseEnrollmentInfoCol.Sort(CourseEnquiryAPI.BusinessObject.CourseEnrollmentInfo.ByComments);
                     break;
                 default:
                     break;
             }

             if (isSortDescending)
                 objCourseEnrollmentInfoCol.Reverse();

             return objCourseEnrollmentInfoCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public int Insert()
         {
             CourseEnrollmentInfo objCourseEnrollmentInfo = (CourseEnrollmentInfo)this;
             return CourseEnrollmentInfoDataLayer.Insert(objCourseEnrollmentInfo);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public void Update()
         {
             CourseEnrollmentInfo objCourseEnrollmentInfo = (CourseEnrollmentInfo)this;
             CourseEnrollmentInfoDataLayer.Update(objCourseEnrollmentInfo);
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         public static void Delete(int enrollmentId)
         {
             CourseEnrollmentInfoDataLayer.Delete(enrollmentId);
         }

         private static string GetSortExpression(string sortByExpression)
         {
             if (String.IsNullOrEmpty(sortByExpression) || sortByExpression == " asc")
                 sortByExpression = "EnrollmentId";
             else if (sortByExpression.Contains(" asc"))
                 sortByExpression = sortByExpression.Replace(" asc", "");

             return sortByExpression;
         }

         /// <summary>
         /// Compares EnrollmentId used for sorting
         /// </summary>
         public static Comparison<CourseEnrollmentInfo> ByEnrollmentId = delegate(CourseEnrollmentInfo x, CourseEnrollmentInfo y)
         {
             return x.EnrollmentId.CompareTo(y.EnrollmentId);
         };

         /// <summary>
         /// Compares CourseId used for sorting
         /// </summary>
         public static Comparison<CourseEnrollmentInfo> ByCourseId = delegate(CourseEnrollmentInfo x, CourseEnrollmentInfo y)
         {
             return x.CourseId.CompareTo(y.CourseId);
         };

         /// <summary>
         /// Compares StudentId used for sorting
         /// </summary>
         public static Comparison<CourseEnrollmentInfo> ByStudentId = delegate(CourseEnrollmentInfo x, CourseEnrollmentInfo y)
         {
             return x.StudentId.CompareTo(y.StudentId);
         };

         /// <summary>
         /// Compares Comments used for sorting
         /// </summary>
         public static Comparison<CourseEnrollmentInfo> ByComments = delegate(CourseEnrollmentInfo x, CourseEnrollmentInfo y)
         {
             string value1 = x.Comments ?? String.Empty;
             string value2 = y.Comments ?? String.Empty;
             return value1.CompareTo(value2);
         };

     }
}
