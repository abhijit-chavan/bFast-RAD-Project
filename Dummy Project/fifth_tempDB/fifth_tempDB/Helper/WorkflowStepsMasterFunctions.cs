using fifth_tempDBAPI.Domain;
using fifth_tempDBAPI.BusinessObject;
using Application_Components.EmailNotification;
using System;

namespace fifth_tempDB
{
     public class WorkflowStepsMasterFunctions
     {
         private WorkflowStepsMasterFunctions()
         {
         }


         /// <summary>
         /// Used when adding or updating a record.
         /// </summary>
         internal static void AddOrEdit(WorkflowStepsMaster model, CrudOperation operation, bool isForListInline = false)
         {
             WorkflowStepsMaster objWorkflowStepsMaster;
             WorkflowStepsMaster objWorkflowStepsMasterOld = new WorkflowStepsMaster();
             decimal id = 0;

             if (operation == CrudOperation.Add)
                objWorkflowStepsMaster = new WorkflowStepsMaster();
             else
             {
                 objWorkflowStepsMaster = WorkflowStepsMaster.SelectByPrimaryKey(model.StepId);
                 objWorkflowStepsMasterOld = objWorkflowStepsMaster.ShallowCopy();
             }

             objWorkflowStepsMaster.StepId = model.StepId;
             objWorkflowStepsMaster.WorKflowId = model.WorKflowId;
             objWorkflowStepsMaster.ApprovalLevel = model.ApprovalLevel;
             objWorkflowStepsMaster.Description = model.Description;
             objWorkflowStepsMaster.AutoApprove = model.AutoApprove;
             objWorkflowStepsMaster.CreatedBy = model.CreatedBy;
             objWorkflowStepsMaster.CreatedOn = model.CreatedOn;
             objWorkflowStepsMaster.UpdatedBy = model.UpdatedBy;
             objWorkflowStepsMaster.UpdatedOn = model.UpdatedOn;

             if (isForListInline)
             {
                 objWorkflowStepsMaster.WaitTime = model.WaitTime;
             }
             else
             {
                 if(!String.IsNullOrEmpty(model.WaitTimeHidden))
                    objWorkflowStepsMaster.WaitTime = Convert.ToInt32(model.WaitTimeHidden);
                 else
                    objWorkflowStepsMaster.WaitTime = null;

             }

             if (operation == CrudOperation.Add)
             {
                id = objWorkflowStepsMaster.Insert();
             }
             else
             {
                objWorkflowStepsMaster.Update();
             }
         }
     }
}
