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
     public class RoleMaster_ListScrollLoadModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;


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
