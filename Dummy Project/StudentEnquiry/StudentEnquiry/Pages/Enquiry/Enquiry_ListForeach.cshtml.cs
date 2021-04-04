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
     public class Enquiry_ListForeachModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;

         public List<Enquiry> EnquiryData { get; set; }
         public string[,] EnquiryFieldNames { get; set; }
         public string FieldToSort { get; set; }
         public string FieldToSortWithOrder { get; set; }
         public string FieldSortOrder { get; set; }
         public int StartPage { get; set; }
         public int EndPage { get; set; }
         public int CurrentPage { get; set; }
         public int NumberOfPagesToShow { get; set; }
         public int TotalPages { get; set; }
         public List<string> UnsortableFields { get; set; }

         /// <summary>
         /// Default Constructor: /Enquiry_ListForeachModel
         /// </summary>
         public Enquiry_ListForeachModel (ILog Ilog,IEmail IEmail)
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
             string sidx = String.Empty;
             string sord = String.Empty;
             int currentPage = 1;

             GetData(sidx, sord, currentPage);
         }

         /// <summary>
         /// Handler, deletes a record.
         /// </summary>
         public IActionResult OnGetRemove(int id)
         {
             Enquiry Enquiry = Enquiry.SelectByPrimaryKey(id);
             Enquiry.Delete(id);
             return new JsonResult(true);
         }

         public void OnGetGridData(string sidx, string sord, int? _page)
         {
             GetData(sidx, sord, _page);
         }

         public void GetData(string sidx, string sord, int? _page)
         {
             int rows = Functions.GetGridNumberOfRows();
             int numberOfPagesToShow = Functions.GetGridNumberOfPagesToShow();
             int currentPage = _page is null ? 1 : Convert.ToInt32(_page);
             int startRowIndex = ((currentPage * rows) - rows);
             int totalRecords = Enquiry.GetRecordCount();
             int totalPages = (int)Math.Ceiling((float)totalRecords / (float)rows);
             List<Enquiry> objEnquiryCol = Enquiry.SelectSkipAndTake(rows, startRowIndex, sidx + " " + sord);

             // fields and titles
             string[,] fieldNames = new string[,] {
                 {"EnquiryId", "Enquiry Id"},
                 {"CourseId", "Course Id"},
                 {"StudentName", "Student Name"},
                 {"ContactNo", "Contact No"},
                 {"Comments", "Comments"}
             };

             // assign properties
             EnquiryData = objEnquiryCol;
             EnquiryFieldNames = fieldNames;
             TotalPages = totalPages;
             CurrentPage = currentPage;
             FieldToSort = String.IsNullOrEmpty(sidx) ? "EnquiryId" : sidx;
             FieldSortOrder = String.IsNullOrEmpty(sord) ? "asc" : sord;
             FieldToSortWithOrder = String.IsNullOrEmpty(sidx) ? "EnquiryId" : (sidx + " " + sord).Trim();
             NumberOfPagesToShow = numberOfPagesToShow;
             StartPage = Functions.GetPagerStartPage(currentPage, numberOfPagesToShow, totalPages);
             EndPage = Functions.GetPagerEndPage(StartPage, currentPage, numberOfPagesToShow, totalPages);
         }
     }
}
