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
     public class UserRoles_ListReadOnlyModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;


         /// <summary>
         /// Gets the list of data for use by the jqgrid plug-in
         /// </summary>
         public IActionResult OnGetGridData(string sidx, string sord, int _page, int rows, bool isforJqGrid = true)
         {
             int totalRecords = UserRoles.GetRecordCount();
             int startRowIndex = ((_page * rows) - rows);
             List<UserRoles> objUserRolesCol = UserRoles.SelectSkipAndTake(rows, startRowIndex, sidx + " " + sord);
             int totalPages = (int)Math.Ceiling((float)totalRecords / (float)rows);

             if (objUserRolesCol is null)
                 return new JsonResult("{ total = 0, page = 0, records = 0, rows = null }");

             var jsonData = new
             {
                 total = totalPages,
                 _page,
                 records = totalRecords,
                 rows = (
                     from objUserRoles in objUserRolesCol
                     select new
                     {
                         id = objUserRoles.UserRoleId,
                         cell = new string[] { 
                             objUserRoles.UserRoleId.ToString(),
                             objUserRoles.UserId.HasValue ? objUserRoles.UserId.Value.ToString() : "",
                             objUserRoles.RoleId.HasValue ? objUserRoles.RoleId.Value.ToString() : "",
                             objUserRoles.Status.ToString()
                         }
                     }).ToArray()
             };

             return new JsonResult(jsonData);
         }
     }
}
