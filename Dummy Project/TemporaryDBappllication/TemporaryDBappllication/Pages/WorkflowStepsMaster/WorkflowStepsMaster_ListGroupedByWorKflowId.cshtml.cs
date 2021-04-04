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
     public class WorkflowStepsMaster_ListGroupedByWorKflowIdModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;


         /// <summary>
         /// Gets the list of data for use by the jqgrid plug-in
         /// </summary>
         public IActionResult OnGetGridDataGroupedByWorKflowId(string sidx, string sord, int _page, int rows)
         {
             // using a groupField in the jqgrid passes that field
             // along with the field to sort, remove the groupField
             string groupBy = "WorkflowName asc, ";
             sidx = sidx.Replace(groupBy, "");

             int totalRecords = WorkflowStepsMaster.GetRecordCount();
             int startRowIndex = ((_page * rows) - rows);

             List<WorkflowStepsMaster> objWorkflowStepsMasterCol = WorkflowStepsMaster.SelectSkipAndTake(rows, startRowIndex, sidx + " " + sord);
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
                             objWorkflowStepsMaster.UpdatedOn.ToString("d"),
                             objWorkflowStepsMaster.WorKflowId is null ? "" : objWorkflowStepsMaster.WorKflowIdNavigation.WorkflowName

                         }
                     }).ToArray()
             };

             return new JsonResult(jsonData);
         }
     }
}
