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
     public class WorkflowStepsMaster_ListSearchModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;

         public List<WorkflowMaster> WorkflowMasterDropDownListData;


         /// <summary>
         /// Default Constructor: /WorkflowStepsMaster_ListSearchModel
         /// </summary>
         public WorkflowStepsMaster_ListSearchModel (ILog Ilog,IEmail IEmail)
         {
             if (_Ilog == null)
                 _Ilog = Ilog;
if (_IEmail == null)
_IEmail = IEmail;
         }

         /// <summary>
         /// Initial handler the razor page encounters.
         /// </summary>
         public void OnGet()
         {
             WorkflowMasterDropDownListData = WorkflowMaster.SelectWorkflowMasterDropDownListData();
         }

         /// <summary>
         /// Gets the list of data for use by the jqgrid plug-in
         /// </summary>
         public IActionResult OnGetGridDataWithFilters(string sidx, string sord, int _page, int rows, string filters)
         {
             int? stepId = null;
             int? worKflowId = null;
             string approvalLevel = String.Empty;
             string description = String.Empty;
             string autoApprove = String.Empty;
             int? waitTime = null;
             string createdBy = String.Empty;
             DateTime? createdOn = null;
             string updatedBy = String.Empty;
             DateTime? updatedOn = null;

             if (!String.IsNullOrEmpty(filters))
             {
                 // deserialize json and get values being searched
                 var jsonResult = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(filters);

                 foreach (var rule in jsonResult["rules"])
                 {
                     if (rule["field"].Value.ToLower() == "stepid")
                         stepId = Convert.ToInt32(rule["data"].Value);

                     if (rule["field"].Value.ToLower() == "workflowid")
                         worKflowId = Convert.ToInt32(rule["data"].Value);

                     if (rule["field"].Value.ToLower() == "approvallevel")
                         approvalLevel = rule["data"].Value;

                     if (rule["field"].Value.ToLower() == "description")
                         description = rule["data"].Value;

                     if (rule["field"].Value.ToLower() == "autoapprove")
                         autoApprove = rule["data"].Value;

                     if (rule["field"].Value.ToLower() == "waittime")
                         waitTime = Convert.ToInt32(rule["data"].Value);

                     if (rule["field"].Value.ToLower() == "createdby")
                         createdBy = rule["data"].Value;

                     if (rule["field"].Value.ToLower() == "createdon")
                         createdOn = Convert.ToDateTime(rule["data"].Value);

                     if (rule["field"].Value.ToLower() == "updatedby")
                         updatedBy = rule["data"].Value;

                     if (rule["field"].Value.ToLower() == "updatedon")
                         updatedOn = Convert.ToDateTime(rule["data"].Value);

                 }

                 // sometimes jqgrid assigns a -1 to numeric fields when no value is assigned
                 // instead of assigning a null, we'll correct this here
                 if (stepId == -1)
                     stepId = null;

                 if (worKflowId == -1)
                     worKflowId = null;

                 if (waitTime == -1)
                     waitTime = null;

             }

             int totalRecords = WorkflowStepsMaster.GetRecordCountDynamicWhere(stepId, worKflowId, approvalLevel, description, autoApprove, waitTime, createdBy, createdOn, updatedBy, updatedOn);
             int startRowIndex = ((_page * rows) - rows);
             List<WorkflowStepsMaster> objWorkflowStepsMasterCol = WorkflowStepsMaster.SelectSkipAndTakeDynamicWhere(stepId, worKflowId, approvalLevel, description, autoApprove, waitTime, createdBy, createdOn, updatedBy, updatedOn, rows, startRowIndex, sidx + " " + sord);
             int totalPages = (int)Math.Ceiling((float)totalRecords / (float)rows);

             if (objWorkflowStepsMasterCol is null)
                 return new JsonResult("{ total = 0, page = 0, records = 0, rows = null }");

             var jsonData = new
             {
                 total = totalPages,
                 _page,
                 records = totalRecords,
                 rows = (
                     from objWorkflowStepsMaster in objWorkflowStepsMasterCol
                     select new
                     {
                         id = objWorkflowStepsMaster.StepId,
                         cell = new string[] { 
                             objWorkflowStepsMaster.StepId.ToString(),
                             objWorkflowStepsMaster.WorKflowId.HasValue ? objWorkflowStepsMaster.WorKflowId.Value.ToString() : "",
                             objWorkflowStepsMaster.ApprovalLevel,
                             objWorkflowStepsMaster.Description,
                             objWorkflowStepsMaster.AutoApprove,
                             objWorkflowStepsMaster.WaitTime.HasValue ? objWorkflowStepsMaster.WaitTime.Value.ToString() : "",
                             objWorkflowStepsMaster.CreatedBy,
                             objWorkflowStepsMaster.CreatedOn.ToString("d"),
                             objWorkflowStepsMaster.UpdatedBy,
                             objWorkflowStepsMaster.UpdatedOn.ToString("d")
                         }
                     }).ToArray()
             };

             return new JsonResult(jsonData);
         }
     }
}
