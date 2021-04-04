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
     public class Student_ListSearchModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;


         /// <summary>
         /// Default Constructor: /Student_ListSearchModel
         /// </summary>
         public Student_ListSearchModel (ILog Ilog,IEmail IEmail)
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
             int? studentId = null;
             string studentName = String.Empty;
             string emailId = String.Empty;
             Int64? contactNo = null;
             string studentPassword = String.Empty;

             if (!String.IsNullOrEmpty(filters))
             {
                 // deserialize json and get values being searched
                 var jsonResult = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(filters);

                 foreach (var rule in jsonResult["rules"])
                 {
                     if (rule["field"].Value.ToLower() == "studentid")
                         studentId = Convert.ToInt32(rule["data"].Value);

                     if (rule["field"].Value.ToLower() == "studentname")
                         studentName = rule["data"].Value;

                     if (rule["field"].Value.ToLower() == "emailid")
                         emailId = rule["data"].Value;

                     if (rule["field"].Value.ToLower() == "contactno")
                         contactNo = Convert.ToInt64(rule["data"].Value);

                     if (rule["field"].Value.ToLower() == "studentpassword")
                         studentPassword = rule["data"].Value;

                 }

                 // sometimes jqgrid assigns a -1 to numeric fields when no value is assigned
                 // instead of assigning a null, we'll correct this here
                 if (studentId == -1)
                     studentId = null;

                 if (contactNo == -1)
                     contactNo = null;

             }

             int totalRecords = Student.GetRecordCountDynamicWhere(studentId, studentName, emailId, contactNo, studentPassword);
             int startRowIndex = ((_page * rows) - rows);
             List<Student> objStudentCol = Student.SelectSkipAndTakeDynamicWhere(studentId, studentName, emailId, contactNo, studentPassword, rows, startRowIndex, sidx + " " + sord);
             int totalPages = (int)Math.Ceiling((float)totalRecords / (float)rows);

             if (objStudentCol is null)
                 return new JsonResult("{ total = 0, page = 0, records = 0, rows = null }");

             var jsonData = new
             {
                 total = totalPages,
                 _page,
                 records = totalRecords,
                 rows = (
                     from objStudent in objStudentCol
                     select new
                     {
                         id = objStudent.StudentId,
                         cell = new string[] { 
                             objStudent.StudentId.ToString(),
                             objStudent.StudentName,
                             objStudent.EmailId,
                             objStudent.ContactNo.ToString(),
                             objStudent.StudentPassword
                         }
                     }).ToArray()
             };

             return new JsonResult(jsonData);
         }
     }
}
