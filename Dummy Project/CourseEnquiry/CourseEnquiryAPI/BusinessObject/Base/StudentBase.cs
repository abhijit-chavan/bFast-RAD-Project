using System;
using CourseEnquiryAPI.DataLayer;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CourseEnquiryAPI.BusinessObject.Base
{
     /// <summary>
     /// Base class for Student.  Do not make changes to this class,
     /// instead, put additional code in the Student class
     /// </summary>
     public class StudentBase : CourseEnquiryAPI.Models.StudentModel
     {

         /// <summary>
         /// Constructor
         /// </summary>
         public StudentBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static Student SelectByPrimaryKey(int studentId)
         {
             return StudentDataLayer.SelectByPrimaryKey(studentId);
         }

         /// <summary>
         /// Gets the total number of records in the Student table
         /// </summary>
         public static int GetRecordCount()
         {
             return StudentDataLayer.GetRecordCount();
         }

         /// <summary>
         /// Gets the total number of records in the Student table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? studentId, string studentName, string emailId, Int64? contactNo, string studentPassword)
         {
             return StudentDataLayer.GetRecordCountDynamicWhere(studentId, studentName, emailId, contactNo, studentPassword);
         }

         /// <summary>
         /// Selects records as a collection (List) of Student sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         public static List<Student> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return StudentDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of Student sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<Student> SelectSkipAndTakeDynamicWhere(int? studentId, string studentName, string emailId, Int64? contactNo, string studentPassword, int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return StudentDataLayer.SelectSkipAndTakeDynamicWhere(studentId, studentName, emailId, contactNo, studentPassword, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects all records as a collection (List) of Student
         /// </summary>
         public static List<Student> SelectAll()
         {
             return StudentDataLayer.SelectAll();
         }

         /// <summary>
         /// Selects all records as a collection (List) of Student sorted by the sort expression
         /// </summary>
         public static List<Student> SelectAll(string sortByExpression)
         {
             List<Student> objStudentCol = StudentDataLayer.SelectAll();
             return SortByExpression(objStudentCol, sortByExpression);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of Student.
         /// </summary>
         public static List<Student> SelectAllDynamicWhere(int? studentId, string studentName, string emailId, Int64? contactNo, string studentPassword)
         {
             return StudentDataLayer.SelectAllDynamicWhere(studentId, studentName, emailId, contactNo, studentPassword);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of Student sorted by the sort expression.
         /// </summary>
         public static List<Student> SelectAllDynamicWhere(int? studentId, string studentName, string emailId, Int64? contactNo, string studentPassword, string sortByExpression)
         {
             List<Student> objStudentCol = StudentDataLayer.SelectAllDynamicWhere(studentId, studentName, emailId, contactNo, studentPassword);
             return SortByExpression(objStudentCol, sortByExpression);
         }

         /// <summary>
         /// Selects StudentId and StudentName columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
         /// </summary>
         public static List<Student> SelectStudentDropDownListData()
         {
             return StudentDataLayer.SelectStudentDropDownListData();
         }

         /// <summary>
         /// Sorts the List<Student >by sort expression
         /// </summary>
         public static List<Student> SortByExpression(List<Student> objStudentCol, string sortExpression)
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
                 case "StudentId":
                     objStudentCol.Sort(CourseEnquiryAPI.BusinessObject.Student.ByStudentId);
                     break;
                 case "StudentName":
                     objStudentCol.Sort(CourseEnquiryAPI.BusinessObject.Student.ByStudentName);
                     break;
                 case "EmailId":
                     objStudentCol.Sort(CourseEnquiryAPI.BusinessObject.Student.ByEmailId);
                     break;
                 case "ContactNo":
                     objStudentCol.Sort(CourseEnquiryAPI.BusinessObject.Student.ByContactNo);
                     break;
                 case "StudentPassword":
                     objStudentCol.Sort(CourseEnquiryAPI.BusinessObject.Student.ByStudentPassword);
                     break;
                 default:
                     break;
             }

             if (isSortDescending)
                 objStudentCol.Reverse();

             return objStudentCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public int Insert()
         {
             Student objStudent = (Student)this;
             return StudentDataLayer.Insert(objStudent);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public void Update()
         {
             Student objStudent = (Student)this;
             StudentDataLayer.Update(objStudent);
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         public static void Delete(int studentId)
         {
             StudentDataLayer.Delete(studentId);
         }

         private static string GetSortExpression(string sortByExpression)
         {
             if (String.IsNullOrEmpty(sortByExpression) || sortByExpression == " asc")
                 sortByExpression = "StudentId";
             else if (sortByExpression.Contains(" asc"))
                 sortByExpression = sortByExpression.Replace(" asc", "");

             return sortByExpression;
         }

         /// <summary>
         /// Compares StudentId used for sorting
         /// </summary>
         public static Comparison<Student> ByStudentId = delegate(Student x, Student y)
         {
             return x.StudentId.CompareTo(y.StudentId);
         };

         /// <summary>
         /// Compares StudentName used for sorting
         /// </summary>
         public static Comparison<Student> ByStudentName = delegate(Student x, Student y)
         {
             string value1 = x.StudentName ?? String.Empty;
             string value2 = y.StudentName ?? String.Empty;
             return value1.CompareTo(value2);
         };

         /// <summary>
         /// Compares EmailId used for sorting
         /// </summary>
         public static Comparison<Student> ByEmailId = delegate(Student x, Student y)
         {
             string value1 = x.EmailId ?? String.Empty;
             string value2 = y.EmailId ?? String.Empty;
             return value1.CompareTo(value2);
         };

         /// <summary>
         /// Compares ContactNo used for sorting
         /// </summary>
         public static Comparison<Student> ByContactNo = delegate(Student x, Student y)
         {
             return x.ContactNo.CompareTo(y.ContactNo);
         };

         /// <summary>
         /// Compares StudentPassword used for sorting
         /// </summary>
         public static Comparison<Student> ByStudentPassword = delegate(Student x, Student y)
         {
             string value1 = x.StudentPassword ?? String.Empty;
             string value2 = y.StudentPassword ?? String.Empty;
             return value1.CompareTo(value2);
         };

     }
}
