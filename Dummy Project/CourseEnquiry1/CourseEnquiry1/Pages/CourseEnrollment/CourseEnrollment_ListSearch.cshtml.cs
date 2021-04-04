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
     public class CourseEnrollment_ListSearchModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;

         public List<Course> CourseDropDownListData;
         public List<Student> StudentDropDownListData;


         /// <summary>
         /// Default Constructor: /CourseEnrollment_ListSearchModel
         /// </summary>
         public CourseEnrollment_ListSearchModel (ILog Ilog,IEmail IEmail)
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
             CourseDropDownListData = Course.SelectCourseDropDownListData();
             StudentDropDownListData = Student.SelectStudentDropDownListData();
         }

         /// <summary>
         /// Gets the list of data for use by the jqgrid plug-in
         /// </summary>
         public IActionResult OnGetGridDataWithFilters(string sidx, string sord, int _page, int rows, string filters)
         {
             int? enrollmentId = null;
             int? courseName = null;
             int? studentName = null;
             string comments = String.Empty;

             if (!String.IsNullOrEmpty(filters))
             {
                 // deserialize json and get values being searched
                 var jsonResult = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(filters);

                 foreach (var rule in jsonResult["rules"])
                 {
                     if (rule["field"].Value.ToLower() == "enrollmentid")
                         enrollmentId = Convert.ToInt32(rule["data"].Value);

                     if (rule["field"].Value.ToLower() == "coursename")
                         courseName = Convert.ToInt32(rule["data"].Value);

                     if (rule["field"].Value.ToLower() == "studentname")
                         studentName = Convert.ToInt32(rule["data"].Value);

                     if (rule["field"].Value.ToLower() == "comments")
                         comments = rule["data"].Value;

                 }

                 // sometimes jqgrid assigns a -1 to numeric fields when no value is assigned
                 // instead of assigning a null, we'll correct this here
                 if (enrollmentId == -1)
                     enrollmentId = null;

                 if (courseName == -1)
                     courseName = null;

                 if (studentName == -1)
                     studentName = null;

             }

             int totalRecords = CourseEnrollment.GetRecordCountDynamicWhere(enrollmentId, courseName, studentName, comments);
             int startRowIndex = ((_page * rows) - rows);
             List<CourseEnrollment> objCourseEnrollmentCol = CourseEnrollment.SelectSkipAndTakeDynamicWhere(enrollmentId, courseName, studentName, comments, rows, startRowIndex, sidx + " " + sord);
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
