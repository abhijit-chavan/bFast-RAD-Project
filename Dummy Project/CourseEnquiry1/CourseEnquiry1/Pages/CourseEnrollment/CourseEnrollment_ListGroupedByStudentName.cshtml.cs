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
     public class CourseEnrollment_ListGroupedByStudentNameModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;


         /// <summary>
         /// Gets the list of data for use by the jqgrid plug-in
         /// </summary>
         public IActionResult OnGetGridDataGroupedByStudentName(string sidx, string sord, int _page, int rows)
         {
             // using a groupField in the jqgrid passes that field
             // along with the field to sort, remove the groupField
             string groupBy = "StudentName asc, ";
             sidx = sidx.Replace(groupBy, "");

             int totalRecords = CourseEnrollment.GetRecordCount();
             int startRowIndex = ((_page * rows) - rows);

             List<CourseEnrollment> objCourseEnrollmentCol = CourseEnrollment.SelectSkipAndTake(rows, startRowIndex, sidx + " " + sord);
             int totalPages = (int)Math.Ceiling((float)totalRecords / (float)rows);

             if (objCourseEnrollmentCol is null)
                 return new JsonResult("{ total = 0, page = 0, records = 0, rows = null }");

             var jsonData = new
             {
                 total = totalPages,
                 _page,
                 records = totalRecords,
                 rows = (
                     from objCourseEnrollment in objCourseEnrollmentCol
                     select new
                     {
                         id = objCourseEnrollment.EnrollmentId,
                         cell = new string[] { 
                             objCourseEnrollment.EnrollmentId.ToString(),
                             objCourseEnrollment.CourseName.ToString(),
                             objCourseEnrollment.StudentName.ToString(),
                             objCourseEnrollment.Comments,
                             objCourseEnrollment.StudentNameNavigation.StudentName

                         }
                     }).ToArray()
             };

             return new JsonResult(jsonData);
         }
     }
}
