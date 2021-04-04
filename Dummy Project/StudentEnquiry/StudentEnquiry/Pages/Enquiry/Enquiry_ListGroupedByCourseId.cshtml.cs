using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentEnquiryAPI.Domain;
using StudentEnquiryAPI.BusinessObject;
using Newtonsoft.Json;
using Application_Components.Logging;
using Application_Components.EmailNotification;

namespace StudentEnquiry.Pages
{
     [AutoValidateAntiforgeryToken]
     public class Enquiry_ListGroupedByCourseIdModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;


         /// <summary>
         /// Gets the list of data for use by the jqgrid plug-in
         /// </summary>
         public IActionResult OnGetGridDataGroupedByCourseId(string sidx, string sord, int _page, int rows)
         {
             // using a groupField in the jqgrid passes that field
             // along with the field to sort, remove the groupField
             string groupBy = "CouseName asc, ";
             sidx = sidx.Replace(groupBy, "");

             int totalRecords = Enquiry.GetRecordCount();
             int startRowIndex = ((_page * rows) - rows);

             List<Enquiry> objEnquiryCol = Enquiry.SelectSkipAndTake(rows, startRowIndex, sidx + " " + sord);
             int totalPages = (int)Math.Ceiling((float)totalRecords / (float)rows);

             if (objEnquiryCol is null)
                 return new JsonResult("{ total = 0, page = 0, records = 0, rows = null }");

             var jsonData = new
             {
                 total = totalPages,
                 _page,
                 records = totalRecords,
                 rows = (
                     from objEnquiry in objEnquiryCol
                     select new
                     {
                         id = objEnquiry.EnquiryId,
                         cell = new string[] { 
                             objEnquiry.EnquiryId.ToString(),
                             objEnquiry.CourseId.ToString(),
                             objEnquiry.StudentName,
                             objEnquiry.ContactNo.ToString(),
                             objEnquiry.Comments,
                             objEnquiry.CourseIdNavigation.CouseName

                         }
                     }).ToArray()
             };

             return new JsonResult(jsonData);
         }
     }
}
