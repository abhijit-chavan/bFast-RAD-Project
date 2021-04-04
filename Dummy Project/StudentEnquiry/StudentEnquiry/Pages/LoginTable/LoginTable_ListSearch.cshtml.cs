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
     public class LoginTable_ListSearchModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;


         /// <summary>
         /// Default Constructor: /LoginTable_ListSearchModel
         /// </summary>
         public LoginTable_ListSearchModel (ILog Ilog,IEmail IEmail)
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
             int? adminid = null;
             string password = String.Empty;

             if (!String.IsNullOrEmpty(filters))
             {
                 // deserialize json and get values being searched
                 var jsonResult = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(filters);

                 foreach (var rule in jsonResult["rules"])
                 {
                     if (rule["field"].Value.ToLower() == "adminid")
                         adminid = Convert.ToInt32(rule["data"].Value);

                     if (rule["field"].Value.ToLower() == "password")
                         password = rule["data"].Value;

                 }

                 // sometimes jqgrid assigns a -1 to numeric fields when no value is assigned
                 // instead of assigning a null, we'll correct this here
                 if (adminid == -1)
                     adminid = null;

             }

             int totalRecords = LoginTable.GetRecordCountDynamicWhere(adminid, password);
             int startRowIndex = ((_page * rows) - rows);
             List<LoginTable> objLoginTableCol = LoginTable.SelectSkipAndTakeDynamicWhere(adminid, password, rows, startRowIndex, sidx + " " + sord);
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
