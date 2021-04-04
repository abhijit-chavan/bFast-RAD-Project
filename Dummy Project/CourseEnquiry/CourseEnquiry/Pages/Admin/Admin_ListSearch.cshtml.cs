using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CourseEnquiryAPI.Domain;
using CourseEnquiryAPI.BusinessObject;
using Newtonsoft.Json;
using Application_Components.Logging;
using Application_Components.EmailNotification;

namespace CourseEnquiry.Pages
{
     [AutoValidateAntiforgeryToken]
     public class Admin_ListSearchModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;


         /// <summary>
         /// Default Constructor: /Admin_ListSearchModel
         /// </summary>
         public Admin_ListSearchModel (ILog Ilog,IEmail IEmail)
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
             int? adminId = null;
             string adminName = String.Empty;
             string adminPassword = String.Empty;

             if (!String.IsNullOrEmpty(filters))
             {
                 // deserialize json and get values being searched
                 var jsonResult = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(filters);

                 foreach (var rule in jsonResult["rules"])
                 {
                     if (rule["field"].Value.ToLower() == "adminid")
                         adminId = Convert.ToInt32(rule["data"].Value);

                     if (rule["field"].Value.ToLower() == "adminname")
                         adminName = rule["data"].Value;

                     if (rule["field"].Value.ToLower() == "adminpassword")
                         adminPassword = rule["data"].Value;

                 }

                 // sometimes jqgrid assigns a -1 to numeric fields when no value is assigned
                 // instead of assigning a null, we'll correct this here
                 if (adminId == -1)
                     adminId = null;

             }

             int totalRecords = Admin.GetRecordCountDynamicWhere(adminId, adminName, adminPassword);
             int startRowIndex = ((_page * rows) - rows);
             List<Admin> objAdminCol = Admin.SelectSkipAndTakeDynamicWhere(adminId, adminName, adminPassword, rows, startRowIndex, sidx + " " + sord);
             int totalPages = (int)Math.Ceiling((float)totalRecords / (float)rows);

             if (objAdminCol is null)
                 return new JsonResult("{ total = 0, page = 0, records = 0, rows = null }");

             var jsonData = new
             {
                 total = totalPages,
                 _page,
                 records = totalRecords,
                 rows = (
                     from objAdmin in objAdminCol
                     select new
                     {
                         id = objAdmin.AdminId,
                         cell = new string[] { 
                             objAdmin.AdminId.ToString(),
                             objAdmin.AdminName,
                             objAdmin.AdminPassword
                         }
                     }).ToArray()
             };

             return new JsonResult(jsonData);
         }
     }
}
