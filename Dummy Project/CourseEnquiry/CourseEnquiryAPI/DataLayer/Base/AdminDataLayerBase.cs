using CourseEnquiryAPI.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CourseEnquiryAPI.DataLayer.Base
{
     /// <summary>
     /// Base class for AdminDataLayer.  Do not make changes to this class,
     /// instead, put additional code in the AdminDataLayer class
     /// </summary>
     internal class AdminDataLayerBase
     {
         // constructor
         internal AdminDataLayerBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         internal static Admin SelectByPrimaryKey(int adminId)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             return context.Admin.Where(a => a.AdminId == adminId).FirstOrDefault();
         }

         /// <summary>
         /// Gets the total number of records in the Admin table
         /// </summary>
         internal static int GetRecordCount()
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             return context.Admin.Count();
         }

         /// <summary>
         /// Gets the total number of records in the Admin table based on search parameters
         /// </summary>
         internal static int GetRecordCountDynamicWhere(int? adminId, string adminName, string adminPassword)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();

             int adminIdValue = int.MinValue;

             if (adminId != null)
                adminIdValue = adminId.Value;

             return context.Admin
                 .Where(a =>
                           (adminId != null ? a.AdminId == adminIdValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(adminName) ? a.AdminName.Contains(adminName) : 1 == 1) &&
                           (!String.IsNullOrEmpty(adminPassword) ? a.AdminPassword.Contains(adminPassword) : 1 == 1) 
                       ).Count();
         }

         /// <summary>
         /// Selects Admin records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
         /// </summary>
         internal static List<Admin> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();

             if (sortByExpression.Contains(" desc"))
             {
                     switch (sortByExpression)
                     {
                         case "AdminName desc":
                             return context.Admin.OrderByDescending(a => a.AdminName).Skip(startRowIndex).Take(rows).ToList();
                         case "AdminPassword desc":
                             return context.Admin.OrderByDescending(a => a.AdminPassword).Skip(startRowIndex).Take(rows).ToList();
                         default:
                             return context.Admin.OrderByDescending(a => a.AdminId).Skip(startRowIndex).Take(rows).ToList();
                     }
             }
             else
             {
                     switch (sortByExpression)
                     {
                         case "AdminName":
                             return context.Admin.OrderBy(a => a.AdminName).Skip(startRowIndex).Take(rows).ToList();
                         case "AdminPassword":
                             return context.Admin.OrderBy(a => a.AdminPassword).Skip(startRowIndex).Take(rows).ToList();
                         default:
                             return context.Admin.OrderBy(a => a.AdminId).Skip(startRowIndex).Take(rows).ToList();
                     }
             }
         }

         /// <summary>
         /// Selects Admin records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
         /// </summary>
         internal static List<Admin> SelectSkipAndTakeDynamicWhere(int? adminId, string adminName, string adminPassword, string sortByExpression, int startRowIndex, int rows)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();

             int adminIdValue = int.MinValue;

             if (adminId != null)
                adminIdValue = adminId.Value;

             if (sortByExpression.Contains(" desc"))
             {
                 switch (sortByExpression)
                 {
                     case "AdminName desc":
                         return context.Admin
                             .Where(a =>
                                       (adminId != null ? a.AdminId == adminIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(adminName) ? a.AdminName.Contains(adminName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(adminPassword) ? a.AdminPassword.Contains(adminPassword) : 1 == 1) 
                                   ).OrderByDescending(a => a.AdminName).Skip(startRowIndex).Take(rows).ToList();

                     case "AdminPassword desc":
                         return context.Admin
                             .Where(a =>
                                       (adminId != null ? a.AdminId == adminIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(adminName) ? a.AdminName.Contains(adminName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(adminPassword) ? a.AdminPassword.Contains(adminPassword) : 1 == 1) 
                                   ).OrderByDescending(a => a.AdminPassword).Skip(startRowIndex).Take(rows).ToList();

                     default:
                         return context.Admin
                             .Where(a =>
                                       (adminId != null ? a.AdminId == adminIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(adminName) ? a.AdminName.Contains(adminName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(adminPassword) ? a.AdminPassword.Contains(adminPassword) : 1 == 1) 
                                   ).OrderByDescending(a => a.AdminId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
             else
             {
                 switch (sortByExpression)
                 {
                     case "AdminName":
                         return context.Admin
                             .Where(a =>
                                       (adminId != null ? a.AdminId == adminIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(adminName) ? a.AdminName.Contains(adminName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(adminPassword) ? a.AdminPassword.Contains(adminPassword) : 1 == 1) 
                                   ).OrderBy(a => a.AdminName).Skip(startRowIndex).Take(rows).ToList();

                     case "AdminPassword":
                         return context.Admin
                             .Where(a =>
                                       (adminId != null ? a.AdminId == adminIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(adminName) ? a.AdminName.Contains(adminName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(adminPassword) ? a.AdminPassword.Contains(adminPassword) : 1 == 1) 
                                   ).OrderBy(a => a.AdminPassword).Skip(startRowIndex).Take(rows).ToList();

                     default:
                         return context.Admin
                             .Where(a =>
                                       (adminId != null ? a.AdminId == adminIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(adminName) ? a.AdminName.Contains(adminName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(adminPassword) ? a.AdminPassword.Contains(adminPassword) : 1 == 1) 
                                   ).OrderBy(a => a.AdminId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
         }

         /// <summary>
         /// Selects all Admin
         /// </summary>
         internal static List<Admin> SelectAll()
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             return context.Admin.ToList();
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of Admin.
         /// </summary>
         internal static List<Admin> SelectAllDynamicWhere(int? adminId, string adminName, string adminPassword)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();

             int adminIdValue = int.MinValue;

             if (adminId != null)
                adminIdValue = adminId.Value;

             return context.Admin
                 .Where(a =>
                           (adminId != null ? a.AdminId == adminIdValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(adminName) ? a.AdminName.Contains(adminName) : 1 == 1) &&
                           (!String.IsNullOrEmpty(adminPassword) ? a.AdminPassword.Contains(adminPassword) : 1 == 1) 
                       ).ToList();
         }
         /// <summary>
         /// Selects AdminId and AdminName columns for use with a DropDownList web control
         /// </summary>
         internal static List<Admin> SelectAdminDropDownListData()
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             return (from a in context.Admin
                     select new Admin { AdminId = a.AdminId, AdminName = a.AdminName }).ToList();
         }
         /// <summary>
         /// Inserts a record
         /// </summary>
         internal static int Insert(Admin objAdmin)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             Admin entAdmin = new Admin();

             entAdmin.AdminName = objAdmin.AdminName;
             entAdmin.AdminPassword = objAdmin.AdminPassword;

             context.Admin.Add(entAdmin);
             context.SaveChanges();

             return entAdmin.AdminId;
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         internal static void Update(Admin objAdmin)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             Admin entAdmin = context.Admin.Where(a => a.AdminId == objAdmin.AdminId).FirstOrDefault();

             if (entAdmin != null)
             {
                 entAdmin.AdminName = objAdmin.AdminName;
                 entAdmin.AdminPassword = objAdmin.AdminPassword;

                 context.SaveChanges();
             }
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         internal static void Delete(int adminId)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             var objAdmin = context.Admin.Where(a => a.AdminId == adminId).FirstOrDefault();

             if (objAdmin != null)
             {
                 context.Admin.Remove(objAdmin);
                 context.SaveChanges();
             }
         }
     }
}
