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

namespace fourth_tempDB.Pages
{
     [AutoValidateAntiforgeryToken]
     public class WorkflowStepsMaster_ListForeachModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;

         public List<WorkflowStepsMaster> WorkflowStepsMasterData { get; set; }
         public string[,] WorkflowStepsMasterFieldNames { get; set; }
         public string FieldToSort { get; set; }
         public string FieldToSortWithOrder { get; set; }
         public string FieldSortOrder { get; set; }
         public int StartPage { get; set; }
         public int EndPage { get; set; }
         public int CurrentPage { get; set; }
         public int NumberOfPagesToShow { get; set; }
         public int TotalPages { get; set; }
         public List<string> UnsortableFields { get; set; }

         /// <summary>
         /// Default Constructor: /WorkflowStepsMaster_ListForeachModel
         /// </summary>
         public WorkflowStepsMaster_ListForeachModel (ILog Ilog,IEmail IEmail)
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
             string sidx = String.Empty;
             string sord = String.Empty;
             int currentPage = 1;

             GetData(sidx, sord, currentPage);
         }

         /// <summary>
         /// Handler, deletes a record.
         /// </summary>
         public IActionResult OnGetRemove(int id)
         {
             WorkflowStepsMaster WorkflowStepsMaster = WorkflowStepsMaster.SelectByPrimaryKey(id);
             WorkflowStepsMaster.Delete(id);
             return new JsonResult(true);
         }

         public void OnGetGridData(string sidx, string sord, int? _page)
         {
             GetData(sidx, sord, _page);
         }

         public void GetData(string sidx, string sord, int? _page)
         {
             int rows = Functions.GetGridNumberOfRows();
             int numberOfPagesToShow = Functions.GetGridNumberOfPagesToShow();
             int currentPage = _page is null ? 1 : Convert.ToInt32(_page);
             int startRowIndex = ((currentPage * rows) - rows);
             int totalRecords = WorkflowStepsMaster.GetRecordCount();
             int totalPages = (int)Math.Ceiling((float)totalRecords / (float)rows);
             List<WorkflowStepsMaster> objWorkflowStepsMasterCol = WorkflowStepsMaster.SelectSkipAndTake(rows, startRowIndex, sidx + " " + sord);

             // fields and titles
             string[,] fieldNames = new string[,] {
                 {"StepId", "Step Id"},
                 {"WorKflowId", "Wor Kflow Id"},
                 {"ApprovalLevel", "Approval Level"},
                 {"Description", "Description"},
                 {"AutoApprove", "Auto Approve"},
                 {"WaitTime", "Wait Time"},
                 {"CreatedBy", "Created By"},
                 {"CreatedOn", "Created On"},
                 {"UpdatedBy", "Updated By"},
                 {"UpdatedOn", "Updated On"}
             };

             // assign properties
             WorkflowStepsMasterData = objWorkflowStepsMasterCol;
             WorkflowStepsMasterFieldNames = fieldNames;
             TotalPages = totalPages;
             CurrentPage = currentPage;
             FieldToSort = String.IsNullOrEmpty(sidx) ? "StepId" : sidx;
             FieldSortOrder = String.IsNullOrEmpty(sord) ? "asc" : sord;
             FieldToSortWithOrder = String.IsNullOrEmpty(sidx) ? "StepId" : (sidx + " " + sord).Trim();
             NumberOfPagesToShow = numberOfPagesToShow;
             StartPage = Functions.GetPagerStartPage(currentPage, numberOfPagesToShow, totalPages);
             EndPage = Functions.GetPagerEndPage(StartPage, currentPage, numberOfPagesToShow, totalPages);
         }
     }
}
