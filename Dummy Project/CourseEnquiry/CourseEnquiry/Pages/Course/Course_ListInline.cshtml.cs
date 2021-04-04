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
     public class Course_ListInlineModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;


         /// <summary>
         /// Default Constructor: /Course_ListInlineModel
         /// </summary>
         public Course_ListInlineModel (ILog Ilog,IEmail IEmail)
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
         /// Handler, deletes a record.
         /// </summary>
         public IActionResult OnGetRemove(int id)
         {
             Course Course = Course.SelectByPrimaryKey(id);
             Course.Delete(id);
             return new JsonResult(true);
         }

         /// <summary>
         /// Handler, adds a new record.
         /// </summary>
         public IActionResult OnGetAdd(string serializedData)
         {
             Course objCourse = JsonConvert.DeserializeObject<Course>(serializedData);
             CourseFunctions.AddOrEdit(objCourse, CrudOperation.Add, true);
             return new JsonResult(true);
         }

         /// <summary>
         /// Handler, updates a record.
         /// </summary>
         public IActionResult OnGetUpdate(int id, string serializedData)
         {
             Course objCourse = JsonConvert.DeserializeObject<Course>(serializedData);
             CourseFunctions.AddOrEdit(objCourse, CrudOperation.Update, true);
             return new JsonResult(true);
         }

         /// <summary>
         /// Gets the list of data for use by the jqgrid plug-in
         /// </summary>
         public IActionResult OnGetGridData(string sidx, string sord, int _page, int rows, bool isforJqGrid = true)
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
