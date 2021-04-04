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
     public class UserRoles_ListCrudModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;

         [BindProperty]
         public CourseEnquiry1API.BusinessObject.UserRoles UserRoles { get; set; }

         public List<UserMaster> UserMasterDropDownListData;
         public List<RoleMaster> RoleMasterDropDownListData;


         /// <summary>
         /// Default Constructor: /UserRoles_ListCrudModel
         /// </summary>
         public UserRoles_ListCrudModel (ILog Ilog,IEmail IEmail)
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
             UserRoles objUserRoles = JsonConvert.DeserializeObject<UserRoles>(serializedData);
             UserRolesFunctions.AddOrEdit(objUserRoles, CrudOperation.Add, true);
             return new JsonResult(true);
         }

         /// <summary>
         /// Handler, updates a record.
         /// </summary>
         public IActionResult OnGetUpdate(string serializedData)
         {
             UserRoles objUserRoles = JsonConvert.DeserializeObject<UserRoles>(serializedData);
             UserRolesFunctions.AddOrEdit(objUserRoles, CrudOperation.Update, true);
             return new JsonResult(true);
         }

         /// <summary>
         /// Handler, deletes a record.
         /// </summary>
         public IActionResult OnGetRemove(int id)
         {
             UserRoles UserRoles = UserRoles.SelectByPrimaryKey(id);
             UserRoles.Delete(id);
             return new JsonResult(true);
         }

         /// <summary>
         /// Sets data needed on page intialization.
         /// </summary>
         private void SetData()
         {
             UserRoles = new CourseEnquiry1API.BusinessObject.UserRoles();
             UserMasterDropDownListData = UserMaster.SelectUserMasterDropDownListData();
             RoleMasterDropDownListData = RoleMaster.SelectRoleMasterDropDownListData();
         }

         /// <summary>
         /// Gets the list of data for use by the jqgrid plug-in
         /// </summary>
         public IActionResult OnGetGridData(string sidx, string sord, int _page, int rows, bool isforJqGrid = true)
         {
             int totalRecords = UserRoles.GetRecordCount();
             int startRowIndex = ((_page * rows) - rows);
             List<UserRoles> objUserRolesCol = UserRoles.SelectSkipAndTake(rows, startRowIndex, sidx + " " + sord);
             int totalPages = (int)Math.Ceiling((float)totalRecords / (float)rows);

             if (objUserRolesCol is null)
                 return new JsonResult("{ total = 0, page = 0, records = 0, rows = null }");

             var jsonData = new
             {
                 total = totalPages,
                 _page,
                 records = totalRecords,
                 rows = (
                     from objUserRoles in objUserRolesCol
                     select new
                     {
                         id = objUserRoles.UserRoleId,
                         cell = new string[] { 
                             objUserRoles.UserRoleId.ToString(),
                             objUserRoles.UserId.HasValue ? objUserRoles.UserId.Value.ToString() : "",
                             objUserRoles.RoleId.HasValue ? objUserRoles.RoleId.Value.ToString() : "",
                             objUserRoles.Status.ToString()
                         }
                     }).ToArray()
             };

             return new JsonResult(jsonData);
         }
     }
}
