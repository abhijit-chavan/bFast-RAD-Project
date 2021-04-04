using System;
using CourseEnquiry1API.DataLayer;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CourseEnquiry1API.BusinessObject.Base
{
     /// <summary>
     /// Base class for CourseEnrollment.  Do not make changes to this class,
     /// instead, put additional code in the CourseEnrollment class
     /// </summary>
     public class CourseEnrollmentBase : CourseEnquiry1API.Models.CourseEnrollmentModel
     {

         /// <summary>
         /// Constructor
         /// </summary>
         public CourseEnrollmentBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static CourseEnrollment SelectByPrimaryKey(int enrollmentId)
         {
             return CourseEnrollmentDataLayer.SelectByPrimaryKey(enrollmentId);
         }

         /// <summary>
         /// Gets the total number of records in the CourseEnrollment table
         /// </summary>
         public static int GetRecordCount()
         {
             return CourseEnrollmentDataLayer.GetRecordCount();
         }

         /// <summary>
         /// Gets the total number of records in the CourseEnrollment table by CourseName
         /// </summary>
         public static int GetRecordCountByCourseName(int courseName)
         {
             return CourseEnrollmentDataLayer.GetRecordCountByCourseName(courseName);
         }

         /// <summary>
         /// Gets the total number of records in the CourseEnrollment table by StudentName
         /// </summary>
         public static int GetRecordCountByStudentName(int studentName)
         {
             return CourseEnrollmentDataLayer.GetRecordCountByStudentName(studentName);
         }

         /// <summary>
         /// Gets the total number of records in the CourseEnrollment table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? enrollmentId, int? courseName, int? studentName, string comments)
         {
             return CourseEnrollmentDataLayer.GetRecordCountDynamicWhere(enrollmentId, courseName, studentName, comments);
         }

         /// <summary>
         /// Selects records as a collection (List) of CourseEnrollment sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         public static List<CourseEnrollment> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression, bool isIncludeRelatedProperties = true)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return CourseEnrollmentDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows, isIncludeRelatedProperties);
         }

         /// <summary>
         /// Selects records by CourseName as a collection (List) of CourseEnrollment sorted by the sortByExpression starting from the startRowIndex
         /// </summary>
         public static List<CourseEnrollment> SelectSkipAndTakeByCourseName(int rows, int startRowIndex, string sortByExpression, int courseName)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return CourseEnrollmentDataLayer.SelectSkipAndTakeByCourseName(sortByExpression, startRowIndex, rows, courseName);
         }

         /// <summary>
         /// Selects records by StudentName as a collection (List) of CourseEnrollment sorted by the sortByExpression starting from the startRowIndex
         /// </summary>
         public static List<CourseEnrollment> SelectSkipAndTakeByStudentName(int rows, int startRowIndex, string sortByExpression, int studentName)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return CourseEnrollmentDataLayer.SelectSkipAndTakeByStudentName(sortByExpression, startRowIndex, rows, studentName);
         }

         /// <summary>
         /// Selects records as a collection (List) of CourseEnrollment sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<CourseEnrollment> SelectSkipAndTakeDynamicWhere(int? enrollmentId, int? courseName, int? studentName, string comments, int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return CourseEnrollmentDataLayer.SelectSkipAndTakeDynamicWhere(enrollmentId, courseName, studentName, comments, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects all records as a collection (List) of CourseEnrollment
         /// </summary>
         public static List<CourseEnrollment> SelectAll()
         {
             return CourseEnrollmentDataLayer.SelectAll();
         }

         /// <summary>
         /// Selects all records as a collection (List) of CourseEnrollment sorted by the sort expression
         /// </summary>
         public static List<CourseEnrollment> SelectAll(string sortByExpression)
         {
             List<CourseEnrollment> objCourseEnrollmentCol = CourseEnrollmentDataLayer.SelectAll();
             return SortByExpression(objCourseEnrollmentCol, sortByExpression);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of CourseEnrollment.
         /// </summary>
         public static List<CourseEnrollment> SelectAllDynamicWhere(int? enrollmentId, int? courseName, int? studentName, string comments)
         {
             return CourseEnrollmentDataLayer.SelectAllDynamicWhere(enrollmentId, courseName, studentName, comments);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of CourseEnrollment sorted by the sort expression.
         /// </summary>
         public static List<CourseEnrollment> SelectAllDynamicWhere(int? enrollmentId, int? courseName, int? studentName, string comments, string sortByExpression)
         {
             List<CourseEnrollment> objCourseEnrollmentCol = CourseEnrollmentDataLayer.SelectAllDynamicWhere(enrollmentId, courseName, studentName, comments);
             return SortByExpression(objCourseEnrollmentCol, sortByExpression);
         }

         /// <summary>
         /// Selects all CourseEnrollment by Course, related to column CourseName
         /// </summary>
         public static List<CourseEnrollment> SelectCourseEnrollmentCollectionByCourseName(int courseId)
         {
             return CourseEnrollmentDataLayer.SelectCourseEnrollmentCollectionByCourseName(courseId);
         }

         /// <summary>
         /// Selects all CourseEnrollment by Course, related to column CourseName, sorted by the sort expression
         /// </summary>
         public static List<CourseEnrollment> SelectCourseEnrollmentCollectionByCourseName(int courseId, string sortByExpression)
         {
             List<CourseEnrollment> objCourseEnrollmentCol = CourseEnrollmentDataLayer.SelectCourseEnrollmentCollectionByCourseName(courseId);
             return SortByExpression(objCourseEnrollmentCol, sortByExpression);
         }

         /// <summary>
         /// Selects all CourseEnrollment by Student, related to column StudentName
         /// </summary>
         public static List<CourseEnrollment> SelectCourseEnrollmentCollectionByStudentName(int studenId)
         {
             return CourseEnrollmentDataLayer.SelectCourseEnrollmentCollectionByStudentName(studenId);
         }

         /// <summary>
         /// Selects all CourseEnrollment by Student, related to column StudentName, sorted by the sort expression
         /// </summary>
         public static List<CourseEnrollment> SelectCourseEnrollmentCollectionByStudentName(int studenId, string sortByExpression)
         {
             List<CourseEnrollment> objCourseEnrollmentCol = CourseEnrollmentDataLayer.SelectCourseEnrollmentCollectionByStudentName(studenId);
             return SortByExpression(objCourseEnrollmentCol, sortByExpression);
         }

         /// <summary>
         /// Selects EnrollmentId and Comments columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
         /// </summary>
         public static List<CourseEnrollment> SelectCourseEnrollmentDropDownListData()
         {
             return CourseEnrollmentDataLayer.SelectCourseEnrollmentDropDownListData();
         }

         /// <summary>
         /// Sorts the List<CourseEnrollment >by sort expression
         /// </summary>
         public static List<CourseEnrollment> SortByExpression(List<CourseEnrollment> objCourseEnrollmentCol, string sortExpression)
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
                     objCourseEnrollmentCol.Sort(CourseEnquiry1API.BusinessObject.CourseEnrollment.ByEnrollmentId);
                     break;
                 case "CourseName":
                     objCourseEnrollmentCol.Sort(CourseEnquiry1API.BusinessObject.CourseEnrollment.ByCourseName);
                     break;
                 case "StudentName":
                     objCourseEnrollmentCol.Sort(CourseEnquiry1API.BusinessObject.CourseEnrollment.ByStudentName);
                     break;
                 case "Comments":
                     objCourseEnrollmentCol.Sort(CourseEnquiry1API.BusinessObject.CourseEnrollment.ByComments);
                     break;
                 default:
                     break;
             }

             if (isSortDescending)
                 objCourseEnrollmentCol.Reverse();

             return objCourseEnrollmentCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public int Insert()
         {
             CourseEnrollment objCourseEnrollment = (CourseEnrollment)this;
             return CourseEnrollmentDataLayer.Insert(objCourseEnrollment);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public void Update()
         {
             CourseEnrollment objCourseEnrollment = (CourseEnrollment)this;
             CourseEnrollmentDataLayer.Update(objCourseEnrollment);
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         public static void Delete(int enrollmentId)
         {
             CourseEnrollmentDataLayer.Delete(enrollmentId);
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
         public static Comparison<CourseEnrollment> ByEnrollmentId = delegate(CourseEnrollment x, CourseEnrollment y)
         {
             return x.EnrollmentId.CompareTo(y.EnrollmentId);
         };

         /// <summary>
         /// Compares CourseName used for sorting
         /// </summary>
         public static Comparison<CourseEnrollment> ByCourseName = delegate(CourseEnrollment x, CourseEnrollment y)
         {
             return x.CourseName.CompareTo(y.CourseName);
         };

         /// <summary>
         /// Compares StudentName used for sorting
         /// </summary>
         public static Comparison<CourseEnrollment> ByStudentName = delegate(CourseEnrollment x, CourseEnrollment y)
         {
             return x.StudentName.CompareTo(y.StudentName);
         };

         /// <summary>
         /// Compares Comments used for sorting
         /// </summary>
         public static Comparison<CourseEnrollment> ByComments = delegate(CourseEnrollment x, CourseEnrollment y)
         {
             string value1 = x.Comments ?? String.Empty;
             string value2 = y.Comments ?? String.Empty;
             return value1.CompareTo(value2);
         };

     }
}
