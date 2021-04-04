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
     public class CourseEnrollmentInfo_ListGroupedByEnrollmentIdModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;


         /// <summary>
         /// Gets the list of data for use by the jqgrid plug-in
         /// </summary>
         public IActionResult OnGetGridDataGroupedByEnrollmentId(string sidx, string sord, int _page, int rows)
         {
             // using a groupField in the jqgrid passes that field
             // along with the field to sort, remove the groupField
             string groupBy = "Comments asc, ";
             sidx = sidx.Replace(groupBy, "");

             int totalRecords = CourseEnrollmentInfo.GetRecordCount();
             int startRowIndex = ((_page * rows) - rows);

             List<CourseEnrollmentInfo> objCourseEnrollmentInfoCol = CourseEnrollmentInfo.SelectSkipAndTake(rows, startRowIndex, sidx + " " + sord);
             int totalPages = (int)Math.Ceiling((float)totalRecords / (float)rows);

             if (objCourseEnrollmentInfoCol is null)
                 return new JsonResult("{ total = 0, page = 0, records = 0, rows = null }");

             var jsonData = new
             {
                 total = totalPages,
                 _page,
                 records = totalRecords,
                 rows = (
                     from objCourseEnrollmentInfo in objCourseEnrollmentInfoCol
                     select new
                     {
                         id = objCourseEnrollmentInfo.EnrollmentId,
                         cell = new string[] { 
                             objCourseEnrollmentInfo.EnrollmentId.ToString(),
                             objCourseEnrollmentInfo.CourseId.ToString(),
                             objCourseEnrollmentInfo.StudentId.ToString(),
                             objCourseEnrollmentInfo.Comments,
                             objCourseEnrollmentInfo.CourseEnrollmentInfo1.Comments

                         }
                     }).ToArray()
             };

             return new JsonResult(jsonData);
         }
     }
}
