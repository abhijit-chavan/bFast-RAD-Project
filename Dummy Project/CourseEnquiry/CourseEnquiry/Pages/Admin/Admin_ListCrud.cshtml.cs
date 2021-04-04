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
     public class Admin_ListCrudModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;

         [BindProperty]
         public CourseEnquiryAPI.BusinessObject.Admin Admin { get; set; }


         /// <summary>
         /// Default Constructor: /Admin_ListCrudModel
         /// </summary>
         public Admin_ListCrudModel (ILog Ilog,IEmail IEmail)
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
             Admin objAdmin = JsonConvert.DeserializeObject<Admin>(serializedData);
             AdminFunctions.AddOrEdit(objAdmin, CrudOperation.Add, true);
             return new JsonResult(true);
         }

         /// <summary>
         /// Handler, updates a record.
         /// </summary>
         public IActionResult OnGetUpdate(string serializedData)
         {
             Admin objAdmin = JsonConvert.DeserializeObject<Admin>(serializedData);
             AdminFunctions.AddOrEdit(objAdmin, CrudOperation.Update, true);
             return new JsonResult(true);
         }

         /// <summary>
         /// Handler, deletes a record.
         /// </summary>
         public IActionResult OnGetRemove(int id)
         {
             Admin Admin = Admin.SelectByPrimaryKey(id);
             Admin.Delete(id);
             return new JsonResult(true);
         }

         /// <summary>
         /// Sets data needed on page intialization.
         /// </summary>
         private void SetData()
         {
             Admin = new CourseEnquiryAPI.BusinessObject.Admin();
         }

         /// <summary>
         /// Gets the list of data for use by the jqgrid plug-in
         /// </summary>
         public IActionResult OnGetGridData(string sidx, string sord, int _page, int rows, bool isforJqGrid = true)
         {
             int totalRecords = Admin.GetRecordCount();
             int startRowIndex = ((_page * rows) - rows);
             List<Admin> objAdminCol = Admin.SelectSkipAndTake(rows, startRowIndex, sidx + " " + sord);
             int totalPages = (int)Math.Ceiling((float)totalRecords / (float)rows);

             if (objAdminCol is null)
                 return new JsonResult("{ total = 0, page = 0, records = 0, rows = null }");

             var jsonData = new
             {
                 total = totalPages,
                 _page,
                 records = totalRecords,
                 rows = (
                     from objAdmin in objAdminCol
                     select new
                     {
                         id = objAdmin.AdminId,
                         cell = new string[] { 
                             objAdmin.AdminId.ToString(),
                             objAdmin.AdminName,
                             objAdmin.AdminPassword
                         }
                     }).ToArray()
             };

             return new JsonResult(jsonData);
         }
     }
}
