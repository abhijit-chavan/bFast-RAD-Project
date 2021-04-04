using TemporaryDBappllicationAPI.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TemporaryDBappllicationAPI.DataLayer.Base
{
     /// <summary>
     /// Base class for WorkflowStepsMasterDataLayer.  Do not make changes to this class,
     /// instead, put additional code in the WorkflowStepsMasterDataLayer class
     /// </summary>
     internal class WorkflowStepsMasterDataLayerBase
     {
         // constructor
         internal WorkflowStepsMasterDataLayerBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         internal static WorkflowStepsMaster SelectByPrimaryKey(int stepId)
         {
             FirstTempdbContext context = new FirstTempdbContext();
             return context.WorkflowStepsMaster.Where(w => w.StepId == stepId).FirstOrDefault();
         }

         /// <summary>
         /// Gets the total number of records in the WorkflowStepsMaster table
         /// </summary>
         internal static int GetRecordCount()
         {
             FirstTempdbContext context = new FirstTempdbContext();
             return context.WorkflowStepsMaster.Count();
         }

         /// <summary>
         /// Gets the total number of records in the WorkflowStepsMaster table by WorKflowId
         /// </summary>
         internal static int GetRecordCountByWorKflowId(int worKflowId)
         {
             FirstTempdbContext context = new FirstTempdbContext();
             return context.WorkflowStepsMaster.Where(w => w.WorKflowId == worKflowId).Count();
         }

         /// <summary>
         /// Gets the total number of records in the WorkflowStepsMaster table based on search parameters
         /// </summary>
         internal static int GetRecordCountDynamicWhere(int? stepId, int? worKflowId, string approvalLevel, string description, string autoApprove, int? waitTime, string createdBy, DateTime? createdOn, string updatedBy, DateTime? updatedOn)
         {
             FirstTempdbContext context = new FirstTempdbContext();

             int stepIdValue = int.MinValue;
             int worKflowIdValue = int.MinValue;
             int waitTimeValue = int.MinValue;
             DateTime createdOnValue = DateTime.MinValue;
             DateTime updatedOnValue = DateTime.MinValue;

             if (stepId != null)
                stepIdValue = stepId.Value;

             if (worKflowId != null)
                worKflowIdValue = worKflowId.Value;

             if (waitTime != null)
                waitTimeValue = waitTime.Value;

             if (createdOn != null)
                createdOnValue = createdOn.Value;

             if (updatedOn != null)
                updatedOnValue = updatedOn.Value;

             return context.WorkflowStepsMaster
                 .Where(w =>
                           (stepId != null ? w.StepId == stepIdValue : 1 == 1) &&
                           (worKflowId != null ? w.WorKflowId == worKflowIdValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(approvalLevel) ? w.ApprovalLevel.Contains(approvalLevel) : 1 == 1) &&
                           (!String.IsNullOrEmpty(description) ? w.Description.Contains(description) : 1 == 1) &&
                           (!String.IsNullOrEmpty(autoApprove) ? w.AutoApprove.Contains(autoApprove) : 1 == 1) &&
                           (waitTime != null ? w.WaitTime == waitTimeValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(createdBy) ? w.CreatedBy.Contains(createdBy) : 1 == 1) &&
                           (createdOn != null ? w.CreatedOn == createdOnValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(updatedBy) ? w.UpdatedBy.Contains(updatedBy) : 1 == 1) &&
                           (updatedOn != null ? w.UpdatedOn == updatedOnValue : 1 == 1) 
                       ).Count();
         }

         /// <summary>
         /// Selects WorkflowStepsMaster records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
         /// </summary>
         internal static List<WorkflowStepsMaster> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows, bool isIncludeRelatedProperties = true)
         {
             FirstTempdbContext context = new FirstTempdbContext();

             if (!isIncludeRelatedProperties)
             {
                 if (sortByExpression.Contains(" desc"))
                 {
                     switch (sortByExpression)
                     {
                         case "WorKflowId desc":
                             return context.WorkflowStepsMaster.OrderByDescending(w => w.WorKflowId).Skip(startRowIndex).Take(rows).ToList();
                         case "ApprovalLevel desc":
                             return context.WorkflowStepsMaster.OrderByDescending(w => w.ApprovalLevel).Skip(startRowIndex).Take(rows).ToList();
                         case "Description desc":
                             return context.WorkflowStepsMaster.OrderByDescending(w => w.Description).Skip(startRowIndex).Take(rows).ToList();
                         case "AutoApprove desc":
                             return context.WorkflowStepsMaster.OrderByDescending(w => w.AutoApprove).Skip(startRowIndex).Take(rows).ToList();
                         case "WaitTime desc":
                             return context.WorkflowStepsMaster.OrderByDescending(w => w.WaitTime).Skip(startRowIndex).Take(rows).ToList();
                         case "CreatedBy desc":
                             return context.WorkflowStepsMaster.OrderByDescending(w => w.CreatedBy).Skip(startRowIndex).Take(rows).ToList();
                         case "CreatedOn desc":
                             return context.WorkflowStepsMaster.OrderByDescending(w => w.CreatedOn).Skip(startRowIndex).Take(rows).ToList();
                         case "UpdatedBy desc":
                             return context.WorkflowStepsMaster.OrderByDescending(w => w.UpdatedBy).Skip(startRowIndex).Take(rows).ToList();
                         case "UpdatedOn desc":
                             return context.WorkflowStepsMaster.OrderByDescending(w => w.UpdatedOn).Skip(startRowIndex).Take(rows).ToList();
                         default:
                             return context.WorkflowStepsMaster.OrderByDescending(w => w.StepId).Skip(startRowIndex).Take(rows).ToList();
                     }
                 }
                 else
                 {
                     switch (sortByExpression)
                     {
                         case "WorKflowId":
                             return context.WorkflowStepsMaster.OrderBy(w => w.WorKflowId).Skip(startRowIndex).Take(rows).ToList();
                         case "ApprovalLevel":
                             return context.WorkflowStepsMaster.OrderBy(w => w.ApprovalLevel).Skip(startRowIndex).Take(rows).ToList();
                         case "Description":
                             return context.WorkflowStepsMaster.OrderBy(w => w.Description).Skip(startRowIndex).Take(rows).ToList();
                         case "AutoApprove":
                             return context.WorkflowStepsMaster.OrderBy(w => w.AutoApprove).Skip(startRowIndex).Take(rows).ToList();
                         case "WaitTime":
                             return context.WorkflowStepsMaster.OrderBy(w => w.WaitTime).Skip(startRowIndex).Take(rows).ToList();
                         case "CreatedBy":
                             return context.WorkflowStepsMaster.OrderBy(w => w.CreatedBy).Skip(startRowIndex).Take(rows).ToList();
                         case "CreatedOn":
                             return context.WorkflowStepsMaster.OrderBy(w => w.CreatedOn).Skip(startRowIndex).Take(rows).ToList();
                         case "UpdatedBy":
                             return context.WorkflowStepsMaster.OrderBy(w => w.UpdatedBy).Skip(startRowIndex).Take(rows).ToList();
                         case "UpdatedOn":
                             return context.WorkflowStepsMaster.OrderBy(w => w.UpdatedOn).Skip(startRowIndex).Take(rows).ToList();
                         default:
                             return context.WorkflowStepsMaster.OrderBy(w => w.StepId).Skip(startRowIndex).Take(rows).ToList();
                     }
                 }
             }
             else
             {
                 if (sortByExpression.Contains(" desc"))
                 {
                     switch (sortByExpression)
                     {
                         case "WorKflowId desc":
                             return context.WorkflowStepsMaster.Include(w => w.WorKflowIdNavigation).OrderByDescending(w => w.WorKflowId).Skip(startRowIndex).Take(rows).ToList();
                         case "ApprovalLevel desc":
                             return context.WorkflowStepsMaster.Include(w => w.WorKflowIdNavigation).OrderByDescending(w => w.ApprovalLevel).Skip(startRowIndex).Take(rows).ToList();
                         case "Description desc":
                             return context.WorkflowStepsMaster.Include(w => w.WorKflowIdNavigation).OrderByDescending(w => w.Description).Skip(startRowIndex).Take(rows).ToList();
                         case "AutoApprove desc":
                             return context.WorkflowStepsMaster.Include(w => w.WorKflowIdNavigation).OrderByDescending(w => w.AutoApprove).Skip(startRowIndex).Take(rows).ToList();
                         case "WaitTime desc":
                             return context.WorkflowStepsMaster.Include(w => w.WorKflowIdNavigation).OrderByDescending(w => w.WaitTime).Skip(startRowIndex).Take(rows).ToList();
                         case "CreatedBy desc":
                             return context.WorkflowStepsMaster.Include(w => w.WorKflowIdNavigation).OrderByDescending(w => w.CreatedBy).Skip(startRowIndex).Take(rows).ToList();
                         case "CreatedOn desc":
                             return context.WorkflowStepsMaster.Include(w => w.WorKflowIdNavigation).OrderByDescending(w => w.CreatedOn).Skip(startRowIndex).Take(rows).ToList();
                         case "UpdatedBy desc":
                             return context.WorkflowStepsMaster.Include(w => w.WorKflowIdNavigation).OrderByDescending(w => w.UpdatedBy).Skip(startRowIndex).Take(rows).ToList();
                         case "UpdatedOn desc":
                             return context.WorkflowStepsMaster.Include(w => w.WorKflowIdNavigation).OrderByDescending(w => w.UpdatedOn).Skip(startRowIndex).Take(rows).ToList();
                         default:
                             return context.WorkflowStepsMaster.Include(w => w.WorKflowIdNavigation).OrderByDescending(w => w.StepId).Skip(startRowIndex).Take(rows).ToList();
                     }
                 }
                 else
                 {
                     switch (sortByExpression)
                     {
                         case "WorKflowId":
                             return context.WorkflowStepsMaster.Include(w => w.WorKflowIdNavigation).OrderBy(w => w.WorKflowId).Skip(startRowIndex).Take(rows).ToList();
                         case "ApprovalLevel":
                             return context.WorkflowStepsMaster.Include(w => w.WorKflowIdNavigation).OrderBy(w => w.ApprovalLevel).Skip(startRowIndex).Take(rows).ToList();
                         case "Description":
                             return context.WorkflowStepsMaster.Include(w => w.WorKflowIdNavigation).OrderBy(w => w.Description).Skip(startRowIndex).Take(rows).ToList();
                         case "AutoApprove":
                             return context.WorkflowStepsMaster.Include(w => w.WorKflowIdNavigation).OrderBy(w => w.AutoApprove).Skip(startRowIndex).Take(rows).ToList();
                         case "WaitTime":
                             return context.WorkflowStepsMaster.Include(w => w.WorKflowIdNavigation).OrderBy(w => w.WaitTime).Skip(startRowIndex).Take(rows).ToList();
                         case "CreatedBy":
                             return context.WorkflowStepsMaster.Include(w => w.WorKflowIdNavigation).OrderBy(w => w.CreatedBy).Skip(startRowIndex).Take(rows).ToList();
                         case "CreatedOn":
                             return context.WorkflowStepsMaster.Include(w => w.WorKflowIdNavigation).OrderBy(w => w.CreatedOn).Skip(startRowIndex).Take(rows).ToList();
                         case "UpdatedBy":
                             return context.WorkflowStepsMaster.Include(w => w.WorKflowIdNavigation).OrderBy(w => w.UpdatedBy).Skip(startRowIndex).Take(rows).ToList();
                         case "UpdatedOn":
                             return context.WorkflowStepsMaster.Include(w => w.WorKflowIdNavigation).OrderBy(w => w.UpdatedOn).Skip(startRowIndex).Take(rows).ToList();
                         default:
                             return context.WorkflowStepsMaster.Include(w => w.WorKflowIdNavigation).OrderBy(w => w.StepId).Skip(startRowIndex).Take(rows).ToList();
                     }
                 }
             }
         }

         /// <summary>
         /// Selects records by WorKflowId as a collection (List) of WorkflowStepsMaster sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         internal static List<WorkflowStepsMaster> SelectSkipAndTakeByWorKflowId(string sortByExpression, int startRowIndex, int rows, int worKflowId)
         {
             FirstTempdbContext context = new FirstTempdbContext();

             if (sortByExpression.Contains(" desc"))
             {
                 switch (sortByExpression)
                 {
                     case "WorKflowId desc":
                         return context.WorkflowStepsMaster.Where(w => w.WorKflowId == worKflowId).OrderByDescending(w => w.WorKflowId).Skip(startRowIndex).Take(rows).ToList();
                     case "ApprovalLevel desc":
                         return context.WorkflowStepsMaster.Where(w => w.WorKflowId == worKflowId).OrderByDescending(w => w.ApprovalLevel).Skip(startRowIndex).Take(rows).ToList();
                     case "Description desc":
                         return context.WorkflowStepsMaster.Where(w => w.WorKflowId == worKflowId).OrderByDescending(w => w.Description).Skip(startRowIndex).Take(rows).ToList();
                     case "AutoApprove desc":
                         return context.WorkflowStepsMaster.Where(w => w.WorKflowId == worKflowId).OrderByDescending(w => w.AutoApprove).Skip(startRowIndex).Take(rows).ToList();
                     case "WaitTime desc":
                         return context.WorkflowStepsMaster.Where(w => w.WorKflowId == worKflowId).OrderByDescending(w => w.WaitTime).Skip(startRowIndex).Take(rows).ToList();
                     case "CreatedBy desc":
                         return context.WorkflowStepsMaster.Where(w => w.WorKflowId == worKflowId).OrderByDescending(w => w.CreatedBy).Skip(startRowIndex).Take(rows).ToList();
                     case "CreatedOn desc":
                         return context.WorkflowStepsMaster.Where(w => w.WorKflowId == worKflowId).OrderByDescending(w => w.CreatedOn).Skip(startRowIndex).Take(rows).ToList();
                     case "UpdatedBy desc":
                         return context.WorkflowStepsMaster.Where(w => w.WorKflowId == worKflowId).OrderByDescending(w => w.UpdatedBy).Skip(startRowIndex).Take(rows).ToList();
                     case "UpdatedOn desc":
                         return context.WorkflowStepsMaster.Where(w => w.WorKflowId == worKflowId).OrderByDescending(w => w.UpdatedOn).Skip(startRowIndex).Take(rows).ToList();
                     default:
                         return context.WorkflowStepsMaster.Where(w => w.WorKflowId == worKflowId).OrderByDescending(w => w.StepId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
             else
             {
                 switch (sortByExpression)
                 {
                     case "WorKflowId":
                         return context.WorkflowStepsMaster.Where(w => w.WorKflowId == worKflowId).OrderBy(w => w.WorKflowId).Skip(startRowIndex).Take(rows).ToList();
                     case "ApprovalLevel":
                         return context.WorkflowStepsMaster.Where(w => w.WorKflowId == worKflowId).OrderBy(w => w.ApprovalLevel).Skip(startRowIndex).Take(rows).ToList();
                     case "Description":
                         return context.WorkflowStepsMaster.Where(w => w.WorKflowId == worKflowId).OrderBy(w => w.Description).Skip(startRowIndex).Take(rows).ToList();
                     case "AutoApprove":
                         return context.WorkflowStepsMaster.Where(w => w.WorKflowId == worKflowId).OrderBy(w => w.AutoApprove).Skip(startRowIndex).Take(rows).ToList();
                     case "WaitTime":
                         return context.WorkflowStepsMaster.Where(w => w.WorKflowId == worKflowId).OrderBy(w => w.WaitTime).Skip(startRowIndex).Take(rows).ToList();
                     case "CreatedBy":
                         return context.WorkflowStepsMaster.Where(w => w.WorKflowId == worKflowId).OrderBy(w => w.CreatedBy).Skip(startRowIndex).Take(rows).ToList();
                     case "CreatedOn":
                         return context.WorkflowStepsMaster.Where(w => w.WorKflowId == worKflowId).OrderBy(w => w.CreatedOn).Skip(startRowIndex).Take(rows).ToList();
                     case "UpdatedBy":
                         return context.WorkflowStepsMaster.Where(w => w.WorKflowId == worKflowId).OrderBy(w => w.UpdatedBy).Skip(startRowIndex).Take(rows).ToList();
                     case "UpdatedOn":
                         return context.WorkflowStepsMaster.Where(w => w.WorKflowId == worKflowId).OrderBy(w => w.UpdatedOn).Skip(startRowIndex).Take(rows).ToList();
                     default:
                         return context.WorkflowStepsMaster.Where(w => w.WorKflowId == worKflowId).OrderBy(w => w.StepId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
         }

         /// <summary>
         /// Selects WorkflowStepsMaster records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
         /// </summary>
         internal static List<WorkflowStepsMaster> SelectSkipAndTakeDynamicWhere(int? stepId, int? worKflowId, string approvalLevel, string description, string autoApprove, int? waitTime, string createdBy, DateTime? createdOn, string updatedBy, DateTime? updatedOn, string sortByExpression, int startRowIndex, int rows)
         {
             FirstTempdbContext context = new FirstTempdbContext();

             int stepIdValue = int.MinValue;
             int worKflowIdValue = int.MinValue;
             int waitTimeValue = int.MinValue;
             DateTime createdOnValue = DateTime.MinValue;
             DateTime updatedOnValue = DateTime.MinValue;

             if (stepId != null)
                stepIdValue = stepId.Value;

             if (worKflowId != null)
                worKflowIdValue = worKflowId.Value;

             if (waitTime != null)
                waitTimeValue = waitTime.Value;

             if (createdOn != null)
                createdOnValue = createdOn.Value;

             if (updatedOn != null)
                updatedOnValue = updatedOn.Value;

             if (sortByExpression.Contains(" desc"))
             {
                 switch (sortByExpression)
                 {
                     case "WorKflowId desc":
                         return context.WorkflowStepsMaster
                             .Where(w =>
                                       (stepId != null ? w.StepId == stepIdValue : 1 == 1) &&
                                       (worKflowId != null ? w.WorKflowId == worKflowIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(approvalLevel) ? w.ApprovalLevel.Contains(approvalLevel) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(description) ? w.Description.Contains(description) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(autoApprove) ? w.AutoApprove.Contains(autoApprove) : 1 == 1) &&
                                       (waitTime != null ? w.WaitTime == waitTimeValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? w.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (createdOn != null ? w.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(updatedBy) ? w.UpdatedBy.Contains(updatedBy) : 1 == 1) &&
                                       (updatedOn != null ? w.UpdatedOn == updatedOnValue : 1 == 1) 
                                   ).OrderByDescending(w => w.WorKflowId).Skip(startRowIndex).Take(rows).ToList();

                     case "ApprovalLevel desc":
                         return context.WorkflowStepsMaster
                             .Where(w =>
                                       (stepId != null ? w.StepId == stepIdValue : 1 == 1) &&
                                       (worKflowId != null ? w.WorKflowId == worKflowIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(approvalLevel) ? w.ApprovalLevel.Contains(approvalLevel) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(description) ? w.Description.Contains(description) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(autoApprove) ? w.AutoApprove.Contains(autoApprove) : 1 == 1) &&
                                       (waitTime != null ? w.WaitTime == waitTimeValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? w.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (createdOn != null ? w.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(updatedBy) ? w.UpdatedBy.Contains(updatedBy) : 1 == 1) &&
                                       (updatedOn != null ? w.UpdatedOn == updatedOnValue : 1 == 1) 
                                   ).OrderByDescending(w => w.ApprovalLevel).Skip(startRowIndex).Take(rows).ToList();

                     case "Description desc":
                         return context.WorkflowStepsMaster
                             .Where(w =>
                                       (stepId != null ? w.StepId == stepIdValue : 1 == 1) &&
                                       (worKflowId != null ? w.WorKflowId == worKflowIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(approvalLevel) ? w.ApprovalLevel.Contains(approvalLevel) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(description) ? w.Description.Contains(description) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(autoApprove) ? w.AutoApprove.Contains(autoApprove) : 1 == 1) &&
                                       (waitTime != null ? w.WaitTime == waitTimeValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? w.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (createdOn != null ? w.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(updatedBy) ? w.UpdatedBy.Contains(updatedBy) : 1 == 1) &&
                                       (updatedOn != null ? w.UpdatedOn == updatedOnValue : 1 == 1) 
                                   ).OrderByDescending(w => w.Description).Skip(startRowIndex).Take(rows).ToList();

                     case "AutoApprove desc":
                         return context.WorkflowStepsMaster
                             .Where(w =>
                                       (stepId != null ? w.StepId == stepIdValue : 1 == 1) &&
                                       (worKflowId != null ? w.WorKflowId == worKflowIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(approvalLevel) ? w.ApprovalLevel.Contains(approvalLevel) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(description) ? w.Description.Contains(description) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(autoApprove) ? w.AutoApprove.Contains(autoApprove) : 1 == 1) &&
                                       (waitTime != null ? w.WaitTime == waitTimeValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? w.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (createdOn != null ? w.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(updatedBy) ? w.UpdatedBy.Contains(updatedBy) : 1 == 1) &&
                                       (updatedOn != null ? w.UpdatedOn == updatedOnValue : 1 == 1) 
                                   ).OrderByDescending(w => w.AutoApprove).Skip(startRowIndex).Take(rows).ToList();

                     case "WaitTime desc":
                         return context.WorkflowStepsMaster
                             .Where(w =>
                                       (stepId != null ? w.StepId == stepIdValue : 1 == 1) &&
                                       (worKflowId != null ? w.WorKflowId == worKflowIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(approvalLevel) ? w.ApprovalLevel.Contains(approvalLevel) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(description) ? w.Description.Contains(description) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(autoApprove) ? w.AutoApprove.Contains(autoApprove) : 1 == 1) &&
                                       (waitTime != null ? w.WaitTime == waitTimeValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? w.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (createdOn != null ? w.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(updatedBy) ? w.UpdatedBy.Contains(updatedBy) : 1 == 1) &&
                                       (updatedOn != null ? w.UpdatedOn == updatedOnValue : 1 == 1) 
                                   ).OrderByDescending(w => w.WaitTime).Skip(startRowIndex).Take(rows).ToList();

                     case "CreatedBy desc":
                         return context.WorkflowStepsMaster
                             .Where(w =>
                                       (stepId != null ? w.StepId == stepIdValue : 1 == 1) &&
                                       (worKflowId != null ? w.WorKflowId == worKflowIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(approvalLevel) ? w.ApprovalLevel.Contains(approvalLevel) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(description) ? w.Description.Contains(description) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(autoApprove) ? w.AutoApprove.Contains(autoApprove) : 1 == 1) &&
                                       (waitTime != null ? w.WaitTime == waitTimeValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? w.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (createdOn != null ? w.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(updatedBy) ? w.UpdatedBy.Contains(updatedBy) : 1 == 1) &&
                                       (updatedOn != null ? w.UpdatedOn == updatedOnValue : 1 == 1) 
                                   ).OrderByDescending(w => w.CreatedBy).Skip(startRowIndex).Take(rows).ToList();

                     case "CreatedOn desc":
                         return context.WorkflowStepsMaster
                             .Where(w =>
                                       (stepId != null ? w.StepId == stepIdValue : 1 == 1) &&
                                       (worKflowId != null ? w.WorKflowId == worKflowIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(approvalLevel) ? w.ApprovalLevel.Contains(approvalLevel) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(description) ? w.Description.Contains(description) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(autoApprove) ? w.AutoApprove.Contains(autoApprove) : 1 == 1) &&
                                       (waitTime != null ? w.WaitTime == waitTimeValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? w.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (createdOn != null ? w.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(updatedBy) ? w.UpdatedBy.Contains(updatedBy) : 1 == 1) &&
                                       (updatedOn != null ? w.UpdatedOn == updatedOnValue : 1 == 1) 
                                   ).OrderByDescending(w => w.CreatedOn).Skip(startRowIndex).Take(rows).ToList();

                     case "UpdatedBy desc":
                         return context.WorkflowStepsMaster
                             .Where(w =>
                                       (stepId != null ? w.StepId == stepIdValue : 1 == 1) &&
                                       (worKflowId != null ? w.WorKflowId == worKflowIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(approvalLevel) ? w.ApprovalLevel.Contains(approvalLevel) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(description) ? w.Description.Contains(description) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(autoApprove) ? w.AutoApprove.Contains(autoApprove) : 1 == 1) &&
                                       (waitTime != null ? w.WaitTime == waitTimeValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? w.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (createdOn != null ? w.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(updatedBy) ? w.UpdatedBy.Contains(updatedBy) : 1 == 1) &&
                                       (updatedOn != null ? w.UpdatedOn == updatedOnValue : 1 == 1) 
                                   ).OrderByDescending(w => w.UpdatedBy).Skip(startRowIndex).Take(rows).ToList();

                     case "UpdatedOn desc":
                         return context.WorkflowStepsMaster
                             .Where(w =>
                                       (stepId != null ? w.StepId == stepIdValue : 1 == 1) &&
                                       (worKflowId != null ? w.WorKflowId == worKflowIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(approvalLevel) ? w.ApprovalLevel.Contains(approvalLevel) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(description) ? w.Description.Contains(description) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(autoApprove) ? w.AutoApprove.Contains(autoApprove) : 1 == 1) &&
                                       (waitTime != null ? w.WaitTime == waitTimeValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? w.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (createdOn != null ? w.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(updatedBy) ? w.UpdatedBy.Contains(updatedBy) : 1 == 1) &&
                                       (updatedOn != null ? w.UpdatedOn == updatedOnValue : 1 == 1) 
                                   ).OrderByDescending(w => w.UpdatedOn).Skip(startRowIndex).Take(rows).ToList();

                     default:
                         return context.WorkflowStepsMaster
                             .Where(w =>
                                       (stepId != null ? w.StepId == stepIdValue : 1 == 1) &&
                                       (worKflowId != null ? w.WorKflowId == worKflowIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(approvalLevel) ? w.ApprovalLevel.Contains(approvalLevel) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(description) ? w.Description.Contains(description) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(autoApprove) ? w.AutoApprove.Contains(autoApprove) : 1 == 1) &&
                                       (waitTime != null ? w.WaitTime == waitTimeValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? w.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (createdOn != null ? w.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(updatedBy) ? w.UpdatedBy.Contains(updatedBy) : 1 == 1) &&
                                       (updatedOn != null ? w.UpdatedOn == updatedOnValue : 1 == 1) 
                                   ).OrderByDescending(w => w.StepId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
             else
             {
                 switch (sortByExpression)
                 {
                     case "WorKflowId":
                         return context.WorkflowStepsMaster
                             .Where(w =>
                                       (stepId != null ? w.StepId == stepIdValue : 1 == 1) &&
                                       (worKflowId != null ? w.WorKflowId == worKflowIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(approvalLevel) ? w.ApprovalLevel.Contains(approvalLevel) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(description) ? w.Description.Contains(description) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(autoApprove) ? w.AutoApprove.Contains(autoApprove) : 1 == 1) &&
                                       (waitTime != null ? w.WaitTime == waitTimeValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? w.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (createdOn != null ? w.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(updatedBy) ? w.UpdatedBy.Contains(updatedBy) : 1 == 1) &&
                                       (updatedOn != null ? w.UpdatedOn == updatedOnValue : 1 == 1) 
                                   ).OrderBy(w => w.WorKflowId).Skip(startRowIndex).Take(rows).ToList();

                     case "ApprovalLevel":
                         return context.WorkflowStepsMaster
                             .Where(w =>
                                       (stepId != null ? w.StepId == stepIdValue : 1 == 1) &&
                                       (worKflowId != null ? w.WorKflowId == worKflowIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(approvalLevel) ? w.ApprovalLevel.Contains(approvalLevel) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(description) ? w.Description.Contains(description) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(autoApprove) ? w.AutoApprove.Contains(autoApprove) : 1 == 1) &&
                                       (waitTime != null ? w.WaitTime == waitTimeValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? w.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (createdOn != null ? w.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(updatedBy) ? w.UpdatedBy.Contains(updatedBy) : 1 == 1) &&
                                       (updatedOn != null ? w.UpdatedOn == updatedOnValue : 1 == 1) 
                                   ).OrderBy(w => w.ApprovalLevel).Skip(startRowIndex).Take(rows).ToList();

                     case "Description":
                         return context.WorkflowStepsMaster
                             .Where(w =>
                                       (stepId != null ? w.StepId == stepIdValue : 1 == 1) &&
                                       (worKflowId != null ? w.WorKflowId == worKflowIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(approvalLevel) ? w.ApprovalLevel.Contains(approvalLevel) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(description) ? w.Description.Contains(description) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(autoApprove) ? w.AutoApprove.Contains(autoApprove) : 1 == 1) &&
                                       (waitTime != null ? w.WaitTime == waitTimeValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? w.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (createdOn != null ? w.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(updatedBy) ? w.UpdatedBy.Contains(updatedBy) : 1 == 1) &&
                                       (updatedOn != null ? w.UpdatedOn == updatedOnValue : 1 == 1) 
                                   ).OrderBy(w => w.Description).Skip(startRowIndex).Take(rows).ToList();

                     case "AutoApprove":
                         return context.WorkflowStepsMaster
                             .Where(w =>
                                       (stepId != null ? w.StepId == stepIdValue : 1 == 1) &&
                                       (worKflowId != null ? w.WorKflowId == worKflowIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(approvalLevel) ? w.ApprovalLevel.Contains(approvalLevel) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(description) ? w.Description.Contains(description) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(autoApprove) ? w.AutoApprove.Contains(autoApprove) : 1 == 1) &&
                                       (waitTime != null ? w.WaitTime == waitTimeValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? w.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (createdOn != null ? w.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(updatedBy) ? w.UpdatedBy.Contains(updatedBy) : 1 == 1) &&
                                       (updatedOn != null ? w.UpdatedOn == updatedOnValue : 1 == 1) 
                                   ).OrderBy(w => w.AutoApprove).Skip(startRowIndex).Take(rows).ToList();

                     case "WaitTime":
                         return context.WorkflowStepsMaster
                             .Where(w =>
                                       (stepId != null ? w.StepId == stepIdValue : 1 == 1) &&
                                       (worKflowId != null ? w.WorKflowId == worKflowIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(approvalLevel) ? w.ApprovalLevel.Contains(approvalLevel) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(description) ? w.Description.Contains(description) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(autoApprove) ? w.AutoApprove.Contains(autoApprove) : 1 == 1) &&
                                       (waitTime != null ? w.WaitTime == waitTimeValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? w.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (createdOn != null ? w.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(updatedBy) ? w.UpdatedBy.Contains(updatedBy) : 1 == 1) &&
                                       (updatedOn != null ? w.UpdatedOn == updatedOnValue : 1 == 1) 
                                   ).OrderBy(w => w.WaitTime).Skip(startRowIndex).Take(rows).ToList();

                     case "CreatedBy":
                         return context.WorkflowStepsMaster
                             .Where(w =>
                                       (stepId != null ? w.StepId == stepIdValue : 1 == 1) &&
                                       (worKflowId != null ? w.WorKflowId == worKflowIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(approvalLevel) ? w.ApprovalLevel.Contains(approvalLevel) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(description) ? w.Description.Contains(description) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(autoApprove) ? w.AutoApprove.Contains(autoApprove) : 1 == 1) &&
                                       (waitTime != null ? w.WaitTime == waitTimeValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? w.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (createdOn != null ? w.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(updatedBy) ? w.UpdatedBy.Contains(updatedBy) : 1 == 1) &&
                                       (updatedOn != null ? w.UpdatedOn == updatedOnValue : 1 == 1) 
                                   ).OrderBy(w => w.CreatedBy).Skip(startRowIndex).Take(rows).ToList();

                     case "CreatedOn":
                         return context.WorkflowStepsMaster
                             .Where(w =>
                                       (stepId != null ? w.StepId == stepIdValue : 1 == 1) &&
                                       (worKflowId != null ? w.WorKflowId == worKflowIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(approvalLevel) ? w.ApprovalLevel.Contains(approvalLevel) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(description) ? w.Description.Contains(description) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(autoApprove) ? w.AutoApprove.Contains(autoApprove) : 1 == 1) &&
                                       (waitTime != null ? w.WaitTime == waitTimeValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? w.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (createdOn != null ? w.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(updatedBy) ? w.UpdatedBy.Contains(updatedBy) : 1 == 1) &&
                                       (updatedOn != null ? w.UpdatedOn == updatedOnValue : 1 == 1) 
                                   ).OrderBy(w => w.CreatedOn).Skip(startRowIndex).Take(rows).ToList();

                     case "UpdatedBy":
                         return context.WorkflowStepsMaster
                             .Where(w =>
                                       (stepId != null ? w.StepId == stepIdValue : 1 == 1) &&
                                       (worKflowId != null ? w.WorKflowId == worKflowIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(approvalLevel) ? w.ApprovalLevel.Contains(approvalLevel) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(description) ? w.Description.Contains(description) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(autoApprove) ? w.AutoApprove.Contains(autoApprove) : 1 == 1) &&
                                       (waitTime != null ? w.WaitTime == waitTimeValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? w.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (createdOn != null ? w.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(updatedBy) ? w.UpdatedBy.Contains(updatedBy) : 1 == 1) &&
                                       (updatedOn != null ? w.UpdatedOn == updatedOnValue : 1 == 1) 
                                   ).OrderBy(w => w.UpdatedBy).Skip(startRowIndex).Take(rows).ToList();

                     case "UpdatedOn":
                         return context.WorkflowStepsMaster
                             .Where(w =>
                                       (stepId != null ? w.StepId == stepIdValue : 1 == 1) &&
                                       (worKflowId != null ? w.WorKflowId == worKflowIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(approvalLevel) ? w.ApprovalLevel.Contains(approvalLevel) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(description) ? w.Description.Contains(description) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(autoApprove) ? w.AutoApprove.Contains(autoApprove) : 1 == 1) &&
                                       (waitTime != null ? w.WaitTime == waitTimeValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? w.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (createdOn != null ? w.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(updatedBy) ? w.UpdatedBy.Contains(updatedBy) : 1 == 1) &&
                                       (updatedOn != null ? w.UpdatedOn == updatedOnValue : 1 == 1) 
                                   ).OrderBy(w => w.UpdatedOn).Skip(startRowIndex).Take(rows).ToList();

                     default:
                         return context.WorkflowStepsMaster
                             .Where(w =>
                                       (stepId != null ? w.StepId == stepIdValue : 1 == 1) &&
                                       (worKflowId != null ? w.WorKflowId == worKflowIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(approvalLevel) ? w.ApprovalLevel.Contains(approvalLevel) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(description) ? w.Description.Contains(description) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(autoApprove) ? w.AutoApprove.Contains(autoApprove) : 1 == 1) &&
                                       (waitTime != null ? w.WaitTime == waitTimeValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(createdBy) ? w.CreatedBy.Contains(createdBy) : 1 == 1) &&
                                       (createdOn != null ? w.CreatedOn == createdOnValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(updatedBy) ? w.UpdatedBy.Contains(updatedBy) : 1 == 1) &&
                                       (updatedOn != null ? w.UpdatedOn == updatedOnValue : 1 == 1) 
                                   ).OrderBy(w => w.StepId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
         }

         /// <summary>
         /// Selects all WorkflowStepsMaster
         /// </summary>
         internal static List<WorkflowStepsMaster> SelectAll()
         {
             FirstTempdbContext context = new FirstTempdbContext();
             return context.WorkflowStepsMaster.ToList();
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of WorkflowStepsMaster.
         /// </summary>
         internal static List<WorkflowStepsMaster> SelectAllDynamicWhere(int? stepId, int? worKflowId, string approvalLevel, string description, string autoApprove, int? waitTime, string createdBy, DateTime? createdOn, string updatedBy, DateTime? updatedOn)
         {
             FirstTempdbContext context = new FirstTempdbContext();

             int stepIdValue = int.MinValue;
             int worKflowIdValue = int.MinValue;
             int waitTimeValue = int.MinValue;
             DateTime createdOnValue = DateTime.MinValue;
             DateTime updatedOnValue = DateTime.MinValue;

             if (stepId != null)
                stepIdValue = stepId.Value;

             if (worKflowId != null)
                worKflowIdValue = worKflowId.Value;

             if (waitTime != null)
                waitTimeValue = waitTime.Value;

             if (createdOn != null)
                createdOnValue = createdOn.Value;

             if (updatedOn != null)
                updatedOnValue = updatedOn.Value;

             return context.WorkflowStepsMaster
                 .Where(w =>
                           (stepId != null ? w.StepId == stepIdValue : 1 == 1) &&
                           (worKflowId != null ? w.WorKflowId == worKflowIdValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(approvalLevel) ? w.ApprovalLevel.Contains(approvalLevel) : 1 == 1) &&
                           (!String.IsNullOrEmpty(description) ? w.Description.Contains(description) : 1 == 1) &&
                           (!String.IsNullOrEmpty(autoApprove) ? w.AutoApprove.Contains(autoApprove) : 1 == 1) &&
                           (waitTime != null ? w.WaitTime == waitTimeValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(createdBy) ? w.CreatedBy.Contains(createdBy) : 1 == 1) &&
                           (createdOn != null ? w.CreatedOn == createdOnValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(updatedBy) ? w.UpdatedBy.Contains(updatedBy) : 1 == 1) &&
                           (updatedOn != null ? w.UpdatedOn == updatedOnValue : 1 == 1) 
                       ).ToList();
         }

         /// <summary>
         /// Selects all WorkflowStepsMaster by WorkflowMaster, related to column WorKflowId
         /// </summary>
         internal static List<WorkflowStepsMaster> SelectWorkflowStepsMasterCollectionByWorKflowId(int workflowId)
         {
             FirstTempdbContext context = new FirstTempdbContext();
             return context.WorkflowStepsMaster.Where(w => w.WorKflowId == workflowId).ToList();
         }
         /// <summary>
         /// Selects StepId and ApprovalLevel columns for use with a DropDownList web control
         /// </summary>
         internal static List<WorkflowStepsMaster> SelectWorkflowStepsMasterDropDownListData()
         {
             FirstTempdbContext context = new FirstTempdbContext();
             return (from w in context.WorkflowStepsMaster
                     select new WorkflowStepsMaster { StepId = w.StepId, ApprovalLevel = w.ApprovalLevel }).ToList();
         }
         /// <summary>
         /// Inserts a record
         /// </summary>
         internal static int Insert(WorkflowStepsMaster objWorkflowStepsMaster)
         {
             FirstTempdbContext context = new FirstTempdbContext();
             WorkflowStepsMaster entWorkflowStepsMaster = new WorkflowStepsMaster();

             entWorkflowStepsMaster.WorKflowId = objWorkflowStepsMaster.WorKflowId;
             entWorkflowStepsMaster.ApprovalLevel = objWorkflowStepsMaster.ApprovalLevel;
             entWorkflowStepsMaster.Description = objWorkflowStepsMaster.Description;
             entWorkflowStepsMaster.AutoApprove = objWorkflowStepsMaster.AutoApprove;
             entWorkflowStepsMaster.WaitTime = objWorkflowStepsMaster.WaitTime;
             entWorkflowStepsMaster.CreatedBy = objWorkflowStepsMaster.CreatedBy;
             entWorkflowStepsMaster.CreatedOn = objWorkflowStepsMaster.CreatedOn;
             entWorkflowStepsMaster.UpdatedBy = objWorkflowStepsMaster.UpdatedBy;
             entWorkflowStepsMaster.UpdatedOn = objWorkflowStepsMaster.UpdatedOn;

             context.WorkflowStepsMaster.Add(entWorkflowStepsMaster);
             context.SaveChanges();

             return entWorkflowStepsMaster.StepId;
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         internal static void Update(WorkflowStepsMaster objWorkflowStepsMaster)
         {
             FirstTempdbContext context = new FirstTempdbContext();
             WorkflowStepsMaster entWorkflowStepsMaster = context.WorkflowStepsMaster.Where(w => w.StepId == objWorkflowStepsMaster.StepId).FirstOrDefault();

             if (entWorkflowStepsMaster != null)
             {
                 entWorkflowStepsMaster.WorKflowId = objWorkflowStepsMaster.WorKflowId;
                 entWorkflowStepsMaster.ApprovalLevel = objWorkflowStepsMaster.ApprovalLevel;
                 entWorkflowStepsMaster.Description = objWorkflowStepsMaster.Description;
                 entWorkflowStepsMaster.AutoApprove = objWorkflowStepsMaster.AutoApprove;
                 entWorkflowStepsMaster.WaitTime = objWorkflowStepsMaster.WaitTime;
                 entWorkflowStepsMaster.CreatedBy = objWorkflowStepsMaster.CreatedBy;
                 entWorkflowStepsMaster.CreatedOn = objWorkflowStepsMaster.CreatedOn;
                 entWorkflowStepsMaster.UpdatedBy = objWorkflowStepsMaster.UpdatedBy;
                 entWorkflowStepsMaster.UpdatedOn = objWorkflowStepsMaster.UpdatedOn;

                 context.SaveChanges();
             }
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         internal static void Delete(int stepId)
         {
             FirstTempdbContext context = new FirstTempdbContext();
             var objWorkflowStepsMaster = context.WorkflowStepsMaster.Where(w => w.StepId == stepId).FirstOrDefault();

             if (objWorkflowStepsMaster != null)
             {
                 context.WorkflowStepsMaster.Remove(objWorkflowStepsMaster);
                 context.SaveChanges();
             }
         }
     }
}
