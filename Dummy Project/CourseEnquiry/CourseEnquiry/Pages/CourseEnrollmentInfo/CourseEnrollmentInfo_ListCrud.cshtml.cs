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
     public class CourseEnrollmentInfo_ListCrudModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;

         [BindProperty]
         public CourseEnquiryAPI.BusinessObject.CourseEnrollmentInfo CourseEnrollmentInfo { get; set; }

         public List<CourseEnrollmentInfo> CourseEnrollmentInfoDropDownListData;
         public List<Course> CourseDropDownListData;
         public List<Student> StudentDropDownListData;


         /// <summary>
         /// Default Constructor: /CourseEnrollmentInfo_ListCrudModel
         /// </summary>
         public CourseEnrollmentInfo_ListCrudModel (ILog Ilog,IEmail IEmail)
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
             CourseEnrollmentInfo objCourseEnrollmentInfo = JsonConvert.DeserializeObject<CourseEnrollmentInfo>(serializedData);
             CourseEnrollmentInfoFunctions.AddOrEdit(objCourseEnrollmentInfo, CrudOperation.Add, true);
             return new JsonResult(true);
         }

         /// <summary>
         /// Handler, updates a record.
         /// </summary>
         public IActionResult OnGetUpdate(string serializedData)
         {
             CourseEnrollmentInfo objCourseEnrollmentInfo = JsonConvert.DeserializeObject<CourseEnrollmentInfo>(serializedData);
             CourseEnrollmentInfoFunctions.AddOrEdit(objCourseEnrollmentInfo, CrudOperation.Update, true);
             return new JsonResult(true);
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
         /// Sets data needed on page intialization.
         /// </summary>
         private void SetData()
         {
             CourseEnrollmentInfo = new CourseEnquiryAPI.BusinessObject.CourseEnrollmentInfo();
             CourseEnrollmentInfoDropDownListData = CourseEnrollmentInfo.SelectCourseEnrollmentInfoDropDownListData();
             CourseDropDownListData = Course.SelectCourseDropDownListData();
             StudentDropDownListData = Student.SelectStudentDropDownListData();
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
