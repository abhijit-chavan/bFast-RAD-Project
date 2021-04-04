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
     public class WorkflowMaster_DetailsModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;

         [BindProperty]
         public fifth_tempDBAPI.BusinessObject.WorkflowMaster WorkflowMaster { get; set; }

         [BindProperty]
         public string ReturnUrl { get; set; }


         /// <summary>
         /// Default Constructor: /WorkflowMaster_DetailsModel
         /// </summary>
         public WorkflowMaster_DetailsModel (ILog Ilog,IEmail IEmail)
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
             fifth_tempDBAPI.BusinessObject.WorkflowMaster objWorkflowMaster = WorkflowMaster.SelectByPrimaryKey(id);

             // assign values to the model
             WorkflowMaster objWorkflowMasterTemp = new WorkflowMaster();
             objWorkflowMasterTemp.WorkflowId = objWorkflowMaster.WorkflowId;
             objWorkflowMasterTemp.WorkflowName = objWorkflowMaster.WorkflowName;
             objWorkflowMasterTemp.LevelOfApprovals = objWorkflowMaster.LevelOfApprovals;

             if (objWorkflowMaster.LevelOfApprovals.HasValue)
                 objWorkflowMasterTemp.LevelOfApprovalsHidden = objWorkflowMaster.LevelOfApprovals.Value.ToString();
             else
                 objWorkflowMasterTemp.LevelOfApprovalsHidden = null;

             objWorkflowMasterTemp.CreatedBy = objWorkflowMaster.CreatedBy;
             objWorkflowMasterTemp.CreatedOn = objWorkflowMaster.CreatedOn;
             objWorkflowMasterTemp.Updatedby = objWorkflowMaster.Updatedby;
             objWorkflowMasterTemp.Updatedon = objWorkflowMaster.Updatedon;

             // assign values to this page's bound property
             WorkflowMaster = objWorkflowMasterTemp;

             // assign the return url
             ReturnUrl = returnUrl;
         }
     }
}
