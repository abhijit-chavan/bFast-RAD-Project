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

namespace CourseEnquiry.Pages
{
     [AutoValidateAntiforgeryToken]
     public class WorkflowMaster_ListCrudRedirectModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;


         /// <summary>
         /// Default Constructor: /WorkflowMaster_ListCrudRedirectModel
         /// </summary>
         public WorkflowMaster_ListCrudRedirectModel (ILog Ilog,IEmail IEmail)
         {
             if (_Ilog == null)
                 _Ilog = Ilog;
if (_IEmail == null)
_IEmail = IEmail;
         }


         /// <summary>
         /// Handler, deletes a record.
         /// </summary>
         public IActionResult OnGetRemove(int id)
         {
             WorkflowMaster WorkflowMaster = WorkflowMaster.SelectByPrimaryKey(id);
             WorkflowMaster.Delete(id);
             return new JsonResult(true);
         }

         /// <summary>
         /// Gets the list of data for use by the jqgrid plug-in
         /// </summary>
         public IActionResult OnGetGridData(string sidx, string sord, int _page, int rows, bool isforJqGrid = true)
         {
             int totalRecords = WorkflowMaster.GetRecordCount();
             int startRowIndex = ((_page * rows) - rows);
             List<WorkflowMaster> objWorkflowMasterCol = WorkflowMaster.SelectSkipAndTake(rows, startRowIndex, sidx + " " + sord);
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
