using CourseEnquiryAPI.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CourseEnquiryAPI.DataLayer.Base
{
     /// <summary>
     /// Base class for UserMasterDataLayer.  Do not make changes to this class,
     /// instead, put additional code in the UserMasterDataLayer class
     /// </summary>
     internal class UserMasterDataLayerBase
     {
         // constructor
         internal UserMasterDataLayerBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         internal static UserMaster SelectByPrimaryKey(int userId)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             return context.UserMaster.Where(u => u.UserId == userId).FirstOrDefault();
         }

         /// <summary>
         /// Gets the total number of records in the UserMaster table
         /// </summary>
         internal static int GetRecordCount()
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             return context.UserMaster.Count();
         }

         /// <summary>
         /// Gets the total number of records in the UserMaster table based on search parameters
         /// </summary>
         internal static int GetRecordCountDynamicWhere(int? userId, string userName, string password, string email, DateTime? createdOn, string createdBy, DateTime? modifiedOn, string modifiedBy)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();

             int userIdValue = int.MinValue;
             DateTime createdOnValue = DateTime.MinValue;
             DateTime? modifiedOnValue = null;

             if (userId != null)
                userIdValue = userId.Value;

             if (createdOn != null)
                createdOnValue = createdOn.Value;

             if (modifiedOn != null)
                modifiedOnValue = modifiedOn.Value;

             return context.UserMaster
                 .Where(u =>
                           (userId != null ? u.UserId == userIdValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(userName) ? u.UserName.Contains(userName) : 1 == 1) &&
                           (!String.IsNullOrEmpty(password) ? u.Password.Contains(password) : 1 == 1) &&
                           (!String.IsNullOrEmpty(email) ? u.Email.Contains(email) : 1 == 1) &&
                           (createdOn != null ? u.CreatedOn == createdOnValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(createdBy) ? u.CreatedBy.Contains(createdBy) : 1 == 1) &&
                           (modifiedOn != null ? u.ModifiedOn == modifiedOnValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(modifiedBy) ? u.ModifiedBy.Contains(modifiedBy) : 1 == 1) 
                       ).Count();
         }

         /// <summary>
         /// Selects UserMaster records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
         /// </summary>
         internal static List<UserMaster> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();

             if (sortByExpression.Contains(" desc"))
             {
                     switch (sortByExpression)
                     {
                         case "UserName desc":
                             return context.UserMaster.OrderByDescending(u => u.UserName).Skip(startRowIndex).Take(rows).ToList();
                         case "Password desc":
                             return context.UserMaster.OrderByDescending(u => u.Password).Skip(startRowIndex).Take(rows).ToList();
                         case "Email desc":
                             return context.UserMaster.OrderByDescending(u => u.Email).Skip(startRowIndex).Take(rows).ToList();
                         case "CreatedOn desc":
                             return context.UserMaster.OrderByDescending(u => u.CreatedOn).Skip(startRowIndex).Take(rows).ToList();
                         case "CreatedBy desc":
                             return context.UserMaster.OrderByDescending(u => u.CreatedBy).Skip(startRowIndex).Take(rows).ToList();
                         case "ModifiedOn desc":
                             return context.UserMaster.OrderByDescending(u => u.ModifiedOn).Skip(startRowIndex).Take(rows).ToList();
                         case "ModifiedBy desc":
                             return context.UserMaster.OrderByDescending(u => u.ModifiedBy).Skip(startRowIndex).Take(rows).ToList();
                         default:
                             return context.UserMaster.OrderByDescending(u => u.UserId).Skip(startRowIndex).Take(rows).ToList();
                     }
             }
             else
             {
                     switch (sortByExpression)
                     {
                         case "UserName":
                             return context.UserMaster.OrderBy(u => u.UserName).Skip(startRowIndex).Take(rows).ToList();
                         case "Password":
                             return context.UserMaster.OrderBy(u => u.Password).Skip(startRowIndex).Take(rows).ToList();
                         case "Email":
                             return context.UserMaster.OrderBy(u => u.Email).Skip(startRowIndex).Take(rows).ToList();
                         case "CreatedOn":
                             return context.UserMaster.OrderBy(u => u.CreatedOn).Skip(startRowIndex).Take(rows).ToList();
                         case "CreatedBy":
                             return context.UserMaster.OrderBy(u => u.CreatedBy).Skip(startRowIndex).Take(rows).ToList();
                         case "ModifiedOn":
                             return context.UserMaster.OrderBy(u => u.ModifiedOn).Skip(startRowIndex).Take(rows).ToList();
                         case "ModifiedBy":
                             return context.UserMaster.OrderBy(u => u.ModifiedBy).Skip(startRowIndex).Take(rows).ToList();
                         default:
                             return context.UserMaster.OrderBy(u => u.UserId).Skip(startRowIndex).Take(rows).ToList();
                     }
             }
         }

         /// <summary>
         /// Selects UserMaster records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
         /// </summary>
         internal static List<UserMaster> SelectSkipAndTakeDynamicWhere(int? userId, string userName, string password, string email, DateTime? createdOn, string createdBy, DateTime? modifiedOn, string modifiedBy, string sortByExpression, int startRowIndex, int rows)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();

             int userIdValue = int.MinValue;
             DateTime createdOnValue = DateTime.MinValue;
             DateTime? modifiedOnValue = null;

             if (userId != null)
                userIdValue = userId.Value;

             if (createdOn != null)
                createdOnValue = createdOn.Value;

             if (modifiedOn != null)
                modifiedOnValue = modifiedOn.Value;

             if (sortByExpression.Contains(" desc"))
             {
                 switch (sortByExpression)
                 {
                     case "UserName desc":
                         return context.UserMaster
                             .Where(u =>
                                       (userId != null ? u.UserId == userIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(userName) ? u.UserName.Contains(userName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(password) ? u.Password.Contains(password) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(email) ? u.Email.Contains(email) : 1 == 1) &&
                                       (createdOn != null ? u.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? u.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (modifiedOn != null ? u.ModifiedOn == modifiedOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(modifiedBy) ? u.ModifiedBy.Contains(modifiedBy) : 1 == 1) 
                                   ).OrderByDescending(u => u.UserName).Skip(startRowIndex).Take(rows).ToList();

                     case "Password desc":
                         return context.UserMaster
                             .Where(u =>
                                       (userId != null ? u.UserId == userIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(userName) ? u.UserName.Contains(userName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(password) ? u.Password.Contains(password) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(email) ? u.Email.Contains(email) : 1 == 1) &&
                                       (createdOn != null ? u.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? u.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (modifiedOn != null ? u.ModifiedOn == modifiedOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(modifiedBy) ? u.ModifiedBy.Contains(modifiedBy) : 1 == 1) 
                                   ).OrderByDescending(u => u.Password).Skip(startRowIndex).Take(rows).ToList();

                     case "Email desc":
                         return context.UserMaster
                             .Where(u =>
                                       (userId != null ? u.UserId == userIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(userName) ? u.UserName.Contains(userName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(password) ? u.Password.Contains(password) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(email) ? u.Email.Contains(email) : 1 == 1) &&
                                       (createdOn != null ? u.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? u.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (modifiedOn != null ? u.ModifiedOn == modifiedOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(modifiedBy) ? u.ModifiedBy.Contains(modifiedBy) : 1 == 1) 
                                   ).OrderByDescending(u => u.Email).Skip(startRowIndex).Take(rows).ToList();

                     case "CreatedOn desc":
                         return context.UserMaster
                             .Where(u =>
                                       (userId != null ? u.UserId == userIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(userName) ? u.UserName.Contains(userName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(password) ? u.Password.Contains(password) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(email) ? u.Email.Contains(email) : 1 == 1) &&
                                       (createdOn != null ? u.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? u.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (modifiedOn != null ? u.ModifiedOn == modifiedOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(modifiedBy) ? u.ModifiedBy.Contains(modifiedBy) : 1 == 1) 
                                   ).OrderByDescending(u => u.CreatedOn).Skip(startRowIndex).Take(rows).ToList();

                     case "CreatedBy desc":
                         return context.UserMaster
                             .Where(u =>
                                       (userId != null ? u.UserId == userIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(userName) ? u.UserName.Contains(userName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(password) ? u.Password.Contains(password) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(email) ? u.Email.Contains(email) : 1 == 1) &&
                                       (createdOn != null ? u.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? u.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (modifiedOn != null ? u.ModifiedOn == modifiedOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(modifiedBy) ? u.ModifiedBy.Contains(modifiedBy) : 1 == 1) 
                                   ).OrderByDescending(u => u.CreatedBy).Skip(startRowIndex).Take(rows).ToList();

                     case "ModifiedOn desc":
                         return context.UserMaster
                             .Where(u =>
                                       (userId != null ? u.UserId == userIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(userName) ? u.UserName.Contains(userName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(password) ? u.Password.Contains(password) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(email) ? u.Email.Contains(email) : 1 == 1) &&
                                       (createdOn != null ? u.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? u.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (modifiedOn != null ? u.ModifiedOn == modifiedOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(modifiedBy) ? u.ModifiedBy.Contains(modifiedBy) : 1 == 1) 
                                   ).OrderByDescending(u => u.ModifiedOn).Skip(startRowIndex).Take(rows).ToList();

                     case "ModifiedBy desc":
                         return context.UserMaster
                             .Where(u =>
                                       (userId != null ? u.UserId == userIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(userName) ? u.UserName.Contains(userName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(password) ? u.Password.Contains(password) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(email) ? u.Email.Contains(email) : 1 == 1) &&
                                       (createdOn != null ? u.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? u.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (modifiedOn != null ? u.ModifiedOn == modifiedOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(modifiedBy) ? u.ModifiedBy.Contains(modifiedBy) : 1 == 1) 
                                   ).OrderByDescending(u => u.ModifiedBy).Skip(startRowIndex).Take(rows).ToList();

                     default:
                         return context.UserMaster
                             .Where(u =>
                                       (userId != null ? u.UserId == userIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(userName) ? u.UserName.Contains(userName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(password) ? u.Password.Contains(password) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(email) ? u.Email.Contains(email) : 1 == 1) &&
                                       (createdOn != null ? u.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? u.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (modifiedOn != null ? u.ModifiedOn == modifiedOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(modifiedBy) ? u.ModifiedBy.Contains(modifiedBy) : 1 == 1) 
                                   ).OrderByDescending(u => u.UserId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
             else
             {
                 switch (sortByExpression)
                 {
                     case "UserName":
                         return context.UserMaster
                             .Where(u =>
                                       (userId != null ? u.UserId == userIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(userName) ? u.UserName.Contains(userName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(password) ? u.Password.Contains(password) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(email) ? u.Email.Contains(email) : 1 == 1) &&
                                       (createdOn != null ? u.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? u.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (modifiedOn != null ? u.ModifiedOn == modifiedOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(modifiedBy) ? u.ModifiedBy.Contains(modifiedBy) : 1 == 1) 
                                   ).OrderBy(u => u.UserName).Skip(startRowIndex).Take(rows).ToList();

                     case "Password":
                         return context.UserMaster
                             .Where(u =>
                                       (userId != null ? u.UserId == userIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(userName) ? u.UserName.Contains(userName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(password) ? u.Password.Contains(password) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(email) ? u.Email.Contains(email) : 1 == 1) &&
                                       (createdOn != null ? u.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? u.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (modifiedOn != null ? u.ModifiedOn == modifiedOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(modifiedBy) ? u.ModifiedBy.Contains(modifiedBy) : 1 == 1) 
                                   ).OrderBy(u => u.Password).Skip(startRowIndex).Take(rows).ToList();

                     case "Email":
                         return context.UserMaster
                             .Where(u =>
                                       (userId != null ? u.UserId == userIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(userName) ? u.UserName.Contains(userName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(password) ? u.Password.Contains(password) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(email) ? u.Email.Contains(email) : 1 == 1) &&
                                       (createdOn != null ? u.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? u.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (modifiedOn != null ? u.ModifiedOn == modifiedOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(modifiedBy) ? u.ModifiedBy.Contains(modifiedBy) : 1 == 1) 
                                   ).OrderBy(u => u.Email).Skip(startRowIndex).Take(rows).ToList();

                     case "CreatedOn":
                         return context.UserMaster
                             .Where(u =>
                                       (userId != null ? u.UserId == userIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(userName) ? u.UserName.Contains(userName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(password) ? u.Password.Contains(password) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(email) ? u.Email.Contains(email) : 1 == 1) &&
                                       (createdOn != null ? u.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? u.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (modifiedOn != null ? u.ModifiedOn == modifiedOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(modifiedBy) ? u.ModifiedBy.Contains(modifiedBy) : 1 == 1) 
                                   ).OrderBy(u => u.CreatedOn).Skip(startRowIndex).Take(rows).ToList();

                     case "CreatedBy":
                         return context.UserMaster
                             .Where(u =>
                                       (userId != null ? u.UserId == userIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(userName) ? u.UserName.Contains(userName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(password) ? u.Password.Contains(password) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(email) ? u.Email.Contains(email) : 1 == 1) &&
                                       (createdOn != null ? u.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? u.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (modifiedOn != null ? u.ModifiedOn == modifiedOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(modifiedBy) ? u.ModifiedBy.Contains(modifiedBy) : 1 == 1) 
                                   ).OrderBy(u => u.CreatedBy).Skip(startRowIndex).Take(rows).ToList();

                     case "ModifiedOn":
                         return context.UserMaster
                             .Where(u =>
                                       (userId != null ? u.UserId == userIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(userName) ? u.UserName.Contains(userName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(password) ? u.Password.Contains(password) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(email) ? u.Email.Contains(email) : 1 == 1) &&
                                       (createdOn != null ? u.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? u.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (modifiedOn != null ? u.ModifiedOn == modifiedOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(modifiedBy) ? u.ModifiedBy.Contains(modifiedBy) : 1 == 1) 
                                   ).OrderBy(u => u.ModifiedOn).Skip(startRowIndex).Take(rows).ToList();

                     case "ModifiedBy":
                         return context.UserMaster
                             .Where(u =>
                                       (userId != null ? u.UserId == userIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(userName) ? u.UserName.Contains(userName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(password) ? u.Password.Contains(password) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(email) ? u.Email.Contains(email) : 1 == 1) &&
                                       (createdOn != null ? u.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? u.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (modifiedOn != null ? u.ModifiedOn == modifiedOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(modifiedBy) ? u.ModifiedBy.Contains(modifiedBy) : 1 == 1) 
                                   ).OrderBy(u => u.ModifiedBy).Skip(startRowIndex).Take(rows).ToList();

                     default:
                         return context.UserMaster
                             .Where(u =>
                                       (userId != null ? u.UserId == userIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(userName) ? u.UserName.Contains(userName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(password) ? u.Password.Contains(password) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(email) ? u.Email.Contains(email) : 1 == 1) &&
                                       (createdOn != null ? u.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? u.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (modifiedOn != null ? u.ModifiedOn == modifiedOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(modifiedBy) ? u.ModifiedBy.Contains(modifiedBy) : 1 == 1) 
                                   ).OrderBy(u => u.UserId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
         }

         /// <summary>
         /// Selects all UserMaster
         /// </summary>
         internal static List<UserMaster> SelectAll()
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             return context.UserMaster.ToList();
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of UserMaster.
         /// </summary>
         internal static List<UserMaster> SelectAllDynamicWhere(int? userId, string userName, string password, string email, DateTime? createdOn, string createdBy, DateTime? modifiedOn, string modifiedBy)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();

             int userIdValue = int.MinValue;
             DateTime createdOnValue = DateTime.MinValue;
             DateTime modifiedOnValue = DateTime.MinValue;

             if (userId != null)
                userIdValue = userId.Value;

             if (createdOn != null)
                createdOnValue = createdOn.Value;

             if (modifiedOn != null)
                modifiedOnValue = modifiedOn.Value;

             return context.UserMaster
                 .Where(u =>
                           (userId != null ? u.UserId == userIdValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(userName) ? u.UserName.Contains(userName) : 1 == 1) &&
                           (!String.IsNullOrEmpty(password) ? u.Password.Contains(password) : 1 == 1) &&
                           (!String.IsNullOrEmpty(email) ? u.Email.Contains(email) : 1 == 1) &&
                           (createdOn != null ? u.CreatedOn == createdOnValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(createdBy) ? u.CreatedBy.Contains(createdBy) : 1 == 1) &&
                           (modifiedOn != null ? u.ModifiedOn == modifiedOnValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(modifiedBy) ? u.ModifiedBy.Contains(modifiedBy) : 1 == 1) 
                       ).ToList();
         }
         /// <summary>
         /// Selects UserId and CreatedBy columns for use with a DropDownList web control
         /// </summary>
         internal static List<UserMaster> SelectUserMasterDropDownListData()
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             return (from u in context.UserMaster
                     select new UserMaster { UserId = u.UserId, CreatedBy = u.CreatedBy }).ToList();
         }
         /// <summary>
         /// Inserts a record
         /// </summary>
         internal static int Insert(UserMaster objUserMaster)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             UserMaster entUserMaster = new UserMaster();

             entUserMaster.UserName = objUserMaster.UserName;
             entUserMaster.Password = objUserMaster.Password;
             entUserMaster.Email = objUserMaster.Email;
             entUserMaster.CreatedOn = objUserMaster.CreatedOn;
             entUserMaster.CreatedBy = objUserMaster.CreatedBy;
             entUserMaster.ModifiedOn = objUserMaster.ModifiedOn;
             entUserMaster.ModifiedBy = objUserMaster.ModifiedBy;

             context.UserMaster.Add(entUserMaster);
             context.SaveChanges();

             return entUserMaster.UserId;
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         internal static void Update(UserMaster objUserMaster)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             UserMaster entUserMaster = context.UserMaster.Where(u => u.UserId == objUserMaster.UserId).FirstOrDefault();

             if (entUserMaster != null)
             {
                 entUserMaster.UserName = objUserMaster.UserName;
                 entUserMaster.Password = objUserMaster.Password;
                 entUserMaster.Email = objUserMaster.Email;
                 entUserMaster.CreatedOn = objUserMaster.CreatedOn;
                 entUserMaster.CreatedBy = objUserMaster.CreatedBy;
                 entUserMaster.ModifiedOn = objUserMaster.ModifiedOn;
                 entUserMaster.ModifiedBy = objUserMaster.ModifiedBy;

                 context.SaveChanges();
             }
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         internal static void Delete(int userId)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             var objUserMaster = context.UserMaster.Where(u => u.UserId == userId).FirstOrDefault();

             if (objUserMaster != null)
             {
                 context.UserMaster.Remove(objUserMaster);
                 context.SaveChanges();
             }
         }
     }
}
