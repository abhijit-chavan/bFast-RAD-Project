using StudentEnquiryAPI.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace StudentEnquiryAPI.DataLayer.Base
{
     /// <summary>
     /// Base class for EnquiryDataLayer.  Do not make changes to this class,
     /// instead, put additional code in the EnquiryDataLayer class
     /// </summary>
     internal class EnquiryDataLayerBase
     {
         // constructor
         internal EnquiryDataLayerBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         internal static Enquiry SelectByPrimaryKey(int enquiryId)
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();
             return context.Enquiry.Where(e1 => e1.EnquiryId == enquiryId).FirstOrDefault();
         }

         /// <summary>
         /// Gets the total number of records in the Enquiry table
         /// </summary>
         internal static int GetRecordCount()
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();
             return context.Enquiry.Count();
         }

         /// <summary>
         /// Gets the total number of records in the Enquiry table by EnquiryId
         /// </summary>
         internal static int GetRecordCountByEnquiryId(int enquiryId)
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();
             return context.Enquiry.Where(e1 => e1.EnquiryId == enquiryId).Count();
         }

         /// <summary>
         /// Gets the total number of records in the Enquiry table by CourseId
         /// </summary>
         internal static int GetRecordCountByCourseId(int courseId)
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();
             return context.Enquiry.Where(e1 => e1.CourseId == courseId).Count();
         }

         /// <summary>
         /// Gets the total number of records in the Enquiry table based on search parameters
         /// </summary>
         internal static int GetRecordCountDynamicWhere(int? enquiryId, int? courseId, string studentName, Int64? contactNo, string comments)
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();

             int enquiryIdValue = int.MinValue;
             int courseIdValue = int.MinValue;
             Int64 contactNoValue = Int64.MinValue;

             if (enquiryId != null)
                enquiryIdValue = enquiryId.Value;

             if (courseId != null)
                courseIdValue = courseId.Value;

             if (contactNo != null)
                contactNoValue = contactNo.Value;

             return context.Enquiry
                 .Where(e1 =>
                           (enquiryId != null ? e1.EnquiryId == enquiryIdValue : 1 == 1) &&
                           (courseId != null ? e1.CourseId == courseIdValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(studentName) ? e1.StudentName.Contains(studentName) : 1 == 1) &&
                           (contactNo != null ? e1.ContactNo == contactNoValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(comments) ? e1.Comments.Contains(comments) : 1 == 1) 
                       ).Count();
         }

         /// <summary>
         /// Selects Enquiry records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
         /// </summary>
         internal static List<Enquiry> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows, bool isIncludeRelatedProperties = true)
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();

             if (!isIncludeRelatedProperties)
             {
                 if (sortByExpression.Contains(" desc"))
                 {
                     switch (sortByExpression)
                     {
                         case "CourseId desc":
                             return context.Enquiry.OrderByDescending(e1 => e1.CourseId).Skip(startRowIndex).Take(rows).ToList();
                         case "StudentName desc":
                             return context.Enquiry.OrderByDescending(e1 => e1.StudentName).Skip(startRowIndex).Take(rows).ToList();
                         case "ContactNo desc":
                             return context.Enquiry.OrderByDescending(e1 => e1.ContactNo).Skip(startRowIndex).Take(rows).ToList();
                         case "Comments desc":
                             return context.Enquiry.OrderByDescending(e1 => e1.Comments).Skip(startRowIndex).Take(rows).ToList();
                         default:
                             return context.Enquiry.OrderByDescending(e1 => e1.EnquiryId).Skip(startRowIndex).Take(rows).ToList();
                     }
                 }
                 else
                 {
                     switch (sortByExpression)
                     {
                         case "CourseId":
                             return context.Enquiry.OrderBy(e1 => e1.CourseId).Skip(startRowIndex).Take(rows).ToList();
                         case "StudentName":
                             return context.Enquiry.OrderBy(e1 => e1.StudentName).Skip(startRowIndex).Take(rows).ToList();
                         case "ContactNo":
                             return context.Enquiry.OrderBy(e1 => e1.ContactNo).Skip(startRowIndex).Take(rows).ToList();
                         case "Comments":
                             return context.Enquiry.OrderBy(e1 => e1.Comments).Skip(startRowIndex).Take(rows).ToList();
                         default:
                             return context.Enquiry.OrderBy(e1 => e1.EnquiryId).Skip(startRowIndex).Take(rows).ToList();
                     }
                 }
             }
             else
             {
                 if (sortByExpression.Contains(" desc"))
                 {
                     switch (sortByExpression)
                     {
                         case "CourseId desc":
                             return context.Enquiry.Include(e1 => e1.Enquiry1).Include(e1 => e1.CourseIdNavigation).OrderByDescending(e1 => e1.CourseId).Skip(startRowIndex).Take(rows).ToList();
                         case "StudentName desc":
                             return context.Enquiry.Include(e1 => e1.Enquiry1).Include(e1 => e1.CourseIdNavigation).OrderByDescending(e1 => e1.StudentName).Skip(startRowIndex).Take(rows).ToList();
                         case "ContactNo desc":
                             return context.Enquiry.Include(e1 => e1.Enquiry1).Include(e1 => e1.CourseIdNavigation).OrderByDescending(e1 => e1.ContactNo).Skip(startRowIndex).Take(rows).ToList();
                         case "Comments desc":
                             return context.Enquiry.Include(e1 => e1.Enquiry1).Include(e1 => e1.CourseIdNavigation).OrderByDescending(e1 => e1.Comments).Skip(startRowIndex).Take(rows).ToList();
                         default:
                             return context.Enquiry.Include(e1 => e1.Enquiry1).Include(e1 => e1.CourseIdNavigation).OrderByDescending(e1 => e1.EnquiryId).Skip(startRowIndex).Take(rows).ToList();
                     }
                 }
                 else
                 {
                     switch (sortByExpression)
                     {
                         case "CourseId":
                             return context.Enquiry.Include(e1 => e1.Enquiry1).Include(e1 => e1.CourseIdNavigation).OrderBy(e1 => e1.CourseId).Skip(startRowIndex).Take(rows).ToList();
                         case "StudentName":
                             return context.Enquiry.Include(e1 => e1.Enquiry1).Include(e1 => e1.CourseIdNavigation).OrderBy(e1 => e1.StudentName).Skip(startRowIndex).Take(rows).ToList();
                         case "ContactNo":
                             return context.Enquiry.Include(e1 => e1.Enquiry1).Include(e1 => e1.CourseIdNavigation).OrderBy(e1 => e1.ContactNo).Skip(startRowIndex).Take(rows).ToList();
                         case "Comments":
                             return context.Enquiry.Include(e1 => e1.Enquiry1).Include(e1 => e1.CourseIdNavigation).OrderBy(e1 => e1.Comments).Skip(startRowIndex).Take(rows).ToList();
                         default:
                             return context.Enquiry.Include(e1 => e1.Enquiry1).Include(e1 => e1.CourseIdNavigation).OrderBy(e1 => e1.EnquiryId).Skip(startRowIndex).Take(rows).ToList();
                     }
                 }
             }
         }

         /// <summary>
         /// Selects records by EnquiryId as a collection (List) of Enquiry sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         internal static List<Enquiry> SelectSkipAndTakeByEnquiryId(string sortByExpression, int startRowIndex, int rows, int enquiryId)
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();

             if (sortByExpression.Contains(" desc"))
             {
                 switch (sortByExpression)
                 {
                     case "CourseId desc":
                         return context.Enquiry.Where(e1 => e1.EnquiryId == enquiryId).OrderByDescending(e1 => e1.CourseId).Skip(startRowIndex).Take(rows).ToList();
                     case "StudentName desc":
                         return context.Enquiry.Where(e1 => e1.EnquiryId == enquiryId).OrderByDescending(e1 => e1.StudentName).Skip(startRowIndex).Take(rows).ToList();
                     case "ContactNo desc":
                         return context.Enquiry.Where(e1 => e1.EnquiryId == enquiryId).OrderByDescending(e1 => e1.ContactNo).Skip(startRowIndex).Take(rows).ToList();
                     case "Comments desc":
                         return context.Enquiry.Where(e1 => e1.EnquiryId == enquiryId).OrderByDescending(e1 => e1.Comments).Skip(startRowIndex).Take(rows).ToList();
                     default:
                         return context.Enquiry.Where(e1 => e1.EnquiryId == enquiryId).OrderByDescending(e1 => e1.EnquiryId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
             else
             {
                 switch (sortByExpression)
                 {
                     case "CourseId":
                         return context.Enquiry.Where(e1 => e1.EnquiryId == enquiryId).OrderBy(e1 => e1.CourseId).Skip(startRowIndex).Take(rows).ToList();
                     case "StudentName":
                         return context.Enquiry.Where(e1 => e1.EnquiryId == enquiryId).OrderBy(e1 => e1.StudentName).Skip(startRowIndex).Take(rows).ToList();
                     case "ContactNo":
                         return context.Enquiry.Where(e1 => e1.EnquiryId == enquiryId).OrderBy(e1 => e1.ContactNo).Skip(startRowIndex).Take(rows).ToList();
                     case "Comments":
                         return context.Enquiry.Where(e1 => e1.EnquiryId == enquiryId).OrderBy(e1 => e1.Comments).Skip(startRowIndex).Take(rows).ToList();
                     default:
                         return context.Enquiry.Where(e1 => e1.EnquiryId == enquiryId).OrderBy(e1 => e1.EnquiryId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
         }

         /// <summary>
         /// Selects records by CourseId as a collection (List) of Enquiry sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         internal static List<Enquiry> SelectSkipAndTakeByCourseId(string sortByExpression, int startRowIndex, int rows, int courseId)
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();

             if (sortByExpression.Contains(" desc"))
             {
                 switch (sortByExpression)
                 {
                     case "CourseId desc":
                         return context.Enquiry.Where(e1 => e1.CourseId == courseId).OrderByDescending(e1 => e1.CourseId).Skip(startRowIndex).Take(rows).ToList();
                     case "StudentName desc":
                         return context.Enquiry.Where(e1 => e1.CourseId == courseId).OrderByDescending(e1 => e1.StudentName).Skip(startRowIndex).Take(rows).ToList();
                     case "ContactNo desc":
                         return context.Enquiry.Where(e1 => e1.CourseId == courseId).OrderByDescending(e1 => e1.ContactNo).Skip(startRowIndex).Take(rows).ToList();
                     case "Comments desc":
                         return context.Enquiry.Where(e1 => e1.CourseId == courseId).OrderByDescending(e1 => e1.Comments).Skip(startRowIndex).Take(rows).ToList();
                     default:
                         return context.Enquiry.Where(e1 => e1.CourseId == courseId).OrderByDescending(e1 => e1.EnquiryId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
             else
             {
                 switch (sortByExpression)
                 {
                     case "CourseId":
                         return context.Enquiry.Where(e1 => e1.CourseId == courseId).OrderBy(e1 => e1.CourseId).Skip(startRowIndex).Take(rows).ToList();
                     case "StudentName":
                         return context.Enquiry.Where(e1 => e1.CourseId == courseId).OrderBy(e1 => e1.StudentName).Skip(startRowIndex).Take(rows).ToList();
                     case "ContactNo":
                         return context.Enquiry.Where(e1 => e1.CourseId == courseId).OrderBy(e1 => e1.ContactNo).Skip(startRowIndex).Take(rows).ToList();
                     case "Comments":
                         return context.Enquiry.Where(e1 => e1.CourseId == courseId).OrderBy(e1 => e1.Comments).Skip(startRowIndex).Take(rows).ToList();
                     default:
                         return context.Enquiry.Where(e1 => e1.CourseId == courseId).OrderBy(e1 => e1.EnquiryId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
         }

         /// <summary>
         /// Selects Enquiry records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
         /// </summary>
         internal static List<Enquiry> SelectSkipAndTakeDynamicWhere(int? enquiryId, int? courseId, string studentName, Int64? contactNo, string comments, string sortByExpression, int startRowIndex, int rows)
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();

             int enquiryIdValue = int.MinValue;
             int courseIdValue = int.MinValue;
             Int64 contactNoValue = Int64.MinValue;

             if (enquiryId != null)
                enquiryIdValue = enquiryId.Value;

             if (courseId != null)
                courseIdValue = courseId.Value;

             if (contactNo != null)
                contactNoValue = contactNo.Value;

             if (sortByExpression.Contains(" desc"))
             {
                 switch (sortByExpression)
                 {
                     case "CourseId desc":
                         return context.Enquiry
                             .Where(e1 =>
                                       (enquiryId != null ? e1.EnquiryId == enquiryIdValue : 1 == 1) &&
                                       (courseId != null ? e1.CourseId == courseIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentName) ? e1.StudentName.Contains(studentName) : 1 == 1) &&
                                       (contactNo != null ? e1.ContactNo == contactNoValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(comments) ? e1.Comments.Contains(comments) : 1 == 1) 
                                   ).OrderByDescending(e1 => e1.CourseId).Skip(startRowIndex).Take(rows).ToList();

                     case "StudentName desc":
                         return context.Enquiry
                             .Where(e1 =>
                                       (enquiryId != null ? e1.EnquiryId == enquiryIdValue : 1 == 1) &&
                                       (courseId != null ? e1.CourseId == courseIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentName) ? e1.StudentName.Contains(studentName) : 1 == 1) &&
                                       (contactNo != null ? e1.ContactNo == contactNoValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(comments) ? e1.Comments.Contains(comments) : 1 == 1) 
                                   ).OrderByDescending(e1 => e1.StudentName).Skip(startRowIndex).Take(rows).ToList();

                     case "ContactNo desc":
                         return context.Enquiry
                             .Where(e1 =>
                                       (enquiryId != null ? e1.EnquiryId == enquiryIdValue : 1 == 1) &&
                                       (courseId != null ? e1.CourseId == courseIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentName) ? e1.StudentName.Contains(studentName) : 1 == 1) &&
                                       (contactNo != null ? e1.ContactNo == contactNoValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(comments) ? e1.Comments.Contains(comments) : 1 == 1) 
                                   ).OrderByDescending(e1 => e1.ContactNo).Skip(startRowIndex).Take(rows).ToList();

                     case "Comments desc":
                         return context.Enquiry
                             .Where(e1 =>
                                       (enquiryId != null ? e1.EnquiryId == enquiryIdValue : 1 == 1) &&
                                       (courseId != null ? e1.CourseId == courseIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentName) ? e1.StudentName.Contains(studentName) : 1 == 1) &&
                                       (contactNo != null ? e1.ContactNo == contactNoValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(comments) ? e1.Comments.Contains(comments) : 1 == 1) 
                                   ).OrderByDescending(e1 => e1.Comments).Skip(startRowIndex).Take(rows).ToList();

                     default:
                         return context.Enquiry
                             .Where(e1 =>
                                       (enquiryId != null ? e1.EnquiryId == enquiryIdValue : 1 == 1) &&
                                       (courseId != null ? e1.CourseId == courseIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentName) ? e1.StudentName.Contains(studentName) : 1 == 1) &&
                                       (contactNo != null ? e1.ContactNo == contactNoValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(comments) ? e1.Comments.Contains(comments) : 1 == 1) 
                                   ).OrderByDescending(e1 => e1.EnquiryId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
             else
             {
                 switch (sortByExpression)
                 {
                     case "CourseId":
                         return context.Enquiry
                             .Where(e1 =>
                                       (enquiryId != null ? e1.EnquiryId == enquiryIdValue : 1 == 1) &&
                                       (courseId != null ? e1.CourseId == courseIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentName) ? e1.StudentName.Contains(studentName) : 1 == 1) &&
                                       (contactNo != null ? e1.ContactNo == contactNoValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(comments) ? e1.Comments.Contains(comments) : 1 == 1) 
                                   ).OrderBy(e1 => e1.CourseId).Skip(startRowIndex).Take(rows).ToList();

                     case "StudentName":
                         return context.Enquiry
                             .Where(e1 =>
                                       (enquiryId != null ? e1.EnquiryId == enquiryIdValue : 1 == 1) &&
                                       (courseId != null ? e1.CourseId == courseIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentName) ? e1.StudentName.Contains(studentName) : 1 == 1) &&
                                       (contactNo != null ? e1.ContactNo == contactNoValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(comments) ? e1.Comments.Contains(comments) : 1 == 1) 
                                   ).OrderBy(e1 => e1.StudentName).Skip(startRowIndex).Take(rows).ToList();

                     case "ContactNo":
                         return context.Enquiry
                             .Where(e1 =>
                                       (enquiryId != null ? e1.EnquiryId == enquiryIdValue : 1 == 1) &&
                                       (courseId != null ? e1.CourseId == courseIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentName) ? e1.StudentName.Contains(studentName) : 1 == 1) &&
                                       (contactNo != null ? e1.ContactNo == contactNoValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(comments) ? e1.Comments.Contains(comments) : 1 == 1) 
                                   ).OrderBy(e1 => e1.ContactNo).Skip(startRowIndex).Take(rows).ToList();

                     case "Comments":
                         return context.Enquiry
                             .Where(e1 =>
                                       (enquiryId != null ? e1.EnquiryId == enquiryIdValue : 1 == 1) &&
                                       (courseId != null ? e1.CourseId == courseIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentName) ? e1.StudentName.Contains(studentName) : 1 == 1) &&
                                       (contactNo != null ? e1.ContactNo == contactNoValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(comments) ? e1.Comments.Contains(comments) : 1 == 1) 
                                   ).OrderBy(e1 => e1.Comments).Skip(startRowIndex).Take(rows).ToList();

                     default:
                         return context.Enquiry
                             .Where(e1 =>
                                       (enquiryId != null ? e1.EnquiryId == enquiryIdValue : 1 == 1) &&
                                       (courseId != null ? e1.CourseId == courseIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentName) ? e1.StudentName.Contains(studentName) : 1 == 1) &&
                                       (contactNo != null ? e1.ContactNo == contactNoValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(comments) ? e1.Comments.Contains(comments) : 1 == 1) 
                                   ).OrderBy(e1 => e1.EnquiryId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
         }

         /// <summary>
         /// Selects all Enquiry
         /// </summary>
         internal static List<Enquiry> SelectAll()
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();
             return context.Enquiry.ToList();
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of Enquiry.
         /// </summary>
         internal static List<Enquiry> SelectAllDynamicWhere(int? enquiryId, int? courseId, string studentName, Int64? contactNo, string comments)
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();

             int enquiryIdValue = int.MinValue;
             int courseIdValue = int.MinValue;
             Int64 contactNoValue = Int64.MinValue;

             if (enquiryId != null)
                enquiryIdValue = enquiryId.Value;

             if (courseId != null)
                courseIdValue = courseId.Value;

             if (contactNo != null)
                contactNoValue = contactNo.Value;

             return context.Enquiry
                 .Where(e1 =>
                           (enquiryId != null ? e1.EnquiryId == enquiryIdValue : 1 == 1) &&
                           (courseId != null ? e1.CourseId == courseIdValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(studentName) ? e1.StudentName.Contains(studentName) : 1 == 1) &&
                           (contactNo != null ? e1.ContactNo == contactNoValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(comments) ? e1.Comments.Contains(comments) : 1 == 1) 
                       ).ToList();
         }

         /// <summary>
         /// Selects all Enquiry by Enquiry, related to column EnquiryId
         /// </summary>
         internal static List<Enquiry> SelectEnquiryCollectionByEnquiryId(int enquiryId)
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();
             return context.Enquiry.Where(e1 => e1.EnquiryId == enquiryId).ToList();
         }

         /// <summary>
         /// Selects all Enquiry by Couse, related to column CourseId
         /// </summary>
         internal static List<Enquiry> SelectEnquiryCollectionByCourseId(int couseid)
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();
             return context.Enquiry.Where(e1 => e1.CourseId == couseid).ToList();
         }
         /// <summary>
         /// Selects EnquiryId and StudentName columns for use with a DropDownList web control
         /// </summary>
         internal static List<Enquiry> SelectEnquiryDropDownListData()
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();
             return (from e1 in context.Enquiry
                     select new Enquiry { EnquiryId = e1.EnquiryId, StudentName = e1.StudentName }).ToList();
         }
         /// <summary>
         /// Inserts a record
         /// </summary>
         internal static int Insert(Enquiry objEnquiry)
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();
             Enquiry entEnquiry = new Enquiry();

             entEnquiry.CourseId = objEnquiry.CourseId;
             entEnquiry.StudentName = objEnquiry.StudentName;
             entEnquiry.ContactNo = objEnquiry.ContactNo;
             entEnquiry.Comments = objEnquiry.Comments;

             context.Enquiry.Add(entEnquiry);
             context.SaveChanges();

             return entEnquiry.EnquiryId;
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         internal static void Update(Enquiry objEnquiry)
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();
             Enquiry entEnquiry = context.Enquiry.Where(e1 => e1.EnquiryId == objEnquiry.EnquiryId).FirstOrDefault();

             if (entEnquiry != null)
             {
                 entEnquiry.CourseId = objEnquiry.CourseId;
                 entEnquiry.StudentName = objEnquiry.StudentName;
                 entEnquiry.ContactNo = objEnquiry.ContactNo;
                 entEnquiry.Comments = objEnquiry.Comments;

                 context.SaveChanges();
             }
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         internal static void Delete(int enquiryId)
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();
             var objEnquiry = context.Enquiry.Where(e1 => e1.EnquiryId == enquiryId).FirstOrDefault();

             if (objEnquiry != null)
             {
                 context.Enquiry.Remove(objEnquiry);
                 context.SaveChanges();
             }
         }
     }
}
