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
     public class Student_ListScrollLoadModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;


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
