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
     public class UserMaster_ListScrollLoadModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;


         /// <summary>
         /// Gets the list of data for use by the jqgrid plug-in
         /// </summary>
         public IActionResult OnGetGridData(string sidx, string sord, int _page, int rows, bool isforJqGrid = true)
         {
             int totalRecords = UserMaster.GetRecordCount();
             int startRowIndex = ((_page * rows) - rows);
             List<UserMaster> objUserMasterCol = UserMaster.SelectSkipAndTake(rows, startRowIndex, sidx + " " + sord);
             int totalPages = (int)Math.Ceiling((float)totalRecords / (float)rows);

             if (objUserMasterCol is null)
                 return new JsonResult("{ total = 0, page = 0, records = 0, rows = null }");

             var jsonData = new
             {
                 total = totalPages,
                 _page,
                 records = totalRecords,
                 rows = (
                     from objUserMaster in objUserMasterCol
                     select new
                     {
                         id = objUserMaster.UserId,
                         cell = new string[] { 
                             objUserMaster.UserId.ToString(),
                             objUserMaster.UserName,
                             objUserMaster.Password,
                             objUserMaster.Email,
                             objUserMaster.CreatedOn.ToString("d"),
                             objUserMaster.CreatedBy,
                             objUserMaster.ModifiedOn.HasValue ? objUserMaster.ModifiedOn.Value.ToString("d") : "",
                             objUserMaster.ModifiedBy
                         }
                     }).ToArray()
             };

             return new JsonResult(jsonData);
         }
     }
}
