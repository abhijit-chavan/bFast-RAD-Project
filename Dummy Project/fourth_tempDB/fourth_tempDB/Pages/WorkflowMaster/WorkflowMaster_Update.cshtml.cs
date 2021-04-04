using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using fourth_tempDBAPI.Domain;
using fourth_tempDBAPI.BusinessObject;
using Newtonsoft.Json;
using Application_Components.Logging;
using Application_Components.EmailNotification;
using fourth_tempDB.PartialModels;

namespace fourth_tempDB.Pages
{
     [AutoValidateAntiforgeryToken]
     public class WorkflowMaster_UpdateModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;

         [BindProperty]
         public fourth_tempDBAPI.BusinessObject.WorkflowMaster WorkflowMaster { get; set; }

         [BindProperty]
         public string ReturnUrl { get; set; }

         public AddEditWorkflowMasterPartialModel PartialModel { get; set; }


         /// <summary>
         /// Default Constructor: /WorkflowMaster_UpdateModel
         /// </summary>
         public WorkflowMaster_UpdateModel (ILog Ilog,IEmail IEmail)
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

         public PageResult LoadPage(int id, string returnUrl)
         {
             // select a record by primary key(s)
             fourth_tempDBAPI.BusinessObject.WorkflowMaster objWorkflowMaster = WorkflowMaster.SelectByPrimaryKey(id);

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
             // create the model used by the partial page
             AddEditWorkflowMasterPartialModel model = new AddEditWorkflowMasterPartialModel();
             model.Operation = CrudOperation.Update;
             model.ReturnUrl = returnUrl;
             model.WorkflowMaster = objWorkflowMasterTemp;

             // assign values to the model used by this page
             PartialModel = model;

             // assign the return url
             ReturnUrl = returnUrl;

             return Page();
         }

         public IActionResult OnPostUpdate()
         {
             if (ModelState.IsValid)
             {
                 try
                 {
                     // update record
                     WorkflowMasterFunctions.AddOrEdit(WorkflowMaster, CrudOperation.Update);
                     return RedirectToPage(ReturnUrl);
                 }
                 catch(Exception ex)
                 {
                     _Ilog.GetInstance().Error("Error Occured", ex);

                     if (ex.InnerException != null)
                         ModelState.AddModelError("", ex.InnerException.Message);
                     else
                         ModelState.AddModelError("", ex.Message);
                 }
             }

             // if we got this far, something failed, redisplay form
             return LoadPage(WorkflowMaster.WorkflowId, ReturnUrl);
         }
     }
}
