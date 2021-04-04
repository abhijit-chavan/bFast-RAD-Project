using CourseEnquiry1API.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CourseEnquiry1API.DataLayer.Base
{
     /// <summary>
     /// Base class for CourseEnrollmentDataLayer.  Do not make changes to this class,
     /// instead, put additional code in the CourseEnrollmentDataLayer class
     /// </summary>
     internal class CourseEnrollmentDataLayerBase
     {
         // constructor
         internal CourseEnrollmentDataLayerBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         internal static CourseEnrollment SelectByPrimaryKey(int enrollmentId)
         {
             CourseEnquiryContext context = new CourseEnquiryContext();
             return context.CourseEnrollment.Where(c => c.EnrollmentId == enrollmentId).FirstOrDefault();
         }

         /// <summary>
         /// Gets the total number of records in the CourseEnrollment table
         /// </summary>
         internal static int GetRecordCount()
         {
             CourseEnquiryContext context = new CourseEnquiryContext();
             return context.CourseEnrollment.Count();
         }

         /// <summary>
         /// Gets the total number of records in the CourseEnrollment table by CourseName
         /// </summary>
         internal static int GetRecordCountByCourseName(int courseName)
         {
             CourseEnquiryContext context = new CourseEnquiryContext();
             return context.CourseEnrollment.Where(c => c.CourseName == courseName).Count();
         }

         /// <summary>
         /// Gets the total number of records in the CourseEnrollment table by StudentName
         /// </summary>
         internal static int GetRecordCountByStudentName(int studentName)
         {
             CourseEnquiryContext context = new CourseEnquiryContext();
             return context.CourseEnrollment.Where(c => c.StudentName == studentName).Count();
         }

         /// <summary>
         /// Gets the total number of records in the CourseEnrollment table based on search parameters
         /// </summary>
         internal static int GetRecordCountDynamicWhere(int? enrollmentId, int? courseName, int? studentName, string comments)
         {
             CourseEnquiryContext context = new CourseEnquiryContext();

             int enrollmentIdValue = int.MinValue;
             int courseNameValue = int.MinValue;
             int studentNameValue = int.MinValue;

             if (enrollmentId != null)
                enrollmentIdValue = enrollmentId.Value;

             if (courseName != null)
                courseNameValue = courseName.Value;

             if (studentName != null)
                studentNameValue = studentName.Value;

             return context.CourseEnrollment
                 .Where(c =>
                           (enrollmentId != null ? c.EnrollmentId == enrollmentIdValue : 1 == 1) &&
                           (courseName != null ? c.CourseName == courseNameValue : 1 == 1) &&
                           (studentName != null ? c.StudentName == studentNameValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(comments) ? c.Comments.Contains(comments) : 1 == 1) 
                       ).Count();
         }

         /// <summary>
         /// Selects CourseEnrollment records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
         /// </summary>
         internal static List<CourseEnrollment> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows, bool isIncludeRelatedProperties = true)
         {
             CourseEnquiryContext context = new CourseEnquiryContext();

             if (!isIncludeRelatedProperties)
             {
                 if (sortByExpression.Contains(" desc"))
                 {
                     switch (sortByExpression)
                     {
                         case "CourseName desc":
                             return context.CourseEnrollment.OrderByDescending(c => c.CourseName).Skip(startRowIndex).Take(rows).ToList();
                         case "StudentName desc":
                             return context.CourseEnrollment.OrderByDescending(c => c.StudentName).Skip(startRowIndex).Take(rows).ToList();
                         case "Comments desc":
                             return context.CourseEnrollment.OrderByDescending(c => c.Comments).Skip(startRowIndex).Take(rows).ToList();
                         default:
                             return context.CourseEnrollment.OrderByDescending(c => c.EnrollmentId).Skip(startRowIndex).Take(rows).ToList();
                     }
                 }
                 else
                 {
                     switch (sortByExpression)
                     {
                         case "CourseName":
                             return context.CourseEnrollment.OrderBy(c => c.CourseName).Skip(startRowIndex).Take(rows).ToList();
                         case "StudentName":
                             return context.CourseEnrollment.OrderBy(c => c.StudentName).Skip(startRowIndex).Take(rows).ToList();
                         case "Comments":
                             return context.CourseEnrollment.OrderBy(c => c.Comments).Skip(startRowIndex).Take(rows).ToList();
                         default:
                             return context.CourseEnrollment.OrderBy(c => c.EnrollmentId).Skip(startRowIndex).Take(rows).ToList();
                     }
                 }
             }
             else
             {
                 if (sortByExpression.Contains(" desc"))
                 {
                     switch (sortByExpression)
                     {
                         case "CourseName desc":
                             return context.CourseEnrollment.Include(c => c.CourseNameNavigation).Include(c => c.StudentNameNavigation).OrderByDescending(c => c.CourseName).Skip(startRowIndex).Take(rows).ToList();
                         case "StudentName desc":
                             return context.CourseEnrollment.Include(c => c.CourseNameNavigation).Include(c => c.StudentNameNavigation).OrderByDescending(c => c.StudentName).Skip(startRowIndex).Take(rows).ToList();
                         case "Comments desc":
                             return context.CourseEnrollment.Include(c => c.CourseNameNavigation).Include(c => c.StudentNameNavigation).OrderByDescending(c => c.Comments).Skip(startRowIndex).Take(rows).ToList();
                         default:
                             return context.CourseEnrollment.Include(c => c.CourseNameNavigation).Include(c => c.StudentNameNavigation).OrderByDescending(c => c.EnrollmentId).Skip(startRowIndex).Take(rows).ToList();
                     }
                 }
                 else
                 {
                     switch (sortByExpression)
                     {
                         case "CourseName":
                             return context.CourseEnrollment.Include(c => c.CourseNameNavigation).Include(c => c.StudentNameNavigation).OrderBy(c => c.CourseName).Skip(startRowIndex).Take(rows).ToList();
                         case "StudentName":
                             return context.CourseEnrollment.Include(c => c.CourseNameNavigation).Include(c => c.StudentNameNavigation).OrderBy(c => c.StudentName).Skip(startRowIndex).Take(rows).ToList();
                         case "Comments":
                             return context.CourseEnrollment.Include(c => c.CourseNameNavigation).Include(c => c.StudentNameNavigation).OrderBy(c => c.Comments).Skip(startRowIndex).Take(rows).ToList();
                         default:
                             return context.CourseEnrollment.Include(c => c.CourseNameNavigation).Include(c => c.StudentNameNavigation).OrderBy(c => c.EnrollmentId).Skip(startRowIndex).Take(rows).ToList();
                     }
                 }
             }
         }

         /// <summary>
         /// Selects records by CourseName as a collection (List) of CourseEnrollment sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         internal static List<CourseEnrollment> SelectSkipAndTakeByCourseName(string sortByExpression, int startRowIndex, int rows, int courseName)
         {
             CourseEnquiryContext context = new CourseEnquiryContext();

             if (sortByExpression.Contains(" desc"))
             {
                 switch (sortByExpression)
                 {
                     case "CourseName desc":
                         return context.CourseEnrollment.Where(c => c.CourseName == courseName).OrderByDescending(c => c.CourseName).Skip(startRowIndex).Take(rows).ToList();
                     case "StudentName desc":
                         return context.CourseEnrollment.Where(c => c.CourseName == courseName).OrderByDescending(c => c.StudentName).Skip(startRowIndex).Take(rows).ToList();
                     case "Comments desc":
                         return context.CourseEnrollment.Where(c => c.CourseName == courseName).OrderByDescending(c => c.Comments).Skip(startRowIndex).Take(rows).ToList();
                     default:
                         return context.CourseEnrollment.Where(c => c.CourseName == courseName).OrderByDescending(c => c.EnrollmentId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
             else
             {
                 switch (sortByExpression)
                 {
                     case "CourseName":
                         return context.CourseEnrollment.Where(c => c.CourseName == courseName).OrderBy(c => c.CourseName).Skip(startRowIndex).Take(rows).ToList();
                     case "StudentName":
                         return context.CourseEnrollment.Where(c => c.CourseName == courseName).OrderBy(c => c.StudentName).Skip(startRowIndex).Take(rows).ToList();
                     case "Comments":
                         return context.CourseEnrollment.Where(c => c.CourseName == courseName).OrderBy(c => c.Comments).Skip(startRowIndex).Take(rows).ToList();
                     default:
                         return context.CourseEnrollment.Where(c => c.CourseName == courseName).OrderBy(c => c.EnrollmentId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
         }

         /// <summary>
         /// Selects records by StudentName as a collection (List) of CourseEnrollment sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         internal static List<CourseEnrollment> SelectSkipAndTakeByStudentName(string sortByExpression, int startRowIndex, int rows, int studentName)
         {
             CourseEnquiryContext context = new CourseEnquiryContext();

             if (sortByExpression.Contains(" desc"))
             {
                 switch (sortByExpression)
                 {
                     case "CourseName desc":
                         return context.CourseEnrollment.Where(c => c.StudentName == studentName).OrderByDescending(c => c.CourseName).Skip(startRowIndex).Take(rows).ToList();
                     case "StudentName desc":
                         return context.CourseEnrollment.Where(c => c.StudentName == studentName).OrderByDescending(c => c.StudentName).Skip(startRowIndex).Take(rows).ToList();
                     case "Comments desc":
                         return context.CourseEnrollment.Where(c => c.StudentName == studentName).OrderByDescending(c => c.Comments).Skip(startRowIndex).Take(rows).ToList();
                     default:
                         return context.CourseEnrollment.Where(c => c.StudentName == studentName).OrderByDescending(c => c.EnrollmentId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
             else
             {
                 switch (sortByExpression)
                 {
                     case "CourseName":
                         return context.CourseEnrollment.Where(c => c.StudentName == studentName).OrderBy(c => c.CourseName).Skip(startRowIndex).Take(rows).ToList();
                     case "StudentName":
                         return context.CourseEnrollment.Where(c => c.StudentName == studentName).OrderBy(c => c.StudentName).Skip(startRowIndex).Take(rows).ToList();
                     case "Comments":
                         return context.CourseEnrollment.Where(c => c.StudentName == studentName).OrderBy(c => c.Comments).Skip(startRowIndex).Take(rows).ToList();
                     default:
                         return context.CourseEnrollment.Where(c => c.StudentName == studentName).OrderBy(c => c.EnrollmentId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
         }

         /// <summary>
         /// Selects CourseEnrollment records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
         /// </summary>
         internal static List<CourseEnrollment> SelectSkipAndTakeDynamicWhere(int? enrollmentId, int? courseName, int? studentName, string comments, string sortByExpression, int startRowIndex, int rows)
         {
             CourseEnquiryContext context = new CourseEnquiryContext();

             int enrollmentIdValue = int.MinValue;
             int courseNameValue = int.MinValue;
             int studentNameValue = int.MinValue;

             if (enrollmentId != null)
                enrollmentIdValue = enrollmentId.Value;

             if (courseName != null)
                courseNameValue = courseName.Value;

             if (studentName != null)
                studentNameValue = studentName.Value;

             if (sortByExpression.Contains(" desc"))
             {
                 switch (sortByExpression)
                 {
                     case "CourseName desc":
                         return context.CourseEnrollment
                             .Where(c =>
                                       (enrollmentId != null ? c.EnrollmentId == enrollmentIdValue : 1 == 1) &&
                                       (courseName != null ? c.CourseName == courseNameValue : 1 == 1) &&
                                       (studentName != null ? c.StudentName == studentNameValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(comments) ? c.Comments.Contains(comments) : 1 == 1) 
                                   ).OrderByDescending(c => c.CourseName).Skip(startRowIndex).Take(rows).ToList();

                     case "StudentName desc":
                         return context.CourseEnrollment
                             .Where(c =>
                                       (enrollmentId != null ? c.EnrollmentId == enrollmentIdValue : 1 == 1) &&
                                       (courseName != null ? c.CourseName == courseNameValue : 1 == 1) &&
                                       (studentName != null ? c.StudentName == studentNameValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(comments) ? c.Comments.Contains(comments) : 1 == 1) 
                                   ).OrderByDescending(c => c.StudentName).Skip(startRowIndex).Take(rows).ToList();

                     case "Comments desc":
                         return context.CourseEnrollment
                             .Where(c =>
                                       (enrollmentId != null ? c.EnrollmentId == enrollmentIdValue : 1 == 1) &&
                                       (courseName != null ? c.CourseName == courseNameValue : 1 == 1) &&
                                       (studentName != null ? c.StudentName == studentNameValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(comments) ? c.Comments.Contains(comments) : 1 == 1) 
                                   ).OrderByDescending(c => c.Comments).Skip(startRowIndex).Take(rows).ToList();

                     default:
                         return context.CourseEnrollment
                             .Where(c =>
                                       (enrollmentId != null ? c.EnrollmentId == enrollmentIdValue : 1 == 1) &&
                                       (courseName != null ? c.CourseName == courseNameValue : 1 == 1) &&
                                       (studentName != null ? c.StudentName == studentNameValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(comments) ? c.Comments.Contains(comments) : 1 == 1) 
                                   ).OrderByDescending(c => c.EnrollmentId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
             else
             {
                 switch (sortByExpression)
                 {
                     case "CourseName":
                         return context.CourseEnrollment
                             .Where(c =>
                                       (enrollmentId != null ? c.EnrollmentId == enrollmentIdValue : 1 == 1) &&
                                       (courseName != null ? c.CourseName == courseNameValue : 1 == 1) &&
                                       (studentName != null ? c.StudentName == studentNameValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(comments) ? c.Comments.Contains(comments) : 1 == 1) 
                                   ).OrderBy(c => c.CourseName).Skip(startRowIndex).Take(rows).ToList();

                     case "StudentName":
                         return context.CourseEnrollment
                             .Where(c =>
                                       (enrollmentId != null ? c.EnrollmentId == enrollmentIdValue : 1 == 1) &&
                                       (courseName != null ? c.CourseName == courseNameValue : 1 == 1) &&
                                       (studentName != null ? c.StudentName == studentNameValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(comments) ? c.Comments.Contains(comments) : 1 == 1) 
                                   ).OrderBy(c => c.StudentName).Skip(startRowIndex).Take(rows).ToList();

                     case "Comments":
                         return context.CourseEnrollment
                             .Where(c =>
                                       (enrollmentId != null ? c.EnrollmentId == enrollmentIdValue : 1 == 1) &&
                                       (courseName != null ? c.CourseName == courseNameValue : 1 == 1) &&
                                       (studentName != null ? c.StudentName == studentNameValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(comments) ? c.Comments.Contains(comments) : 1 == 1) 
                                   ).OrderBy(c => c.Comments).Skip(startRowIndex).Take(rows).ToList();

                     default:
                         return context.CourseEnrollment
                             .Where(c =>
                                       (enrollmentId != null ? c.EnrollmentId == enrollmentIdValue : 1 == 1) &&
                                       (courseName != null ? c.CourseName == courseNameValue : 1 == 1) &&
                                       (studentName != null ? c.StudentName == studentNameValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(comments) ? c.Comments.Contains(comments) : 1 == 1) 
                                   ).OrderBy(c => c.EnrollmentId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
         }

         /// <summary>
         /// Selects all CourseEnrollment
         /// </summary>
         internal static List<CourseEnrollment> SelectAll()
         {
             CourseEnquiryContext context = new CourseEnquiryContext();
             return context.CourseEnrollment.ToList();
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of CourseEnrollment.
         /// </summary>
         internal static List<CourseEnrollment> SelectAllDynamicWhere(int? enrollmentId, int? courseName, int? studentName, string comments)
         {
             CourseEnquiryContext context = new CourseEnquiryContext();

             int enrollmentIdValue = int.MinValue;
             int courseNameValue = int.MinValue;
             int studentNameValue = int.MinValue;

             if (enrollmentId != null)
                enrollmentIdValue = enrollmentId.Value;

             if (courseName != null)
                courseNameValue = courseName.Value;

             if (studentName != null)
                studentNameValue = studentName.Value;

             return context.CourseEnrollment
                 .Where(c =>
                           (enrollmentId != null ? c.EnrollmentId == enrollmentIdValue : 1 == 1) &&
                           (courseName != null ? c.CourseName == courseNameValue : 1 == 1) &&
                           (studentName != null ? c.StudentName == studentNameValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(comments) ? c.Comments.Contains(comments) : 1 == 1) 
                       ).ToList();
         }

         /// <summary>
         /// Selects all CourseEnrollment by Course, related to column CourseName
         /// </summary>
         internal static List<CourseEnrollment> SelectCourseEnrollmentCollectionByCourseName(int courseId)
         {
             CourseEnquiryContext context = new CourseEnquiryContext();
             return context.CourseEnrollment.Where(c => c.CourseName == courseId).ToList();
         }

         /// <summary>
         /// Selects all CourseEnrollment by Student, related to column StudentName
         /// </summary>
         internal static List<CourseEnrollment> SelectCourseEnrollmentCollectionByStudentName(int studenId)
         {
             CourseEnquiryContext context = new CourseEnquiryContext();
             return context.CourseEnrollment.Where(c => c.StudentName == studenId).ToList();
         }
         /// <summary>
         /// Selects EnrollmentId and Comments columns for use with a DropDownList web control
         /// </summary>
         internal static List<CourseEnrollment> SelectCourseEnrollmentDropDownListData()
         {
             CourseEnquiryContext context = new CourseEnquiryContext();
             return (from c in context.CourseEnrollment
                     select new CourseEnrollment { EnrollmentId = c.EnrollmentId, Comments = c.Comments }).ToList();
         }
         /// <summary>
         /// Inserts a record
         /// </summary>
         internal static int Insert(CourseEnrollment objCourseEnrollment)
         {
             CourseEnquiryContext context = new CourseEnquiryContext();
             CourseEnrollment entCourseEnrollment = new CourseEnrollment();

             entCourseEnrollment.CourseName = objCourseEnrollment.CourseName;
             entCourseEnrollment.StudentName = objCourseEnrollment.StudentName;
             entCourseEnrollment.Comments = objCourseEnrollment.Comments;

             context.CourseEnrollment.Add(entCourseEnrollment);
             context.SaveChanges();

             return entCourseEnrollment.EnrollmentId;
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         internal static void Update(CourseEnrollment objCourseEnrollment)
         {
             CourseEnquiryContext context = new CourseEnquiryContext();
             CourseEnrollment entCourseEnrollment = context.CourseEnrollment.Where(c => c.EnrollmentId == objCourseEnrollment.EnrollmentId).FirstOrDefault();

             if (entCourseEnrollment != null)
             {
                 entCourseEnrollment.CourseName = objCourseEnrollment.CourseName;
                 entCourseEnrollment.StudentName = objCourseEnrollment.StudentName;
                 entCourseEnrollment.Comments = objCourseEnrollment.Comments;

                 context.SaveChanges();
             }
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         internal static void Delete(int enrollmentId)
         {
             CourseEnquiryContext context = new CourseEnquiryContext();
             var objCourseEnrollment = context.CourseEnrollment.Where(c => c.EnrollmentId == enrollmentId).FirstOrDefault();

             if (objCourseEnrollment != null)
             {
                 context.CourseEnrollment.Remove(objCourseEnrollment);
                 context.SaveChanges();
             }
         }
     }
}
