using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using fifth_tempDBAPI.Domain;
using fifth_tempDBAPI.BusinessObject;
using Newtonsoft.Json;
using Application_Components.Logging;
using Application_Components.EmailNotification;

namespace fifth_tempDB.Pages
{
     [AutoValidateAntiforgeryToken]
     public class WorkflowStepsMaster_DetailsModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;

         [BindProperty]
         public fifth_tempDBAPI.BusinessObject.WorkflowStepsMaster WorkflowStepsMaster { get; set; }

         [BindProperty]
         public string ReturnUrl { get; set; }


         /// <summary>
         /// Default Constructor: /WorkflowStepsMaster_DetailsModel
         /// </summary>
         public WorkflowStepsMaster_DetailsModel (ILog Ilog,IEmail IEmail)
         {
             if (_Ilog == null)
                 _Ilog = Ilog;
if (_IEmail == null)
_IEmail = IEmail;
         }

         /// <summary>
         /// Initial handler the razor page encounters.
         /// </summary>
         public void OnGet(int id, string returnUrl)
         {
             LoadPage(id, returnUrl);
         }

         public void LoadPage(int id, string returnUrl)
         {
             // select a record by primary key(s)
             fifth_tempDBAPI.BusinessObject.WorkflowStepsMaster objWorkflowStepsMaster = WorkflowStepsMaster.SelectByPrimaryKey(id);

             // assign values to the model
             WorkflowStepsMaster objWorkflowStepsMasterTemp = new WorkflowStepsMaster();
             objWorkflowStepsMasterTemp.StepId = objWorkflowStepsMaster.StepId;
             objWorkflowStepsMasterTemp.WorKflowId = objWorkflowStepsMaster.WorKflowId;
             objWorkflowStepsMasterTemp.ApprovalLevel = objWorkflowStepsMaster.ApprovalLevel;
             objWorkflowStepsMasterTemp.Description = objWorkflowStepsMaster.Description;
             objWorkflowStepsMasterTemp.AutoApprove = objWorkflowStepsMaster.AutoApprove;
             objWorkflowStepsMasterTemp.WaitTime = objWorkflowStepsMaster.WaitTime;

             if (objWorkflowStepsMaster.WaitTime.HasValue)
                 objWorkflowStepsMasterTemp.WaitTimeHidden = objWorkflowStepsMaster.WaitTime.Value.ToString();
             else
                 objWorkflowStepsMasterTemp.WaitTimeHidden = null;

             objWorkflowStepsMasterTemp.CreatedBy = objWorkflowStepsMaster.CreatedBy;
             objWorkflowStepsMasterTemp.CreatedOn = objWorkflowStepsMaster.CreatedOn;
             objWorkflowStepsMasterTemp.UpdatedBy = objWorkflowStepsMaster.UpdatedBy;
             objWorkflowStepsMasterTemp.UpdatedOn = objWorkflowStepsMaster.UpdatedOn;

             // assign values to this page's bound property
             WorkflowStepsMaster = objWorkflowStepsMasterTemp;

             // assign the return url
             ReturnUrl = returnUrl;
         }
     }
}
