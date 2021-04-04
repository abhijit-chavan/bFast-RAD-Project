using CourseEnquiryAPI.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CourseEnquiryAPI.DataLayer.Base
{
     /// <summary>
     /// Base class for CourseEnrollmentInfoDataLayer.  Do not make changes to this class,
     /// instead, put additional code in the CourseEnrollmentInfoDataLayer class
     /// </summary>
     internal class CourseEnrollmentInfoDataLayerBase
     {
         // constructor
         internal CourseEnrollmentInfoDataLayerBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         internal static CourseEnrollmentInfo SelectByPrimaryKey(int enrollmentId)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             return context.CourseEnrollmentInfo.Where(c => c.EnrollmentId == enrollmentId).FirstOrDefault();
         }

         /// <summary>
         /// Gets the total number of records in the CourseEnrollmentInfo table
         /// </summary>
         internal static int GetRecordCount()
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             return context.CourseEnrollmentInfo.Count();
         }

         /// <summary>
         /// Gets the total number of records in the CourseEnrollmentInfo table by EnrollmentId
         /// </summary>
         internal static int GetRecordCountByEnrollmentId(int enrollmentId)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             return context.CourseEnrollmentInfo.Where(c => c.EnrollmentId == enrollmentId).Count();
         }

         /// <summary>
         /// Gets the total number of records in the CourseEnrollmentInfo table by CourseId
         /// </summary>
         internal static int GetRecordCountByCourseId(int courseId)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             return context.CourseEnrollmentInfo.Where(c => c.CourseId == courseId).Count();
         }

         /// <summary>
         /// Gets the total number of records in the CourseEnrollmentInfo table by StudentId
         /// </summary>
         internal static int GetRecordCountByStudentId(int studentId)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             return context.CourseEnrollmentInfo.Where(c => c.StudentId == studentId).Count();
         }

         /// <summary>
         /// Gets the total number of records in the CourseEnrollmentInfo table based on search parameters
         /// </summary>
         internal static int GetRecordCountDynamicWhere(int? enrollmentId, int? courseId, int? studentId, string comments)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();

             int enrollmentIdValue = int.MinValue;
             int courseIdValue = int.MinValue;
             int studentIdValue = int.MinValue;

             if (enrollmentId != null)
                enrollmentIdValue = enrollmentId.Value;

             if (courseId != null)
                courseIdValue = courseId.Value;

             if (studentId != null)
                studentIdValue = studentId.Value;

             return context.CourseEnrollmentInfo
                 .Where(c =>
                           (enrollmentId != null ? c.EnrollmentId == enrollmentIdValue : 1 == 1) &&
                           (courseId != null ? c.CourseId == courseIdValue : 1 == 1) &&
                           (studentId != null ? c.StudentId == studentIdValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(comments) ? c.Comments.Contains(comments) : 1 == 1) 
                       ).Count();
         }

         /// <summary>
         /// Selects CourseEnrollmentInfo records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
         /// </summary>
         internal static List<CourseEnrollmentInfo> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows, bool isIncludeRelatedProperties = true)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();

             if (!isIncludeRelatedProperties)
             {
                 if (sortByExpression.Contains(" desc"))
                 {
                     switch (sortByExpression)
                     {
                         case "CourseId desc":
                             return context.CourseEnrollmentInfo.OrderByDescending(c => c.CourseId).Skip(startRowIndex).Take(rows).ToList();
                         case "StudentId desc":
                             return context.CourseEnrollmentInfo.OrderByDescending(c => c.StudentId).Skip(startRowIndex).Take(rows).ToList();
                         case "Comments desc":
                             return context.CourseEnrollmentInfo.OrderByDescending(c => c.Comments).Skip(startRowIndex).Take(rows).ToList();
                         default:
                             return context.CourseEnrollmentInfo.OrderByDescending(c => c.EnrollmentId).Skip(startRowIndex).Take(rows).ToList();
                     }
                 }
                 else
                 {
                     switch (sortByExpression)
                     {
                         case "CourseId":
                             return context.CourseEnrollmentInfo.OrderBy(c => c.CourseId).Skip(startRowIndex).Take(rows).ToList();
                         case "StudentId":
                             return context.CourseEnrollmentInfo.OrderBy(c => c.StudentId).Skip(startRowIndex).Take(rows).ToList();
                         case "Comments":
                             return context.CourseEnrollmentInfo.OrderBy(c => c.Comments).Skip(startRowIndex).Take(rows).ToList();
                         default:
                             return context.CourseEnrollmentInfo.OrderBy(c => c.EnrollmentId).Skip(startRowIndex).Take(rows).ToList();
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
                             return context.CourseEnrollmentInfo.Include(c => c.CourseEnrollmentInfo1).Include(c => c.Course).Include(c => c.Student).OrderByDescending(c => c.CourseId).Skip(startRowIndex).Take(rows).ToList();
                         case "StudentId desc":
                             return context.CourseEnrollmentInfo.Include(c => c.CourseEnrollmentInfo1).Include(c => c.Course).Include(c => c.Student).OrderByDescending(c => c.StudentId).Skip(startRowIndex).Take(rows).ToList();
                         case "Comments desc":
                             return context.CourseEnrollmentInfo.Include(c => c.CourseEnrollmentInfo1).Include(c => c.Course).Include(c => c.Student).OrderByDescending(c => c.Comments).Skip(startRowIndex).Take(rows).ToList();
                         default:
                             return context.CourseEnrollmentInfo.Include(c => c.CourseEnrollmentInfo1).Include(c => c.Course).Include(c => c.Student).OrderByDescending(c => c.EnrollmentId).Skip(startRowIndex).Take(rows).ToList();
                     }
                 }
                 else
                 {
                     switch (sortByExpression)
                     {
                         case "CourseId":
                             return context.CourseEnrollmentInfo.Include(c => c.CourseEnrollmentInfo1).Include(c => c.Course).Include(c => c.Student).OrderBy(c => c.CourseId).Skip(startRowIndex).Take(rows).ToList();
                         case "StudentId":
                             return context.CourseEnrollmentInfo.Include(c => c.CourseEnrollmentInfo1).Include(c => c.Course).Include(c => c.Student).OrderBy(c => c.StudentId).Skip(startRowIndex).Take(rows).ToList();
                         case "Comments":
                             return context.CourseEnrollmentInfo.Include(c => c.CourseEnrollmentInfo1).Include(c => c.Course).Include(c => c.Student).OrderBy(c => c.Comments).Skip(startRowIndex).Take(rows).ToList();
                         default:
                             return context.CourseEnrollmentInfo.Include(c => c.CourseEnrollmentInfo1).Include(c => c.Course).Include(c => c.Student).OrderBy(c => c.EnrollmentId).Skip(startRowIndex).Take(rows).ToList();
                     }
                 }
             }
         }

         /// <summary>
         /// Selects records by EnrollmentId as a collection (List) of CourseEnrollmentInfo sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         internal static List<CourseEnrollmentInfo> SelectSkipAndTakeByEnrollmentId(string sortByExpression, int startRowIndex, int rows, int enrollmentId)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();

             if (sortByExpression.Contains(" desc"))
             {
                 switch (sortByExpression)
                 {
                     case "CourseId desc":
                         return context.CourseEnrollmentInfo.Where(c => c.EnrollmentId == enrollmentId).OrderByDescending(c => c.CourseId).Skip(startRowIndex).Take(rows).ToList();
                     case "StudentId desc":
                         return context.CourseEnrollmentInfo.Where(c => c.EnrollmentId == enrollmentId).OrderByDescending(c => c.StudentId).Skip(startRowIndex).Take(rows).ToList();
                     case "Comments desc":
                         return context.CourseEnrollmentInfo.Where(c => c.EnrollmentId == enrollmentId).OrderByDescending(c => c.Comments).Skip(startRowIndex).Take(rows).ToList();
                     default:
                         return context.CourseEnrollmentInfo.Where(c => c.EnrollmentId == enrollmentId).OrderByDescending(c => c.EnrollmentId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
             else
             {
                 switch (sortByExpression)
                 {
                     case "CourseId":
                         return context.CourseEnrollmentInfo.Where(c => c.EnrollmentId == enrollmentId).OrderBy(c => c.CourseId).Skip(startRowIndex).Take(rows).ToList();
                     case "StudentId":
                         return context.CourseEnrollmentInfo.Where(c => c.EnrollmentId == enrollmentId).OrderBy(c => c.StudentId).Skip(startRowIndex).Take(rows).ToList();
                     case "Comments":
                         return context.CourseEnrollmentInfo.Where(c => c.EnrollmentId == enrollmentId).OrderBy(c => c.Comments).Skip(startRowIndex).Take(rows).ToList();
                     default:
                         return context.CourseEnrollmentInfo.Where(c => c.EnrollmentId == enrollmentId).OrderBy(c => c.EnrollmentId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
         }

         /// <summary>
         /// Selects records by CourseId as a collection (List) of CourseEnrollmentInfo sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         internal static List<CourseEnrollmentInfo> SelectSkipAndTakeByCourseId(string sortByExpression, int startRowIndex, int rows, int courseId)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();

             if (sortByExpression.Contains(" desc"))
             {
                 switch (sortByExpression)
                 {
                     case "CourseId desc":
                         return context.CourseEnrollmentInfo.Where(c => c.CourseId == courseId).OrderByDescending(c => c.CourseId).Skip(startRowIndex).Take(rows).ToList();
                     case "StudentId desc":
                         return context.CourseEnrollmentInfo.Where(c => c.CourseId == courseId).OrderByDescending(c => c.StudentId).Skip(startRowIndex).Take(rows).ToList();
                     case "Comments desc":
                         return context.CourseEnrollmentInfo.Where(c => c.CourseId == courseId).OrderByDescending(c => c.Comments).Skip(startRowIndex).Take(rows).ToList();
                     default:
                         return context.CourseEnrollmentInfo.Where(c => c.CourseId == courseId).OrderByDescending(c => c.EnrollmentId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
             else
             {
                 switch (sortByExpression)
                 {
                     case "CourseId":
                         return context.CourseEnrollmentInfo.Where(c => c.CourseId == courseId).OrderBy(c => c.CourseId).Skip(startRowIndex).Take(rows).ToList();
                     case "StudentId":
                         return context.CourseEnrollmentInfo.Where(c => c.CourseId == courseId).OrderBy(c => c.StudentId).Skip(startRowIndex).Take(rows).ToList();
                     case "Comments":
                         return context.CourseEnrollmentInfo.Where(c => c.CourseId == courseId).OrderBy(c => c.Comments).Skip(startRowIndex).Take(rows).ToList();
                     default:
                         return context.CourseEnrollmentInfo.Where(c => c.CourseId == courseId).OrderBy(c => c.EnrollmentId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
         }

         /// <summary>
         /// Selects records by StudentId as a collection (List) of CourseEnrollmentInfo sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         internal static List<CourseEnrollmentInfo> SelectSkipAndTakeByStudentId(string sortByExpression, int startRowIndex, int rows, int studentId)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();

             if (sortByExpression.Contains(" desc"))
             {
                 switch (sortByExpression)
                 {
                     case "CourseId desc":
                         return context.CourseEnrollmentInfo.Where(c => c.StudentId == studentId).OrderByDescending(c => c.CourseId).Skip(startRowIndex).Take(rows).ToList();
                     case "StudentId desc":
                         return context.CourseEnrollmentInfo.Where(c => c.StudentId == studentId).OrderByDescending(c => c.StudentId).Skip(startRowIndex).Take(rows).ToList();
                     case "Comments desc":
                         return context.CourseEnrollmentInfo.Where(c => c.StudentId == studentId).OrderByDescending(c => c.Comments).Skip(startRowIndex).Take(rows).ToList();
                     default:
                         return context.CourseEnrollmentInfo.Where(c => c.StudentId == studentId).OrderByDescending(c => c.EnrollmentId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
             else
             {
                 switch (sortByExpression)
                 {
                     case "CourseId":
                         return context.CourseEnrollmentInfo.Where(c => c.StudentId == studentId).OrderBy(c => c.CourseId).Skip(startRowIndex).Take(rows).ToList();
                     case "StudentId":
                         return context.CourseEnrollmentInfo.Where(c => c.StudentId == studentId).OrderBy(c => c.StudentId).Skip(startRowIndex).Take(rows).ToList();
                     case "Comments":
                         return context.CourseEnrollmentInfo.Where(c => c.StudentId == studentId).OrderBy(c => c.Comments).Skip(startRowIndex).Take(rows).ToList();
                     default:
                         return context.CourseEnrollmentInfo.Where(c => c.StudentId == studentId).OrderBy(c => c.EnrollmentId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
         }

         /// <summary>
         /// Selects CourseEnrollmentInfo records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
         /// </summary>
         internal static List<CourseEnrollmentInfo> SelectSkipAndTakeDynamicWhere(int? enrollmentId, int? courseId, int? studentId, string comments, string sortByExpression, int startRowIndex, int rows)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();

             int enrollmentIdValue = int.MinValue;
             int courseIdValue = int.MinValue;
             int studentIdValue = int.MinValue;

             if (enrollmentId != null)
                enrollmentIdValue = enrollmentId.Value;

             if (courseId != null)
                courseIdValue = courseId.Value;

             if (studentId != null)
                studentIdValue = studentId.Value;

             if (sortByExpression.Contains(" desc"))
             {
                 switch (sortByExpression)
                 {
                     case "CourseId desc":
                         return context.CourseEnrollmentInfo
                             .Where(c =>
                                       (enrollmentId != null ? c.EnrollmentId == enrollmentIdValue : 1 == 1) &&
                                       (courseId != null ? c.CourseId == courseIdValue : 1 == 1) &&
                                       (studentId != null ? c.StudentId == studentIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(comments) ? c.Comments.Contains(comments) : 1 == 1) 
                                   ).OrderByDescending(c => c.CourseId).Skip(startRowIndex).Take(rows).ToList();

                     case "StudentId desc":
                         return context.CourseEnrollmentInfo
                             .Where(c =>
                                       (enrollmentId != null ? c.EnrollmentId == enrollmentIdValue : 1 == 1) &&
                                       (courseId != null ? c.CourseId == courseIdValue : 1 == 1) &&
                                       (studentId != null ? c.StudentId == studentIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(comments) ? c.Comments.Contains(comments) : 1 == 1) 
                                   ).OrderByDescending(c => c.StudentId).Skip(startRowIndex).Take(rows).ToList();

                     case "Comments desc":
                         return context.CourseEnrollmentInfo
                             .Where(c =>
                                       (enrollmentId != null ? c.EnrollmentId == enrollmentIdValue : 1 == 1) &&
                                       (courseId != null ? c.CourseId == courseIdValue : 1 == 1) &&
                                       (studentId != null ? c.StudentId == studentIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(comments) ? c.Comments.Contains(comments) : 1 == 1) 
                                   ).OrderByDescending(c => c.Comments).Skip(startRowIndex).Take(rows).ToList();

                     default:
                         return context.CourseEnrollmentInfo
                             .Where(c =>
                                       (enrollmentId != null ? c.EnrollmentId == enrollmentIdValue : 1 == 1) &&
                                       (courseId != null ? c.CourseId == courseIdValue : 1 == 1) &&
                                       (studentId != null ? c.StudentId == studentIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(comments) ? c.Comments.Contains(comments) : 1 == 1) 
                                   ).OrderByDescending(c => c.EnrollmentId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
             else
             {
                 switch (sortByExpression)
                 {
                     case "CourseId":
                         return context.CourseEnrollmentInfo
                             .Where(c =>
                                       (enrollmentId != null ? c.EnrollmentId == enrollmentIdValue : 1 == 1) &&
                                       (courseId != null ? c.CourseId == courseIdValue : 1 == 1) &&
                                       (studentId != null ? c.StudentId == studentIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(comments) ? c.Comments.Contains(comments) : 1 == 1) 
                                   ).OrderBy(c => c.CourseId).Skip(startRowIndex).Take(rows).ToList();

                     case "StudentId":
                         return context.CourseEnrollmentInfo
                             .Where(c =>
                                       (enrollmentId != null ? c.EnrollmentId == enrollmentIdValue : 1 == 1) &&
                                       (courseId != null ? c.CourseId == courseIdValue : 1 == 1) &&
                                       (studentId != null ? c.StudentId == studentIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(comments) ? c.Comments.Contains(comments) : 1 == 1) 
                                   ).OrderBy(c => c.StudentId).Skip(startRowIndex).Take(rows).ToList();

                     case "Comments":
                         return context.CourseEnrollmentInfo
                             .Where(c =>
                                       (enrollmentId != null ? c.EnrollmentId == enrollmentIdValue : 1 == 1) &&
                                       (courseId != null ? c.CourseId == courseIdValue : 1 == 1) &&
                                       (studentId != null ? c.StudentId == studentIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(comments) ? c.Comments.Contains(comments) : 1 == 1) 
                                   ).OrderBy(c => c.Comments).Skip(startRowIndex).Take(rows).ToList();

                     default:
                         return context.CourseEnrollmentInfo
                             .Where(c =>
                                       (enrollmentId != null ? c.EnrollmentId == enrollmentIdValue : 1 == 1) &&
                                       (courseId != null ? c.CourseId == courseIdValue : 1 == 1) &&
                                       (studentId != null ? c.StudentId == studentIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(comments) ? c.Comments.Contains(comments) : 1 == 1) 
                                   ).OrderBy(c => c.EnrollmentId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
         }

         /// <summary>
         /// Selects all CourseEnrollmentInfo
         /// </summary>
         internal static List<CourseEnrollmentInfo> SelectAll()
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             return context.CourseEnrollmentInfo.ToList();
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of CourseEnrollmentInfo.
         /// </summary>
         internal static List<CourseEnrollmentInfo> SelectAllDynamicWhere(int? enrollmentId, int? courseId, int? studentId, string comments)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();

             int enrollmentIdValue = int.MinValue;
             int courseIdValue = int.MinValue;
             int studentIdValue = int.MinValue;

             if (enrollmentId != null)
                enrollmentIdValue = enrollmentId.Value;

             if (courseId != null)
                courseIdValue = courseId.Value;

             if (studentId != null)
                studentIdValue = studentId.Value;

             return context.CourseEnrollmentInfo
                 .Where(c =>
                           (enrollmentId != null ? c.EnrollmentId == enrollmentIdValue : 1 == 1) &&
                           (courseId != null ? c.CourseId == courseIdValue : 1 == 1) &&
                           (studentId != null ? c.StudentId == studentIdValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(comments) ? c.Comments.Contains(comments) : 1 == 1) 
                       ).ToList();
         }

         /// <summary>
         /// Selects all CourseEnrollmentInfo by CourseEnrollmentInfo, related to column EnrollmentId
         /// </summary>
         internal static List<CourseEnrollmentInfo> SelectCourseEnrollmentInfoCollectionByEnrollmentId(int enrollmentId)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             return context.CourseEnrollmentInfo.Where(c => c.EnrollmentId == enrollmentId).ToList();
         }

         /// <summary>
         /// Selects all CourseEnrollmentInfo by Course, related to column CourseId
         /// </summary>
         internal static List<CourseEnrollmentInfo> SelectCourseEnrollmentInfoCollectionByCourseId(int courseId)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             return context.CourseEnrollmentInfo.Where(c => c.CourseId == courseId).ToList();
         }

         /// <summary>
         /// Selects all CourseEnrollmentInfo by Student, related to column StudentId
         /// </summary>
         internal static List<CourseEnrollmentInfo> SelectCourseEnrollmentInfoCollectionByStudentId(int studentId)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             return context.CourseEnrollmentInfo.Where(c => c.StudentId == studentId).ToList();
         }
         /// <summary>
         /// Selects EnrollmentId and Comments columns for use with a DropDownList web control
         /// </summary>
         internal static List<CourseEnrollmentInfo> SelectCourseEnrollmentInfoDropDownListData()
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             return (from c in context.CourseEnrollmentInfo
                     select new CourseEnrollmentInfo { EnrollmentId = c.EnrollmentId, Comments = c.Comments }).ToList();
         }
         /// <summary>
         /// Inserts a record
         /// </summary>
         internal static int Insert(CourseEnrollmentInfo objCourseEnrollmentInfo)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             CourseEnrollmentInfo entCourseEnrollmentInfo = new CourseEnrollmentInfo();

             entCourseEnrollmentInfo.EnrollmentId = objCourseEnrollmentInfo.EnrollmentId;
             entCourseEnrollmentInfo.CourseId = objCourseEnrollmentInfo.CourseId;
             entCourseEnrollmentInfo.StudentId = objCourseEnrollmentInfo.StudentId;
             entCourseEnrollmentInfo.Comments = objCourseEnrollmentInfo.Comments;

             context.CourseEnrollmentInfo.Add(entCourseEnrollmentInfo);
             context.SaveChanges();

             return entCourseEnrollmentInfo.EnrollmentId;
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         internal static void Update(CourseEnrollmentInfo objCourseEnrollmentInfo)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             CourseEnrollmentInfo entCourseEnrollmentInfo = context.CourseEnrollmentInfo.Where(c => c.EnrollmentId == objCourseEnrollmentInfo.EnrollmentId).FirstOrDefault();

             if (entCourseEnrollmentInfo != null)
             {
                 entCourseEnrollmentInfo.CourseId = objCourseEnrollmentInfo.CourseId;
                 entCourseEnrollmentInfo.StudentId = objCourseEnrollmentInfo.StudentId;
                 entCourseEnrollmentInfo.Comments = objCourseEnrollmentInfo.Comments;

                 context.SaveChanges();
             }
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         internal static void Delete(int enrollmentId)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             var objCourseEnrollmentInfo = context.CourseEnrollmentInfo.Where(c => c.EnrollmentId == enrollmentId).FirstOrDefault();

             if (objCourseEnrollmentInfo != null)
             {
                 context.CourseEnrollmentInfo.Remove(objCourseEnrollmentInfo);
                 context.SaveChanges();
             }
         }
     }
}
