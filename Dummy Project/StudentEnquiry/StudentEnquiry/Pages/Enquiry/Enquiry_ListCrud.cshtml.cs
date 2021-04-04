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
     public class Enquiry_ListCrudModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;

         [BindProperty]
         public StudentEnquiryAPI.BusinessObject.Enquiry Enquiry { get; set; }

         public List<Enquiry> EnquiryDropDownListData;
         public List<Couse> CouseDropDownListData;


         /// <summary>
         /// Default Constructor: /Enquiry_ListCrudModel
         /// </summary>
         public Enquiry_ListCrudModel (ILog Ilog,IEmail IEmail)
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
             Enquiry objEnquiry = JsonConvert.DeserializeObject<Enquiry>(serializedData);
             EnquiryFunctions.AddOrEdit(objEnquiry, CrudOperation.Add, true);
             return new JsonResult(true);
         }

         /// <summary>
         /// Handler, updates a record.
         /// </summary>
         public IActionResult OnGetUpdate(string serializedData)
         {
             Enquiry objEnquiry = JsonConvert.DeserializeObject<Enquiry>(serializedData);
             EnquiryFunctions.AddOrEdit(objEnquiry, CrudOperation.Update, true);
             return new JsonResult(true);
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

         /// <summary>
         /// Sets data needed on page intialization.
         /// </summary>
         private void SetData()
         {
             Enquiry = new StudentEnquiryAPI.BusinessObject.Enquiry();
             EnquiryDropDownListData = Enquiry.SelectEnquiryDropDownListData();
             CouseDropDownListData = Couse.SelectCouseDropDownListData();
         }

         /// <summary>
         /// Gets the list of data for use by the jqgrid plug-in
         /// </summary>
         public IActionResult OnGetGridData(string sidx, string sord, int _page, int rows, bool isforJqGrid = true)
         {
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
                             objEnquiry.Comments
                         }
                     }).ToArray()
             };

             return new JsonResult(jsonData);
         }
     }
}
