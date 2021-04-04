using System;
using StudentEnquiryAPI.DataLayer;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentEnquiryAPI.BusinessObject.Base
{
     /// <summary>
     /// Base class for Enquiry.  Do not make changes to this class,
     /// instead, put additional code in the Enquiry class
     /// </summary>
     public class EnquiryBase : StudentEnquiryAPI.Models.EnquiryModel
     {

         /// <summary>
         /// Constructor
         /// </summary>
         public EnquiryBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static Enquiry SelectByPrimaryKey(int enquiryId)
         {
             return EnquiryDataLayer.SelectByPrimaryKey(enquiryId);
         }

         /// <summary>
         /// Gets the total number of records in the Enquiry table
         /// </summary>
         public static int GetRecordCount()
         {
             return EnquiryDataLayer.GetRecordCount();
         }

         /// <summary>
         /// Gets the total number of records in the Enquiry table by EnquiryId
         /// </summary>
         public static int GetRecordCountByEnquiryId(int enquiryId)
         {
             return EnquiryDataLayer.GetRecordCountByEnquiryId(enquiryId);
         }

         /// <summary>
         /// Gets the total number of records in the Enquiry table by CourseId
         /// </summary>
         public static int GetRecordCountByCourseId(int courseId)
         {
             return EnquiryDataLayer.GetRecordCountByCourseId(courseId);
         }

         /// <summary>
         /// Gets the total number of records in the Enquiry table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? enquiryId, int? courseId, string studentName, Int64? contactNo, string comments)
         {
             return EnquiryDataLayer.GetRecordCountDynamicWhere(enquiryId, courseId, studentName, contactNo, comments);
         }

         /// <summary>
         /// Selects records as a collection (List) of Enquiry sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         public static List<Enquiry> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression, bool isIncludeRelatedProperties = true)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return EnquiryDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows, isIncludeRelatedProperties);
         }

         /// <summary>
         /// Selects records by EnquiryId as a collection (List) of Enquiry sorted by the sortByExpression starting from the startRowIndex
         /// </summary>
         public static List<Enquiry> SelectSkipAndTakeByEnquiryId(int rows, int startRowIndex, string sortByExpression, int enquiryId)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return EnquiryDataLayer.SelectSkipAndTakeByEnquiryId(sortByExpression, startRowIndex, rows, enquiryId);
         }

         /// <summary>
         /// Selects records by CourseId as a collection (List) of Enquiry sorted by the sortByExpression starting from the startRowIndex
         /// </summary>
         public static List<Enquiry> SelectSkipAndTakeByCourseId(int rows, int startRowIndex, string sortByExpression, int courseId)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return EnquiryDataLayer.SelectSkipAndTakeByCourseId(sortByExpression, startRowIndex, rows, courseId);
         }

         /// <summary>
         /// Selects records as a collection (List) of Enquiry sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<Enquiry> SelectSkipAndTakeDynamicWhere(int? enquiryId, int? courseId, string studentName, Int64? contactNo, string comments, int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return EnquiryDataLayer.SelectSkipAndTakeDynamicWhere(enquiryId, courseId, studentName, contactNo, comments, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects all records as a collection (List) of Enquiry
         /// </summary>
         public static List<Enquiry> SelectAll()
         {
             return EnquiryDataLayer.SelectAll();
         }

         /// <summary>
         /// Selects all records as a collection (List) of Enquiry sorted by the sort expression
         /// </summary>
         public static List<Enquiry> SelectAll(string sortByExpression)
         {
             List<Enquiry> objEnquiryCol = EnquiryDataLayer.SelectAll();
             return SortByExpression(objEnquiryCol, sortByExpression);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of Enquiry.
         /// </summary>
         public static List<Enquiry> SelectAllDynamicWhere(int? enquiryId, int? courseId, string studentName, Int64? contactNo, string comments)
         {
             return EnquiryDataLayer.SelectAllDynamicWhere(enquiryId, courseId, studentName, contactNo, comments);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of Enquiry sorted by the sort expression.
         /// </summary>
         public static List<Enquiry> SelectAllDynamicWhere(int? enquiryId, int? courseId, string studentName, Int64? contactNo, string comments, string sortByExpression)
         {
             List<Enquiry> objEnquiryCol = EnquiryDataLayer.SelectAllDynamicWhere(enquiryId, courseId, studentName, contactNo, comments);
             return SortByExpression(objEnquiryCol, sortByExpression);
         }

         /// <summary>
         /// Selects all Enquiry by Enquiry, related to column EnquiryId
         /// </summary>
         public static List<Enquiry> SelectEnquiryCollectionByEnquiryId(int enquiryId)
         {
             return EnquiryDataLayer.SelectEnquiryCollectionByEnquiryId(enquiryId);
         }

         /// <summary>
         /// Selects all Enquiry by Enquiry, related to column EnquiryId, sorted by the sort expression
         /// </summary>
         public static List<Enquiry> SelectEnquiryCollectionByEnquiryId(int enquiryId, string sortByExpression)
         {
             List<Enquiry> objEnquiryCol = EnquiryDataLayer.SelectEnquiryCollectionByEnquiryId(enquiryId);
             return SortByExpression(objEnquiryCol, sortByExpression);
         }

         /// <summary>
         /// Selects all Enquiry by Couse, related to column CourseId
         /// </summary>
         public static List<Enquiry> SelectEnquiryCollectionByCourseId(int couseid)
         {
             return EnquiryDataLayer.SelectEnquiryCollectionByCourseId(couseid);
         }

         /// <summary>
         /// Selects all Enquiry by Couse, related to column CourseId, sorted by the sort expression
         /// </summary>
         public static List<Enquiry> SelectEnquiryCollectionByCourseId(int couseid, string sortByExpression)
         {
             List<Enquiry> objEnquiryCol = EnquiryDataLayer.SelectEnquiryCollectionByCourseId(couseid);
             return SortByExpression(objEnquiryCol, sortByExpression);
         }

         /// <summary>
         /// Selects EnquiryId and StudentName columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
         /// </summary>
         public static List<Enquiry> SelectEnquiryDropDownListData()
         {
             return EnquiryDataLayer.SelectEnquiryDropDownListData();
         }

         /// <summary>
         /// Sorts the List<Enquiry >by sort expression
         /// </summary>
         public static List<Enquiry> SortByExpression(List<Enquiry> objEnquiryCol, string sortExpression)
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
                 case "EnquiryId":
                     objEnquiryCol.Sort(StudentEnquiryAPI.BusinessObject.Enquiry.ByEnquiryId);
                     break;
                 case "CourseId":
                     objEnquiryCol.Sort(StudentEnquiryAPI.BusinessObject.Enquiry.ByCourseId);
                     break;
                 case "StudentName":
                     objEnquiryCol.Sort(StudentEnquiryAPI.BusinessObject.Enquiry.ByStudentName);
                     break;
                 case "ContactNo":
                     objEnquiryCol.Sort(StudentEnquiryAPI.BusinessObject.Enquiry.ByContactNo);
                     break;
                 case "Comments":
                     objEnquiryCol.Sort(StudentEnquiryAPI.BusinessObject.Enquiry.ByComments);
                     break;
                 default:
                     break;
             }

             if (isSortDescending)
                 objEnquiryCol.Reverse();

             return objEnquiryCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public int Insert()
         {
             Enquiry objEnquiry = (Enquiry)this;
             return EnquiryDataLayer.Insert(objEnquiry);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public void Update()
         {
             Enquiry objEnquiry = (Enquiry)this;
             EnquiryDataLayer.Update(objEnquiry);
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         public static void Delete(int enquiryId)
         {
             EnquiryDataLayer.Delete(enquiryId);
         }

         private static string GetSortExpression(string sortByExpression)
         {
             if (String.IsNullOrEmpty(sortByExpression) || sortByExpression == " asc")
                 sortByExpression = "EnquiryId";
             else if (sortByExpression.Contains(" asc"))
                 sortByExpression = sortByExpression.Replace(" asc", "");

             return sortByExpression;
         }

         /// <summary>
         /// Compares EnquiryId used for sorting
         /// </summary>
         public static Comparison<Enquiry> ByEnquiryId = delegate(Enquiry x, Enquiry y)
         {
             return x.EnquiryId.CompareTo(y.EnquiryId);
         };

         /// <summary>
         /// Compares CourseId used for sorting
         /// </summary>
         public static Comparison<Enquiry> ByCourseId = delegate(Enquiry x, Enquiry y)
         {
             return x.CourseId.CompareTo(y.CourseId);
         };

         /// <summary>
         /// Compares StudentName used for sorting
         /// </summary>
         public static Comparison<Enquiry> ByStudentName = delegate(Enquiry x, Enquiry y)
         {
             string value1 = x.StudentName ?? String.Empty;
             string value2 = y.StudentName ?? String.Empty;
             return value1.CompareTo(value2);
         };

         /// <summary>
         /// Compares ContactNo used for sorting
         /// </summary>
         public static Comparison<Enquiry> ByContactNo = delegate(Enquiry x, Enquiry y)
         {
             return x.ContactNo.CompareTo(y.ContactNo);
         };

         /// <summary>
         /// Compares Comments used for sorting
         /// </summary>
         public static Comparison<Enquiry> ByComments = delegate(Enquiry x, Enquiry y)
         {
             string value1 = x.Comments ?? String.Empty;
             string value2 = y.Comments ?? String.Empty;
             return value1.CompareTo(value2);
         };

     }
}
