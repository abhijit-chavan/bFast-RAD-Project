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
     public class Couse_ListSearchModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;


         /// <summary>
         /// Default Constructor: /Couse_ListSearchModel
         /// </summary>
         public Couse_ListSearchModel (ILog Ilog,IEmail IEmail)
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
             int? couseid = null;
             string couseName = String.Empty;
             DateTime? courseStartDate = null;
             DateTime? courseEndDate = null;
             Int64? couseFees = null;

             if (!String.IsNullOrEmpty(filters))
             {
                 // deserialize json and get values being searched
                 var jsonResult = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(filters);

                 foreach (var rule in jsonResult["rules"])
                 {
                     if (rule["field"].Value.ToLower() == "couseid")
                         couseid = Convert.ToInt32(rule["data"].Value);

                     if (rule["field"].Value.ToLower() == "cousename")
                         couseName = rule["data"].Value;

                     if (rule["field"].Value.ToLower() == "coursestartdate")
                         courseStartDate = Convert.ToDateTime(rule["data"].Value);

                     if (rule["field"].Value.ToLower() == "courseenddate")
                         courseEndDate = Convert.ToDateTime(rule["data"].Value);

                     if (rule["field"].Value.ToLower() == "cousefees")
                         couseFees = Convert.ToInt64(rule["data"].Value);

                 }

                 // sometimes jqgrid assigns a -1 to numeric fields when no value is assigned
                 // instead of assigning a null, we'll correct this here
                 if (couseid == -1)
                     couseid = null;

                 if (couseFees == -1)
                     couseFees = null;

             }

             int totalRecords = Couse.GetRecordCountDynamicWhere(couseid, couseName, courseStartDate, courseEndDate, couseFees);
             int startRowIndex = ((_page * rows) - rows);
             List<Couse> objCouseCol = Couse.SelectSkipAndTakeDynamicWhere(couseid, couseName, courseStartDate, courseEndDate, couseFees, rows, startRowIndex, sidx + " " + sord);
             int totalPages = (int)Math.Ceiling((float)totalRecords / (float)rows);

             if (objCouseCol is null)
                 return new JsonResult("{ total = 0, page = 0, records = 0, rows = null }");

             var jsonData = new
             {
                 total = totalPages,
                 _page,
                 records = totalRecords,
                 rows = (
                     from objCouse in objCouseCol
                     select new
                     {
                         id = objCouse.Couseid,
                         cell = new string[] { 
                             objCouse.Couseid.ToString(),
                             objCouse.CouseName,
                             objCouse.CourseStartDate.ToString("d"),
                             objCouse.CourseEndDate.ToString("d"),
                             objCouse.CouseFees.ToString()
                         }
                     }).ToArray()
             };

             return new JsonResult(jsonData);
         }
     }
}
