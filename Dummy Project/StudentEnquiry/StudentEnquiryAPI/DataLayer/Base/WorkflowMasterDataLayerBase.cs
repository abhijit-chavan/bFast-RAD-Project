using StudentEnquiryAPI.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace StudentEnquiryAPI.DataLayer.Base
{
     /// <summary>
     /// Base class for WorkflowMasterDataLayer.  Do not make changes to this class,
     /// instead, put additional code in the WorkflowMasterDataLayer class
     /// </summary>
     internal class WorkflowMasterDataLayerBase
     {
         // constructor
         internal WorkflowMasterDataLayerBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         internal static WorkflowMaster SelectByPrimaryKey(int workflowId)
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();
             return context.WorkflowMaster.Where(w => w.WorkflowId == workflowId).FirstOrDefault();
         }

         /// <summary>
         /// Gets the total number of records in the WorkflowMaster table
         /// </summary>
         internal static int GetRecordCount()
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();
             return context.WorkflowMaster.Count();
         }

         /// <summary>
         /// Gets the total number of records in the WorkflowMaster table based on search parameters
         /// </summary>
         internal static int GetRecordCountDynamicWhere(int? workflowId, string workflowName, int? levelOfApprovals, string createdBy, DateTime? createdOn, string updatedby, DateTime? updatedon)
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();

             int workflowIdValue = int.MinValue;
             int levelOfApprovalsValue = int.MinValue;
             DateTime createdOnValue = DateTime.MinValue;
             DateTime updatedonValue = DateTime.MinValue;

             if (workflowId != null)
                workflowIdValue = workflowId.Value;

             if (levelOfApprovals != null)
                levelOfApprovalsValue = levelOfApprovals.Value;

             if (createdOn != null)
                createdOnValue = createdOn.Value;

             if (updatedon != null)
                updatedonValue = updatedon.Value;

             return context.WorkflowMaster
                 .Where(w =>
                           (workflowId != null ? w.WorkflowId == workflowIdValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(workflowName) ? w.WorkflowName.Contains(workflowName) : 1 == 1) &&
                           (levelOfApprovals != null ? w.LevelOfApprovals == levelOfApprovalsValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(createdBy) ? w.CreatedBy.Contains(createdBy) : 1 == 1) &&
                           (createdOn != null ? w.CreatedOn == createdOnValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(updatedby) ? w.Updatedby.Contains(updatedby) : 1 == 1) &&
                           (updatedon != null ? w.Updatedon == updatedonValue : 1 == 1) 
                       ).Count();
         }

         /// <summary>
         /// Selects WorkflowMaster records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
         /// </summary>
         internal static List<WorkflowMaster> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();

             if (sortByExpression.Contains(" desc"))
             {
                     switch (sortByExpression)
                     {
                         case "WorkflowName desc":
                             return context.WorkflowMaster.OrderByDescending(w => w.WorkflowName).Skip(startRowIndex).Take(rows).ToList();
                         case "LevelOfApprovals desc":
                             return context.WorkflowMaster.OrderByDescending(w => w.LevelOfApprovals).Skip(startRowIndex).Take(rows).ToList();
                         case "CreatedBy desc":
                             return context.WorkflowMaster.OrderByDescending(w => w.CreatedBy).Skip(startRowIndex).Take(rows).ToList();
                         case "CreatedOn desc":
                             return context.WorkflowMaster.OrderByDescending(w => w.CreatedOn).Skip(startRowIndex).Take(rows).ToList();
                         case "Updatedby desc":
                             return context.WorkflowMaster.OrderByDescending(w => w.Updatedby).Skip(startRowIndex).Take(rows).ToList();
                         case "Updatedon desc":
                             return context.WorkflowMaster.OrderByDescending(w => w.Updatedon).Skip(startRowIndex).Take(rows).ToList();
                         default:
                             return context.WorkflowMaster.OrderByDescending(w => w.WorkflowId).Skip(startRowIndex).Take(rows).ToList();
                     }
             }
             else
             {
                     switch (sortByExpression)
                     {
                         case "WorkflowName":
                             return context.WorkflowMaster.OrderBy(w => w.WorkflowName).Skip(startRowIndex).Take(rows).ToList();
                         case "LevelOfApprovals":
                             return context.WorkflowMaster.OrderBy(w => w.LevelOfApprovals).Skip(startRowIndex).Take(rows).ToList();
                         case "CreatedBy":
                             return context.WorkflowMaster.OrderBy(w => w.CreatedBy).Skip(startRowIndex).Take(rows).ToList();
                         case "CreatedOn":
                             return context.WorkflowMaster.OrderBy(w => w.CreatedOn).Skip(startRowIndex).Take(rows).ToList();
                         case "Updatedby":
                             return context.WorkflowMaster.OrderBy(w => w.Updatedby).Skip(startRowIndex).Take(rows).ToList();
                         case "Updatedon":
                             return context.WorkflowMaster.OrderBy(w => w.Updatedon).Skip(startRowIndex).Take(rows).ToList();
                         default:
                             return context.WorkflowMaster.OrderBy(w => w.WorkflowId).Skip(startRowIndex).Take(rows).ToList();
                     }
             }
         }

         /// <summary>
         /// Selects WorkflowMaster records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
         /// </summary>
         internal static List<WorkflowMaster> SelectSkipAndTakeDynamicWhere(int? workflowId, string workflowName, int? levelOfApprovals, string createdBy, DateTime? createdOn, string updatedby, DateTime? updatedon, string sortByExpression, int startRowIndex, int rows)
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();

             int workflowIdValue = int.MinValue;
             int levelOfApprovalsValue = int.MinValue;
             DateTime createdOnValue = DateTime.MinValue;
             DateTime updatedonValue = DateTime.MinValue;

             if (workflowId != null)
                workflowIdValue = workflowId.Value;

             if (levelOfApprovals != null)
                levelOfApprovalsValue = levelOfApprovals.Value;

             if (createdOn != null)
                createdOnValue = createdOn.Value;

             if (updatedon != null)
                updatedonValue = updatedon.Value;

             if (sortByExpression.Contains(" desc"))
             {
                 switch (sortByExpression)
                 {
                     case "WorkflowName desc":
                         return context.WorkflowMaster
                             .Where(w =>
                                       (workflowId != null ? w.WorkflowId == workflowIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(workflowName) ? w.WorkflowName.Contains(workflowName) : 1 == 1) &&
                                       (levelOfApprovals != null ? w.LevelOfApprovals == levelOfApprovalsValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? w.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (createdOn != null ? w.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(updatedby) ? w.Updatedby.Contains(updatedby) : 1 == 1) &&
                                       (updatedon != null ? w.Updatedon == updatedonValue : 1 == 1) 
                                   ).OrderByDescending(w => w.WorkflowName).Skip(startRowIndex).Take(rows).ToList();

                     case "LevelOfApprovals desc":
                         return context.WorkflowMaster
                             .Where(w =>
                                       (workflowId != null ? w.WorkflowId == workflowIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(workflowName) ? w.WorkflowName.Contains(workflowName) : 1 == 1) &&
                                       (levelOfApprovals != null ? w.LevelOfApprovals == levelOfApprovalsValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? w.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (createdOn != null ? w.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(updatedby) ? w.Updatedby.Contains(updatedby) : 1 == 1) &&
                                       (updatedon != null ? w.Updatedon == updatedonValue : 1 == 1) 
                                   ).OrderByDescending(w => w.LevelOfApprovals).Skip(startRowIndex).Take(rows).ToList();

                     case "CreatedBy desc":
                         return context.WorkflowMaster
                             .Where(w =>
                                       (workflowId != null ? w.WorkflowId == workflowIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(workflowName) ? w.WorkflowName.Contains(workflowName) : 1 == 1) &&
                                       (levelOfApprovals != null ? w.LevelOfApprovals == levelOfApprovalsValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? w.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (createdOn != null ? w.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(updatedby) ? w.Updatedby.Contains(updatedby) : 1 == 1) &&
                                       (updatedon != null ? w.Updatedon == updatedonValue : 1 == 1) 
                                   ).OrderByDescending(w => w.CreatedBy).Skip(startRowIndex).Take(rows).ToList();

                     case "CreatedOn desc":
                         return context.WorkflowMaster
                             .Where(w =>
                                       (workflowId != null ? w.WorkflowId == workflowIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(workflowName) ? w.WorkflowName.Contains(workflowName) : 1 == 1) &&
                                       (levelOfApprovals != null ? w.LevelOfApprovals == levelOfApprovalsValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? w.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (createdOn != null ? w.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(updatedby) ? w.Updatedby.Contains(updatedby) : 1 == 1) &&
                                       (updatedon != null ? w.Updatedon == updatedonValue : 1 == 1) 
                                   ).OrderByDescending(w => w.CreatedOn).Skip(startRowIndex).Take(rows).ToList();

                     case "Updatedby desc":
                         return context.WorkflowMaster
                             .Where(w =>
                                       (workflowId != null ? w.WorkflowId == workflowIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(workflowName) ? w.WorkflowName.Contains(workflowName) : 1 == 1) &&
                                       (levelOfApprovals != null ? w.LevelOfApprovals == levelOfApprovalsValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? w.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (createdOn != null ? w.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(updatedby) ? w.Updatedby.Contains(updatedby) : 1 == 1) &&
                                       (updatedon != null ? w.Updatedon == updatedonValue : 1 == 1) 
                                   ).OrderByDescending(w => w.Updatedby).Skip(startRowIndex).Take(rows).ToList();

                     case "Updatedon desc":
                         return context.WorkflowMaster
                             .Where(w =>
                                       (workflowId != null ? w.WorkflowId == workflowIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(workflowName) ? w.WorkflowName.Contains(workflowName) : 1 == 1) &&
                                       (levelOfApprovals != null ? w.LevelOfApprovals == levelOfApprovalsValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? w.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (createdOn != null ? w.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(updatedby) ? w.Updatedby.Contains(updatedby) : 1 == 1) &&
                                       (updatedon != null ? w.Updatedon == updatedonValue : 1 == 1) 
                                   ).OrderByDescending(w => w.Updatedon).Skip(startRowIndex).Take(rows).ToList();

                     default:
                         return context.WorkflowMaster
                             .Where(w =>
                                       (workflowId != null ? w.WorkflowId == workflowIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(workflowName) ? w.WorkflowName.Contains(workflowName) : 1 == 1) &&
                                       (levelOfApprovals != null ? w.LevelOfApprovals == levelOfApprovalsValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? w.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (createdOn != null ? w.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(updatedby) ? w.Updatedby.Contains(updatedby) : 1 == 1) &&
                                       (updatedon != null ? w.Updatedon == updatedonValue : 1 == 1) 
                                   ).OrderByDescending(w => w.WorkflowId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
             else
             {
                 switch (sortByExpression)
                 {
                     case "WorkflowName":
                         return context.WorkflowMaster
                             .Where(w =>
                                       (workflowId != null ? w.WorkflowId == workflowIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(workflowName) ? w.WorkflowName.Contains(workflowName) : 1 == 1) &&
                                       (levelOfApprovals != null ? w.LevelOfApprovals == levelOfApprovalsValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? w.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (createdOn != null ? w.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(updatedby) ? w.Updatedby.Contains(updatedby) : 1 == 1) &&
                                       (updatedon != null ? w.Updatedon == updatedonValue : 1 == 1) 
                                   ).OrderBy(w => w.WorkflowName).Skip(startRowIndex).Take(rows).ToList();

                     case "LevelOfApprovals":
                         return context.WorkflowMaster
                             .Where(w =>
                                       (workflowId != null ? w.WorkflowId == workflowIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(workflowName) ? w.WorkflowName.Contains(workflowName) : 1 == 1) &&
                                       (levelOfApprovals != null ? w.LevelOfApprovals == levelOfApprovalsValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? w.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (createdOn != null ? w.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(updatedby) ? w.Updatedby.Contains(updatedby) : 1 == 1) &&
                                       (updatedon != null ? w.Updatedon == updatedonValue : 1 == 1) 
                                   ).OrderBy(w => w.LevelOfApprovals).Skip(startRowIndex).Take(rows).ToList();

                     case "CreatedBy":
                         return context.WorkflowMaster
                             .Where(w =>
                                       (workflowId != null ? w.WorkflowId == workflowIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(workflowName) ? w.WorkflowName.Contains(workflowName) : 1 == 1) &&
                                       (levelOfApprovals != null ? w.LevelOfApprovals == levelOfApprovalsValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? w.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (createdOn != null ? w.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(updatedby) ? w.Updatedby.Contains(updatedby) : 1 == 1) &&
                                       (updatedon != null ? w.Updatedon == updatedonValue : 1 == 1) 
                                   ).OrderBy(w => w.CreatedBy).Skip(startRowIndex).Take(rows).ToList();

                     case "CreatedOn":
                         return context.WorkflowMaster
                             .Where(w =>
                                       (workflowId != null ? w.WorkflowId == workflowIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(workflowName) ? w.WorkflowName.Contains(workflowName) : 1 == 1) &&
                                       (levelOfApprovals != null ? w.LevelOfApprovals == levelOfApprovalsValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? w.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (createdOn != null ? w.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(updatedby) ? w.Updatedby.Contains(updatedby) : 1 == 1) &&
                                       (updatedon != null ? w.Updatedon == updatedonValue : 1 == 1) 
                                   ).OrderBy(w => w.CreatedOn).Skip(startRowIndex).Take(rows).ToList();

                     case "Updatedby":
                         return context.WorkflowMaster
                             .Where(w =>
                                       (workflowId != null ? w.WorkflowId == workflowIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(workflowName) ? w.WorkflowName.Contains(workflowName) : 1 == 1) &&
                                       (levelOfApprovals != null ? w.LevelOfApprovals == levelOfApprovalsValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? w.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (createdOn != null ? w.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(updatedby) ? w.Updatedby.Contains(updatedby) : 1 == 1) &&
                                       (updatedon != null ? w.Updatedon == updatedonValue : 1 == 1) 
                                   ).OrderBy(w => w.Updatedby).Skip(startRowIndex).Take(rows).ToList();

                     case "Updatedon":
                         return context.WorkflowMaster
                             .Where(w =>
                                       (workflowId != null ? w.WorkflowId == workflowIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(workflowName) ? w.WorkflowName.Contains(workflowName) : 1 == 1) &&
                                       (levelOfApprovals != null ? w.LevelOfApprovals == levelOfApprovalsValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? w.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (createdOn != null ? w.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(updatedby) ? w.Updatedby.Contains(updatedby) : 1 == 1) &&
                                       (updatedon != null ? w.Updatedon == updatedonValue : 1 == 1) 
                                   ).OrderBy(w => w.Updatedon).Skip(startRowIndex).Take(rows).ToList();

                     default:
                         return context.WorkflowMaster
                             .Where(w =>
                                       (workflowId != null ? w.WorkflowId == workflowIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(workflowName) ? w.WorkflowName.Contains(workflowName) : 1 == 1) &&
                                       (levelOfApprovals != null ? w.LevelOfApprovals == levelOfApprovalsValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? w.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (createdOn != null ? w.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(updatedby) ? w.Updatedby.Contains(updatedby) : 1 == 1) &&
                                       (updatedon != null ? w.Updatedon == updatedonValue : 1 == 1) 
                                   ).OrderBy(w => w.WorkflowId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
         }

         /// <summary>
         /// Selects all WorkflowMaster
         /// </summary>
         internal static List<WorkflowMaster> SelectAll()
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();
             return context.WorkflowMaster.ToList();
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of WorkflowMaster.
         /// </summary>
         internal static List<WorkflowMaster> SelectAllDynamicWhere(int? workflowId, string workflowName, int? levelOfApprovals, string createdBy, DateTime? createdOn, string updatedby, DateTime? updatedon)
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();

             int workflowIdValue = int.MinValue;
             int levelOfApprovalsValue = int.MinValue;
             DateTime createdOnValue = DateTime.MinValue;
             DateTime updatedonValue = DateTime.MinValue;

             if (workflowId != null)
                workflowIdValue = workflowId.Value;

             if (levelOfApprovals != null)
                levelOfApprovalsValue = levelOfApprovals.Value;

             if (createdOn != null)
                createdOnValue = createdOn.Value;

             if (updatedon != null)
                updatedonValue = updatedon.Value;

             return context.WorkflowMaster
                 .Where(w =>
                           (workflowId != null ? w.WorkflowId == workflowIdValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(workflowName) ? w.WorkflowName.Contains(workflowName) : 1 == 1) &&
                           (levelOfApprovals != null ? w.LevelOfApprovals == levelOfApprovalsValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(createdBy) ? w.CreatedBy.Contains(createdBy) : 1 == 1) &&
                           (createdOn != null ? w.CreatedOn == createdOnValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(updatedby) ? w.Updatedby.Contains(updatedby) : 1 == 1) &&
                           (updatedon != null ? w.Updatedon == updatedonValue : 1 == 1) 
                       ).ToList();
         }
         /// <summary>
         /// Selects WorkflowId and WorkflowName columns for use with a DropDownList web control
         /// </summary>
         internal static List<WorkflowMaster> SelectWorkflowMasterDropDownListData()
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();
             return (from w in context.WorkflowMaster
                     select new WorkflowMaster { WorkflowId = w.WorkflowId, WorkflowName = w.WorkflowName }).ToList();
         }
         /// <summary>
         /// Inserts a record
         /// </summary>
         internal static int Insert(WorkflowMaster objWorkflowMaster)
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();
             WorkflowMaster entWorkflowMaster = new WorkflowMaster();

             entWorkflowMaster.WorkflowName = objWorkflowMaster.WorkflowName;
             entWorkflowMaster.LevelOfApprovals = objWorkflowMaster.LevelOfApprovals;
             entWorkflowMaster.CreatedBy = objWorkflowMaster.CreatedBy;
             entWorkflowMaster.CreatedOn = objWorkflowMaster.CreatedOn;
             entWorkflowMaster.Updatedby = objWorkflowMaster.Updatedby;
             entWorkflowMaster.Updatedon = objWorkflowMaster.Updatedon;

             context.WorkflowMaster.Add(entWorkflowMaster);
             context.SaveChanges();

             return entWorkflowMaster.WorkflowId;
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         internal static void Update(WorkflowMaster objWorkflowMaster)
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();
             WorkflowMaster entWorkflowMaster = context.WorkflowMaster.Where(w => w.WorkflowId == objWorkflowMaster.WorkflowId).FirstOrDefault();

             if (entWorkflowMaster != null)
             {
                 entWorkflowMaster.WorkflowName = objWorkflowMaster.WorkflowName;
                 entWorkflowMaster.LevelOfApprovals = objWorkflowMaster.LevelOfApprovals;
                 entWorkflowMaster.CreatedBy = objWorkflowMaster.CreatedBy;
                 entWorkflowMaster.CreatedOn = objWorkflowMaster.CreatedOn;
                 entWorkflowMaster.Updatedby = objWorkflowMaster.Updatedby;
                 entWorkflowMaster.Updatedon = objWorkflowMaster.Updatedon;

                 context.SaveChanges();
             }
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         internal static void Delete(int workflowId)
         {
             StudentEnquiryDBContext context = new StudentEnquiryDBContext();
             var objWorkflowMaster = context.WorkflowMaster.Where(w => w.WorkflowId == workflowId).FirstOrDefault();

             if (objWorkflowMaster != null)
             {
                 context.WorkflowMaster.Remove(objWorkflowMaster);
                 context.SaveChanges();
             }
         }
     }
}
