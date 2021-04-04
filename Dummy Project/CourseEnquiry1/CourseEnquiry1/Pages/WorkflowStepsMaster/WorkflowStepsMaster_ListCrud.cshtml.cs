using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CourseEnquiry1API.Domain;
using CourseEnquiry1API.BusinessObject;
using Newtonsoft.Json;
using Application_Components.Logging;
using Application_Components.EmailNotification;

namespace CourseEnquiry1.Pages
{
     [AutoValidateAntiforgeryToken]
     public class WorkflowStepsMaster_ListCrudModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;

         [BindProperty]
         public CourseEnquiry1API.BusinessObject.WorkflowStepsMaster WorkflowStepsMaster { get; set; }

         public List<WorkflowMaster> WorkflowMasterDropDownListData;


         /// <summary>
         /// Default Constructor: /WorkflowStepsMaster_ListCrudModel
         /// </summary>
         public WorkflowStepsMaster_ListCrudModel (ILog Ilog,IEmail IEmail)
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
             SetData();
         }

         /// <summary>
         /// Handler, adds a new record.
         /// </summary>
         public IActionResult OnGetAdd(string serializedData)
         {
             WorkflowStepsMaster objWorkflowStepsMaster = JsonConvert.DeserializeObject<WorkflowStepsMaster>(serializedData);
             WorkflowStepsMasterFunctions.AddOrEdit(objWorkflowStepsMaster, CrudOperation.Add, true);
             return new JsonResult(true);
         }

         /// <summary>
         /// Handler, updates a record.
         /// </summary>
         public IActionResult OnGetUpdate(string serializedData)
         {
             WorkflowStepsMaster objWorkflowStepsMaster = JsonConvert.DeserializeObject<WorkflowStepsMaster>(serializedData);
             WorkflowStepsMasterFunctions.AddOrEdit(objWorkflowStepsMaster, CrudOperation.Update, true);
             return new JsonResult(true);
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

         /// <summary>
         /// Sets data needed on page intialization.
         /// </summary>
         private void SetData()
         {
             WorkflowStepsMaster = new CourseEnquiry1API.BusinessObject.WorkflowStepsMaster();
             WorkflowMasterDropDownListData = WorkflowMaster.SelectWorkflowMasterDropDownListData();
         }

         /// <summary>
         /// Gets the list of data for use by the jqgrid plug-in
         /// </summary>
         public IActionResult OnGetGridData(string sidx, string sord, int _page, int rows, bool isforJqGrid = true)
         {
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
                             objWorkflowStepsMaster.UpdatedOn.ToString("d")
                         }
                     }).ToArray()
             };

             return new JsonResult(jsonData);
         }
     }
}
