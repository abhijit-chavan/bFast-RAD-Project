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
     public class Course_ListTotalsModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;


         /// <summary>
         /// Gets the list of data for use by the jqgrid plug-in
         /// </summary>
         public IActionResult OnGetGridDataWithTotals(string sidx, string sord, int _page, int rows)
         {
             int totalRecords = Course.GetRecordCount();
             int startRowIndex = ((_page * rows) - rows);

             List<Course> objCourseCol = Course.SelectSkipAndTake(rows, startRowIndex, sidx + " " + sord);
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
