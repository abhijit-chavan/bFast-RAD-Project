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
     public class Course_ListSearchModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;


         /// <summary>
         /// Default Constructor: /Course_ListSearchModel
         /// </summary>
         public Course_ListSearchModel (ILog Ilog,IEmail IEmail)
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
             int? courseId = null;
             string courseName = String.Empty;
             DateTime? startDate = null;
             DateTime? endDate = null;
             decimal? fees = null;

             if (!String.IsNullOrEmpty(filters))
             {
                 // deserialize json and get values being searched
                 var jsonResult = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(filters);

                 foreach (var rule in jsonResult["rules"])
                 {
                     if (rule["field"].Value.ToLower() == "courseid")
                         courseId = Convert.ToInt32(rule["data"].Value);

                     if (rule["field"].Value.ToLower() == "coursename")
                         courseName = rule["data"].Value;

                     if (rule["field"].Value.ToLower() == "startdate")
                         startDate = Convert.ToDateTime(rule["data"].Value);

                     if (rule["field"].Value.ToLower() == "enddate")
                         endDate = Convert.ToDateTime(rule["data"].Value);

                     if (rule["field"].Value.ToLower() == "fees")
                         fees = Convert.ToDecimal(rule["data"].Value);

                 }

                 // sometimes jqgrid assigns a -1 to numeric fields when no value is assigned
                 // instead of assigning a null, we'll correct this here
                 if (courseId == -1)
                     courseId = null;

                 if (fees == -1)
                     fees = null;

             }

             int totalRecords = Course.GetRecordCountDynamicWhere(courseId, courseName, startDate, endDate, fees);
             int startRowIndex = ((_page * rows) - rows);
             List<Course> objCourseCol = Course.SelectSkipAndTakeDynamicWhere(courseId, courseName, startDate, endDate, fees, rows, startRowIndex, sidx + " " + sord);
             int totalPages = (int)Math.Ceiling((float)totalRecords / (float)rows);

             if (objCourseCol is null)
                 return new JsonResult("{ total = 0, page = 0, records = 0, rows = null }");

             var jsonData = new
             {
                 total = totalPages,
                 _page,
                 records = totalRecords,
                 rows = (
                     from objCourse in objCourseCol
                     select new
                     {
                         id = objCourse.CourseId,
                         cell = new string[] { 
                             objCourse.CourseId.ToString(),
                             objCourse.CourseName,
                             objCourse.StartDate.ToString("d"),
                             objCourse.EndDate.ToString("d"),
                             objCourse.Fees.ToString()
                         }
                     }).ToArray()
             };

             return new JsonResult(jsonData);
         }
     }
}
