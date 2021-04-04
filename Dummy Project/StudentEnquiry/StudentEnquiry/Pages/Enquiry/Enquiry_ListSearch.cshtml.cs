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
     public class Enquiry_ListSearchModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;

         public List<Enquiry> EnquiryDropDownListData;
         public List<Couse> CouseDropDownListData;


         /// <summary>
         /// Default Constructor: /Enquiry_ListSearchModel
         /// </summary>
         public Enquiry_ListSearchModel (ILog Ilog,IEmail IEmail)
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
             EnquiryDropDownListData = Enquiry.SelectEnquiryDropDownListData();
             CouseDropDownListData = Couse.SelectCouseDropDownListData();
         }

         /// <summary>
         /// Gets the list of data for use by the jqgrid plug-in
         /// </summary>
         public IActionResult OnGetGridDataWithFilters(string sidx, string sord, int _page, int rows, string filters)
         {
             int? enquiryId = null;
             int? courseId = null;
             string studentName = String.Empty;
             Int64? contactNo = null;
             string comments = String.Empty;

             if (!String.IsNullOrEmpty(filters))
             {
                 // deserialize json and get values being searched
                 var jsonResult = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(filters);

                 foreach (var rule in jsonResult["rules"])
                 {
                     if (rule["field"].Value.ToLower() == "enquiryid")
                         enquiryId = Convert.ToInt32(rule["data"].Value);

                     if (rule["field"].Value.ToLower() == "courseid")
                         courseId = Convert.ToInt32(rule["data"].Value);

                     if (rule["field"].Value.ToLower() == "studentname")
                         studentName = rule["data"].Value;

                     if (rule["field"].Value.ToLower() == "contactno")
                         contactNo = Convert.ToInt64(rule["data"].Value);

                     if (rule["field"].Value.ToLower() == "comments")
                         comments = rule["data"].Value;

                 }

                 // sometimes jqgrid assigns a -1 to numeric fields when no value is assigned
                 // instead of assigning a null, we'll correct this here
                 if (enquiryId == -1)
                     enquiryId = null;

                 if (courseId == -1)
                     courseId = null;

                 if (contactNo == -1)
                     contactNo = null;

             }

             int totalRecords = Enquiry.GetRecordCountDynamicWhere(enquiryId, courseId, studentName, contactNo, comments);
             int startRowIndex = ((_page * rows) - rows);
             List<Enquiry> objEnquiryCol = Enquiry.SelectSkipAndTakeDynamicWhere(enquiryId, courseId, studentName, contactNo, comments, rows, startRowIndex, sidx + " " + sord);
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
                             objEnquiry.Comments
                         }
                     }).ToArray()
             };

             return new JsonResult(jsonData);
         }
     }
}
