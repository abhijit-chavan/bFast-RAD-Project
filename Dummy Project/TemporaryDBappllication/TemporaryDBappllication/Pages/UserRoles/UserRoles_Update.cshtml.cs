using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TemporaryDBappllicationAPI.Domain;
using TemporaryDBappllicationAPI.BusinessObject;
using Newtonsoft.Json;
using Application_Components.Logging;
using Application_Components.EmailNotification;
using TemporaryDBappllication.PartialModels;

namespace TemporaryDBappllication.Pages
{
     [AutoValidateAntiforgeryToken]
     public class UserRoles_UpdateModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;

         [BindProperty]
         public TemporaryDBappllicationAPI.BusinessObject.UserRoles UserRoles { get; set; }

         [BindProperty]
         public string ReturnUrl { get; set; }

         public AddEditUserRolesPartialModel PartialModel { get; set; }


         /// <summary>
         /// Default Constructor: /UserRoles_UpdateModel
         /// </summary>
         public UserRoles_UpdateModel (ILog Ilog,IEmail IEmail)
         {
             if (_Ilog == null)
                 _Ilog = Ilog;
if (_IEmail == null)
_IEmail = IEmail;
         }

         /// <summary>
         /// Initial handler the razor page encounters.
         /// </summary>
         public void OnGet(int id, string returnUrl)
         {
             LoadPage(id, returnUrl);
         }

         public PageResult LoadPage(int id, string returnUrl)
         {
             // select a record by primary key(s)
             TemporaryDBappllicationAPI.BusinessObject.UserRoles objUserRoles = UserRoles.SelectByPrimaryKey(id);

             // create the model used by the partial page
             AddEditUserRolesPartialModel model = new AddEditUserRolesPartialModel();
             model.UserMasterDropDownListData = UserMaster.SelectUserMasterDropDownListData();
             model.RoleMasterDropDownListData = RoleMaster.SelectRoleMasterDropDownListData();
             model.Operation = CrudOperation.Update;
             model.ReturnUrl = returnUrl;
             model.UserRoles = objUserRoles;

             // assign values to the model used by this page
             PartialModel = model;

             // assign the return url
             ReturnUrl = returnUrl;

             return Page();
         }

         public IActionResult OnPostUpdate()
         {
             if (ModelState.IsValid)
             {
                 try
                 {
                     // update record
                     UserRolesFunctions.AddOrEdit(UserRoles, CrudOperation.Update);
                     return RedirectToPage(ReturnUrl);
                 }
                 catch(Exception ex)
                 {
                     _Ilog.GetInstance().Error("Error Occured", ex);

                     if (ex.InnerException != null)
                         ModelState.AddModelError("", ex.InnerException.Message);
                     else
                         ModelState.AddModelError("", ex.Message);
                 }
             }

             // if we got this far, something failed, redisplay form
             return LoadPage(UserRoles.UserRoleId, ReturnUrl);
         }
     }
}
