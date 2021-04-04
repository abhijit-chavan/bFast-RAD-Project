using StudentEnquiryAPI.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace StudentEnquiryAPI.DataLayer.Base
{
     /// <summary>
     /// Base class for CouseDataLayer.  Do not make changes to this class,
     /// instead, put additional code in the CouseDataLayer class
     /// </summary>
     internal class CouseDataLayerBase
     {
         // constructor
         internal CouseDataLayerBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         internal static Couse SelectByPrimaryKey(int couseid)
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();
             return context.Couse.Where(c => c.Couseid == couseid).FirstOrDefault();
         }

         /// <summary>
         /// Gets the total number of records in the Couse table
         /// </summary>
         internal static int GetRecordCount()
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();
             return context.Couse.Count();
         }

         /// <summary>
         /// Gets the total number of records in the Couse table based on search parameters
         /// </summary>
         internal static int GetRecordCountDynamicWhere(int? couseid, string couseName, DateTime? courseStartDate, DateTime? courseEndDate, Int64? couseFees)
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();

             int couseidValue = int.MinValue;
             DateTime courseStartDateValue = DateTime.MinValue;
             DateTime courseEndDateValue = DateTime.MinValue;
             Int64 couseFeesValue = Int64.MinValue;

             if (couseid != null)
                couseidValue = couseid.Value;

             if (courseStartDate != null)
                courseStartDateValue = courseStartDate.Value;

             if (courseEndDate != null)
                courseEndDateValue = courseEndDate.Value;

             if (couseFees != null)
                couseFeesValue = couseFees.Value;

             return context.Couse
                 .Where(c =>
                           (couseid != null ? c.Couseid == couseidValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(couseName) ? c.CouseName.Contains(couseName) : 1 == 1) &&
                           (courseStartDate != null ? c.CourseStartDate == courseStartDateValue : 1 == 1) &&
                           (courseEndDate != null ? c.CourseEndDate == courseEndDateValue : 1 == 1) &&
                           (couseFees != null ? c.CouseFees == couseFeesValue : 1 == 1) 
                       ).Count();
         }

         /// <summary>
         /// Selects Couse records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
         /// </summary>
         internal static List<Couse> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();

             if (sortByExpression.Contains(" desc"))
             {
                     switch (sortByExpression)
                     {
                         case "CouseName desc":
                             return context.Couse.OrderByDescending(c => c.CouseName).Skip(startRowIndex).Take(rows).ToList();
                         case "CourseStartDate desc":
                             return context.Couse.OrderByDescending(c => c.CourseStartDate).Skip(startRowIndex).Take(rows).ToList();
                         case "CourseEndDate desc":
                             return context.Couse.OrderByDescending(c => c.CourseEndDate).Skip(startRowIndex).Take(rows).ToList();
                         case "CouseFees desc":
                             return context.Couse.OrderByDescending(c => c.CouseFees).Skip(startRowIndex).Take(rows).ToList();
                         default:
                             return context.Couse.OrderByDescending(c => c.Couseid).Skip(startRowIndex).Take(rows).ToList();
                     }
             }
             else
             {
                     switch (sortByExpression)
                     {
                         case "CouseName":
                             return context.Couse.OrderBy(c => c.CouseName).Skip(startRowIndex).Take(rows).ToList();
                         case "CourseStartDate":
                             return context.Couse.OrderBy(c => c.CourseStartDate).Skip(startRowIndex).Take(rows).ToList();
                         case "CourseEndDate":
                             return context.Couse.OrderBy(c => c.CourseEndDate).Skip(startRowIndex).Take(rows).ToList();
                         case "CouseFees":
                             return context.Couse.OrderBy(c => c.CouseFees).Skip(startRowIndex).Take(rows).ToList();
                         default:
                             return context.Couse.OrderBy(c => c.Couseid).Skip(startRowIndex).Take(rows).ToList();
                     }
             }
         }

         /// <summary>
         /// Selects Couse records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
         /// </summary>
         internal static List<Couse> SelectSkipAndTakeDynamicWhere(int? couseid, string couseName, DateTime? courseStartDate, DateTime? courseEndDate, Int64? couseFees, string sortByExpression, int startRowIndex, int rows)
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();

             int couseidValue = int.MinValue;
             DateTime courseStartDateValue = DateTime.MinValue;
             DateTime courseEndDateValue = DateTime.MinValue;
             Int64 couseFeesValue = Int64.MinValue;

             if (couseid != null)
                couseidValue = couseid.Value;

             if (courseStartDate != null)
                courseStartDateValue = courseStartDate.Value;

             if (courseEndDate != null)
                courseEndDateValue = courseEndDate.Value;

             if (couseFees != null)
                couseFeesValue = couseFees.Value;

             if (sortByExpression.Contains(" desc"))
             {
                 switch (sortByExpression)
                 {
                     case "CouseName desc":
                         return context.Couse
                             .Where(c =>
                                       (couseid != null ? c.Couseid == couseidValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(couseName) ? c.CouseName.Contains(couseName) : 1 == 1) &&
                                       (courseStartDate != null ? c.CourseStartDate == courseStartDateValue : 1 == 1) &&
                                       (courseEndDate != null ? c.CourseEndDate == courseEndDateValue : 1 == 1) &&
                                       (couseFees != null ? c.CouseFees == couseFeesValue : 1 == 1) 
                                   ).OrderByDescending(c => c.CouseName).Skip(startRowIndex).Take(rows).ToList();

                     case "CourseStartDate desc":
                         return context.Couse
                             .Where(c =>
                                       (couseid != null ? c.Couseid == couseidValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(couseName) ? c.CouseName.Contains(couseName) : 1 == 1) &&
                                       (courseStartDate != null ? c.CourseStartDate == courseStartDateValue : 1 == 1) &&
                                       (courseEndDate != null ? c.CourseEndDate == courseEndDateValue : 1 == 1) &&
                                       (couseFees != null ? c.CouseFees == couseFeesValue : 1 == 1) 
                                   ).OrderByDescending(c => c.CourseStartDate).Skip(startRowIndex).Take(rows).ToList();

                     case "CourseEndDate desc":
                         return context.Couse
                             .Where(c =>
                                       (couseid != null ? c.Couseid == couseidValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(couseName) ? c.CouseName.Contains(couseName) : 1 == 1) &&
                                       (courseStartDate != null ? c.CourseStartDate == courseStartDateValue : 1 == 1) &&
                                       (courseEndDate != null ? c.CourseEndDate == courseEndDateValue : 1 == 1) &&
                                       (couseFees != null ? c.CouseFees == couseFeesValue : 1 == 1) 
                                   ).OrderByDescending(c => c.CourseEndDate).Skip(startRowIndex).Take(rows).ToList();

                     case "CouseFees desc":
                         return context.Couse
                             .Where(c =>
                                       (couseid != null ? c.Couseid == couseidValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(couseName) ? c.CouseName.Contains(couseName) : 1 == 1) &&
                                       (courseStartDate != null ? c.CourseStartDate == courseStartDateValue : 1 == 1) &&
                                       (courseEndDate != null ? c.CourseEndDate == courseEndDateValue : 1 == 1) &&
                                       (couseFees != null ? c.CouseFees == couseFeesValue : 1 == 1) 
                                   ).OrderByDescending(c => c.CouseFees).Skip(startRowIndex).Take(rows).ToList();

                     default:
                         return context.Couse
                             .Where(c =>
                                       (couseid != null ? c.Couseid == couseidValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(couseName) ? c.CouseName.Contains(couseName) : 1 == 1) &&
                                       (courseStartDate != null ? c.CourseStartDate == courseStartDateValue : 1 == 1) &&
                                       (courseEndDate != null ? c.CourseEndDate == courseEndDateValue : 1 == 1) &&
                                       (couseFees != null ? c.CouseFees == couseFeesValue : 1 == 1) 
                                   ).OrderByDescending(c => c.Couseid).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
             else
             {
                 switch (sortByExpression)
                 {
                     case "CouseName":
                         return context.Couse
                             .Where(c =>
                                       (couseid != null ? c.Couseid == couseidValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(couseName) ? c.CouseName.Contains(couseName) : 1 == 1) &&
                                       (courseStartDate != null ? c.CourseStartDate == courseStartDateValue : 1 == 1) &&
                                       (courseEndDate != null ? c.CourseEndDate == courseEndDateValue : 1 == 1) &&
                                       (couseFees != null ? c.CouseFees == couseFeesValue : 1 == 1) 
                                   ).OrderBy(c => c.CouseName).Skip(startRowIndex).Take(rows).ToList();

                     case "CourseStartDate":
                         return context.Couse
                             .Where(c =>
                                       (couseid != null ? c.Couseid == couseidValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(couseName) ? c.CouseName.Contains(couseName) : 1 == 1) &&
                                       (courseStartDate != null ? c.CourseStartDate == courseStartDateValue : 1 == 1) &&
                                       (courseEndDate != null ? c.CourseEndDate == courseEndDateValue : 1 == 1) &&
                                       (couseFees != null ? c.CouseFees == couseFeesValue : 1 == 1) 
                                   ).OrderBy(c => c.CourseStartDate).Skip(startRowIndex).Take(rows).ToList();

                     case "CourseEndDate":
                         return context.Couse
                             .Where(c =>
                                       (couseid != null ? c.Couseid == couseidValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(couseName) ? c.CouseName.Contains(couseName) : 1 == 1) &&
                                       (courseStartDate != null ? c.CourseStartDate == courseStartDateValue : 1 == 1) &&
                                       (courseEndDate != null ? c.CourseEndDate == courseEndDateValue : 1 == 1) &&
                                       (couseFees != null ? c.CouseFees == couseFeesValue : 1 == 1) 
                                   ).OrderBy(c => c.CourseEndDate).Skip(startRowIndex).Take(rows).ToList();

                     case "CouseFees":
                         return context.Couse
                             .Where(c =>
                                       (couseid != null ? c.Couseid == couseidValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(couseName) ? c.CouseName.Contains(couseName) : 1 == 1) &&
                                       (courseStartDate != null ? c.CourseStartDate == courseStartDateValue : 1 == 1) &&
                                       (courseEndDate != null ? c.CourseEndDate == courseEndDateValue : 1 == 1) &&
                                       (couseFees != null ? c.CouseFees == couseFeesValue : 1 == 1) 
                                   ).OrderBy(c => c.CouseFees).Skip(startRowIndex).Take(rows).ToList();

                     default:
                         return context.Couse
                             .Where(c =>
                                       (couseid != null ? c.Couseid == couseidValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(couseName) ? c.CouseName.Contains(couseName) : 1 == 1) &&
                                       (courseStartDate != null ? c.CourseStartDate == courseStartDateValue : 1 == 1) &&
                                       (courseEndDate != null ? c.CourseEndDate == courseEndDateValue : 1 == 1) &&
                                       (couseFees != null ? c.CouseFees == couseFeesValue : 1 == 1) 
                                   ).OrderBy(c => c.Couseid).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
         }

         /// <summary>
         /// Selects all Couse
         /// </summary>
         internal static List<Couse> SelectAll()
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();
             return context.Couse.ToList();
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of Couse.
         /// </summary>
         internal static List<Couse> SelectAllDynamicWhere(int? couseid, string couseName, DateTime? courseStartDate, DateTime? courseEndDate, Int64? couseFees)
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();

             int couseidValue = int.MinValue;
             DateTime courseStartDateValue = DateTime.MinValue;
             DateTime courseEndDateValue = DateTime.MinValue;
             Int64 couseFeesValue = Int64.MinValue;

             if (couseid != null)
                couseidValue = couseid.Value;

             if (courseStartDate != null)
                courseStartDateValue = courseStartDate.Value;

             if (courseEndDate != null)
                courseEndDateValue = courseEndDate.Value;

             if (couseFees != null)
                couseFeesValue = couseFees.Value;

             return context.Couse
                 .Where(c =>
                           (couseid != null ? c.Couseid == couseidValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(couseName) ? c.CouseName.Contains(couseName) : 1 == 1) &&
                           (courseStartDate != null ? c.CourseStartDate == courseStartDateValue : 1 == 1) &&
                           (courseEndDate != null ? c.CourseEndDate == courseEndDateValue : 1 == 1) &&
                           (couseFees != null ? c.CouseFees == couseFeesValue : 1 == 1) 
                       ).ToList();
         }
         /// <summary>
         /// Selects Couseid and CouseName columns for use with a DropDownList web control
         /// </summary>
         internal static List<Couse> SelectCouseDropDownListData()
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();
             return (from c in context.Couse
                     select new Couse { Couseid = c.Couseid, CouseName = c.CouseName }).ToList();
         }
         /// <summary>
         /// Inserts a record
         /// </summary>
         internal static int Insert(Couse objCouse)
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();
             Couse entCouse = new Couse();

             entCouse.CouseName = objCouse.CouseName;
             entCouse.CourseStartDate = objCouse.CourseStartDate;
             entCouse.CourseEndDate = objCouse.CourseEndDate;
             entCouse.CouseFees = objCouse.CouseFees;

             context.Couse.Add(entCouse);
             context.SaveChanges();

             return entCouse.Couseid;
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         internal static void Update(Couse objCouse)
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();
             Couse entCouse = context.Couse.Where(c => c.Couseid == objCouse.Couseid).FirstOrDefault();

             if (entCouse != null)
             {
                 entCouse.CouseName = objCouse.CouseName;
                 entCouse.CourseStartDate = objCouse.CourseStartDate;
                 entCouse.CourseEndDate = objCouse.CourseEndDate;
                 entCouse.CouseFees = objCouse.CouseFees;

                 context.SaveChanges();
             }
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         internal static void Delete(int couseid)
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();
             var objCouse = context.Couse.Where(c => c.Couseid == couseid).FirstOrDefault();

             if (objCouse != null)
             {
                 context.Couse.Remove(objCouse);
                 context.SaveChanges();
             }
         }
     }
}
