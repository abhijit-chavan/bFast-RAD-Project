using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TemporaryDBappllicationAPI.Domain;
using TemporaryDBappllicationAPI.BusinessObject;
using Newtonsoft.Json;
using Application_Components.Logging;
using Application_Components.EmailNotification;

namespace TemporaryDBappllication.Pages
{
     [AutoValidateAntiforgeryToken]
     public class WorkflowMaster_ListSearchModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;


         /// <summary>
         /// Default Constructor: /WorkflowMaster_ListSearchModel
         /// </summary>
         public WorkflowMaster_ListSearchModel (ILog Ilog,IEmail IEmail)
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
         }

         /// <summary>
         /// Gets the list of data for use by the jqgrid plug-in
         /// </summary>
         public IActionResult OnGetGridDataWithFilters(string sidx, string sord, int _page, int rows, string filters)
         {
             int? workflowId = null;
             string workflowName = String.Empty;
             int? levelOfApprovals = null;
             string createdBy = String.Empty;
             DateTime? createdOn = null;
             string updatedby = String.Empty;
             DateTime? updatedon = null;

             if (!String.IsNullOrEmpty(filters))
             {
                 // deserialize json and get values being searched
                 var jsonResult = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(filters);

                 foreach (var rule in jsonResult["rules"])
                 {
                     if (rule["field"].Value.ToLower() == "workflowid")
                         workflowId = Convert.ToInt32(rule["data"].Value);

                     if (rule["field"].Value.ToLower() == "workflowname")
                         workflowName = rule["data"].Value;

                     if (rule["field"].Value.ToLower() == "levelofapprovals")
                         levelOfApprovals = Convert.ToInt32(rule["data"].Value);

                     if (rule["field"].Value.ToLower() == "createdby")
                         createdBy = rule["data"].Value;

                     if (rule["field"].Value.ToLower() == "createdon")
                         createdOn = Convert.ToDateTime(rule["data"].Value);

                     if (rule["field"].Value.ToLower() == "updatedby")
                         updatedby = rule["data"].Value;

                     if (rule["field"].Value.ToLower() == "updatedon")
                         updatedon = Convert.ToDateTime(rule["data"].Value);

                 }

                 // sometimes jqgrid assigns a -1 to numeric fields when no value is assigned
                 // instead of assigning a null, we'll correct this here
                 if (workflowId == -1)
                     workflowId = null;

                 if (levelOfApprovals == -1)
                     levelOfApprovals = null;

             }

             int totalRecords = WorkflowMaster.GetRecordCountDynamicWhere(workflowId, workflowName, levelOfApprovals, createdBy, createdOn, updatedby, updatedon);
             int startRowIndex = ((_page * rows) - rows);
             List<WorkflowMaster> objWorkflowMasterCol = WorkflowMaster.SelectSkipAndTakeDynamicWhere(workflowId, workflowName, levelOfApprovals, createdBy, createdOn, updatedby, updatedon, rows, startRowIndex, sidx + " " + sord);
             int totalPages = (int)Math.Ceiling((float)totalRecords / (float)rows);

             if (objWorkflowMasterCol is null)
                 return new JsonResult("{ total = 0, page = 0, records = 0, rows = null }");

             var jsonData = new
             {
                 total = totalPages,
                 _page,
                 records = totalRecords,
                 rows = (
                     from objWorkflowMaster in objWorkflowMasterCol
                     select new
                     {
                         id = objWorkflowMaster.WorkflowId,
                         cell = new string[] { 
                             objWorkflowMaster.WorkflowId.ToString(),
                             objWorkflowMaster.WorkflowName,
                             objWorkflowMaster.LevelOfApprovals.HasValue ? objWorkflowMaster.LevelOfApprovals.Value.ToString() : "",
                             objWorkflowMaster.CreatedBy,
                             objWorkflowMaster.CreatedOn.ToString("d"),
                             objWorkflowMaster.Updatedby,
                             objWorkflowMaster.Updatedon.ToString("d")
                         }
                     }).ToArray()
             };

             return new JsonResult(jsonData);
         }
     }
}
