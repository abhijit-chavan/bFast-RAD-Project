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
     public class CourseEnrollmentInfo_ListCrudRedirectModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;


         /// <summary>
         /// Default Constructor: /CourseEnrollmentInfo_ListCrudRedirectModel
         /// </summary>
         public CourseEnrollmentInfo_ListCrudRedirectModel (ILog Ilog,IEmail IEmail)
         {
             if (_Ilog == null)
                 _Ilog = Ilog;
if (_IEmail == null)
_IEmail = IEmail;
         }


         /// <summary>
         /// Handler, deletes a record.
         /// </summary>
         public IActionResult OnGetRemove(int id)
         {
             CourseEnrollmentInfo CourseEnrollmentInfo = CourseEnrollmentInfo.SelectByPrimaryKey(id);
             CourseEnrollmentInfo.Delete(id);
             return new JsonResult(true);
         }

         /// <summary>
         /// Gets the list of data for use by the jqgrid plug-in
         /// </summary>
         public IActionResult OnGetGridData(string sidx, string sord, int _page, int rows, bool isforJqGrid = true)
         {
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
                             objCourseEnrollmentInfo.Comments
                         }
                     }).ToArray()
             };

             return new JsonResult(jsonData);
         }
     }
}
