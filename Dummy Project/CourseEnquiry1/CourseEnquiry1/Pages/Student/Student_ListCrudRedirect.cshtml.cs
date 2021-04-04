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
     public class Student_ListCrudRedirectModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;


         /// <summary>
         /// Default Constructor: /Student_ListCrudRedirectModel
         /// </summary>
         public Student_ListCrudRedirectModel (ILog Ilog,IEmail IEmail)
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
             Student Student = Student.SelectByPrimaryKey(id);
             Student.Delete(id);
             return new JsonResult(true);
         }

         /// <summary>
         /// Gets the list of data for use by the jqgrid plug-in
         /// </summary>
         public IActionResult OnGetGridData(string sidx, string sord, int _page, int rows, bool isforJqGrid = true)
         {
             int totalRecords = Student.GetRecordCount();
             int startRowIndex = ((_page * rows) - rows);
             List<Student> objStudentCol = Student.SelectSkipAndTake(rows, startRowIndex, sidx + " " + sord);
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
