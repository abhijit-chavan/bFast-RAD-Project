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
     public class UserRoles_ListMasterDetailGridByRoleIdModel : PageModel
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

         /// <summary>
         /// Gets the list of data for use by the jqgrid plug-in
         /// </summary>
         public IActionResult OnGetGridDataWithFilters(string sidx, string sord, int _page, int rows, string filters)
         {
             int? userRoleId = null;
             int? userId = null;
             int? roleId = null;
             bool? status = null;

             if (!String.IsNullOrEmpty(filters))
             {
                 // deserialize json and get values being searched
                 var jsonResult = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(filters);

                 foreach (var rule in jsonResult["rules"])
                 {
                     if (rule["field"].Value.ToLower() == "userroleid")
                         userRoleId = Convert.ToInt32(rule["data"].Value);

                     if (rule["field"].Value.ToLower() == "userid")
                         userId = Convert.ToInt32(rule["data"].Value);

                     if (rule["field"].Value.ToLower() == "roleid")
                         roleId = Convert.ToInt32(rule["data"].Value);

                     if (rule["field"].Value.ToLower() == "status")
                         status = Convert.ToBoolean(rule["data"].Value);

                 }

                 // sometimes jqgrid assigns a -1 to numeric fields when no value is assigned
                 // instead of assigning a null, we'll correct this here
                 if (userRoleId == -1)
                     userRoleId = null;

                 if (userId == -1)
                     userId = null;

                 if (roleId == -1)
                     roleId = null;

             }

             int totalRecords = UserRoles.GetRecordCountDynamicWhere(userRoleId, userId, roleId, status);
             int startRowIndex = ((_page * rows) - rows);
             List<UserRoles> objUserRolesCol = UserRoles.SelectSkipAndTakeDynamicWhere(userRoleId, userId, roleId, status, rows, startRowIndex, sidx + " " + sord);
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
