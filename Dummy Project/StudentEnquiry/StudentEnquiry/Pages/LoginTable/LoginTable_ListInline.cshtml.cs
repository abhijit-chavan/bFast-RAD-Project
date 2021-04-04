using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentEnquiryAPI.Domain;
using StudentEnquiryAPI.BusinessObject;
using Newtonsoft.Json;
using Application_Components.Logging;
using Application_Components.EmailNotification;

namespace StudentEnquiry.Pages
{
     [AutoValidateAntiforgeryToken]
     public class LoginTable_ListInlineModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;


         /// <summary>
         /// Default Constructor: /LoginTable_ListInlineModel
         /// </summary>
         public LoginTable_ListInlineModel (ILog Ilog,IEmail IEmail)
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
         /// Handler, deletes a record.
         /// </summary>
         public IActionResult OnGetRemove(int id)
         {
             LoginTable LoginTable = LoginTable.SelectByPrimaryKey(id);
             LoginTable.Delete(id);
             return new JsonResult(true);
         }

         /// <summary>
         /// Handler, adds a new record.
         /// </summary>
         public IActionResult OnGetAdd(string serializedData)
         {
             LoginTable objLoginTable = JsonConvert.DeserializeObject<LoginTable>(serializedData);
             LoginTableFunctions.AddOrEdit(objLoginTable, CrudOperation.Add, true);
             return new JsonResult(true);
         }

         /// <summary>
         /// Handler, updates a record.
         /// </summary>
         public IActionResult OnGetUpdate(int id, string serializedData)
         {
             LoginTable objLoginTable = JsonConvert.DeserializeObject<LoginTable>(serializedData);
             LoginTableFunctions.AddOrEdit(objLoginTable, CrudOperation.Update, true);
             return new JsonResult(true);
         }

         /// <summary>
         /// Gets the list of data for use by the jqgrid plug-in
         /// </summary>
         public IActionResult OnGetGridData(string sidx, string sord, int _page, int rows, bool isforJqGrid = true)
         {
             int totalRecords = LoginTable.GetRecordCount();
             int startRowIndex = ((_page * rows) - rows);
             List<LoginTable> objLoginTableCol = LoginTable.SelectSkipAndTake(rows, startRowIndex, sidx + " " + sord);
             int totalPages = (int)Math.Ceiling((float)totalRecords / (float)rows);

             if (objLoginTableCol is null)
                 return new JsonResult("{ total = 0, page = 0, records = 0, rows = null }");

             var jsonData = new
             {
                 total = totalPages,
                 _page,
                 records = totalRecords,
                 rows = (
                     from objLoginTable in objLoginTableCol
                     select new
                     {
                         id = objLoginTable.Adminid,
                         cell = new string[] { 
                             objLoginTable.Adminid.ToString(),
                             objLoginTable.Password
                         }
                     }).ToArray()
             };

             return new JsonResult(jsonData);
         }
     }
}
