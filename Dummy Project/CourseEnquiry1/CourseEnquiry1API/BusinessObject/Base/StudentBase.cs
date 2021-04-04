using System;
using CourseEnquiry1API.DataLayer;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CourseEnquiry1API.BusinessObject.Base
{
     /// <summary>
     /// Base class for Student.  Do not make changes to this class,
     /// instead, put additional code in the Student class
     /// </summary>
     public class StudentBase : CourseEnquiry1API.Models.StudentModel
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
         public static Student SelectByPrimaryKey(int studenId)
         {
             return StudentDataLayer.SelectByPrimaryKey(studenId);
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
         public static int GetRecordCountDynamicWhere(int? studenId, string studentName, string emailId, int? contactNumber, string password)
         {
             return StudentDataLayer.GetRecordCountDynamicWhere(studenId, studentName, emailId, contactNumber, password);
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
         public static List<Student> SelectSkipAndTakeDynamicWhere(int? studenId, string studentName, string emailId, int? contactNumber, string password, int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return StudentDataLayer.SelectSkipAndTakeDynamicWhere(studenId, studentName, emailId, contactNumber, password, sortByExpression, startRowIndex, rows);
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
         public static List<Student> SelectAllDynamicWhere(int? studenId, string studentName, string emailId, int? contactNumber, string password)
         {
             return StudentDataLayer.SelectAllDynamicWhere(studenId, studentName, emailId, contactNumber, password);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of Student sorted by the sort expression.
         /// </summary>
         public static List<Student> SelectAllDynamicWhere(int? studenId, string studentName, string emailId, int? contactNumber, string password, string sortByExpression)
         {
             List<Student> objStudentCol = StudentDataLayer.SelectAllDynamicWhere(studenId, studentName, emailId, contactNumber, password);
             return SortByExpression(objStudentCol, sortByExpression);
         }

         /// <summary>
         /// Selects StudenId and StudentName columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
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
                 case "StudenId":
                     objStudentCol.Sort(CourseEnquiry1API.BusinessObject.Student.ByStudenId);
                     break;
                 case "StudentName":
                     objStudentCol.Sort(CourseEnquiry1API.BusinessObject.Student.ByStudentName);
                     break;
                 case "EmailId":
                     objStudentCol.Sort(CourseEnquiry1API.BusinessObject.Student.ByEmailId);
                     break;
                 case "ContactNumber":
                     objStudentCol.Sort(CourseEnquiry1API.BusinessObject.Student.ByContactNumber);
                     break;
                 case "Password":
                     objStudentCol.Sort(CourseEnquiry1API.BusinessObject.Student.ByPassword);
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
         public static void Delete(int studenId)
         {
             StudentDataLayer.Delete(studenId);
         }

         private static string GetSortExpression(string sortByExpression)
         {
             if (String.IsNullOrEmpty(sortByExpression) || sortByExpression == " asc")
                 sortByExpression = "StudenId";
             else if (sortByExpression.Contains(" asc"))
                 sortByExpression = sortByExpression.Replace(" asc", "");

             return sortByExpression;
         }

         /// <summary>
         /// Compares StudenId used for sorting
         /// </summary>
         public static Comparison<Student> ByStudenId = delegate(Student x, Student y)
         {
             return x.StudenId.CompareTo(y.StudenId);
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
         /// Compares ContactNumber used for sorting
         /// </summary>
         public static Comparison<Student> ByContactNumber = delegate(Student x, Student y)
         {
             return x.ContactNumber.CompareTo(y.ContactNumber);
         };

         /// <summary>
         /// Compares Password used for sorting
         /// </summary>
         public static Comparison<Student> ByPassword = delegate(Student x, Student y)
         {
             string value1 = x.Password ?? String.Empty;
             string value2 = y.Password ?? String.Empty;
             return value1.CompareTo(value2);
         };

     }
}
