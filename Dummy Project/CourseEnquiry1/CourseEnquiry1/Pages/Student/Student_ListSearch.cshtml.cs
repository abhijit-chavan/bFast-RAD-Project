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
             int? studenId = null;
             string studentName = String.Empty;
             string emailId = String.Empty;
             int? contactNumber = null;
             string password = String.Empty;

             if (!String.IsNullOrEmpty(filters))
             {
                 // deserialize json and get values being searched
                 var jsonResult = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(filters);

                 foreach (var rule in jsonResult["rules"])
                 {
                     if (rule["field"].Value.ToLower() == "studenid")
                         studenId = Convert.ToInt32(rule["data"].Value);

                     if (rule["field"].Value.ToLower() == "studentname")
                         studentName = rule["data"].Value;

                     if (rule["field"].Value.ToLower() == "emailid")
                         emailId = rule["data"].Value;

                     if (rule["field"].Value.ToLower() == "contactnumber")
                         contactNumber = Convert.ToInt32(rule["data"].Value);

                     if (rule["field"].Value.ToLower() == "password")
                         password = rule["data"].Value;

                 }

                 // sometimes jqgrid assigns a -1 to numeric fields when no value is assigned
                 // instead of assigning a null, we'll correct this here
                 if (studenId == -1)
                     studenId = null;

                 if (contactNumber == -1)
                     contactNumber = null;

             }

             int totalRecords = Student.GetRecordCountDynamicWhere(studenId, studentName, emailId, contactNumber, password);
             int startRowIndex = ((_page * rows) - rows);
             List<Student> objStudentCol = Student.SelectSkipAndTakeDynamicWhere(studenId, studentName, emailId, contactNumber, password, rows, startRowIndex, sidx + " " + sord);
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
                         id = objStudent.StudenId,
                         cell = new string[] { 
                             objStudent.StudenId.ToString(),
                             objStudent.StudentName,
                             objStudent.EmailId,
                             objStudent.ContactNumber.ToString(),
                             objStudent.Password
                         }
                     }).ToArray()
             };

             return new JsonResult(jsonData);
         }
     }
}
