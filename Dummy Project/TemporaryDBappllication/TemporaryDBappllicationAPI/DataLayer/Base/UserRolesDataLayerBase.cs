using TemporaryDBappllicationAPI.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TemporaryDBappllicationAPI.DataLayer.Base
{
     /// <summary>
     /// Base class for UserRolesDataLayer.  Do not make changes to this class,
     /// instead, put additional code in the UserRolesDataLayer class
     /// </summary>
     internal class UserRolesDataLayerBase
     {
         // constructor
         internal UserRolesDataLayerBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         internal static UserRoles SelectByPrimaryKey(int userRoleId)
         {
             FirstTempdbContext context = new FirstTempdbContext();
             return context.UserRoles.Where(u => u.UserRoleId == userRoleId).FirstOrDefault();
         }

         /// <summary>
         /// Gets the total number of records in the UserRoles table
         /// </summary>
         internal static int GetRecordCount()
         {
             FirstTempdbContext context = new FirstTempdbContext();
             return context.UserRoles.Count();
         }

         /// <summary>
         /// Gets the total number of records in the UserRoles table by UserId
         /// </summary>
         internal static int GetRecordCountByUserId(int userId)
         {
             FirstTempdbContext context = new FirstTempdbContext();
             return context.UserRoles.Where(u => u.UserId == userId).Count();
         }

         /// <summary>
         /// Gets the total number of records in the UserRoles table by RoleId
         /// </summary>
         internal static int GetRecordCountByRoleId(int roleId)
         {
             FirstTempdbContext context = new FirstTempdbContext();
             return context.UserRoles.Where(u => u.RoleId == roleId).Count();
         }

         /// <summary>
         /// Gets the total number of records in the UserRoles table based on search parameters
         /// </summary>
         internal static int GetRecordCountDynamicWhere(int? userRoleId, int? userId, int? roleId, bool? status)
         {
             FirstTempdbContext context = new FirstTempdbContext();

             int userRoleIdValue = int.MinValue;
             int userIdValue = int.MinValue;
             int roleIdValue = int.MinValue;
             bool statusValue = false;

             if (userRoleId != null)
                userRoleIdValue = userRoleId.Value;

             if (userId != null)
                userIdValue = userId.Value;

             if (roleId != null)
                roleIdValue = roleId.Value;

             if (status != null)
                statusValue = status.Value;

             return context.UserRoles
                 .Where(u =>
                           (userRoleId != null ? u.UserRoleId == userRoleIdValue : 1 == 1) &&
                           (userId != null ? u.UserId == userIdValue : 1 == 1) &&
                           (roleId != null ? u.RoleId == roleIdValue : 1 == 1) &&
                           (status != null ? u.Status == statusValue : 1 == 1) 
                       ).Count();
         }

         /// <summary>
         /// Selects UserRoles records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
         /// </summary>
         internal static List<UserRoles> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows, bool isIncludeRelatedProperties = true)
         {
             FirstTempdbContext context = new FirstTempdbContext();

             if (!isIncludeRelatedProperties)
             {
                 if (sortByExpression.Contains(" desc"))
                 {
                     switch (sortByExpression)
                     {
                         case "UserId desc":
                             return context.UserRoles.OrderByDescending(u => u.UserId).Skip(startRowIndex).Take(rows).ToList();
                         case "RoleId desc":
                             return context.UserRoles.OrderByDescending(u => u.RoleId).Skip(startRowIndex).Take(rows).ToList();
                         case "Status desc":
                             return context.UserRoles.OrderByDescending(u => u.Status).Skip(startRowIndex).Take(rows).ToList();
                         default:
                             return context.UserRoles.OrderByDescending(u => u.UserRoleId).Skip(startRowIndex).Take(rows).ToList();
                     }
                 }
                 else
                 {
                     switch (sortByExpression)
                     {
                         case "UserId":
                             return context.UserRoles.OrderBy(u => u.UserId).Skip(startRowIndex).Take(rows).ToList();
                         case "RoleId":
                             return context.UserRoles.OrderBy(u => u.RoleId).Skip(startRowIndex).Take(rows).ToList();
                         case "Status":
                             return context.UserRoles.OrderBy(u => u.Status).Skip(startRowIndex).Take(rows).ToList();
                         default:
                             return context.UserRoles.OrderBy(u => u.UserRoleId).Skip(startRowIndex).Take(rows).ToList();
                     }
                 }
             }
             else
             {
                 if (sortByExpression.Contains(" desc"))
                 {
                     switch (sortByExpression)
                     {
                         case "UserId desc":
                             return context.UserRoles.Include(u => u.UserMaster).Include(u => u.RoleMaster).OrderByDescending(u => u.UserId).Skip(startRowIndex).Take(rows).ToList();
                         case "RoleId desc":
                             return context.UserRoles.Include(u => u.UserMaster).Include(u => u.RoleMaster).OrderByDescending(u => u.RoleId).Skip(startRowIndex).Take(rows).ToList();
                         case "Status desc":
                             return context.UserRoles.Include(u => u.UserMaster).Include(u => u.RoleMaster).OrderByDescending(u => u.Status).Skip(startRowIndex).Take(rows).ToList();
                         default:
                             return context.UserRoles.Include(u => u.UserMaster).Include(u => u.RoleMaster).OrderByDescending(u => u.UserRoleId).Skip(startRowIndex).Take(rows).ToList();
                     }
                 }
                 else
                 {
                     switch (sortByExpression)
                     {
                         case "UserId":
                             return context.UserRoles.Include(u => u.UserMaster).Include(u => u.RoleMaster).OrderBy(u => u.UserId).Skip(startRowIndex).Take(rows).ToList();
                         case "RoleId":
                             return context.UserRoles.Include(u => u.UserMaster).Include(u => u.RoleMaster).OrderBy(u => u.RoleId).Skip(startRowIndex).Take(rows).ToList();
                         case "Status":
                             return context.UserRoles.Include(u => u.UserMaster).Include(u => u.RoleMaster).OrderBy(u => u.Status).Skip(startRowIndex).Take(rows).ToList();
                         default:
                             return context.UserRoles.Include(u => u.UserMaster).Include(u => u.RoleMaster).OrderBy(u => u.UserRoleId).Skip(startRowIndex).Take(rows).ToList();
                     }
                 }
             }
         }

         /// <summary>
         /// Selects records by UserId as a collection (List) of UserRoles sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         internal static List<UserRoles> SelectSkipAndTakeByUserId(string sortByExpression, int startRowIndex, int rows, int userId)
         {
             FirstTempdbContext context = new FirstTempdbContext();

             if (sortByExpression.Contains(" desc"))
             {
                 switch (sortByExpression)
                 {
                     case "UserId desc":
                         return context.UserRoles.Where(u => u.UserId == userId).OrderByDescending(u => u.UserId).Skip(startRowIndex).Take(rows).ToList();
                     case "RoleId desc":
                         return context.UserRoles.Where(u => u.UserId == userId).OrderByDescending(u => u.RoleId).Skip(startRowIndex).Take(rows).ToList();
                     case "Status desc":
                         return context.UserRoles.Where(u => u.UserId == userId).OrderByDescending(u => u.Status).Skip(startRowIndex).Take(rows).ToList();
                     default:
                         return context.UserRoles.Where(u => u.UserId == userId).OrderByDescending(u => u.UserRoleId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
             else
             {
                 switch (sortByExpression)
                 {
                     case "UserId":
                         return context.UserRoles.Where(u => u.UserId == userId).OrderBy(u => u.UserId).Skip(startRowIndex).Take(rows).ToList();
                     case "RoleId":
                         return context.UserRoles.Where(u => u.UserId == userId).OrderBy(u => u.RoleId).Skip(startRowIndex).Take(rows).ToList();
                     case "Status":
                         return context.UserRoles.Where(u => u.UserId == userId).OrderBy(u => u.Status).Skip(startRowIndex).Take(rows).ToList();
                     default:
                         return context.UserRoles.Where(u => u.UserId == userId).OrderBy(u => u.UserRoleId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
         }

         /// <summary>
         /// Selects records by RoleId as a collection (List) of UserRoles sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         internal static List<UserRoles> SelectSkipAndTakeByRoleId(string sortByExpression, int startRowIndex, int rows, int roleId)
         {
             FirstTempdbContext context = new FirstTempdbContext();

             if (sortByExpression.Contains(" desc"))
             {
                 switch (sortByExpression)
                 {
                     case "UserId desc":
                         return context.UserRoles.Where(u => u.RoleId == roleId).OrderByDescending(u => u.UserId).Skip(startRowIndex).Take(rows).ToList();
                     case "RoleId desc":
                         return context.UserRoles.Where(u => u.RoleId == roleId).OrderByDescending(u => u.RoleId).Skip(startRowIndex).Take(rows).ToList();
                     case "Status desc":
                         return context.UserRoles.Where(u => u.RoleId == roleId).OrderByDescending(u => u.Status).Skip(startRowIndex).Take(rows).ToList();
                     default:
                         return context.UserRoles.Where(u => u.RoleId == roleId).OrderByDescending(u => u.UserRoleId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
             else
             {
                 switch (sortByExpression)
                 {
                     case "UserId":
                         return context.UserRoles.Where(u => u.RoleId == roleId).OrderBy(u => u.UserId).Skip(startRowIndex).Take(rows).ToList();
                     case "RoleId":
                         return context.UserRoles.Where(u => u.RoleId == roleId).OrderBy(u => u.RoleId).Skip(startRowIndex).Take(rows).ToList();
                     case "Status":
                         return context.UserRoles.Where(u => u.RoleId == roleId).OrderBy(u => u.Status).Skip(startRowIndex).Take(rows).ToList();
                     default:
                         return context.UserRoles.Where(u => u.RoleId == roleId).OrderBy(u => u.UserRoleId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
         }

         /// <summary>
         /// Selects UserRoles records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
         /// </summary>
         internal static List<UserRoles> SelectSkipAndTakeDynamicWhere(int? userRoleId, int? userId, int? roleId, bool? status, string sortByExpression, int startRowIndex, int rows)
         {
             FirstTempdbContext context = new FirstTempdbContext();

             int userRoleIdValue = int.MinValue;
             int userIdValue = int.MinValue;
             int roleIdValue = int.MinValue;
             bool statusValue = false;

             if (userRoleId != null)
                userRoleIdValue = userRoleId.Value;

             if (userId != null)
                userIdValue = userId.Value;

             if (roleId != null)
                roleIdValue = roleId.Value;

             if (status != null)
                statusValue = status.Value;

             if (sortByExpression.Contains(" desc"))
             {
                 switch (sortByExpression)
                 {
                     case "UserId desc":
                         return context.UserRoles
                             .Where(u =>
                                       (userRoleId != null ? u.UserRoleId == userRoleIdValue : 1 == 1) &&
                                       (userId != null ? u.UserId == userIdValue : 1 == 1) &&
                                       (roleId != null ? u.RoleId == roleIdValue : 1 == 1) &&
                                       (status != null ? u.Status == statusValue : 1 == 1) 
                                   ).OrderByDescending(u => u.UserId).Skip(startRowIndex).Take(rows).ToList();

                     case "RoleId desc":
                         return context.UserRoles
                             .Where(u =>
                                       (userRoleId != null ? u.UserRoleId == userRoleIdValue : 1 == 1) &&
                                       (userId != null ? u.UserId == userIdValue : 1 == 1) &&
                                       (roleId != null ? u.RoleId == roleIdValue : 1 == 1) &&
                                       (status != null ? u.Status == statusValue : 1 == 1) 
                                   ).OrderByDescending(u => u.RoleId).Skip(startRowIndex).Take(rows).ToList();

                     case "Status desc":
                         return context.UserRoles
                             .Where(u =>
                                       (userRoleId != null ? u.UserRoleId == userRoleIdValue : 1 == 1) &&
                                       (userId != null ? u.UserId == userIdValue : 1 == 1) &&
                                       (roleId != null ? u.RoleId == roleIdValue : 1 == 1) &&
                                       (status != null ? u.Status == statusValue : 1 == 1) 
                                   ).OrderByDescending(u => u.Status).Skip(startRowIndex).Take(rows).ToList();

                     default:
                         return context.UserRoles
                             .Where(u =>
                                       (userRoleId != null ? u.UserRoleId == userRoleIdValue : 1 == 1) &&
                                       (userId != null ? u.UserId == userIdValue : 1 == 1) &&
                                       (roleId != null ? u.RoleId == roleIdValue : 1 == 1) &&
                                       (status != null ? u.Status == statusValue : 1 == 1) 
                                   ).OrderByDescending(u => u.UserRoleId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
             else
             {
                 switch (sortByExpression)
                 {
                     case "UserId":
                         return context.UserRoles
                             .Where(u =>
                                       (userRoleId != null ? u.UserRoleId == userRoleIdValue : 1 == 1) &&
                                       (userId != null ? u.UserId == userIdValue : 1 == 1) &&
                                       (roleId != null ? u.RoleId == roleIdValue : 1 == 1) &&
                                       (status != null ? u.Status == statusValue : 1 == 1) 
                                   ).OrderBy(u => u.UserId).Skip(startRowIndex).Take(rows).ToList();

                     case "RoleId":
                         return context.UserRoles
                             .Where(u =>
                                       (userRoleId != null ? u.UserRoleId == userRoleIdValue : 1 == 1) &&
                                       (userId != null ? u.UserId == userIdValue : 1 == 1) &&
                                       (roleId != null ? u.RoleId == roleIdValue : 1 == 1) &&
                                       (status != null ? u.Status == statusValue : 1 == 1) 
                                   ).OrderBy(u => u.RoleId).Skip(startRowIndex).Take(rows).ToList();

                     case "Status":
                         return context.UserRoles
                             .Where(u =>
                                       (userRoleId != null ? u.UserRoleId == userRoleIdValue : 1 == 1) &&
                                       (userId != null ? u.UserId == userIdValue : 1 == 1) &&
                                       (roleId != null ? u.RoleId == roleIdValue : 1 == 1) &&
                                       (status != null ? u.Status == statusValue : 1 == 1) 
                                   ).OrderBy(u => u.Status).Skip(startRowIndex).Take(rows).ToList();

                     default:
                         return context.UserRoles
                             .Where(u =>
                                       (userRoleId != null ? u.UserRoleId == userRoleIdValue : 1 == 1) &&
                                       (userId != null ? u.UserId == userIdValue : 1 == 1) &&
                                       (roleId != null ? u.RoleId == roleIdValue : 1 == 1) &&
                                       (status != null ? u.Status == statusValue : 1 == 1) 
                                   ).OrderBy(u => u.UserRoleId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
         }

         /// <summary>
         /// Selects all UserRoles
         /// </summary>
         internal static List<UserRoles> SelectAll()
         {
             FirstTempdbContext context = new FirstTempdbContext();
             return context.UserRoles.ToList();
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of UserRoles.
         /// </summary>
         internal static List<UserRoles> SelectAllDynamicWhere(int? userRoleId, int? userId, int? roleId, bool? status)
         {
             FirstTempdbContext context = new FirstTempdbContext();

             int userRoleIdValue = int.MinValue;
             int userIdValue = int.MinValue;
             int roleIdValue = int.MinValue;
             bool statusValue = false;

             if (userRoleId != null)
                userRoleIdValue = userRoleId.Value;

             if (userId != null)
                userIdValue = userId.Value;

             if (roleId != null)
                roleIdValue = roleId.Value;

             if (status != null)
                statusValue = status.Value;

             return context.UserRoles
                 .Where(u =>
                           (userRoleId != null ? u.UserRoleId == userRoleIdValue : 1 == 1) &&
                           (userId != null ? u.UserId == userIdValue : 1 == 1) &&
                           (roleId != null ? u.RoleId == roleIdValue : 1 == 1) &&
                           (status != null ? u.Status == statusValue : 1 == 1) 
                       ).ToList();
         }

         /// <summary>
         /// Selects all UserRoles by UserMaster, related to column UserId
         /// </summary>
         internal static List<UserRoles> SelectUserRolesCollectionByUserId(int userId)
         {
             FirstTempdbContext context = new FirstTempdbContext();
             return context.UserRoles.Where(u => u.UserId == userId).ToList();
         }

         /// <summary>
         /// Selects all UserRoles by RoleMaster, related to column RoleId
         /// </summary>
         internal static List<UserRoles> SelectUserRolesCollectionByRoleId(int roleId)
         {
             FirstTempdbContext context = new FirstTempdbContext();
             return context.UserRoles.Where(u => u.RoleId == roleId).ToList();
         }
         /// <summary>
         /// Selects UserRoleId and Status columns for use with a DropDownList web control
         /// </summary>
         internal static List<UserRoles> SelectUserRolesDropDownListData()
         {
             FirstTempdbContext context = new FirstTempdbContext();
             return (from u in context.UserRoles
                     select new UserRoles { UserRoleId = u.UserRoleId, Status = u.Status }).ToList();
         }
         /// <summary>
         /// Inserts a record
         /// </summary>
         internal static int Insert(UserRoles objUserRoles)
         {
             FirstTempdbContext context = new FirstTempdbContext();
             UserRoles entUserRoles = new UserRoles();

             entUserRoles.UserId = objUserRoles.UserId;
             entUserRoles.RoleId = objUserRoles.RoleId;
             entUserRoles.Status = objUserRoles.Status;

             context.UserRoles.Add(entUserRoles);
             context.SaveChanges();

             return entUserRoles.UserRoleId;
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         internal static void Update(UserRoles objUserRoles)
         {
             FirstTempdbContext context = new FirstTempdbContext();
             UserRoles entUserRoles = context.UserRoles.Where(u => u.UserRoleId == objUserRoles.UserRoleId).FirstOrDefault();

             if (entUserRoles != null)
             {
                 entUserRoles.UserId = objUserRoles.UserId;
                 entUserRoles.RoleId = objUserRoles.RoleId;
                 entUserRoles.Status = objUserRoles.Status;

                 context.SaveChanges();
             }
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         internal static void Delete(int userRoleId)
         {
             FirstTempdbContext context = new FirstTempdbContext();
             var objUserRoles = context.UserRoles.Where(u => u.UserRoleId == userRoleId).FirstOrDefault();

             if (objUserRoles != null)
             {
                 context.UserRoles.Remove(objUserRoles);
                 context.SaveChanges();
             }
         }
     }
}
