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
     public class RoleMaster_ListInlineModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;


         /// <summary>
         /// Default Constructor: /RoleMaster_ListInlineModel
         /// </summary>
         public RoleMaster_ListInlineModel (ILog Ilog,IEmail IEmail)
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
             RoleMaster RoleMaster = RoleMaster.SelectByPrimaryKey(id);
             RoleMaster.Delete(id);
             return new JsonResult(true);
         }

         /// <summary>
         /// Handler, adds a new record.
         /// </summary>
         public IActionResult OnGetAdd(string serializedData)
         {
             RoleMaster objRoleMaster = JsonConvert.DeserializeObject<RoleMaster>(serializedData);
             RoleMasterFunctions.AddOrEdit(objRoleMaster, CrudOperation.Add, true);
             return new JsonResult(true);
         }

         /// <summary>
         /// Handler, updates a record.
         /// </summary>
         public IActionResult OnGetUpdate(int id, string serializedData)
         {
             RoleMaster objRoleMaster = JsonConvert.DeserializeObject<RoleMaster>(serializedData);
             RoleMasterFunctions.AddOrEdit(objRoleMaster, CrudOperation.Update, true);
             return new JsonResult(true);
         }

         /// <summary>
         /// Gets the list of data for use by the jqgrid plug-in
         /// </summary>
         public IActionResult OnGetGridData(string sidx, string sord, int _page, int rows, bool isforJqGrid = true)
         {
             int totalRecords = RoleMaster.GetRecordCount();
             int startRowIndex = ((_page * rows) - rows);
             List<RoleMaster> objRoleMasterCol = RoleMaster.SelectSkipAndTake(rows, startRowIndex, sidx + " " + sord);
             int totalPages = (int)Math.Ceiling((float)totalRecords / (float)rows);

             if (objRoleMasterCol is null)
                 return new JsonResult("{ total = 0, page = 0, records = 0, rows = null }");

             var jsonData = new
             {
                 total = totalPages,
                 _page,
                 records = totalRecords,
                 rows = (
                     from objRoleMaster in objRoleMasterCol
                     select new
                     {
                         id = objRoleMaster.RoleId,
                         cell = new string[] { 
                             objRoleMaster.RoleId.ToString(),
                             objRoleMaster.RoleDescription,
                             objRoleMaster.CreatedOn.ToString("d"),
                             objRoleMaster.CreatedBy,
                             objRoleMaster.ModifiedOn.HasValue ? objRoleMaster.ModifiedOn.Value.ToString("d") : "",
                             objRoleMaster.ModifiedBy
                         }
                     }).ToArray()
             };

             return new JsonResult(jsonData);
         }
     }
}
