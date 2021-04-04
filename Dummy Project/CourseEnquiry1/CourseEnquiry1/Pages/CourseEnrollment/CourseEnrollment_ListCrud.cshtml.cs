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
     public class CourseEnrollment_ListCrudModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;

         [BindProperty]
         public CourseEnquiry1API.BusinessObject.CourseEnrollment CourseEnrollment { get; set; }

         public List<Course> CourseDropDownListData;
         public List<Student> StudentDropDownListData;


         /// <summary>
         /// Default Constructor: /CourseEnrollment_ListCrudModel
         /// </summary>
         public CourseEnrollment_ListCrudModel (ILog Ilog,IEmail IEmail)
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
             SetData();
         }

         /// <summary>
         /// Handler, adds a new record.
         /// </summary>
         public IActionResult OnGetAdd(string serializedData)
         {
             CourseEnrollment objCourseEnrollment = JsonConvert.DeserializeObject<CourseEnrollment>(serializedData);
             CourseEnrollmentFunctions.AddOrEdit(objCourseEnrollment, CrudOperation.Add, true);
             return new JsonResult(true);
         }

         /// <summary>
         /// Handler, updates a record.
         /// </summary>
         public IActionResult OnGetUpdate(string serializedData)
         {
             CourseEnrollment objCourseEnrollment = JsonConvert.DeserializeObject<CourseEnrollment>(serializedData);
             CourseEnrollmentFunctions.AddOrEdit(objCourseEnrollment, CrudOperation.Update, true);
             return new JsonResult(true);
         }

         /// <summary>
         /// Handler, deletes a record.
         /// </summary>
         public IActionResult OnGetRemove(int id)
         {
             CourseEnrollment CourseEnrollment = CourseEnrollment.SelectByPrimaryKey(id);
             CourseEnrollment.Delete(id);
             return new JsonResult(true);
         }

         /// <summary>
         /// Sets data needed on page intialization.
         /// </summary>
         private void SetData()
         {
             CourseEnrollment = new CourseEnquiry1API.BusinessObject.CourseEnrollment();
             CourseDropDownListData = Course.SelectCourseDropDownListData();
             StudentDropDownListData = Student.SelectStudentDropDownListData();
         }

         /// <summary>
         /// Gets the list of data for use by the jqgrid plug-in
         /// </summary>
         public IActionResult OnGetGridData(string sidx, string sord, int _page, int rows, bool isforJqGrid = true)
         {
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
                             objCourseEnrollment.Comments
                         }
                     }).ToArray()
             };

             return new JsonResult(jsonData);
         }
     }
}
