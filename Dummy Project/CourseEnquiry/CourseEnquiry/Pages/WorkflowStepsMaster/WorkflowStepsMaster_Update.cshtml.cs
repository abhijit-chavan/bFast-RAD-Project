using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CourseEnquiryAPI.Domain;
using CourseEnquiryAPI.BusinessObject;
using Newtonsoft.Json;
using Application_Components.Logging;
using Application_Components.EmailNotification;
using CourseEnquiry.PartialModels;

namespace CourseEnquiry.Pages
{
     [AutoValidateAntiforgeryToken]
     public class WorkflowStepsMaster_UpdateModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;

         [BindProperty]
         public CourseEnquiryAPI.BusinessObject.WorkflowStepsMaster WorkflowStepsMaster { get; set; }

         [BindProperty]
         public string ReturnUrl { get; set; }

         public AddEditWorkflowStepsMasterPartialModel PartialModel { get; set; }


         /// <summary>
         /// Default Constructor: /WorkflowStepsMaster_UpdateModel
         /// </summary>
         public WorkflowStepsMaster_UpdateModel (ILog Ilog,IEmail IEmail)
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
             CourseEnquiryAPI.BusinessObject.WorkflowStepsMaster objWorkflowStepsMaster = WorkflowStepsMaster.SelectByPrimaryKey(id);

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
             // create the model used by the partial page
             AddEditWorkflowStepsMasterPartialModel model = new AddEditWorkflowStepsMasterPartialModel();
             model.WorkflowMasterDropDownListData = WorkflowMaster.SelectWorkflowMasterDropDownListData();
             model.Operation = CrudOperation.Update;
             model.ReturnUrl = returnUrl;
             model.WorkflowStepsMaster = objWorkflowStepsMasterTemp;

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
                     WorkflowStepsMasterFunctions.AddOrEdit(WorkflowStepsMaster, CrudOperation.Update);
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
             return LoadPage(WorkflowStepsMaster.StepId, ReturnUrl);
         }
     }
}
