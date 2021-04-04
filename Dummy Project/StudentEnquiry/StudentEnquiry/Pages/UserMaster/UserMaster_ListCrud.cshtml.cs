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
     public class UserMaster_ListCrudModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;

         [BindProperty]
         public StudentEnquiryAPI.BusinessObject.UserMaster UserMaster { get; set; }


         /// <summary>
         /// Default Constructor: /UserMaster_ListCrudModel
         /// </summary>
         public UserMaster_ListCrudModel (ILog Ilog,IEmail IEmail)
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
             UserMaster objUserMaster = JsonConvert.DeserializeObject<UserMaster>(serializedData);
             UserMasterFunctions.AddOrEdit(objUserMaster, CrudOperation.Add, true);
             return new JsonResult(true);
         }

         /// <summary>
         /// Handler, updates a record.
         /// </summary>
         public IActionResult OnGetUpdate(string serializedData)
         {
             UserMaster objUserMaster = JsonConvert.DeserializeObject<UserMaster>(serializedData);
             UserMasterFunctions.AddOrEdit(objUserMaster, CrudOperation.Update, true);
             return new JsonResult(true);
         }

         /// <summary>
         /// Handler, deletes a record.
         /// </summary>
         public IActionResult OnGetRemove(int id)
         {
             UserMaster UserMaster = UserMaster.SelectByPrimaryKey(id);
             UserMaster.Delete(id);
             return new JsonResult(true);
         }

         /// <summary>
         /// Sets data needed on page intialization.
         /// </summary>
         private void SetData()
         {
             UserMaster = new StudentEnquiryAPI.BusinessObject.UserMaster();
         }

         /// <summary>
         /// Gets the list of data for use by the jqgrid plug-in
         /// </summary>
         public IActionResult OnGetGridData(string sidx, string sord, int _page, int rows, bool isforJqGrid = true)
         {
             int totalRecords = UserMaster.GetRecordCount();
             int startRowIndex = ((_page * rows) - rows);
             List<UserMaster> objUserMasterCol = UserMaster.SelectSkipAndTake(rows, startRowIndex, sidx + " " + sord);
             int totalPages = (int)Math.Ceiling((float)totalRecords / (float)rows);

             if (objUserMasterCol is null)
                 return new JsonResult("{ total = 0, page = 0, records = 0, rows = null }");

             var jsonData = new
             {
                 total = totalPages,
                 _page,
                 records = totalRecords,
                 rows = (
                     from objUserMaster in objUserMasterCol
                     select new
                     {
                         id = objUserMaster.UserId,
                         cell = new string[] { 
                             objUserMaster.UserId.ToString(),
                             objUserMaster.UserName,
                             objUserMaster.Password,
                             objUserMaster.Email,
                             objUserMaster.CreatedOn.ToString("d"),
                             objUserMaster.CreatedBy,
                             objUserMaster.ModifiedOn.HasValue ? objUserMaster.ModifiedOn.Value.ToString("d") : "",
                             objUserMaster.ModifiedBy
                         }
                     }).ToArray()
             };

             return new JsonResult(jsonData);
         }
     }
}
