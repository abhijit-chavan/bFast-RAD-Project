using fifth_tempDBAPI.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace fifth_tempDBAPI.DataLayer.Base
{
     /// <summary>
     /// Base class for RoleMasterDataLayer.  Do not make changes to this class,
     /// instead, put additional code in the RoleMasterDataLayer class
     /// </summary>
     internal class RoleMasterDataLayerBase
     {
         // constructor
         internal RoleMasterDataLayerBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         internal static RoleMaster SelectByPrimaryKey(int roleId)
         {
             ThirdTempdbContext context = new ThirdTempdbContext();
             return context.RoleMaster.Where(r => r.RoleId == roleId).FirstOrDefault();
         }

         /// <summary>
         /// Gets the total number of records in the RoleMaster table
         /// </summary>
         internal static int GetRecordCount()
         {
             ThirdTempdbContext context = new ThirdTempdbContext();
             return context.RoleMaster.Count();
         }

         /// <summary>
         /// Gets the total number of records in the RoleMaster table based on search parameters
         /// </summary>
         internal static int GetRecordCountDynamicWhere(int? roleId, string roleDescription, DateTime? createdOn, string createdBy, DateTime? modifiedOn, string modifiedBy)
         {
             ThirdTempdbContext context = new ThirdTempdbContext();

             int roleIdValue = int.MinValue;
             DateTime createdOnValue = DateTime.MinValue;
             DateTime? modifiedOnValue = null;

             if (roleId != null)
                roleIdValue = roleId.Value;

             if (createdOn != null)
                createdOnValue = createdOn.Value;

             if (modifiedOn != null)
                modifiedOnValue = modifiedOn.Value;

             return context.RoleMaster
                 .Where(r =>
                           (roleId != null ? r.RoleId == roleIdValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(roleDescription) ? r.RoleDescription.Contains(roleDescription) : 1 == 1) &&
                           (createdOn != null ? r.CreatedOn == createdOnValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(createdBy) ? r.CreatedBy.Contains(createdBy) : 1 == 1) &&
                           (modifiedOn != null ? r.ModifiedOn == modifiedOnValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(modifiedBy) ? r.ModifiedBy.Contains(modifiedBy) : 1 == 1) 
                       ).Count();
         }

         /// <summary>
         /// Selects RoleMaster records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
         /// </summary>
         internal static List<RoleMaster> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
         {
             ThirdTempdbContext context = new ThirdTempdbContext();

             if (sortByExpression.Contains(" desc"))
             {
                     switch (sortByExpression)
                     {
                         case "RoleDescription desc":
                             return context.RoleMaster.OrderByDescending(r => r.RoleDescription).Skip(startRowIndex).Take(rows).ToList();
                         case "CreatedOn desc":
                             return context.RoleMaster.OrderByDescending(r => r.CreatedOn).Skip(startRowIndex).Take(rows).ToList();
                         case "CreatedBy desc":
                             return context.RoleMaster.OrderByDescending(r => r.CreatedBy).Skip(startRowIndex).Take(rows).ToList();
                         case "ModifiedOn desc":
                             return context.RoleMaster.OrderByDescending(r => r.ModifiedOn).Skip(startRowIndex).Take(rows).ToList();
                         case "ModifiedBy desc":
                             return context.RoleMaster.OrderByDescending(r => r.ModifiedBy).Skip(startRowIndex).Take(rows).ToList();
                         default:
                             return context.RoleMaster.OrderByDescending(r => r.RoleId).Skip(startRowIndex).Take(rows).ToList();
                     }
             }
             else
             {
                     switch (sortByExpression)
                     {
                         case "RoleDescription":
                             return context.RoleMaster.OrderBy(r => r.RoleDescription).Skip(startRowIndex).Take(rows).ToList();
                         case "CreatedOn":
                             return context.RoleMaster.OrderBy(r => r.CreatedOn).Skip(startRowIndex).Take(rows).ToList();
                         case "CreatedBy":
                             return context.RoleMaster.OrderBy(r => r.CreatedBy).Skip(startRowIndex).Take(rows).ToList();
                         case "ModifiedOn":
                             return context.RoleMaster.OrderBy(r => r.ModifiedOn).Skip(startRowIndex).Take(rows).ToList();
                         case "ModifiedBy":
                             return context.RoleMaster.OrderBy(r => r.ModifiedBy).Skip(startRowIndex).Take(rows).ToList();
                         default:
                             return context.RoleMaster.OrderBy(r => r.RoleId).Skip(startRowIndex).Take(rows).ToList();
                     }
             }
         }

         /// <summary>
         /// Selects RoleMaster records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
         /// </summary>
         internal static List<RoleMaster> SelectSkipAndTakeDynamicWhere(int? roleId, string roleDescription, DateTime? createdOn, string createdBy, DateTime? modifiedOn, string modifiedBy, string sortByExpression, int startRowIndex, int rows)
         {
             ThirdTempdbContext context = new ThirdTempdbContext();

             int roleIdValue = int.MinValue;
             DateTime createdOnValue = DateTime.MinValue;
             DateTime? modifiedOnValue = null;

             if (roleId != null)
                roleIdValue = roleId.Value;

             if (createdOn != null)
                createdOnValue = createdOn.Value;

             if (modifiedOn != null)
                modifiedOnValue = modifiedOn.Value;

             if (sortByExpression.Contains(" desc"))
             {
                 switch (sortByExpression)
                 {
                     case "RoleDescription desc":
                         return context.RoleMaster
                             .Where(r =>
                                       (roleId != null ? r.RoleId == roleIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(roleDescription) ? r.RoleDescription.Contains(roleDescription) : 1 == 1) &&
                                       (createdOn != null ? r.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? r.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (modifiedOn != null ? r.ModifiedOn == modifiedOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(modifiedBy) ? r.ModifiedBy.Contains(modifiedBy) : 1 == 1) 
                                   ).OrderByDescending(r => r.RoleDescription).Skip(startRowIndex).Take(rows).ToList();

                     case "CreatedOn desc":
                         return context.RoleMaster
                             .Where(r =>
                                       (roleId != null ? r.RoleId == roleIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(roleDescription) ? r.RoleDescription.Contains(roleDescription) : 1 == 1) &&
                                       (createdOn != null ? r.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? r.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (modifiedOn != null ? r.ModifiedOn == modifiedOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(modifiedBy) ? r.ModifiedBy.Contains(modifiedBy) : 1 == 1) 
                                   ).OrderByDescending(r => r.CreatedOn).Skip(startRowIndex).Take(rows).ToList();

                     case "CreatedBy desc":
                         return context.RoleMaster
                             .Where(r =>
                                       (roleId != null ? r.RoleId == roleIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(roleDescription) ? r.RoleDescription.Contains(roleDescription) : 1 == 1) &&
                                       (createdOn != null ? r.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? r.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (modifiedOn != null ? r.ModifiedOn == modifiedOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(modifiedBy) ? r.ModifiedBy.Contains(modifiedBy) : 1 == 1) 
                                   ).OrderByDescending(r => r.CreatedBy).Skip(startRowIndex).Take(rows).ToList();

                     case "ModifiedOn desc":
                         return context.RoleMaster
                             .Where(r =>
                                       (roleId != null ? r.RoleId == roleIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(roleDescription) ? r.RoleDescription.Contains(roleDescription) : 1 == 1) &&
                                       (createdOn != null ? r.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? r.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (modifiedOn != null ? r.ModifiedOn == modifiedOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(modifiedBy) ? r.ModifiedBy.Contains(modifiedBy) : 1 == 1) 
                                   ).OrderByDescending(r => r.ModifiedOn).Skip(startRowIndex).Take(rows).ToList();

                     case "ModifiedBy desc":
                         return context.RoleMaster
                             .Where(r =>
                                       (roleId != null ? r.RoleId == roleIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(roleDescription) ? r.RoleDescription.Contains(roleDescription) : 1 == 1) &&
                                       (createdOn != null ? r.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? r.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (modifiedOn != null ? r.ModifiedOn == modifiedOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(modifiedBy) ? r.ModifiedBy.Contains(modifiedBy) : 1 == 1) 
                                   ).OrderByDescending(r => r.ModifiedBy).Skip(startRowIndex).Take(rows).ToList();

                     default:
                         return context.RoleMaster
                             .Where(r =>
                                       (roleId != null ? r.RoleId == roleIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(roleDescription) ? r.RoleDescription.Contains(roleDescription) : 1 == 1) &&
                                       (createdOn != null ? r.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? r.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (modifiedOn != null ? r.ModifiedOn == modifiedOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(modifiedBy) ? r.ModifiedBy.Contains(modifiedBy) : 1 == 1) 
                                   ).OrderByDescending(r => r.RoleId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
             else
             {
                 switch (sortByExpression)
                 {
                     case "RoleDescription":
                         return context.RoleMaster
                             .Where(r =>
                                       (roleId != null ? r.RoleId == roleIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(roleDescription) ? r.RoleDescription.Contains(roleDescription) : 1 == 1) &&
                                       (createdOn != null ? r.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? r.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (modifiedOn != null ? r.ModifiedOn == modifiedOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(modifiedBy) ? r.ModifiedBy.Contains(modifiedBy) : 1 == 1) 
                                   ).OrderBy(r => r.RoleDescription).Skip(startRowIndex).Take(rows).ToList();

                     case "CreatedOn":
                         return context.RoleMaster
                             .Where(r =>
                                       (roleId != null ? r.RoleId == roleIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(roleDescription) ? r.RoleDescription.Contains(roleDescription) : 1 == 1) &&
                                       (createdOn != null ? r.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? r.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (modifiedOn != null ? r.ModifiedOn == modifiedOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(modifiedBy) ? r.ModifiedBy.Contains(modifiedBy) : 1 == 1) 
                                   ).OrderBy(r => r.CreatedOn).Skip(startRowIndex).Take(rows).ToList();

                     case "CreatedBy":
                         return context.RoleMaster
                             .Where(r =>
                                       (roleId != null ? r.RoleId == roleIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(roleDescription) ? r.RoleDescription.Contains(roleDescription) : 1 == 1) &&
                                       (createdOn != null ? r.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? r.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (modifiedOn != null ? r.ModifiedOn == modifiedOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(modifiedBy) ? r.ModifiedBy.Contains(modifiedBy) : 1 == 1) 
                                   ).OrderBy(r => r.CreatedBy).Skip(startRowIndex).Take(rows).ToList();

                     case "ModifiedOn":
                         return context.RoleMaster
                             .Where(r =>
                                       (roleId != null ? r.RoleId == roleIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(roleDescription) ? r.RoleDescription.Contains(roleDescription) : 1 == 1) &&
                                       (createdOn != null ? r.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? r.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (modifiedOn != null ? r.ModifiedOn == modifiedOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(modifiedBy) ? r.ModifiedBy.Contains(modifiedBy) : 1 == 1) 
                                   ).OrderBy(r => r.ModifiedOn).Skip(startRowIndex).Take(rows).ToList();

                     case "ModifiedBy":
                         return context.RoleMaster
                             .Where(r =>
                                       (roleId != null ? r.RoleId == roleIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(roleDescription) ? r.RoleDescription.Contains(roleDescription) : 1 == 1) &&
                                       (createdOn != null ? r.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? r.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (modifiedOn != null ? r.ModifiedOn == modifiedOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(modifiedBy) ? r.ModifiedBy.Contains(modifiedBy) : 1 == 1) 
                                   ).OrderBy(r => r.ModifiedBy).Skip(startRowIndex).Take(rows).ToList();

                     default:
                         return context.RoleMaster
                             .Where(r =>
                                       (roleId != null ? r.RoleId == roleIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(roleDescription) ? r.RoleDescription.Contains(roleDescription) : 1 == 1) &&
                                       (createdOn != null ? r.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? r.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (modifiedOn != null ? r.ModifiedOn == modifiedOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(modifiedBy) ? r.ModifiedBy.Contains(modifiedBy) : 1 == 1) 
                                   ).OrderBy(r => r.RoleId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
         }

         /// <summary>
         /// Selects all RoleMaster
         /// </summary>
         internal static List<RoleMaster> SelectAll()
         {
             ThirdTempdbContext context = new ThirdTempdbContext();
             return context.RoleMaster.ToList();
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of RoleMaster.
         /// </summary>
         internal static List<RoleMaster> SelectAllDynamicWhere(int? roleId, string roleDescription, DateTime? createdOn, string createdBy, DateTime? modifiedOn, string modifiedBy)
         {
             ThirdTempdbContext context = new ThirdTempdbContext();

             int roleIdValue = int.MinValue;
             DateTime createdOnValue = DateTime.MinValue;
             DateTime modifiedOnValue = DateTime.MinValue;

             if (roleId != null)
                roleIdValue = roleId.Value;

             if (createdOn != null)
                createdOnValue = createdOn.Value;

             if (modifiedOn != null)
                modifiedOnValue = modifiedOn.Value;

             return context.RoleMaster
                 .Where(r =>
                           (roleId != null ? r.RoleId == roleIdValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(roleDescription) ? r.RoleDescription.Contains(roleDescription) : 1 == 1) &&
                           (createdOn != null ? r.CreatedOn == createdOnValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(createdBy) ? r.CreatedBy.Contains(createdBy) : 1 == 1) &&
                           (modifiedOn != null ? r.ModifiedOn == modifiedOnValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(modifiedBy) ? r.ModifiedBy.Contains(modifiedBy) : 1 == 1) 
                       ).ToList();
         }
         /// <summary>
         /// Selects RoleId and CreatedBy columns for use with a DropDownList web control
         /// </summary>
         internal static List<RoleMaster> SelectRoleMasterDropDownListData()
         {
             ThirdTempdbContext context = new ThirdTempdbContext();
             return (from r in context.RoleMaster
                     select new RoleMaster { RoleId = r.RoleId, CreatedBy = r.CreatedBy }).ToList();
         }
         /// <summary>
         /// Inserts a record
         /// </summary>
         internal static int Insert(RoleMaster objRoleMaster)
         {
             ThirdTempdbContext context = new ThirdTempdbContext();
             RoleMaster entRoleMaster = new RoleMaster();

             entRoleMaster.RoleDescription = objRoleMaster.RoleDescription;
             entRoleMaster.CreatedOn = objRoleMaster.CreatedOn;
             entRoleMaster.CreatedBy = objRoleMaster.CreatedBy;
             entRoleMaster.ModifiedOn = objRoleMaster.ModifiedOn;
             entRoleMaster.ModifiedBy = objRoleMaster.ModifiedBy;

             context.RoleMaster.Add(entRoleMaster);
             context.SaveChanges();

             return entRoleMaster.RoleId;
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         internal static void Update(RoleMaster objRoleMaster)
         {
             ThirdTempdbContext context = new ThirdTempdbContext();
             RoleMaster entRoleMaster = context.RoleMaster.Where(r => r.RoleId == objRoleMaster.RoleId).FirstOrDefault();

             if (entRoleMaster != null)
             {
                 entRoleMaster.RoleDescription = objRoleMaster.RoleDescription;
                 entRoleMaster.CreatedOn = objRoleMaster.CreatedOn;
                 entRoleMaster.CreatedBy = objRoleMaster.CreatedBy;
                 entRoleMaster.ModifiedOn = objRoleMaster.ModifiedOn;
                 entRoleMaster.ModifiedBy = objRoleMaster.ModifiedBy;

                 context.SaveChanges();
             }
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         internal static void Delete(int roleId)
         {
             ThirdTempdbContext context = new ThirdTempdbContext();
             var objRoleMaster = context.RoleMaster.Where(r => r.RoleId == roleId).FirstOrDefault();

             if (objRoleMaster != null)
             {
                 context.RoleMaster.Remove(objRoleMaster);
                 context.SaveChanges();
             }
         }
     }
}
