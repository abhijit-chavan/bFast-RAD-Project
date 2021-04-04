using StudentEnquiryAPI.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace StudentEnquiryAPI.DataLayer.Base
{
     /// <summary>
     /// Base class for LoginTableDataLayer.  Do not make changes to this class,
     /// instead, put additional code in the LoginTableDataLayer class
     /// </summary>
     internal class LoginTableDataLayerBase
     {
         // constructor
         internal LoginTableDataLayerBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         internal static LoginTable SelectByPrimaryKey(int adminid)
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();
             return context.LoginTable.Where(l => l.Adminid == adminid).FirstOrDefault();
         }

         /// <summary>
         /// Gets the total number of records in the LoginTable table
         /// </summary>
         internal static int GetRecordCount()
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();
             return context.LoginTable.Count();
         }

         /// <summary>
         /// Gets the total number of records in the LoginTable table based on search parameters
         /// </summary>
         internal static int GetRecordCountDynamicWhere(int? adminid, string password)
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();

             int adminidValue = int.MinValue;

             if (adminid != null)
                adminidValue = adminid.Value;

             return context.LoginTable
                 .Where(l =>
                           (adminid != null ? l.Adminid == adminidValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(password) ? l.Password.Contains(password) : 1 == 1) 
                       ).Count();
         }

         /// <summary>
         /// Selects LoginTable records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
         /// </summary>
         internal static List<LoginTable> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();

             if (sortByExpression.Contains(" desc"))
             {
                     switch (sortByExpression)
                     {
                         case "Password desc":
                             return context.LoginTable.OrderByDescending(l => l.Password).Skip(startRowIndex).Take(rows).ToList();
                         default:
                             return context.LoginTable.OrderByDescending(l => l.Adminid).Skip(startRowIndex).Take(rows).ToList();
                     }
             }
             else
             {
                     switch (sortByExpression)
                     {
                         case "Password":
                             return context.LoginTable.OrderBy(l => l.Password).Skip(startRowIndex).Take(rows).ToList();
                         default:
                             return context.LoginTable.OrderBy(l => l.Adminid).Skip(startRowIndex).Take(rows).ToList();
                     }
             }
         }

         /// <summary>
         /// Selects LoginTable records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
         /// </summary>
         internal static List<LoginTable> SelectSkipAndTakeDynamicWhere(int? adminid, string password, string sortByExpression, int startRowIndex, int rows)
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();

             int adminidValue = int.MinValue;

             if (adminid != null)
                adminidValue = adminid.Value;

             if (sortByExpression.Contains(" desc"))
             {
                 switch (sortByExpression)
                 {
                     case "Password desc":
                         return context.LoginTable
                             .Where(l =>
                                       (adminid != null ? l.Adminid == adminidValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(password) ? l.Password.Contains(password) : 1 == 1) 
                                   ).OrderByDescending(l => l.Password).Skip(startRowIndex).Take(rows).ToList();

                     default:
                         return context.LoginTable
                             .Where(l =>
                                       (adminid != null ? l.Adminid == adminidValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(password) ? l.Password.Contains(password) : 1 == 1) 
                                   ).OrderByDescending(l => l.Adminid).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
             else
             {
                 switch (sortByExpression)
                 {
                     case "Password":
                         return context.LoginTable
                             .Where(l =>
                                       (adminid != null ? l.Adminid == adminidValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(password) ? l.Password.Contains(password) : 1 == 1) 
                                   ).OrderBy(l => l.Password).Skip(startRowIndex).Take(rows).ToList();

                     default:
                         return context.LoginTable
                             .Where(l =>
                                       (adminid != null ? l.Adminid == adminidValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(password) ? l.Password.Contains(password) : 1 == 1) 
                                   ).OrderBy(l => l.Adminid).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
         }

         /// <summary>
         /// Selects all LoginTable
         /// </summary>
         internal static List<LoginTable> SelectAll()
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();
             return context.LoginTable.ToList();
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of LoginTable.
         /// </summary>
         internal static List<LoginTable> SelectAllDynamicWhere(int? adminid, string password)
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();

             int adminidValue = int.MinValue;

             if (adminid != null)
                adminidValue = adminid.Value;

             return context.LoginTable
                 .Where(l =>
                           (adminid != null ? l.Adminid == adminidValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(password) ? l.Password.Contains(password) : 1 == 1) 
                       ).ToList();
         }
         /// <summary>
         /// Selects Adminid and Password columns for use with a DropDownList web control
         /// </summary>
         internal static List<LoginTable> SelectLoginTableDropDownListData()
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();
             return (from l in context.LoginTable
                     select new LoginTable { Adminid = l.Adminid, Password = l.Password }).ToList();
         }
         /// <summary>
         /// Inserts a record
         /// </summary>
         internal static int Insert(LoginTable objLoginTable)
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();
             LoginTable entLoginTable = new LoginTable();

             entLoginTable.Password = objLoginTable.Password;

             context.LoginTable.Add(entLoginTable);
             context.SaveChanges();

             return entLoginTable.Adminid;
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         internal static void Update(LoginTable objLoginTable)
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();
             LoginTable entLoginTable = context.LoginTable.Where(l => l.Adminid == objLoginTable.Adminid).FirstOrDefault();

             if (entLoginTable != null)
             {
                 entLoginTable.Password = objLoginTable.Password;

                 context.SaveChanges();
             }
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         internal static void Delete(int adminid)
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();
             var objLoginTable = context.LoginTable.Where(l => l.Adminid == adminid).FirstOrDefault();

             if (objLoginTable != null)
             {
                 context.LoginTable.Remove(objLoginTable);
                 context.SaveChanges();
             }
         }
     }
}
