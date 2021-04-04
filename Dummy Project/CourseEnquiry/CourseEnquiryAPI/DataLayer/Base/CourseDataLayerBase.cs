using CourseEnquiryAPI.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CourseEnquiryAPI.DataLayer.Base
{
     /// <summary>
     /// Base class for CourseDataLayer.  Do not make changes to this class,
     /// instead, put additional code in the CourseDataLayer class
     /// </summary>
     internal class CourseDataLayerBase
     {
         // constructor
         internal CourseDataLayerBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         internal static Course SelectByPrimaryKey(int courseId)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             return context.Course.Where(c => c.CourseId == courseId).FirstOrDefault();
         }

         /// <summary>
         /// Gets the total number of records in the Course table
         /// </summary>
         internal static int GetRecordCount()
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             return context.Course.Count();
         }

         /// <summary>
         /// Gets the total number of records in the Course table based on search parameters
         /// </summary>
         internal static int GetRecordCountDynamicWhere(int? courseId, string courseName, DateTime? startDate, DateTime? endDate, decimal? fees)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();

             int courseIdValue = int.MinValue;
             DateTime startDateValue = DateTime.MinValue;
             DateTime endDateValue = DateTime.MinValue;
             decimal feesValue = decimal.MinValue;

             if (courseId != null)
                courseIdValue = courseId.Value;

             if (startDate != null)
                startDateValue = startDate.Value;

             if (endDate != null)
                endDateValue = endDate.Value;

             if (fees != null)
                feesValue = fees.Value;

             return context.Course
                 .Where(c =>
                           (courseId != null ? c.CourseId == courseIdValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(courseName) ? c.CourseName.Contains(courseName) : 1 == 1) &&
                           (startDate != null ? c.StartDate == startDateValue : 1 == 1) &&
                           (endDate != null ? c.EndDate == endDateValue : 1 == 1) &&
                           (fees != null ? c.Fees == feesValue : 1 == 1) 
                       ).Count();
         }

         /// <summary>
         /// Selects Course records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
         /// </summary>
         internal static List<Course> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();

             if (sortByExpression.Contains(" desc"))
             {
                     switch (sortByExpression)
                     {
                         case "CourseName desc":
                             return context.Course.OrderByDescending(c => c.CourseName).Skip(startRowIndex).Take(rows).ToList();
                         case "StartDate desc":
                             return context.Course.OrderByDescending(c => c.StartDate).Skip(startRowIndex).Take(rows).ToList();
                         case "EndDate desc":
                             return context.Course.OrderByDescending(c => c.EndDate).Skip(startRowIndex).Take(rows).ToList();
                         case "Fees desc":
                             return context.Course.OrderByDescending(c => c.Fees).Skip(startRowIndex).Take(rows).ToList();
                         default:
                             return context.Course.OrderByDescending(c => c.CourseId).Skip(startRowIndex).Take(rows).ToList();
                     }
             }
             else
             {
                     switch (sortByExpression)
                     {
                         case "CourseName":
                             return context.Course.OrderBy(c => c.CourseName).Skip(startRowIndex).Take(rows).ToList();
                         case "StartDate":
                             return context.Course.OrderBy(c => c.StartDate).Skip(startRowIndex).Take(rows).ToList();
                         case "EndDate":
                             return context.Course.OrderBy(c => c.EndDate).Skip(startRowIndex).Take(rows).ToList();
                         case "Fees":
                             return context.Course.OrderBy(c => c.Fees).Skip(startRowIndex).Take(rows).ToList();
                         default:
                             return context.Course.OrderBy(c => c.CourseId).Skip(startRowIndex).Take(rows).ToList();
                     }
             }
         }

         /// <summary>
         /// Selects Course records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
         /// </summary>
         internal static List<Course> SelectSkipAndTakeDynamicWhere(int? courseId, string courseName, DateTime? startDate, DateTime? endDate, decimal? fees, string sortByExpression, int startRowIndex, int rows)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();

             int courseIdValue = int.MinValue;
             DateTime startDateValue = DateTime.MinValue;
             DateTime endDateValue = DateTime.MinValue;
             decimal feesValue = decimal.MinValue;

             if (courseId != null)
                courseIdValue = courseId.Value;

             if (startDate != null)
                startDateValue = startDate.Value;

             if (endDate != null)
                endDateValue = endDate.Value;

             if (fees != null)
                feesValue = fees.Value;

             if (sortByExpression.Contains(" desc"))
             {
                 switch (sortByExpression)
                 {
                     case "CourseName desc":
                         return context.Course
                             .Where(c =>
                                       (courseId != null ? c.CourseId == courseIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(courseName) ? c.CourseName.Contains(courseName) : 1 == 1) &&
                                       (startDate != null ? c.StartDate == startDateValue : 1 == 1) &&
                                       (endDate != null ? c.EndDate == endDateValue : 1 == 1) &&
                                       (fees != null ? c.Fees == feesValue : 1 == 1) 
                                   ).OrderByDescending(c => c.CourseName).Skip(startRowIndex).Take(rows).ToList();

                     case "StartDate desc":
                         return context.Course
                             .Where(c =>
                                       (courseId != null ? c.CourseId == courseIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(courseName) ? c.CourseName.Contains(courseName) : 1 == 1) &&
                                       (startDate != null ? c.StartDate == startDateValue : 1 == 1) &&
                                       (endDate != null ? c.EndDate == endDateValue : 1 == 1) &&
                                       (fees != null ? c.Fees == feesValue : 1 == 1) 
                                   ).OrderByDescending(c => c.StartDate).Skip(startRowIndex).Take(rows).ToList();

                     case "EndDate desc":
                         return context.Course
                             .Where(c =>
                                       (courseId != null ? c.CourseId == courseIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(courseName) ? c.CourseName.Contains(courseName) : 1 == 1) &&
                                       (startDate != null ? c.StartDate == startDateValue : 1 == 1) &&
                                       (endDate != null ? c.EndDate == endDateValue : 1 == 1) &&
                                       (fees != null ? c.Fees == feesValue : 1 == 1) 
                                   ).OrderByDescending(c => c.EndDate).Skip(startRowIndex).Take(rows).ToList();

                     case "Fees desc":
                         return context.Course
                             .Where(c =>
                                       (courseId != null ? c.CourseId == courseIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(courseName) ? c.CourseName.Contains(courseName) : 1 == 1) &&
                                       (startDate != null ? c.StartDate == startDateValue : 1 == 1) &&
                                       (endDate != null ? c.EndDate == endDateValue : 1 == 1) &&
                                       (fees != null ? c.Fees == feesValue : 1 == 1) 
                                   ).OrderByDescending(c => c.Fees).Skip(startRowIndex).Take(rows).ToList();

                     default:
                         return context.Course
                             .Where(c =>
                                       (courseId != null ? c.CourseId == courseIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(courseName) ? c.CourseName.Contains(courseName) : 1 == 1) &&
                                       (startDate != null ? c.StartDate == startDateValue : 1 == 1) &&
                                       (endDate != null ? c.EndDate == endDateValue : 1 == 1) &&
                                       (fees != null ? c.Fees == feesValue : 1 == 1) 
                                   ).OrderByDescending(c => c.CourseId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
             else
             {
                 switch (sortByExpression)
                 {
                     case "CourseName":
                         return context.Course
                             .Where(c =>
                                       (courseId != null ? c.CourseId == courseIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(courseName) ? c.CourseName.Contains(courseName) : 1 == 1) &&
                                       (startDate != null ? c.StartDate == startDateValue : 1 == 1) &&
                                       (endDate != null ? c.EndDate == endDateValue : 1 == 1) &&
                                       (fees != null ? c.Fees == feesValue : 1 == 1) 
                                   ).OrderBy(c => c.CourseName).Skip(startRowIndex).Take(rows).ToList();

                     case "StartDate":
                         return context.Course
                             .Where(c =>
                                       (courseId != null ? c.CourseId == courseIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(courseName) ? c.CourseName.Contains(courseName) : 1 == 1) &&
                                       (startDate != null ? c.StartDate == startDateValue : 1 == 1) &&
                                       (endDate != null ? c.EndDate == endDateValue : 1 == 1) &&
                                       (fees != null ? c.Fees == feesValue : 1 == 1) 
                                   ).OrderBy(c => c.StartDate).Skip(startRowIndex).Take(rows).ToList();

                     case "EndDate":
                         return context.Course
                             .Where(c =>
                                       (courseId != null ? c.CourseId == courseIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(courseName) ? c.CourseName.Contains(courseName) : 1 == 1) &&
                                       (startDate != null ? c.StartDate == startDateValue : 1 == 1) &&
                                       (endDate != null ? c.EndDate == endDateValue : 1 == 1) &&
                                       (fees != null ? c.Fees == feesValue : 1 == 1) 
                                   ).OrderBy(c => c.EndDate).Skip(startRowIndex).Take(rows).ToList();

                     case "Fees":
                         return context.Course
                             .Where(c =>
                                       (courseId != null ? c.CourseId == courseIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(courseName) ? c.CourseName.Contains(courseName) : 1 == 1) &&
                                       (startDate != null ? c.StartDate == startDateValue : 1 == 1) &&
                                       (endDate != null ? c.EndDate == endDateValue : 1 == 1) &&
                                       (fees != null ? c.Fees == feesValue : 1 == 1) 
                                   ).OrderBy(c => c.Fees).Skip(startRowIndex).Take(rows).ToList();

                     default:
                         return context.Course
                             .Where(c =>
                                       (courseId != null ? c.CourseId == courseIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(courseName) ? c.CourseName.Contains(courseName) : 1 == 1) &&
                                       (startDate != null ? c.StartDate == startDateValue : 1 == 1) &&
                                       (endDate != null ? c.EndDate == endDateValue : 1 == 1) &&
                                       (fees != null ? c.Fees == feesValue : 1 == 1) 
                                   ).OrderBy(c => c.CourseId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
         }

         /// <summary>
         /// Selects all Course
         /// </summary>
         internal static List<Course> SelectAll()
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             return context.Course.ToList();
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of Course.
         /// </summary>
         internal static List<Course> SelectAllDynamicWhere(int? courseId, string courseName, DateTime? startDate, DateTime? endDate, decimal? fees)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();

             int courseIdValue = int.MinValue;
             DateTime startDateValue = DateTime.MinValue;
             DateTime endDateValue = DateTime.MinValue;
             decimal feesValue = decimal.MinValue;

             if (courseId != null)
                courseIdValue = courseId.Value;

             if (startDate != null)
                startDateValue = startDate.Value;

             if (endDate != null)
                endDateValue = endDate.Value;

             if (fees != null)
                feesValue = fees.Value;

             return context.Course
                 .Where(c =>
                           (courseId != null ? c.CourseId == courseIdValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(courseName) ? c.CourseName.Contains(courseName) : 1 == 1) &&
                           (startDate != null ? c.StartDate == startDateValue : 1 == 1) &&
                           (endDate != null ? c.EndDate == endDateValue : 1 == 1) &&
                           (fees != null ? c.Fees == feesValue : 1 == 1) 
                       ).ToList();
         }
         /// <summary>
         /// Selects CourseId and CourseName columns for use with a DropDownList web control
         /// </summary>
         internal static List<Course> SelectCourseDropDownListData()
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             return (from c in context.Course
                     select new Course { CourseId = c.CourseId, CourseName = c.CourseName }).ToList();
         }
         /// <summary>
         /// Inserts a record
         /// </summary>
         internal static int Insert(Course objCourse)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             Course entCourse = new Course();

             entCourse.CourseName = objCourse.CourseName;
             entCourse.StartDate = objCourse.StartDate;
             entCourse.EndDate = objCourse.EndDate;
             entCourse.Fees = objCourse.Fees;

             context.Course.Add(entCourse);
             context.SaveChanges();

             return entCourse.CourseId;
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         internal static void Update(Course objCourse)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             Course entCourse = context.Course.Where(c => c.CourseId == objCourse.CourseId).FirstOrDefault();

             if (entCourse != null)
             {
                 entCourse.CourseName = objCourse.CourseName;
                 entCourse.StartDate = objCourse.StartDate;
                 entCourse.EndDate = objCourse.EndDate;
                 entCourse.Fees = objCourse.Fees;

                 context.SaveChanges();
             }
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         internal static void Delete(int courseId)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             var objCourse = context.Course.Where(c => c.CourseId == courseId).FirstOrDefault();

             if (objCourse != null)
             {
                 context.Course.Remove(objCourse);
                 context.SaveChanges();
             }
         }
     }
}
