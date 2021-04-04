using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using fifth_tempDBAPI.Domain;
using fifth_tempDBAPI.BusinessObject;
using Newtonsoft.Json;
using Application_Components.Logging;
using Application_Components.EmailNotification;

namespace fifth_tempDB.Pages
{
     [AutoValidateAntiforgeryToken]
     public class RoleMaster_ListSearchModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;


         /// <summary>
         /// Default Constructor: /RoleMaster_ListSearchModel
         /// </summary>
         public RoleMaster_ListSearchModel (ILog Ilog,IEmail IEmail)
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
         /// Gets the list of data for use by the jqgrid plug-in
         /// </summary>
         public IActionResult OnGetGridDataWithFilters(string sidx, string sord, int _page, int rows, string filters)
         {
             int? roleId = null;
             string roleDescription = String.Empty;
             DateTime? createdOn = null;
             string createdBy = String.Empty;
             DateTime? modifiedOn = null;
             string modifiedBy = String.Empty;

             if (!String.IsNullOrEmpty(filters))
             {
                 // deserialize json and get values being searched
                 var jsonResult = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(filters);

                 foreach (var rule in jsonResult["rules"])
                 {
                     if (rule["field"].Value.ToLower() == "roleid")
                         roleId = Convert.ToInt32(rule["data"].Value);

                     if (rule["field"].Value.ToLower() == "roledescription")
                         roleDescription = rule["data"].Value;

                     if (rule["field"].Value.ToLower() == "createdon")
                         createdOn = Convert.ToDateTime(rule["data"].Value);

                     if (rule["field"].Value.ToLower() == "createdby")
                         createdBy = rule["data"].Value;

                     if (rule["field"].Value.ToLower() == "modifiedon")
                         modifiedOn = Convert.ToDateTime(rule["data"].Value);

                     if (rule["field"].Value.ToLower() == "modifiedby")
                         modifiedBy = rule["data"].Value;

                 }

                 // sometimes jqgrid assigns a -1 to numeric fields when no value is assigned
                 // instead of assigning a null, we'll correct this here
                 if (roleId == -1)
                     roleId = null;

             }

             int totalRecords = RoleMaster.GetRecordCountDynamicWhere(roleId, roleDescription, createdOn, createdBy, modifiedOn, modifiedBy);
             int startRowIndex = ((_page * rows) - rows);
             List<RoleMaster> objRoleMasterCol = RoleMaster.SelectSkipAndTakeDynamicWhere(roleId, roleDescription, createdOn, createdBy, modifiedOn, modifiedBy, rows, startRowIndex, sidx + " " + sord);
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
