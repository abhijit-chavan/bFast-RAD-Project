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
     public class CourseEnrollmentInfo_ListSearchModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;

         public List<CourseEnrollmentInfo> CourseEnrollmentInfoDropDownListData;
         public List<Course> CourseDropDownListData;
         public List<Student> StudentDropDownListData;


         /// <summary>
         /// Default Constructor: /CourseEnrollmentInfo_ListSearchModel
         /// </summary>
         public CourseEnrollmentInfo_ListSearchModel (ILog Ilog,IEmail IEmail)
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
             CourseEnrollmentInfoDropDownListData = CourseEnrollmentInfo.SelectCourseEnrollmentInfoDropDownListData();
             CourseDropDownListData = Course.SelectCourseDropDownListData();
             StudentDropDownListData = Student.SelectStudentDropDownListData();
         }

         /// <summary>
         /// Gets the list of data for use by the jqgrid plug-in
         /// </summary>
         public IActionResult OnGetGridDataWithFilters(string sidx, string sord, int _page, int rows, string filters)
         {
             int? enrollmentId = null;
             int? courseId = null;
             int? studentId = null;
             string comments = String.Empty;

             if (!String.IsNullOrEmpty(filters))
             {
                 // deserialize json and get values being searched
                 var jsonResult = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(filters);

                 foreach (var rule in jsonResult["rules"])
                 {
                     if (rule["field"].Value.ToLower() == "enrollmentid")
                         enrollmentId = Convert.ToInt32(rule["data"].Value);

                     if (rule["field"].Value.ToLower() == "courseid")
                         courseId = Convert.ToInt32(rule["data"].Value);

                     if (rule["field"].Value.ToLower() == "studentid")
                         studentId = Convert.ToInt32(rule["data"].Value);

                     if (rule["field"].Value.ToLower() == "comments")
                         comments = rule["data"].Value;

                 }

                 // sometimes jqgrid assigns a -1 to numeric fields when no value is assigned
                 // instead of assigning a null, we'll correct this here
                 if (enrollmentId == -1)
                     enrollmentId = null;

                 if (courseId == -1)
                     courseId = null;

                 if (studentId == -1)
                     studentId = null;

             }

             int totalRecords = CourseEnrollmentInfo.GetRecordCountDynamicWhere(enrollmentId, courseId, studentId, comments);
             int startRowIndex = ((_page * rows) - rows);
             List<CourseEnrollmentInfo> objCourseEnrollmentInfoCol = CourseEnrollmentInfo.SelectSkipAndTakeDynamicWhere(enrollmentId, courseId, studentId, comments, rows, startRowIndex, sidx + " " + sord);
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
