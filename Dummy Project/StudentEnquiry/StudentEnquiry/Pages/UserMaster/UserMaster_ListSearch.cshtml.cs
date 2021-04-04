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
     public class UserMaster_ListSearchModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;


         /// <summary>
         /// Default Constructor: /UserMaster_ListSearchModel
         /// </summary>
         public UserMaster_ListSearchModel (ILog Ilog,IEmail IEmail)
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
             int? userId = null;
             string userName = String.Empty;
             string password = String.Empty;
             string email = String.Empty;
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
                     if (rule["field"].Value.ToLower() == "userid")
                         userId = Convert.ToInt32(rule["data"].Value);

                     if (rule["field"].Value.ToLower() == "username")
                         userName = rule["data"].Value;

                     if (rule["field"].Value.ToLower() == "password")
                         password = rule["data"].Value;

                     if (rule["field"].Value.ToLower() == "email")
                         email = rule["data"].Value;

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
                 if (userId == -1)
                     userId = null;

             }

             int totalRecords = UserMaster.GetRecordCountDynamicWhere(userId, userName, password, email, createdOn, createdBy, modifiedOn, modifiedBy);
             int startRowIndex = ((_page * rows) - rows);
             List<UserMaster> objUserMasterCol = UserMaster.SelectSkipAndTakeDynamicWhere(userId, userName, password, email, createdOn, createdBy, modifiedOn, modifiedBy, rows, startRowIndex, sidx + " " + sord);
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
