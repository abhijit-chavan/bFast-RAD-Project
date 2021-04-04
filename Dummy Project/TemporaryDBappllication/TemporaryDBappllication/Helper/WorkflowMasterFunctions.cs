using TemporaryDBappllicationAPI.Domain;
using TemporaryDBappllicationAPI.BusinessObject;
using Application_Components.EmailNotification;
using System;

namespace TemporaryDBappllication
{
     public class WorkflowMasterFunctions
     {
         private WorkflowMasterFunctions()
         {
         }


         /// <summary>
         /// Used when adding or updating a record.
         /// </summary>
         internal static void AddOrEdit(WorkflowMaster model, CrudOperation operation, bool isForListInline = false)
         {
             WorkflowMaster objWorkflowMaster;
             WorkflowMaster objWorkflowMasterOld = new WorkflowMaster();
             decimal id = 0;

             if (operation == CrudOperation.Add)
                objWorkflowMaster = new WorkflowMaster();
             else
             {
                 objWorkflowMaster = WorkflowMaster.SelectByPrimaryKey(model.WorkflowId);
                 objWorkflowMasterOld = objWorkflowMaster.ShallowCopy();
             }

             objWorkflowMaster.WorkflowId = model.WorkflowId;
             objWorkflowMaster.WorkflowName = model.WorkflowName;
             objWorkflowMaster.CreatedBy = model.CreatedBy;
             objWorkflowMaster.CreatedOn = model.CreatedOn;
             objWorkflowMaster.Updatedby = model.Updatedby;
             objWorkflowMaster.Updatedon = model.Updatedon;

             if (isForListInline)
             {
                 objWorkflowMaster.LevelOfApprovals = model.LevelOfApprovals;
             }
             else
             {
                 if(!String.IsNullOrEmpty(model.LevelOfApprovalsHidden))
                    objWorkflowMaster.LevelOfApprovals = Convert.ToInt32(model.LevelOfApprovalsHidden);
                 else
                    objWorkflowMaster.LevelOfApprovals = null;

             }

             if (operation == CrudOperation.Add)
             {
                id = objWorkflowMaster.Insert();
             }
             else
             {
                objWorkflowMaster.Update();
             }
         }
     }
}
